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
    public partial class PriceRegisterAddForm : Form
    {
        DB_Connect connect = new DB_Connect();

        public PriceRegisterAddForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; 
        }

        private void PriceRegisterAddBtn_Click(object sender, EventArgs e)
        {
            connect.OpenConnection();

            DateTime date = PriceRegisterDateTimePicker.Value;
            int product_code = Convert.ToInt32(ProductCodeTxtBx.Text);
            int price_of_release = Convert.ToInt32(PriceOfReleasePriceRegisterTxtBx.Text);
            
            var addQuerry = $"INSERT INTO Регистр_цен_продаж (Дата, Код_товара, Цена_продажи) VALUES (@date, @product_code, @price_of_release)";
            var command = new SqlCommand(addQuerry, connect.GetConnection());

            command.Parameters.Add("@date", SqlDbType.Date).Value = date;
            command.Parameters.AddWithValue("@product_code", product_code);
            command.Parameters.AddWithValue("@price_of_release", price_of_release);

            command.ExecuteNonQuery();

            connect.CloseConnection();
        }
    }
}
