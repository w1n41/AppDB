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
    public partial class ReleaseForm : Form
    {
        DB_Connect connect = new DB_Connect();
        public ReleaseForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            ReleaseDataGridView.AllowUserToAddRows = false;
        }
        
        private int selectedRow;

        private void CreateColumns()
        {
            ReleaseDataGridView.Columns.Add("Invoice code", "Номер_Накладной");
            ReleaseDataGridView.Columns.Add("CA Code", "Код_Контрагента");
            ReleaseDataGridView.Columns.Add("Stock code", "Код_Склада");
            ReleaseDataGridView.Columns.Add("Date of release", "Дата_Отпуска");
            ReleaseDataGridView.Columns.Add("IsNew", String.Empty);

            ReleaseDataGridView.Columns["IsNew"].Visible = false;

            ReleaseDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetInt32(2), record.GetDateTime(3), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string querryText = $"Select * From Отпуск";

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

            for (int index = 0; index < ReleaseDataGridView.Rows.Count; index++)
            {
                var rowState = (RowState)ReleaseDataGridView.Rows[index].Cells[4].Value;

                if (rowState == RowState.Deleted)
                {
                    var invoice_id = Convert.ToInt32(ReleaseDataGridView.Rows[index].Cells[0].Value);

                    var deleteQuerry = $"DELETE FROM Отпуск WHERE Номер_Накладной = {invoice_id}";

                    var command = new SqlCommand(deleteQuerry, connect.GetConnection());

                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var invoice_id = Convert.ToInt32(ReleaseDataGridView.Rows[index].Cells[0].Value);
                    var ca_id = Convert.ToInt32(ReleaseDataGridView.Rows[index].Cells[1].Value);
                    var stock_id = Convert.ToInt32(ReleaseDataGridView.Rows[index].Cells[2].Value);
                    var release_date = Convert.ToDateTime(ReleaseDataGridView.Rows[index].Cells[3].Value);

                    var modifyQuerry = "UPDATE Отпуск SET Код_Контрагента = @ca_id, Код_Склада = @stock_id, Дата_Отпуска = @release_date WHERE Номер_Накладной = @invoice_id";
                    var command = new SqlCommand(modifyQuerry, connect.GetConnection());

                    command.Parameters.AddWithValue("@invoice_id", invoice_id);
                    command.Parameters.AddWithValue("@ca_id", ca_id);
                    command.Parameters.AddWithValue("@stock_id", stock_id);
                    command.Parameters.AddWithValue("@release_date", release_date);

                    command.ExecuteNonQuery();
                }
            }

            connect.CloseConnection();
        }

        private void ReleaseForm_Load(object sender, EventArgs e)
        {
            if (ReleaseDataGridView.Rows.Count == 0)
            {
                CreateColumns();
            }
            FormatDateColumn(ReleaseDataGridView);
            RefreshDataGrid(ReleaseDataGridView);
        }

        private void ReleaseDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (selectedRow >= 0)
            {
                DataGridViewRow row = ReleaseDataGridView.Rows[selectedRow];

                InvoiceCodeReleaseTxtBx.Text = row.Cells[0].Value.ToString();
                CACodeReleaseTxtBx.Text = row.Cells[1].Value.ToString();
                StockIdReleaseTxtBx.Text = row.Cells[2].Value.ToString();

                DateTime releaseDate;
                if (DateTime.TryParse(row.Cells[3].Value.ToString(), out releaseDate))
                {
                    ReleaseDateReleaseTxtBx.Text = releaseDate.ToString("dd.MM.yyyy");
                }
                else
                {
                    ReleaseDateReleaseTxtBx.Text = row.Cells[3].Value.ToString();
                }
            }
        }


        private void ReleaseRefreshBtn_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(ReleaseDataGridView);
        }

        private void ReleaseAddInfoBtn_Click(object sender, EventArgs e)
        {
            ReleaseAddForm releaseAdd = new ReleaseAddForm();
            releaseAdd.ShowDialog();
        }

        private void Delete()
        {
            int index = ReleaseDataGridView.CurrentCell.RowIndex;

            ReleaseDataGridView.Rows[index].Visible = false;

            if (ReleaseDataGridView.Rows[index].Cells[0].ToString() != String.Empty)
            {
                ReleaseDataGridView.Rows[index].Cells[4].Value = RowState.Deleted;
                return;
            }
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchQuerry = $"select * from Отпуск where concat (Номер_Накладной, Код_Контрагента, Код_Склада, Дата_Отпуска) like '%" + ReleaseSearchTxtBox.Text + "%'";

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
            Search(ReleaseDataGridView);
        }

        private void ReleaseDeleteInfoBtn_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void ReleaseUpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateCells();
        }

        private void ChangeInfo()
        {
            int index = ReleaseDataGridView.CurrentCell.RowIndex;

            int invoice_id;
            int ca_code;
            int stock_id;
            var release_date = ReleaseDateReleaseTxtBx.Text;

            if (int.TryParse(InvoiceCodeReleaseTxtBx.Text, out invoice_id) & int.TryParse(CACodeReleaseTxtBx.Text, out ca_code) & int.TryParse(StockIdReleaseTxtBx.Text, out stock_id))
            {
                ReleaseDataGridView.Rows[index].SetValues(invoice_id, ca_code, stock_id, release_date);

                ReleaseDataGridView.Rows[index].Cells[4].Value = RowState.Modified;
            }        
        }

        private void ReleaseChangeInfoBtn_Click(object sender, EventArgs e)
        {
            ChangeInfo();
        }

        private void FormatDateColumn(DataGridView dgw)
        {
            dgw.Columns[3].DefaultCellStyle.Format = "dd.MM.yyyy";
        }

    }
}

