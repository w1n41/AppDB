namespace AppDB
{
    partial class ReleaseForm
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
            this.ReleaseChangeInfoBtn = new System.Windows.Forms.Button();
            this.ReleaseUpdateBtn = new System.Windows.Forms.Button();
            this.ReleaseDeleteInfoBtn = new System.Windows.Forms.Button();
            this.ReleaseAddInfoBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ReleaseDateReleaseTxtBx = new System.Windows.Forms.TextBox();
            this.StockIdReleaseTxtBx = new System.Windows.Forms.TextBox();
            this.ReleaseDateReleaseLbl = new System.Windows.Forms.Label();
            this.StockIdReleaseLbl = new System.Windows.Forms.Label();
            this.CAMarksLbl = new System.Windows.Forms.Label();
            this.CACodeReleaseTxtBx = new System.Windows.Forms.TextBox();
            this.InvoiceCodeReleaseTxtBx = new System.Windows.Forms.TextBox();
            this.CACodeReleaseLbl = new System.Windows.Forms.Label();
            this.InvoiceCodeReleaseLbl = new System.Windows.Forms.Label();
            this.ReleaseDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ReleaseRefrehBtn = new System.Windows.Forms.Button();
            this.SearchTxtLbl = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.ReleaseSearchTxtBox = new System.Windows.Forms.TextBox();
            this.CounteragentLbl = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReleaseDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(719, 503);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Работа с записями:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.ReleaseChangeInfoBtn);
            this.panel2.Controls.Add(this.ReleaseUpdateBtn);
            this.panel2.Controls.Add(this.ReleaseDeleteInfoBtn);
            this.panel2.Controls.Add(this.ReleaseAddInfoBtn);
            this.panel2.Location = new System.Drawing.Point(651, 527);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 161);
            this.panel2.TabIndex = 9;
            // 
            // ReleaseChangeInfoBtn
            // 
            this.ReleaseChangeInfoBtn.Location = new System.Drawing.Point(156, 95);
            this.ReleaseChangeInfoBtn.Name = "ReleaseChangeInfoBtn";
            this.ReleaseChangeInfoBtn.Size = new System.Drawing.Size(111, 40);
            this.ReleaseChangeInfoBtn.TabIndex = 3;
            this.ReleaseChangeInfoBtn.Text = "Изменить ";
            this.ReleaseChangeInfoBtn.UseVisualStyleBackColor = true;
            this.ReleaseChangeInfoBtn.Click += new System.EventHandler(this.ReleaseChangeInfoBtn_Click);
            // 
            // ReleaseUpdateBtn
            // 
            this.ReleaseUpdateBtn.Location = new System.Drawing.Point(24, 95);
            this.ReleaseUpdateBtn.Name = "ReleaseUpdateBtn";
            this.ReleaseUpdateBtn.Size = new System.Drawing.Size(111, 40);
            this.ReleaseUpdateBtn.TabIndex = 2;
            this.ReleaseUpdateBtn.Text = "Сохранить ";
            this.ReleaseUpdateBtn.UseVisualStyleBackColor = true;
            this.ReleaseUpdateBtn.Click += new System.EventHandler(this.ReleaseUpdateBtn_Click);
            // 
            // ReleaseDeleteInfoBtn
            // 
            this.ReleaseDeleteInfoBtn.Location = new System.Drawing.Point(156, 30);
            this.ReleaseDeleteInfoBtn.Name = "ReleaseDeleteInfoBtn";
            this.ReleaseDeleteInfoBtn.Size = new System.Drawing.Size(111, 40);
            this.ReleaseDeleteInfoBtn.TabIndex = 1;
            this.ReleaseDeleteInfoBtn.Text = "Удалить запись";
            this.ReleaseDeleteInfoBtn.UseVisualStyleBackColor = true;
            this.ReleaseDeleteInfoBtn.Click += new System.EventHandler(this.ReleaseDeleteInfoBtn_Click);
            // 
            // ReleaseAddInfoBtn
            // 
            this.ReleaseAddInfoBtn.Location = new System.Drawing.Point(24, 31);
            this.ReleaseAddInfoBtn.Name = "ReleaseAddInfoBtn";
            this.ReleaseAddInfoBtn.Size = new System.Drawing.Size(111, 40);
            this.ReleaseAddInfoBtn.TabIndex = 0;
            this.ReleaseAddInfoBtn.Text = "Новая запись";
            this.ReleaseAddInfoBtn.UseVisualStyleBackColor = true;
            this.ReleaseAddInfoBtn.Click += new System.EventHandler(this.ReleaseAddInfoBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.ReleaseDateReleaseTxtBx);
            this.panel3.Controls.Add(this.StockIdReleaseTxtBx);
            this.panel3.Controls.Add(this.ReleaseDateReleaseLbl);
            this.panel3.Controls.Add(this.StockIdReleaseLbl);
            this.panel3.Controls.Add(this.CAMarksLbl);
            this.panel3.Controls.Add(this.CACodeReleaseTxtBx);
            this.panel3.Controls.Add(this.InvoiceCodeReleaseTxtBx);
            this.panel3.Controls.Add(this.CACodeReleaseLbl);
            this.panel3.Controls.Add(this.InvoiceCodeReleaseLbl);
            this.panel3.Location = new System.Drawing.Point(80, 480);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(395, 228);
            this.panel3.TabIndex = 8;
            // 
            // ReleaseDateReleaseTxtBx
            // 
            this.ReleaseDateReleaseTxtBx.Location = new System.Drawing.Point(232, 178);
            this.ReleaseDateReleaseTxtBx.Name = "ReleaseDateReleaseTxtBx";
            this.ReleaseDateReleaseTxtBx.Size = new System.Drawing.Size(143, 20);
            this.ReleaseDateReleaseTxtBx.TabIndex = 8;
            // 
            // StockIdReleaseTxtBx
            // 
            this.StockIdReleaseTxtBx.Location = new System.Drawing.Point(232, 137);
            this.StockIdReleaseTxtBx.Name = "StockIdReleaseTxtBx";
            this.StockIdReleaseTxtBx.Size = new System.Drawing.Size(143, 20);
            this.StockIdReleaseTxtBx.TabIndex = 7;
            // 
            // ReleaseDateReleaseLbl
            // 
            this.ReleaseDateReleaseLbl.AutoSize = true;
            this.ReleaseDateReleaseLbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReleaseDateReleaseLbl.Location = new System.Drawing.Point(13, 181);
            this.ReleaseDateReleaseLbl.Name = "ReleaseDateReleaseLbl";
            this.ReleaseDateReleaseLbl.Size = new System.Drawing.Size(112, 17);
            this.ReleaseDateReleaseLbl.TabIndex = 6;
            this.ReleaseDateReleaseLbl.Text = "Дата_Отпуска:";
            // 
            // StockIdReleaseLbl
            // 
            this.StockIdReleaseLbl.AutoSize = true;
            this.StockIdReleaseLbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StockIdReleaseLbl.Location = new System.Drawing.Point(13, 141);
            this.StockIdReleaseLbl.Name = "StockIdReleaseLbl";
            this.StockIdReleaseLbl.Size = new System.Drawing.Size(97, 17);
            this.StockIdReleaseLbl.TabIndex = 5;
            this.StockIdReleaseLbl.Text = "Код_Склада:";
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
            // CACodeReleaseTxtBx
            // 
            this.CACodeReleaseTxtBx.Location = new System.Drawing.Point(232, 101);
            this.CACodeReleaseTxtBx.Name = "CACodeReleaseTxtBx";
            this.CACodeReleaseTxtBx.Size = new System.Drawing.Size(143, 20);
            this.CACodeReleaseTxtBx.TabIndex = 3;
            // 
            // InvoiceCodeReleaseTxtBx
            // 
            this.InvoiceCodeReleaseTxtBx.Location = new System.Drawing.Point(232, 60);
            this.InvoiceCodeReleaseTxtBx.Name = "InvoiceCodeReleaseTxtBx";
            this.InvoiceCodeReleaseTxtBx.Size = new System.Drawing.Size(143, 20);
            this.InvoiceCodeReleaseTxtBx.TabIndex = 2;
            // 
            // CACodeReleaseLbl
            // 
            this.CACodeReleaseLbl.AutoSize = true;
            this.CACodeReleaseLbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CACodeReleaseLbl.Location = new System.Drawing.Point(13, 104);
            this.CACodeReleaseLbl.Name = "CACodeReleaseLbl";
            this.CACodeReleaseLbl.Size = new System.Drawing.Size(136, 17);
            this.CACodeReleaseLbl.TabIndex = 1;
            this.CACodeReleaseLbl.Text = "Код_Контрагента:";
            // 
            // InvoiceCodeReleaseLbl
            // 
            this.InvoiceCodeReleaseLbl.AutoSize = true;
            this.InvoiceCodeReleaseLbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InvoiceCodeReleaseLbl.Location = new System.Drawing.Point(13, 63);
            this.InvoiceCodeReleaseLbl.Name = "InvoiceCodeReleaseLbl";
            this.InvoiceCodeReleaseLbl.Size = new System.Drawing.Size(144, 17);
            this.InvoiceCodeReleaseLbl.TabIndex = 0;
            this.InvoiceCodeReleaseLbl.Text = "Номер_Накладной:";
            // 
            // ReleaseDataGridView
            // 
            this.ReleaseDataGridView.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.ReleaseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReleaseDataGridView.Location = new System.Drawing.Point(0, 85);
            this.ReleaseDataGridView.Name = "ReleaseDataGridView";
            this.ReleaseDataGridView.Size = new System.Drawing.Size(1058, 389);
            this.ReleaseDataGridView.TabIndex = 7;
            this.ReleaseDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReleaseDataGridView_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.ReleaseRefrehBtn);
            this.panel1.Controls.Add(this.SearchTxtLbl);
            this.panel1.Controls.Add(this.SearchBtn);
            this.panel1.Controls.Add(this.ReleaseSearchTxtBox);
            this.panel1.Controls.Add(this.CounteragentLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1058, 93);
            this.panel1.TabIndex = 6;
            // 
            // ReleaseRefrehBtn
            // 
            this.ReleaseRefrehBtn.Image = global::AppDB.Properties.Resources.Обновить;
            this.ReleaseRefrehBtn.Location = new System.Drawing.Point(675, 12);
            this.ReleaseRefrehBtn.Name = "ReleaseRefrehBtn";
            this.ReleaseRefrehBtn.Size = new System.Drawing.Size(69, 58);
            this.ReleaseRefrehBtn.TabIndex = 3;
            this.ReleaseRefrehBtn.UseVisualStyleBackColor = true;
            this.ReleaseRefrehBtn.Click += new System.EventHandler(this.ReleaseRefreshBtn_Click);
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
            // ReleaseSearchTxtBox
            // 
            this.ReleaseSearchTxtBox.Location = new System.Drawing.Point(862, 29);
            this.ReleaseSearchTxtBox.Name = "ReleaseSearchTxtBox";
            this.ReleaseSearchTxtBox.Size = new System.Drawing.Size(105, 20);
            this.ReleaseSearchTxtBox.TabIndex = 1;
            this.ReleaseSearchTxtBox.TextChanged += new System.EventHandler(this.SearchTxtBox_TextChanged);
            // 
            // CounteragentLbl
            // 
            this.CounteragentLbl.AutoSize = true;
            this.CounteragentLbl.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CounteragentLbl.Location = new System.Drawing.Point(12, 20);
            this.CounteragentLbl.Name = "CounteragentLbl";
            this.CounteragentLbl.Size = new System.Drawing.Size(133, 40);
            this.CounteragentLbl.TabIndex = 0;
            this.CounteragentLbl.Text = "Отпуск";
            // 
            // ReleaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 716);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ReleaseDataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "ReleaseForm";
            this.Text = "Таблица \"Отпуск\"";
            this.Load += new System.EventHandler(this.ReleaseForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReleaseDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ReleaseChangeInfoBtn;
        private System.Windows.Forms.Button ReleaseUpdateBtn;
        private System.Windows.Forms.Button ReleaseDeleteInfoBtn;
        private System.Windows.Forms.Button ReleaseAddInfoBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label CAMarksLbl;
        private System.Windows.Forms.TextBox CACodeReleaseTxtBx;
        private System.Windows.Forms.TextBox InvoiceCodeReleaseTxtBx;
        private System.Windows.Forms.Label CACodeReleaseLbl;
        private System.Windows.Forms.Label InvoiceCodeReleaseLbl;
        private System.Windows.Forms.DataGridView ReleaseDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ReleaseRefrehBtn;
        private System.Windows.Forms.Label SearchTxtLbl;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox ReleaseSearchTxtBox;
        private System.Windows.Forms.Label CounteragentLbl;
        private System.Windows.Forms.TextBox ReleaseDateReleaseTxtBx;
        private System.Windows.Forms.TextBox StockIdReleaseTxtBx;
        private System.Windows.Forms.Label ReleaseDateReleaseLbl;
        private System.Windows.Forms.Label StockIdReleaseLbl;
    }
}