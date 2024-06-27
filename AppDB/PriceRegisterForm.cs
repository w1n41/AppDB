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
    public partial class PriceRegisterForm : Form
    {
        DB_Connect connect = new DB_Connect();

        public PriceRegisterForm()
        {
            InitializeComponent();
            PriceRegisterDataGridView.AllowUserToAddRows = false;
        }

        private int selectedRow;

        private void CreateColumns()
        {
            PriceRegisterDataGridView.Columns.Add("Date", "Дата");
            PriceRegisterDataGridView.Columns.Add("Product code", "Код_Товара");
            PriceRegisterDataGridView.Columns.Add("Price of release", "Цена_Продажи");
            PriceRegisterDataGridView.Columns.Add("IsNew", String.Empty);

            PriceRegisterDataGridView.Columns["IsNew"].Visible = false;

            PriceRegisterDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetDateTime(0), record.GetInt32(1), record.GetDecimal(2), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string querryText = $"Select * From Регистр_цен_продаж";

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

            for (int index = 0; index < PriceRegisterDataGridView.Rows.Count; index++)
            {
                var rowState = (RowState)PriceRegisterDataGridView.Rows[index].Cells[3].Value;

                if (rowState == RowState.Deleted)
                {
                    var date = Convert.ToDateTime(PriceRegisterDataGridView.Rows[index].Cells[0].Value);

                    var deleteQuerry = "DELETE FROM Регистр_цен_продаж WHERE Дата = @date";

                    var command = new SqlCommand(deleteQuerry, connect.GetConnection());

                    command.Parameters.AddWithValue("@date", date);

                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var date = Convert.ToDateTime(PriceRegisterDataGridView.Rows[index].Cells[0].Value);
                    var product_code = Convert.ToInt32(PriceRegisterDataGridView.Rows[index].Cells[1].Value);
                    var price_of_release = Convert.ToInt32(PriceRegisterDataGridView.Rows[index].Cells[2].Value);

                    var modifyQuerry = "UPDATE Регистр_цен_продаж SET Код_Товара = @product_code, Цена_Продажи = @price_of_release WHERE Дата = @date";
                    var command = new SqlCommand(modifyQuerry, connect.GetConnection());

                    command.Parameters.AddWithValue("@date", date);
                    command.Parameters.AddWithValue("@product_code", product_code);
                    command.Parameters.AddWithValue("@price_of_release", price_of_release);

                    command.ExecuteNonQuery();
                }
            }

            connect.CloseConnection();
        }

        private void PriceRegisterForm_Load(object sender, EventArgs e)
        {
            if (PriceRegisterDataGridView.Rows.Count == 0)
            {
                CreateColumns();
            }
            FormatDateColumn();
            RefreshDataGrid(PriceRegisterDataGridView);
        }

        private void PriceRegisterDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (selectedRow >= 0)
            {
                DataGridViewRow row = PriceRegisterDataGridView.Rows[selectedRow];

                ProductCodePriceRegisterTxtBx.Text = row.Cells[1].Value.ToString();
                PriceOfReleasePriceRegisterTxtBx.Text = row.Cells[2].Value.ToString();

                DateTime date;
                if (DateTime.TryParse(row.Cells[0].Value.ToString(), out date))
                {
                    PriceRegisterDateTxtBx.Text = date.ToString("dd.MM.yyyy");
                }
                else
                {
                    PriceRegisterDateTxtBx.Text = row.Cells[0].Value.ToString();
                }
            }
        }

        private void PriceRegisterRefreshBtn_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(PriceRegisterDataGridView);
        }

        private void PriceRegisterAddInfoBtn_Click(object sender, EventArgs e)
        {
            PriceRegisterAddForm priceRegisterAdd = new PriceRegisterAddForm();
            priceRegisterAdd.ShowDialog();
        }

        private void Delete()
        {
            int index = PriceRegisterDataGridView.CurrentCell.RowIndex;

            PriceRegisterDataGridView.Rows[index].Visible = false;

            if (PriceRegisterDataGridView.Rows[index].Cells[0].ToString() != String.Empty)
            {
                PriceRegisterDataGridView.Rows[index].Cells[3].Value = RowState.Deleted;
                return;
            }
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchQuerry = $"select * from Регистр_цен_продаж where concat (Дата, Код_Товара, Цена_Продажи) like '%" + PriceRegisterSearchTxtBox.Text + "%'";

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
            Search(PriceRegisterDataGridView);
        }

        private void PriceRegisterDeleteInfoBtn_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void PriceRegisterUpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateCells();
        }

        private void ChangeInfo()
        {
            int index = PriceRegisterDataGridView.CurrentCell.RowIndex;

            int price_of_release;
            int product_code;
            var release_date = PriceRegisterDateTxtBx.Text;

            if (int.TryParse(PriceOfReleasePriceRegisterTxtBx.Text, out price_of_release) & int.TryParse(ProductCodePriceRegisterTxtBx.Text, out product_code))
            {
                PriceRegisterDataGridView.Rows[index].SetValues(release_date, product_code, price_of_release);

                PriceRegisterDataGridView.Rows[index].Cells[3].Value = RowState.Modified;
            }
        }

        private void PriceRegisterChangeInfoBtn_Click(object sender, EventArgs e)
        {
            ChangeInfo();
        }

        private void FormatDateColumn()
        {
            PriceRegisterDataGridView.Columns[0].DefaultCellStyle.Format = "dd.MM.yyyy";
        }
    }
}
