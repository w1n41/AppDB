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
    public partial class SupplyForm : Form
    {
        DB_Connect connect = new DB_Connect();

        public SupplyForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            SupplyDataGridView.AllowUserToAddRows = false;
        }

        private int selectedRow;

        private void CreateColumns()
        {
            SupplyDataGridView.Columns.Add("Invoice code", "Номер_Накладной");
            SupplyDataGridView.Columns.Add("CA Code", "Код_Контрагента");
            SupplyDataGridView.Columns.Add("Stock code", "Код_Склада");
            SupplyDataGridView.Columns.Add("Date of supply", "Дата_Поставки");
            SupplyDataGridView.Columns.Add("IsNew", String.Empty);

            SupplyDataGridView.Columns["IsNew"].Visible = false;

            SupplyDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetInt32(2), record.GetDateTime(3), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string querryText = $"SELECT * FROM Поставка";

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

            for (int index = 0; index < SupplyDataGridView.Rows.Count; index++)
            {
                var rowState = (RowState)SupplyDataGridView.Rows[index].Cells[4].Value;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(SupplyDataGridView.Rows[index].Cells[0].Value);

                    var deleteQuerry = $"DELETE FROM Поставка WHERE Номер_Накладной = {id}";

                    var command = new SqlCommand(deleteQuerry, connect.GetConnection());

                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var invoice_id = Convert.ToInt32(SupplyDataGridView.Rows[index].Cells[0].Value);
                    var ca_id = Convert.ToInt32(SupplyDataGridView.Rows[index].Cells[1].Value);
                    var stock_id = Convert.ToInt32(SupplyDataGridView.Rows[index].Cells[2].Value);
                    var supply_date = Convert.ToDateTime(SupplyDataGridView.Rows[index].Cells[3].Value);

                    var modifyQuerry = "UPDATE Поставка SET Код_Контрагента = @ca_id, Код_Склада = @stock_id, Дата_Поставки = @supply_date WHERE Номер_Накладной = @invoice_id";
                    var command = new SqlCommand(modifyQuerry, connect.GetConnection());

                    command.Parameters.AddWithValue("@invoice_id", invoice_id);
                    command.Parameters.AddWithValue("@ca_id", ca_id);
                    command.Parameters.AddWithValue("@stock_id", stock_id);
                    command.Parameters.AddWithValue("@supply_date", supply_date);

                    command.ExecuteNonQuery();
                }
            }

            connect.CloseConnection();
        }

        private void SupplyForm_Load(object sender, EventArgs e)
        {
            if (SupplyDataGridView.Rows.Count == 0)
            {
                CreateColumns();
            }
            FormatDateColumn(SupplyDataGridView);
            RefreshDataGrid(SupplyDataGridView);
        }

        private void SupplyDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (selectedRow >= 0)
            {
                DataGridViewRow row = SupplyDataGridView.Rows[selectedRow];

                InvoiceCodeSupplyTxtBx.Text = row.Cells[0].Value.ToString();
                CACodeSupplyTxtBx.Text = row.Cells[1].Value.ToString();
                StockIdSupplyTxtBx.Text = row.Cells[2].Value.ToString();

                DateTime releaseDate;
                if (DateTime.TryParse(row.Cells[3].Value.ToString(), out releaseDate))
                {
                    SupplyDateSupplyTxtBx.Text = releaseDate.ToString("dd.MM.yyyy");
                }
                else
                {
                    SupplyDateSupplyTxtBx.Text = row.Cells[3].Value.ToString();
                }
            }
        }


        private void SupplyRefreshBtn_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(SupplyDataGridView);
        }

        private void SupplyAddInfoBtn_Click(object sender, EventArgs e)
        {
            SupplyAddForm supplyAdd = new SupplyAddForm();
            supplyAdd.ShowDialog();
        }

        private void Delete()
        {
            int index = SupplyDataGridView.CurrentCell.RowIndex;

            SupplyDataGridView.Rows[index].Visible = false;

            if (SupplyDataGridView.Rows[index].Cells[0].ToString() != String.Empty)
            {
                SupplyDataGridView.Rows[index].Cells[4].Value = RowState.Deleted;
                return;
            }
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchQuerry = $"SELECT * FROM Поставка WHERE CONCAT (Номер_Накладной, Код_Контрагента, Код_Склада, Дата_Поставки) LIKE '%" + SupplySearchTxtBox.Text + "%'";

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
            Search(SupplyDataGridView);
        }

        private void SupplyDeleteInfoBtn_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void SupplyUpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateCells();
        }

        private void ChangeInfo()
        {
            int index = SupplyDataGridView.CurrentCell.RowIndex;

            int invoice_id;
            int ca_code;
            int stock_id;
            var supply_date = SupplyDateSupplyLbl.Text;

            if (int.TryParse(InvoiceCodeSupplyTxtBx.Text, out invoice_id) & int.TryParse(CACodeSupplyTxtBx.Text, out ca_code) & int.TryParse(StockIdSupplyTxtBx.Text, out stock_id))
            {
                SupplyDataGridView.Rows[index].SetValues(invoice_id, ca_code, stock_id, supply_date);

                SupplyDataGridView.Rows[index].Cells[4].Value = RowState.Modified;
            }
            else
            {
                MessageBox.Show("Поля 'Номер_Накладной', 'Код_Контрагента' и 'Код_склада' должны содержать числовое значение. ", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void SupplyChangeInfoBtn_Click(object sender, EventArgs e)
        {
            ChangeInfo();
        }

        private void FormatDateColumn(DataGridView dgw)
        {
            dgw.Columns[3].DefaultCellStyle.Format = "dd.MM.yyyy";
        }

    }
}
