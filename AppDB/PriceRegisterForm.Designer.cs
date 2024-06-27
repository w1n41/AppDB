namespace AppDB
{
    partial class PriceRegisterForm
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
            this.PriceRegisterChangeInfoBtn = new System.Windows.Forms.Button();
            this.PriceRegisterUpdateBtn = new System.Windows.Forms.Button();
            this.PriceRegisterDeleteInfoBtn = new System.Windows.Forms.Button();
            this.PriceRegisterAddInfoBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ProductCodePriceRegisterTxtBx = new System.Windows.Forms.TextBox();
            this.ProductCodePriceRegisterLbl = new System.Windows.Forms.Label();
            this.CAMarksLbl = new System.Windows.Forms.Label();
            this.PriceOfReleasePriceRegisterTxtBx = new System.Windows.Forms.TextBox();
            this.PriceRegisterDateTxtBx = new System.Windows.Forms.TextBox();
            this.PriceOfReleasePriceRegisterLbl = new System.Windows.Forms.Label();
            this.DatePriceRegisterLbl = new System.Windows.Forms.Label();
            this.PriceRegisterDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchTxtLbl = new System.Windows.Forms.Label();
            this.PriceRegisterSearchTxtBox = new System.Windows.Forms.TextBox();
            this.PriceRegisterLbl = new System.Windows.Forms.Label();
            this.PriceRegisterRefreshBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PriceRegisterDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(649, 505);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Работа с записями:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.PriceRegisterChangeInfoBtn);
            this.panel2.Controls.Add(this.PriceRegisterUpdateBtn);
            this.panel2.Controls.Add(this.PriceRegisterDeleteInfoBtn);
            this.panel2.Controls.Add(this.PriceRegisterAddInfoBtn);
            this.panel2.Location = new System.Drawing.Point(570, 525);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 155);
            this.panel2.TabIndex = 9;
            // 
            // PriceRegisterChangeInfoBtn
            // 
            this.PriceRegisterChangeInfoBtn.Location = new System.Drawing.Point(156, 95);
            this.PriceRegisterChangeInfoBtn.Name = "PriceRegisterChangeInfoBtn";
            this.PriceRegisterChangeInfoBtn.Size = new System.Drawing.Size(111, 40);
            this.PriceRegisterChangeInfoBtn.TabIndex = 3;
            this.PriceRegisterChangeInfoBtn.Text = "Изменить ";
            this.PriceRegisterChangeInfoBtn.UseVisualStyleBackColor = true;
            this.PriceRegisterChangeInfoBtn.Click += new System.EventHandler(this.PriceRegisterChangeInfoBtn_Click);
            // 
            // PriceRegisterUpdateBtn
            // 
            this.PriceRegisterUpdateBtn.Location = new System.Drawing.Point(24, 95);
            this.PriceRegisterUpdateBtn.Name = "PriceRegisterUpdateBtn";
            this.PriceRegisterUpdateBtn.Size = new System.Drawing.Size(111, 40);
            this.PriceRegisterUpdateBtn.TabIndex = 2;
            this.PriceRegisterUpdateBtn.Text = "Сохранить ";
            this.PriceRegisterUpdateBtn.UseVisualStyleBackColor = true;
            this.PriceRegisterUpdateBtn.Click += new System.EventHandler(this.PriceRegisterUpdateBtn_Click);
            // 
            // PriceRegisterDeleteInfoBtn
            // 
            this.PriceRegisterDeleteInfoBtn.Location = new System.Drawing.Point(156, 30);
            this.PriceRegisterDeleteInfoBtn.Name = "PriceRegisterDeleteInfoBtn";
            this.PriceRegisterDeleteInfoBtn.Size = new System.Drawing.Size(111, 40);
            this.PriceRegisterDeleteInfoBtn.TabIndex = 1;
            this.PriceRegisterDeleteInfoBtn.Text = "Удалить запись";
            this.PriceRegisterDeleteInfoBtn.UseVisualStyleBackColor = true;
            this.PriceRegisterDeleteInfoBtn.Click += new System.EventHandler(this.PriceRegisterDeleteInfoBtn_Click);
            // 
            // PriceRegisterAddInfoBtn
            // 
            this.PriceRegisterAddInfoBtn.Location = new System.Drawing.Point(24, 31);
            this.PriceRegisterAddInfoBtn.Name = "PriceRegisterAddInfoBtn";
            this.PriceRegisterAddInfoBtn.Size = new System.Drawing.Size(111, 40);
            this.PriceRegisterAddInfoBtn.TabIndex = 0;
            this.PriceRegisterAddInfoBtn.Text = "Новая запись";
            this.PriceRegisterAddInfoBtn.UseVisualStyleBackColor = true;
            this.PriceRegisterAddInfoBtn.Click += new System.EventHandler(this.PriceRegisterAddInfoBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.ProductCodePriceRegisterTxtBx);
            this.panel3.Controls.Add(this.ProductCodePriceRegisterLbl);
            this.panel3.Controls.Add(this.CAMarksLbl);
            this.panel3.Controls.Add(this.PriceOfReleasePriceRegisterTxtBx);
            this.panel3.Controls.Add(this.PriceRegisterDateTxtBx);
            this.panel3.Controls.Add(this.PriceOfReleasePriceRegisterLbl);
            this.panel3.Controls.Add(this.DatePriceRegisterLbl);
            this.panel3.Location = new System.Drawing.Point(61, 505);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(395, 188);
            this.panel3.TabIndex = 8;
            // 
            // ProductCodePriceRegisterTxtBx
            // 
            this.ProductCodePriceRegisterTxtBx.Location = new System.Drawing.Point(232, 98);
            this.ProductCodePriceRegisterTxtBx.Name = "ProductCodePriceRegisterTxtBx";
            this.ProductCodePriceRegisterTxtBx.Size = new System.Drawing.Size(143, 20);
            this.ProductCodePriceRegisterTxtBx.TabIndex = 6;
            // 
            // ProductCodePriceRegisterLbl
            // 
            this.ProductCodePriceRegisterLbl.AutoSize = true;
            this.ProductCodePriceRegisterLbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductCodePriceRegisterLbl.Location = new System.Drawing.Point(13, 101);
            this.ProductCodePriceRegisterLbl.Name = "ProductCodePriceRegisterLbl";
            this.ProductCodePriceRegisterLbl.Size = new System.Drawing.Size(94, 17);
            this.ProductCodePriceRegisterLbl.TabIndex = 5;
            this.ProductCodePriceRegisterLbl.Text = "Код_Товара:";
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
            // PriceOfReleasePriceRegisterTxtBx
            // 
            this.PriceOfReleasePriceRegisterTxtBx.Location = new System.Drawing.Point(232, 134);
            this.PriceOfReleasePriceRegisterTxtBx.Name = "PriceOfReleasePriceRegisterTxtBx";
            this.PriceOfReleasePriceRegisterTxtBx.Size = new System.Drawing.Size(143, 20);
            this.PriceOfReleasePriceRegisterTxtBx.TabIndex = 3;
            // 
            // PriceRegisterDateTxtBx
            // 
            this.PriceRegisterDateTxtBx.Location = new System.Drawing.Point(232, 60);
            this.PriceRegisterDateTxtBx.Name = "PriceRegisterDateTxtBx";
            this.PriceRegisterDateTxtBx.Size = new System.Drawing.Size(143, 20);
            this.PriceRegisterDateTxtBx.TabIndex = 2;
            // 
            // PriceOfReleasePriceRegisterLbl
            // 
            this.PriceOfReleasePriceRegisterLbl.AutoSize = true;
            this.PriceOfReleasePriceRegisterLbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceOfReleasePriceRegisterLbl.Location = new System.Drawing.Point(13, 137);
            this.PriceOfReleasePriceRegisterLbl.Name = "PriceOfReleasePriceRegisterLbl";
            this.PriceOfReleasePriceRegisterLbl.Size = new System.Drawing.Size(119, 17);
            this.PriceOfReleasePriceRegisterLbl.TabIndex = 1;
            this.PriceOfReleasePriceRegisterLbl.Text = "Цена_Продажи:";
            // 
            // DatePriceRegisterLbl
            // 
            this.DatePriceRegisterLbl.AutoSize = true;
            this.DatePriceRegisterLbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DatePriceRegisterLbl.Location = new System.Drawing.Point(13, 63);
            this.DatePriceRegisterLbl.Name = "DatePriceRegisterLbl";
            this.DatePriceRegisterLbl.Size = new System.Drawing.Size(45, 17);
            this.DatePriceRegisterLbl.TabIndex = 0;
            this.DatePriceRegisterLbl.Text = "Дата:";
            // 
            // PriceRegisterDataGridView
            // 
            this.PriceRegisterDataGridView.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.PriceRegisterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PriceRegisterDataGridView.Location = new System.Drawing.Point(0, 91);
            this.PriceRegisterDataGridView.Name = "PriceRegisterDataGridView";
            this.PriceRegisterDataGridView.Size = new System.Drawing.Size(966, 383);
            this.PriceRegisterDataGridView.TabIndex = 7;
            this.PriceRegisterDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PriceRegisterDataGridView_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.PriceRegisterRefreshBtn);
            this.panel1.Controls.Add(this.SearchTxtLbl);
            this.panel1.Controls.Add(this.SearchBtn);
            this.panel1.Controls.Add(this.PriceRegisterSearchTxtBox);
            this.panel1.Controls.Add(this.PriceRegisterLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(966, 94);
            this.panel1.TabIndex = 6;
            // 
            // SearchTxtLbl
            // 
            this.SearchTxtLbl.AutoSize = true;
            this.SearchTxtLbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTxtLbl.Location = new System.Drawing.Point(675, 27);
            this.SearchTxtLbl.Name = "SearchTxtLbl";
            this.SearchTxtLbl.Size = new System.Drawing.Size(90, 26);
            this.SearchTxtLbl.TabIndex = 2;
            this.SearchTxtLbl.Text = "Поиск:";
            // 
            // PriceRegisterSearchTxtBox
            // 
            this.PriceRegisterSearchTxtBox.Location = new System.Drawing.Point(771, 31);
            this.PriceRegisterSearchTxtBox.Name = "PriceRegisterSearchTxtBox";
            this.PriceRegisterSearchTxtBox.Size = new System.Drawing.Size(105, 20);
            this.PriceRegisterSearchTxtBox.TabIndex = 1;
            this.PriceRegisterSearchTxtBox.TextChanged += new System.EventHandler(this.SearchTxtBox_TextChanged);
            // 
            // PriceRegisterLbl
            // 
            this.PriceRegisterLbl.AutoSize = true;
            this.PriceRegisterLbl.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceRegisterLbl.Location = new System.Drawing.Point(12, 22);
            this.PriceRegisterLbl.Name = "PriceRegisterLbl";
            this.PriceRegisterLbl.Size = new System.Drawing.Size(334, 40);
            this.PriceRegisterLbl.TabIndex = 0;
            this.PriceRegisterLbl.Text = "Регистр цен продаж";
            // 
            // PriceRegisterRefreshBtn
            // 
            this.PriceRegisterRefreshBtn.Image = global::AppDB.Properties.Resources.Обновить;
            this.PriceRegisterRefreshBtn.Location = new System.Drawing.Point(584, 14);
            this.PriceRegisterRefreshBtn.Name = "PriceRegisterRefreshBtn";
            this.PriceRegisterRefreshBtn.Size = new System.Drawing.Size(69, 58);
            this.PriceRegisterRefreshBtn.TabIndex = 3;
            this.PriceRegisterRefreshBtn.UseVisualStyleBackColor = true;
            this.PriceRegisterRefreshBtn.Click += new System.EventHandler(this.PriceRegisterRefreshBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackgroundImage = global::AppDB.Properties.Resources.Без_имени;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Location = new System.Drawing.Point(894, 18);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(48, 44);
            this.SearchBtn.TabIndex = 1;
            this.SearchBtn.UseVisualStyleBackColor = true;
            // 
            // PriceRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 727);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.PriceRegisterDataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "PriceRegisterForm";
            this.Text = "Таблица \"Регистр цен продаж\"";
            this.Load += new System.EventHandler(this.PriceRegisterForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PriceRegisterDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button PriceRegisterChangeInfoBtn;
        private System.Windows.Forms.Button PriceRegisterUpdateBtn;
        private System.Windows.Forms.Button PriceRegisterDeleteInfoBtn;
        private System.Windows.Forms.Button PriceRegisterAddInfoBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label CAMarksLbl;
        private System.Windows.Forms.TextBox PriceOfReleasePriceRegisterTxtBx;
        private System.Windows.Forms.TextBox PriceRegisterDateTxtBx;
        private System.Windows.Forms.Label PriceOfReleasePriceRegisterLbl;
        private System.Windows.Forms.Label DatePriceRegisterLbl;
        private System.Windows.Forms.DataGridView PriceRegisterDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button PriceRegisterRefreshBtn;
        private System.Windows.Forms.Label SearchTxtLbl;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox PriceRegisterSearchTxtBox;
        private System.Windows.Forms.Label PriceRegisterLbl;
        private System.Windows.Forms.TextBox ProductCodePriceRegisterTxtBx;
        private System.Windows.Forms.Label ProductCodePriceRegisterLbl;
    }
}