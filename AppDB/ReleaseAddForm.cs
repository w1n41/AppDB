using System;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using System.Data;

namespace AppDB
{
    public partial class ReleaseAddForm : Form
    {
        DB_Connect connect = new DB_Connect();

        public ReleaseAddForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void ReleaseAddBtn_Click(object sender, EventArgs e)
        {
            connect.OpenConnection();

            int invoice_id = Convert.ToInt32(InvoiceCodeReleaseTxtBx.Text);
            int ca_id = Convert.ToInt32(CACodeReleaseTxtBx.Text);
            int stock_id = Convert.ToInt32(StockIdReleaseTxtBx.Text);            
            DateTime release_date = DateTimePickerRelease.Value;
            var addQuerry = $"INSERT INTO Отпуск (Номер_Накладной, Код_Контрагента, Код_Склада, Дата_Отпуска) VALUES (@Invoice_id, @Ca_id, @Stock_id, @Release_date)";
            var command = new SqlCommand(addQuerry, connect.GetConnection());

            command.Parameters.AddWithValue("@Invoice_id", invoice_id);
            command.Parameters.AddWithValue("@Ca_id", ca_id);
            command.Parameters.AddWithValue("@Stock_id", stock_id);
            command.Parameters.Add("@Release_date", SqlDbType.Date).Value = release_date;

            command.ExecuteNonQuery();

            connect.CloseConnection();
        }
    }
}
