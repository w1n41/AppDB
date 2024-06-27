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
    public partial class ProductForm : Form
    {
        DB_Connect connect = new DB_Connect();

        public ProductForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            ProductDataGridView.AllowUserToAddRows = false;
        }

        private int selectedRow;

        private void CreateColumns()
        {

            ProductDataGridView.Columns.Add("Product code", "Код_Товара");
            ProductDataGridView.Columns.Add("Product name", "Наименование_Товара");
            ProductDataGridView.Columns.Add("Type of product", "Единица_Измерения");
            ProductDataGridView.Columns.Add("Supplier price", "Цена_Поставщика");
            ProductDataGridView.Columns.Add("Celling price", "Цена_Продажи");
            ProductDataGridView.Columns.Add("Discount price", "Учетная_Цена");
            ProductDataGridView.Columns.Add("IsNew", String.Empty);

            ProductDataGridView.Columns["IsNew"].Visible = false;

            ProductDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetDecimal(3), record.GetDecimal(4), record.GetDecimal(5), RowState.ModifiedNew); ;
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string querryText = "Select * From Товар";

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

            for (int index = 0; index < ProductDataGridView.Rows.Count; index++)
            {
                var rowState = (RowState)ProductDataGridView.Rows[index].Cells[6].Value;

                if (rowState == RowState.Deleted)
                {
                    var product_code = Convert.ToInt32(ProductDataGridView.Rows[index].Cells[0].Value);

                    var deleteQuerry = $"delete from Товар where Код_товара = {product_code}";

                    var command = new SqlCommand(deleteQuerry, connect.GetConnection());

                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    if (!int.TryParse(ProductDataGridView.Rows[index].Cells[0].Value.ToString(), out int product_code))
                    {
                        MessageBox.Show("Код товара должен быть числовым значением!", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string product_name = ProductDataGridView.Rows[index].Cells[1].Value.ToString();
                    string type_of_product = ProductDataGridView.Rows[index].Cells[2].Value.ToString();

                    if (!decimal.TryParse(ProductDataGridView.Rows[index].Cells[3].Value.ToString(), out decimal supplier_price) |
                        !decimal.TryParse(ProductDataGridView.Rows[index].Cells[4].Value.ToString(), out decimal selling_price) |
                        !decimal.TryParse(ProductDataGridView.Rows[index].Cells[5].Value.ToString(), out decimal discount_price))
                    {
                        MessageBox.Show("Цены должны быть числовыми значениями!", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var modifyQuery = "UPDATE Товар SET Код_Товара = @product_code, Наименование_Товара = @product_name, Единица_Измерения = @type_of_product, Цена_Поставщика = @supplier_price, Цена_Продажи = @selling_price, Учетная_Цена = @discount_price WHERE Код_Товара = @product_code";


                    var command = new SqlCommand(modifyQuery, connect.GetConnection());

                    command.Parameters.AddWithValue("@product_code", product_code);
                    command.Parameters.AddWithValue("@product_name", product_name);
                    command.Parameters.AddWithValue("@type_of_product", type_of_product);
                    command.Parameters.AddWithValue("@supplier_price", supplier_price);
                    command.Parameters.AddWithValue("@selling_price", selling_price);
                    command.Parameters.AddWithValue("@discount_price", discount_price);

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Запись успешно обновлена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Произошла непредвиденная ошибка: {ex.Message}", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    connect.CloseConnection();
                }
            }

            connect.CloseConnection();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            if (ProductDataGridView.Rows.Count == 0)
            {
                CreateColumns();
            }
            RefreshDataGrid(ProductDataGridView);
        }

        private void ProductDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (selectedRow >= 0)
            {
                DataGridViewRow row = ProductDataGridView.Rows[selectedRow];

                ProductCodeProductTxtBx.Text = row.Cells[0].Value.ToString();
                ProductNameProductTxtBx.Text = row.Cells[1].Value.ToString();
                ProductTypeOfProductTxtBx.Text = row.Cells[2].Value.ToString();
                ProductSupplierPriceTxtBx.Text = row.Cells[3].Value.ToString();
                ProductSellingPriceTxtBx.Text = row.Cells[4].Value.ToString();
                ProductDiscountPriceTxtBx.Text = row.Cells[5].Value.ToString();
            }
        }

        private void ProductRefreshBtn_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(ProductDataGridView);
        }

        private void Delete()
        {
            int index = ProductDataGridView.CurrentCell.RowIndex;

            ProductDataGridView.Rows[index].Visible = false;

            if (ProductDataGridView.Rows[index].Cells[0].ToString() != String.Empty)
            {
                ProductDataGridView.Rows[index].Cells[6].Value = RowState.Deleted;
                return;
            }
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchQuerry = $"select * from Товар where concat (Код_Товара, Наименование_Товара, Единица_Измерения, Цена_Поставщика, Цена_Продажи, Учетная_Цена) like '%" + ProductSearchTxtBox.Text + "%'";

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
            Search(ProductDataGridView);
        }

        private void ProductDeleteInfoBtn_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void ProductUpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateCells();
        }

        private void ChangeInfo()
        {
            int index = ProductDataGridView.CurrentCell.RowIndex;

            int product_code;
            var product_name = ProductNameProductTxtBx.Text;
            var type_of_product = ProductTypeOfProductTxtBx.Text;
            var supplier_price = ProductSupplierPriceTxtBx.Text;
            var selling_price = ProductSellingPriceTxtBx.Text;
            var discount_price = ProductDiscountPriceTxtBx.Text;

            if (ProductDataGridView.Rows[index].Cells[0].Value.ToString() != String.Empty)
            {
                if (int.TryParse(ProductCodeProductTxtBx.Text, out product_code))
                {
                    ProductDataGridView.Rows[index].SetValues(product_code, product_name, type_of_product);

                    ProductDataGridView.Rows[index].Cells[6].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Поле 'Код_товара' должно содержать числовое значение. ", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void ProductChangeInfoBtn_Click(object sender, EventArgs e)
        {
            ChangeInfo();
        }

        private void ProductAddInfoBtn_Click(object sender, EventArgs e)
        {
            ProductAddForm productAddForm = new ProductAddForm();
            productAddForm.ShowDialog();
        }
    }
}
