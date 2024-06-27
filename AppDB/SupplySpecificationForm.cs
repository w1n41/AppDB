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
    public partial class SupplySpecificationForm : Form
    {
        DB_Connect connect = new DB_Connect();

        public SupplySpecificationForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            SupplySpecificationDataGridView.AllowUserToAddRows = false;
        }
        
        private int selectedRow;

        private void CreateColumns()
        {
            SupplySpecificationDataGridView.Columns.Add("Invoice id", "Номер_накладной");
            SupplySpecificationDataGridView.Columns.Add("Product code", "Код_товара");
            SupplySpecificationDataGridView.Columns.Add("Count of product", "Количество");
            SupplySpecificationDataGridView.Columns.Add("IsNew", String.Empty);

            SupplySpecificationDataGridView.Columns["IsNew"].Visible = false;

            SupplySpecificationDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetInt32(2), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string querryText = "Select * From Спецификация_Поставки";

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

            for (int index = 0; index < SupplySpecificationDataGridView.Rows.Count; index++)
            {
                var rowState = (RowState)SupplySpecificationDataGridView.Rows[index].Cells[3].Value;

                if (rowState == RowState.Deleted)
                {
                    var invoice_id = Convert.ToInt32(SupplySpecificationDataGridView.Rows[index].Cells[0].Value);

                    var deleteQuerry = $"delete from Спецификация_Поставки where Номер_накладной = {invoice_id}";

                    var command = new SqlCommand(deleteQuerry, connect.GetConnection());

                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var invoice_id = SupplySpecificationDataGridView.Rows[index].Cells[0].Value.ToString();
                    var product_code = SupplySpecificationDataGridView.Rows[index].Cells[1].Value.ToString();
                    var count_of_product = SupplySpecificationDataGridView.Rows[index].Cells[2].Value.ToString();

                    var modifyQuerry = $"update Спецификация_Поставки set Код_товара = '{product_code}', Количество = '{count_of_product}' where Номер_накладной = {invoice_id}";

                    var command = new SqlCommand(modifyQuerry, connect.GetConnection());

                    command.ExecuteNonQuery();
                }
            }

            connect.CloseConnection();
        }

        private void SupplySpecificationForm_Load(object sender, EventArgs e)
        {
            if (SupplySpecificationDataGridView.Rows.Count == 0)
            {
                CreateColumns();
            }
            RefreshDataGrid(SupplySpecificationDataGridView);
        }

        private void SupplyDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (selectedRow >= 0)
            {
                DataGridViewRow row = SupplySpecificationDataGridView.Rows[selectedRow];

                InvoiceIdSupplySpecificationTxtBx.Text = row.Cells[0].Value.ToString();
                ProductCodeSupplySpecificationTxtBx.Text = row.Cells[1].Value.ToString();
                CountOfProductSupplySpecifacionTxtBx.Text = row.Cells[2].Value.ToString();
            }
        }

        private void SupplySpecificationRefreshBtn_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(SupplySpecificationDataGridView);
        }

        private void SupplySpecificationAddInfoBtn_Click(object sender, EventArgs e)
        {
            SupplySpecificationAddForm supplySpecificationAdd = new SupplySpecificationAddForm();
            supplySpecificationAdd.ShowDialog();
        }

        private void Delete()
        {
            int index = SupplySpecificationDataGridView.CurrentCell.RowIndex;

            SupplySpecificationDataGridView.Rows[index].Visible = false;

            if (SupplySpecificationDataGridView.Rows[index].Cells[0].ToString() != String.Empty)
            {
                SupplySpecificationDataGridView.Rows[index].Cells[3].Value = RowState.Deleted;
                return;
            }
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchQuerry = $"select * from Спецификация_Поставки where concat (Номер_Накладной, Код_Товара) like '%" + SupplySpecificationSearchTxtBox.Text + "%'";

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
            Search(SupplySpecificationDataGridView);
        }

        private void SupplySpecificationDeleteInfoBtn_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void SupplySpetificationUpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateCells();
        }

        private void ChangeInfo()
        {
            int index = SupplySpecificationDataGridView.CurrentCell.RowIndex;

            int invoice_id;
            var product_code = ProductCodeSupplySpecificationTxtBx.Text;
            var count_of_product = CountOfProductSupplySpecifacionTxtBx.Text;

            if (SupplySpecificationDataGridView.Rows[index].Cells[0].Value.ToString() != String.Empty)
            {
                if (int.TryParse(InvoiceIdSupplySpecificationTxtBx.Text, out invoice_id))
                {
                    SupplySpecificationDataGridView.Rows[index].SetValues(invoice_id, product_code, count_of_product);

                    SupplySpecificationDataGridView.Rows[index].Cells[3].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Поле 'Номер_накладной' должно содержать числовое значение. ", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void SupplySpecificationChangeInfoBtn_Click(object sender, EventArgs e)
        {
            ChangeInfo();
        }
    }
}
