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
    public partial class ProductAddForm : Form
    {
        DB_Connect connect = new DB_Connect();

        public ProductAddForm()
        {
            InitializeComponent();
        }

        private void ProductAddBtn_Click(object sender, EventArgs e)
        {
            connect.OpenConnection();

            int product_code;
            string product_name = ProductNameProductTxtBx.Text;
            string type_of_product = ProductTypeOfProductTxtBx.Text;
            decimal supplier_price;
            decimal selling_price;
            decimal discount_price;

            if (int.TryParse(ProductCodeProductTxtBx.Text, out product_code) &&
                decimal.TryParse(ProductSupplierPriceTxtBx.Text, out supplier_price) &&
                decimal.TryParse(ProductSellingPriceTxtBx.Text, out selling_price) &&
                decimal.TryParse(ProductDiscountPriceTxtBx.Text, out discount_price))
            {
                var addQuery = "INSERT INTO Товар (Код_Товара, Наименование_Товара, Единица_Измерения, Цена_Поставщика, Цена_Продажи, Учетная_Цена) VALUES (@product_code, @product_name, @type_of_product, @supplier_price, @selling_price, @discount_price)";

                var command = new SqlCommand(addQuery, connect.GetConnection());

                command.Parameters.AddWithValue("@product_code", product_code);
                command.Parameters.AddWithValue("@product_name", product_name);
                command.Parameters.AddWithValue("@type_of_product", type_of_product);
                command.Parameters.AddWithValue("@supplier_price", supplier_price);
                command.Parameters.AddWithValue("@selling_price", selling_price);
                command.Parameters.AddWithValue("@discount_price", discount_price);

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла непредвиденная ошибка: {ex.Message}", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Поля 'Код товара', 'Цена поставщика', 'Цена продажи' и 'Учетная цена' должны содержать числовые значения!", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            connect.CloseConnection();
        }

    }
}
