using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AppDB
{
    public partial class CAAddForm : Form
    {
        DB_Connect connect = new DB_Connect();

        public CAAddForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CAAddBtn_Click(object sender, EventArgs e)
        {
            connect.OpenConnection();
            
            var nameOfCA = CANameTxtBx.Text;
            int codeOfCA;

            if (int.TryParse(CACodeTxtBx.Text, out codeOfCA))
            {
                var addQuerry = $"insert into Контрагент (Код_Контрагента, Наименование_Контрагента) values ('{codeOfCA}', '{nameOfCA}')";

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
