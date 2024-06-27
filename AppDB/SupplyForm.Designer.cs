namespace AppDB
{
    partial class SupplyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SupplyChangeInfoBtn = new System.Windows.Forms.Button();
            this.SupplyUpdateBtn = new System.Windows.Forms.Button();
            this.SupplyDeleteInfoBtn = new System.Windows.Forms.Button();
            this.SupplyAddInfoBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SupplyDateSupplyTxtBx = new System.Windows.Forms.TextBox();
            this.StockIdSupplyTxtBx = new System.Windows.Forms.TextBox();
            this.SupplyDateSupplyLbl = new System.Windows.Forms.Label();
            this.StockIdSupplyLbl = new System.Windows.Forms.Label();
            this.CAMarksLbl = new System.Windows.Forms.Label();
            this.CACodeSupplyTxtBx = new System.Windows.Forms.TextBox();
            this.InvoiceCodeSupplyTxtBx = new System.Windows.Forms.TextBox();
            this.CACodeSupplyLbl = new System.Windows.Forms.Label();
            this.InvoiceCodeSupplyLbl = new System.Windows.Forms.Label();
            this.SupplyDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchTxtLbl = new System.Windows.Forms.Label();
            this.SupplySearchTxtBox = new System.Windows.Forms.TextBox();
            this.SupplyLbl = new System.Windows.Forms.Label();
            this.SupplyRefreshBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SupplyDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(700, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Работа с записями:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.SupplyChangeInfoBtn);
            this.panel2.Controls.Add(this.SupplyUpdateBtn);
            this.panel2.Controls.Add(this.SupplyDeleteInfoBtn);
            this.panel2.Controls.Add(this.SupplyAddInfoBtn);
            this.panel2.Location = new System.Drawing.Point(632, 533);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 154);
            this.panel2.TabIndex = 14;
            // 
            // SupplyChangeInfoBtn
            // 
            this.SupplyChangeInfoBtn.Location = new System.Drawing.Point(156, 95);
            this.SupplyChangeInfoBtn.Name = "SupplyChangeInfoBtn";
            this.SupplyChangeInfoBtn.Size = new System.Drawing.Size(111, 40);
            this.SupplyChangeInfoBtn.TabIndex = 3;
            this.SupplyChangeInfoBtn.Text = "Изменить ";
            this.SupplyChangeInfoBtn.UseVisualStyleBackColor = true;
            this.SupplyChangeInfoBtn.Click += new System.EventHandler(this.SupplyChangeInfoBtn_Click);
            // 
            // SupplyUpdateBtn
            // 
            this.SupplyUpdateBtn.Location = new System.Drawing.Point(24, 95);
            this.SupplyUpdateBtn.Name = "SupplyUpdateBtn";
            this.SupplyUpdateBtn.Size = new System.Drawing.Size(111, 40);
            this.SupplyUpdateBtn.TabIndex = 2;
            this.SupplyUpdateBtn.Text = "Сохранить ";
            this.SupplyUpdateBtn.UseVisualStyleBackColor = true;
            this.SupplyUpdateBtn.Click += new System.EventHandler(this.SupplyUpdateBtn_Click);
            // 
            // SupplyDeleteInfoBtn
            // 
            this.SupplyDeleteInfoBtn.Location = new System.Drawing.Point(156, 30);
            this.SupplyDeleteInfoBtn.Name = "SupplyDeleteInfoBtn";
            this.SupplyDeleteInfoBtn.Size = new System.Drawing.Size(111, 40);
            this.SupplyDeleteInfoBtn.TabIndex = 1;
            this.SupplyDeleteInfoBtn.Text = "Удалить запись";
            this.SupplyDeleteInfoBtn.UseVisualStyleBackColor = true;
            this.SupplyDeleteInfoBtn.Click += new System.EventHandler(this.SupplyDeleteInfoBtn_Click);
            // 
            // SupplyAddInfoBtn
            // 
            this.SupplyAddInfoBtn.Location = new System.Drawing.Point(24, 31);
            this.SupplyAddInfoBtn.Name = "SupplyAddInfoBtn";
            this.SupplyAddInfoBtn.Size = new System.Drawing.Size(111, 40);
            this.SupplyAddInfoBtn.TabIndex = 0;
            this.SupplyAddInfoBtn.Text = "Новая запись";
            this.SupplyAddInfoBtn.UseVisualStyleBackColor = true;
            this.SupplyAddInfoBtn.Click += new System.EventHandler(this.SupplyAddInfoBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.SupplyDateSupplyTxtBx);
            this.panel3.Controls.Add(this.StockIdSupplyTxtBx);
            this.panel3.Controls.Add(this.SupplyDateSupplyLbl);
            this.panel3.Controls.Add(this.StockIdSupplyLbl);
            this.panel3.Controls.Add(this.CAMarksLbl);
            this.panel3.Controls.Add(this.CACodeSupplyTxtBx);
            this.panel3.Controls.Add(this.InvoiceCodeSupplyTxtBx);
            this.panel3.Controls.Add(this.CACodeSupplyLbl);
            this.panel3.Controls.Add(this.InvoiceCodeSupplyLbl);
            this.panel3.Location = new System.Drawing.Point(80, 495);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(395, 221);
            this.panel3.TabIndex = 13;
            // 
            // SupplyDateSupplyTxtBx
            // 
            this.SupplyDateSupplyTxtBx.Location = new System.Drawing.Point(232, 178);
            this.SupplyDateSupplyTxtBx.Name = "SupplyDateSupplyTxtBx";
            this.SupplyDateSupplyTxtBx.Size = new System.Drawing.Size(143, 20);
            this.SupplyDateSupplyTxtBx.TabIndex = 8;
            // 
            // StockIdSupplyTxtBx
            // 
            this.StockIdSupplyTxtBx.Location = new System.Drawing.Point(232, 137);
            this.StockIdSupplyTxtBx.Name = "StockIdSupplyTxtBx";
            this.StockIdSupplyTxtBx.Size = new System.Drawing.Size(143, 20);
            this.StockIdSupplyTxtBx.TabIndex = 7;
            // 
            // SupplyDateSupplyLbl
            // 
            this.SupplyDateSupplyLbl.AutoSize = true;
            this.SupplyDateSupplyLbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SupplyDateSupplyLbl.Location = new System.Drawing.Point(13, 178);
            this.SupplyDateSupplyLbl.Name = "SupplyDateSupplyLbl";
            this.SupplyDateSupplyLbl.Size = new System.Drawing.Size(121, 17);
            this.SupplyDateSupplyLbl.TabIndex = 6;
            this.SupplyDateSupplyLbl.Text = "Дата_Поставки:";
            // 
            // StockIdSupplyLbl
            // 
            this.StockIdSupplyLbl.AutoSize = true;
            this.StockIdSupplyLbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StockIdSupplyLbl.Location = new System.Drawing.Point(13, 141);
            this.StockIdSupplyLbl.Name = "StockIdSupplyLbl";
            this.StockIdSupplyLbl.Size = new System.Drawing.Size(97, 17);
            this.StockIdSupplyLbl.TabIndex = 5;
            this.StockIdSupplyLbl.Text = "Код_Склада:";
            // 
            // CAMarksLbl
            // 
            this.CAMarksLbl.AutoSize = true;
            this.CAMarksLbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CAMarksLbl.Location = new System.Drawing.Point(164, 13);
            this.CAMarksLbl.Name = "CAMarksLbl";
            this.CAMarksLbl.Size = new System.Drawing.Size(62, 17);
            this.CAMarksLbl.TabIndex = 4;
            this.CAMarksLbl.Text = "Записи:";
            // 
            // CACodeSupplyTxtBx
            // 
            this.CACodeSupplyTxtBx.Location = new System.Drawing.Point(232, 101);
            this.CACodeSupplyTxtBx.Name = "CACodeSupplyTxtBx";
            this.CACodeSupplyTxtBx.Size = new System.Drawing.Size(143, 20);
            this.CACodeSupplyTxtBx.TabIndex = 3;
            // 
            // InvoiceCodeSupplyTxtBx
            // 
            this.InvoiceCodeSupplyTxtBx.Location = new System.Drawing.Point(232, 60);
            this.InvoiceCodeSupplyTxtBx.Name = "InvoiceCodeSupplyTxtBx";
            this.InvoiceCodeSupplyTxtBx.Size = new System.Drawing.Size(143, 20);
            this.InvoiceCodeSupplyTxtBx.TabIndex = 2;
            // 
            // CACodeSupplyLbl
            // 
            this.CACodeSupplyLbl.AutoSize = true;
            this.CACodeSupplyLbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CACodeSupplyLbl.Location = new System.Drawing.Point(13, 104);
            this.CACodeSupplyLbl.Name = "CACodeSupplyLbl";
            this.CACodeSupplyLbl.Size = new System.Drawing.Size(136, 17);
            this.CACodeSupplyLbl.TabIndex = 1;
            this.CACodeSupplyLbl.Text = "Код_Контрагента:";
            // 
            // InvoiceCodeSupplyLbl
            // 
            this.InvoiceCodeSupplyLbl.AutoSize = true;
            this.InvoiceCodeSupplyLbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InvoiceCodeSupplyLbl.Location = new System.Drawing.Point(13, 63);
            this.InvoiceCodeSupplyLbl.Name = "InvoiceCodeSupplyLbl";
            this.InvoiceCodeSupplyLbl.Size = new System.Drawing.Size(144, 17);
            this.InvoiceCodeSupplyLbl.TabIndex = 0;
            this.InvoiceCodeSupplyLbl.Text = "Номер_Накладной:";
            // 
            // SupplyDataGridView
            // 
            this.SupplyDataGridView.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.SupplyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SupplyDataGridView.Location = new System.Drawing.Point(0, 85);
            this.SupplyDataGridView.Name = "SupplyDataGridView";
            this.SupplyDataGridView.Size = new System.Drawing.Size(1054, 403);
            this.SupplyDataGridView.TabIndex = 12;
            this.SupplyDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SupplyDataGridView_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.SupplyRefreshBtn);
            this.panel1.Controls.Add(this.SearchTxtLbl);
            this.panel1.Controls.Add(this.SearchBtn);
            this.panel1.Controls.Add(this.SupplySearchTxtBox);
            this.panel1.Controls.Add(this.SupplyLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 89);
            this.panel1.TabIndex = 11;
            // 
            // SearchTxtLbl
            // 
            this.SearchTxtLbl.AutoSize = true;
            this.SearchTxtLbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTxtLbl.Location = new System.Drawing.Point(766, 25);
            this.SearchTxtLbl.Name = "SearchTxtLbl";
            this.SearchTxtLbl.Size = new System.Drawing.Size(90, 26);
            this.SearchTxtLbl.TabIndex = 2;
            this.SearchTxtLbl.Text = "Поиск:";
            // 
            // SupplySearchTxtBox
            // 
            this.SupplySearchTxtBox.Location = new System.Drawing.Point(862, 29);
            this.SupplySearchTxtBox.Name = "SupplySearchTxtBox";
            this.SupplySearchTxtBox.Size = new System.Drawing.Size(105, 20);
            this.SupplySearchTxtBox.TabIndex = 1;
            this.SupplySearchTxtBox.TextChanged += new System.EventHandler(this.SearchTxtBox_TextChanged);
            // 
            // SupplyLbl
            // 
            this.SupplyLbl.AutoSize = true;
            this.SupplyLbl.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SupplyLbl.Location = new System.Drawing.Point(12, 20);
            this.SupplyLbl.Name = "SupplyLbl";
            this.SupplyLbl.Size = new System.Drawing.Size(169, 40);
            this.SupplyLbl.TabIndex = 0;
            this.SupplyLbl.Text = "Поставка";
            // 
            // SupplyRefreshBtn
            // 
            this.SupplyRefreshBtn.Image = global::AppDB.Properties.Resources.Обновить;
            this.SupplyRefreshBtn.Location = new System.Drawing.Point(675, 12);
            this.SupplyRefreshBtn.Name = "SupplyRefreshBtn";
            this.SupplyRefreshBtn.Size = new System.Drawing.Size(69, 58);
            this.SupplyRefreshBtn.TabIndex = 3;
            this.SupplyRefreshBtn.UseVisualStyleBackColor = true;
            this.SupplyRefreshBtn.Click += new System.EventHandler(this.SupplyRefreshBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackgroundImage = global::AppDB.Properties.Resources.Без_имени;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Location = new System.Drawing.Point(988, 16);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(48, 44);
            this.SearchBtn.TabIndex = 1;
            this.SearchBtn.UseVisualStyleBackColor = true;
            // 
            // SupplyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 728);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.SupplyDataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "SupplyForm";
            this.Text = "Таблица \"Поставка\"";
            this.Load += new System.EventHandler(this.SupplyForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SupplyDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button SupplyChangeInfoBtn;
        private System.Windows.Forms.Button SupplyUpdateBtn;
        private System.Windows.Forms.Button SupplyDeleteInfoBtn;
        private System.Windows.Forms.Button SupplyAddInfoBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox SupplyDateSupplyTxtBx;
        private System.Windows.Forms.TextBox StockIdSupplyTxtBx;
        private System.Windows.Forms.Label SupplyDateSupplyLbl;
        private System.Windows.Forms.Label StockIdSupplyLbl;
        private System.Windows.Forms.Label CAMarksLbl;
        private System.Windows.Forms.TextBox CACodeSupplyTxtBx;
        private System.Windows.Forms.TextBox InvoiceCodeSupplyTxtBx;
        private System.Windows.Forms.Label CACodeSupplyLbl;
        private System.Windows.Forms.Label InvoiceCodeSupplyLbl;
        private System.Windows.Forms.DataGridView SupplyDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SupplyRefreshBtn;
        private System.Windows.Forms.Label SearchTxtLbl;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox SupplySearchTxtBox;
        private System.Windows.Forms.Label SupplyLbl;
    }
}