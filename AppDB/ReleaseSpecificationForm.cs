using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDB
{
    public partial class ReleaseSpecificationForm : Form
    {
        DB_Connect connect = new DB_Connect();

        public ReleaseSpecificationForm()
        {
            InitializeComponent();
            ReleaseSpecificationDataGridView.AllowUserToAddRows = false;
        }

        private int selectedRow;

        private void CreateColumns()
        {
            ReleaseSpecificationDataGridView.Columns.Add("Invoice id", "Номер_накладной");
            ReleaseSpecificationDataGridView.Columns.Add("Product code", "Код_товара");
            ReleaseSpecificationDataGridView.Columns.Add("Count of product", "Количество");
            ReleaseSpecificationDataGridView.Columns.Add("IsNew", String.Empty);

            ReleaseSpecificationDataGridView.Columns["IsNew"].Visible = false;

            ReleaseSpecificationDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetInt32(2), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string querryText = "Select * From Спецификация_Отпуска_Со_Cклада";

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

            for (int index = 0; index < ReleaseSpecificationDataGridView.Rows.Count; index++)
            {
                var rowState = (RowState)ReleaseSpecificationDataGridView.Rows[index].Cells[3].Value;

                if (rowState == RowState.Deleted)
                {
                    var invoice_id = Convert.ToInt32(ReleaseSpecificationDataGridView.Rows[index].Cells[0].Value);

                    var deleteQuerry = $"delete from Спецификация_Отпуска_Со_Cклада where Номер_накладной = {invoice_id}";

                    var command = new SqlCommand(deleteQuerry, connect.GetConnection());

                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var invoice_id = ReleaseSpecificationDataGridView.Rows[index].Cells[0].Value.ToString();
                    var product_code = ReleaseSpecificationDataGridView.Rows[index].Cells[1].Value.ToString();
                    var count_of_product = ReleaseSpecificationDataGridView.Rows[index].Cells[2].Value.ToString();

                    var modifyQuerry = $"update Спецификация_Отпуска_Со_Cклада set Код_товара = '{product_code}', Количество = '{count_of_product}' where Номер_накладной = {invoice_id}";

                    var command = new SqlCommand(modifyQuerry, connect.GetConnection());

                    command.ExecuteNonQuery();
                }
            }

            connect.CloseConnection();
        }

        private void ReleaseSpecificationForm_Load(object sender, EventArgs e)
        {
            if (ReleaseSpecificationDataGridView.Rows.Count == 0)
            {
                CreateColumns();
            }
            RefreshDataGrid(ReleaseSpecificationDataGridView);
        }

        private void ReleaseDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (selectedRow >= 0)
            {
                DataGridViewRow row = ReleaseSpecificationDataGridView.Rows[selectedRow];

                InvoiceIdReleaseSpecificationTxtBx.Text = row.Cells[0].Value.ToString();
                ProductCodeReleaseSpecificationTxtBx.Text = row.Cells[1].Value.ToString();
                CountOfProductReleaseSpecifacionTxtBx.Text = row.Cells[2].Value.ToString();
            }
        }

        private void ReleaseSpecificationRefreshBtn_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(ReleaseSpecificationDataGridView);
        }

        private void ReleaseSpecificationAddInfoBtn_Click(object sender, EventArgs e)
        {
            ReleaseSpecificationAddForm releaseSpecificationAdd = new ReleaseSpecificationAddForm();
            releaseSpecificationAdd.ShowDialog();
        }

        private void Delete()
        {
            int index = ReleaseSpecificationDataGridView.CurrentCell.RowIndex;

            ReleaseSpecificationDataGridView.Rows[index].Visible = false;

            if (ReleaseSpecificationDataGridView.Rows[index].Cells[0].ToString() != String.Empty)
            {
                ReleaseSpecificationDataGridView.Rows[index].Cells[3].Value = RowState.Deleted;
                return;
            }
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchQuerry = $"select * from Спецификация_Отпуска_Со_Cклада where concat (Номер_Накладной, Код_Товара) like '%" + ReleaseSpecificationSearchTxtBox.Text + "%'";

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
            Search(ReleaseSpecificationDataGridView);
        }

        private void ReleaseSpecificationDeleteInfoBtn_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void ReleaseSpetificationUpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateCells();
        }

        private void ChangeInfo()
        {
            int index = ReleaseSpecificationDataGridView.CurrentCell.RowIndex;

            int invoice_id;
            var product_code = ProductCodeReleaseSpecificationTxtBx.Text;
            var count_of_product = CountOfProductReleaseSpecifacionTxtBx.Text;

            if (ReleaseSpecificationDataGridView.Rows[index].Cells[0].Value.ToString() != String.Empty)
            {
                if (int.TryParse(InvoiceIdReleaseSpecificationTxtBx.Text, out invoice_id))
                {
                    ReleaseSpecificationDataGridView.Rows[index].SetValues(invoice_id, product_code, count_of_product);

                    ReleaseSpecificationDataGridView.Rows[index].Cells[3].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Поле 'Номер_накладной' должно содержать числовое значение. ", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void ReleaseSpecificationChangeInfoBtn_Click(object sender, EventArgs e)
        {
            ChangeInfo();
        }
    }
}
