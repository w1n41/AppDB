using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDB
{
    public partial class StockForm : Form
    {
        DB_Connect connect = new DB_Connect();

        public StockForm()
        {
            InitializeComponent();
            StockDataGridView.AllowUserToAddRows = false;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private int selectedRow;

        private void CreateColumns()
        {
            StockDataGridView.Columns.Add("Stock id", "Код_склада");
            StockDataGridView.Columns.Add("Stock Name", "Наименование_склада");
            StockDataGridView.Columns.Add("IsNew", String.Empty);

            StockDataGridView.Columns["IsNew"].Visible = false;

            StockDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string querryText = $"Select * From Склад";

            SqlCommand sqlCommand = new SqlCommand(querryText, connect.GetConnection());

            connect.OpenConnection();

            SqlDataReader reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }

            reader.Close();
        }

        private void UpdateCells()
        {
            connect.OpenConnection();

            for (int index = 0; index < StockDataGridView.Rows.Count; index++)
            {
                var rowState = (RowState)StockDataGridView.Rows[index].Cells[2].Value;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(StockDataGridView.Rows[index].Cells[0].Value);

                    var deleteQuerry = $"delete from Склад where Код_Склада = {id}";

                    var command = new SqlCommand(deleteQuerry, connect.GetConnection());

                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var id = StockDataGridView.Rows[index].Cells[0].Value.ToString();
                    var name = StockDataGridView.Rows[index].Cells[1].Value.ToString();

                    var modifyQuerry = $"update Склад set Наименование_склада = '{name}' where Код_Склада = {id}";

                    var command = new SqlCommand(modifyQuerry, connect.GetConnection());

                    command.ExecuteNonQuery();
                }
            }

            connect.CloseConnection();
        }

        private void StockForm_Load(object sender, EventArgs e)
        {
            if (StockDataGridView.Rows.Count == 0)
            {
                CreateColumns();
            }
            RefreshDataGrid(StockDataGridView);
        }

        private void StockDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (selectedRow >= 0)
            {
                DataGridViewRow row = StockDataGridView.Rows[selectedRow];

                StockCodeTxtBx.Text = row.Cells[0].Value.ToString();
                StockNameTxtBx.Text = row.Cells[1].Value.ToString();
            }
        }

        private void StockRefreshBtn_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(StockDataGridView);
        }

        private void StockAddInfoBtn_Click(object sender, EventArgs e)
        {
            StockAddForm stockAdd = new StockAddForm();
            stockAdd.ShowDialog();
        }

        private void Delete()
        {
            int index = StockDataGridView.CurrentCell.RowIndex;

            StockDataGridView.Rows[index].Visible = false;

            if (StockDataGridView.Rows[index].Cells[0].ToString() != String.Empty)
            {
                StockDataGridView.Rows[index].Cells[2].Value = RowState.Deleted;
                return;
            }
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchQuerry = $"select * from Склад where concat (Код_склада, Наименование_склада) like '%" + StockSearchTxtBox.Text + "%'";

            SqlCommand command = new SqlCommand(searchQuerry, connect.GetConnection());

            connect.OpenConnection();

            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }

            read.Close();
        }

        private void SearchTxtBox_TextChanged(object sender, EventArgs e)
        {
            Search(StockDataGridView);
        }

        private void StockDeleteInfoBtn_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void StockUpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateCells();
        }

        private void ChangeInfo()
        {
            int index = StockDataGridView.CurrentCell.RowIndex;

            int id;
            var name = StockNameTxtBx.Text;

            if (StockDataGridView.Rows[index].Cells[0].Value.ToString() != String.Empty)
            {
                if (int.TryParse(StockCodeTxtBx.Text, out id))
                {
                    StockDataGridView.Rows[index].SetValues(id, name);

                    StockDataGridView.Rows[index].Cells[2].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Поле 'Код_Склад' должно содержать числовое значение. ", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void StockChangeInfoBtn_Click(object sender, EventArgs e)
        {
            ChangeInfo();
        }
    }
}
