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
    public enum RowState
    { 
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class CounterAgentForm : Form
    {
        DB_Connect connect = new DB_Connect();

        private int selectedRow;

        public CounterAgentForm()
        {
            InitializeComponent();
            CounterAgentDataGridView.AllowUserToAddRows = false;
        }

        private void CreateColumns()
        {
            CounterAgentDataGridView.Columns.Add("CA id", "Код_контрагента");
            CounterAgentDataGridView.Columns.Add("CA Name", "Наименование_контрагента");
            CounterAgentDataGridView.Columns.Add("IsNew", String.Empty);

            CounterAgentDataGridView.Columns["IsNew"].Visible = false;

            CounterAgentDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string querryText = $"Select * From Контрагент";

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
            
            for (int index = 0; index < CounterAgentDataGridView.Rows.Count; index++)
            {
                var rowState = (RowState)CounterAgentDataGridView.Rows[index].Cells[2].Value;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(CounterAgentDataGridView.Rows[index].Cells[0].Value);

                    var deleteQuerry = $"delete from Контрагент where Код_Контрагента = {id}";

                    var command = new SqlCommand(deleteQuerry, connect.GetConnection());

                    command.ExecuteNonQuery();  
                }

                if (rowState == RowState.Modified)
                {
                    var id = CounterAgentDataGridView.Rows[index].Cells[0].Value.ToString();
                    var name = CounterAgentDataGridView.Rows[index].Cells[1].Value.ToString();

                    var modifyQuerry = $"update Контрагент set Наименование_Контрагента = '{name}' where Код_Контрагента = {id}";

                    var command = new SqlCommand(modifyQuerry, connect.GetConnection());
                    
                    command.ExecuteNonQuery();
                }
            }

            connect.CloseConnection();
        }

        private void CounterAgentForm_Load(object sender, EventArgs e)
        {
            if (CounterAgentDataGridView.Rows.Count == 0)
            {
                CreateColumns();
            }
            RefreshDataGrid(CounterAgentDataGridView);
        }

        private void CounterAgentDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (selectedRow >= 0)
            {
                DataGridViewRow row = CounterAgentDataGridView.Rows[selectedRow];

                CACodeTxtBx.Text = row.Cells[0].Value.ToString();
                CANameTxtBx.Text = row.Cells[1].Value.ToString();
            }
        }

        private void CARefreshBtn_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(CounterAgentDataGridView);
        }

        private void CAAddInfoBtn_Click(object sender, EventArgs e)
        {
            CAAddForm cAAdd = new CAAddForm();
            cAAdd.ShowDialog();
        }

        private void Delete()
        {
            int index = CounterAgentDataGridView.CurrentCell.RowIndex;

            CounterAgentDataGridView.Rows[index].Visible = false;

            if (CounterAgentDataGridView.Rows[index].Cells[0].ToString() != String.Empty)
            {
                CounterAgentDataGridView.Rows[index].Cells[2].Value = RowState.Deleted;
                return;
            }
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchQuerry = $"select * from Контрагент where concat (Код_контрагента, Наименование_контрагента) like '%" + CASearchTxtBox.Text + "%'";

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
            Search(CounterAgentDataGridView);
        }

        private void CADeleteInfoBtn_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void CAUpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateCells();
        }

        private void ChangeInfo()
        {
            int index = CounterAgentDataGridView.CurrentCell.RowIndex;

            int id;
            var name = CANameTxtBx.Text;    
        
            if (CounterAgentDataGridView.Rows[index].Cells[0].Value.ToString() != String.Empty)
            {
                if (int.TryParse(CACodeTxtBx.Text, out id))
                {
                    CounterAgentDataGridView.Rows[index].SetValues(id, name);

                    CounterAgentDataGridView.Rows[index].Cells[2].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Поле 'Код_Контрагента' должно содержать числовое значение. ", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void CAChangeInfoBtn_Click(object sender, EventArgs e)
        {
            ChangeInfo();
        }
    }
}
