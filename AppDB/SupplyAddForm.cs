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
    public partial class SupplyAddForm : Form
    {
        DB_Connect connect = new DB_Connect();

        public SupplyAddForm()
        {
            InitializeComponent();
        }

        private void SupplyAddBtn_Click(object sender, EventArgs e)
        {
            connect.OpenConnection();

            int invoice_id = Convert.ToInt32(InvoiceCodeSupplyTxtBx.Text);
            int ca_id = Convert.ToInt32(CACodeSupplyTxtBx.Text);
            int stock_id = Convert.ToInt32(StockIdSupplyTxtBx.Text);
            DateTime supply_date = DateTimePickerSupply.Value;
            var addQuerry = $"INSERT INTO Поставка (Номер_Накладной, Код_Контрагента, Код_Склада, Дата_Поставки) VALUES (@Invoice_id, @Ca_id, @Stock_id, @Supply_date)";
            var command = new SqlCommand(addQuerry, connect.GetConnection());

            command.Parameters.AddWithValue("@Invoice_id", invoice_id);
            command.Parameters.AddWithValue("@Ca_id", ca_id);
            command.Parameters.AddWithValue("@Stock_id", stock_id);
            command.Parameters.Add("@Supply_date", SqlDbType.Date).Value = supply_date;

            try
            { 
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла непридвиденная ошибка: {ex.Message} ", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connect.CloseConnection(); 
            
        }
    }
}
