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
    public partial class StockAddForm : Form
    {
        DB_Connect connect = new DB_Connect();

        public StockAddForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void StockAddBtn_Click(object sender, EventArgs e)
        {
            connect.OpenConnection();

            var stockName = StockNameTxtBx.Text;
            int stockId;

            if (int.TryParse(StockCodeTxtBx.Text, out stockId))
            {
                var addQuerry = $"insert into Склад (Код_Склада, Наименование_Склада) values ('{stockId}', '{stockName}')";

                var command = new SqlCommand(addQuerry, connect.GetConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Запись не была создана.", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            connect.CloseConnection();
        }
    }
}
