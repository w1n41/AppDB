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
    public partial class ReleaseSpecificationAddForm : Form
    {
        DB_Connect connect = new DB_Connect();

        public ReleaseSpecificationAddForm()
        {
            InitializeComponent();
        }
        private void ReleaseSpecificationAddBtn_Click(object sender, EventArgs e)
        {
            connect.OpenConnection();

            int invoice_id;
            int product_code;
            int count_of_product;

            if (int.TryParse(InvoiceIdReleaseSpecificationTxtBx.Text, out invoice_id) & int.TryParse(ProductCodeReleaseSpecificationTxtBx.Text, out product_code) & int.TryParse(CountOfProductReleaseSpecificationTxtBx.Text, out count_of_product))
            {
                var addQuerry = $"insert into Спецификация_Отпуска_Со_Cклада (Номер_Накладной, Код_Товара, Количество) values ('{invoice_id}', '{product_code}', '{count_of_product}')";

                var command = new SqlCommand(addQuerry, connect.GetConnection());

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Произошла непредвиденная ошибка: {ex.Message}", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Поля должны содержать числовые значения!", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            connect.CloseConnection();
        }
    }
}
