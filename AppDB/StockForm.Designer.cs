namespace AppDB
{
    partial class StockForm
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
            this.StockChangeInfoBtn = new System.Windows.Forms.Button();
            this.StockUpdateBtn = new System.Windows.Forms.Button();
            this.StockDeleteInfoBtn = new System.Windows.Forms.Button();
            this.StockAddInfoBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CAMarksLbl = new System.Windows.Forms.Label();
            this.StockNameTxtBx = new System.Windows.Forms.TextBox();
            this.StockCodeTxtBx = new System.Windows.Forms.TextBox();
            this.StockNameStockLbl = new System.Windows.Forms.Label();
            this.StockIdStockLbl = new System.Windows.Forms.Label();
            this.StockDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchTxtLbl = new System.Windows.Forms.Label();
            this.StockSearchTxtBox = new System.Windows.Forms.TextBox();
            this.CounteragentLbl = new System.Windows.Forms.Label();
            this.StockRefreshBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(663, 513);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Работа с записями:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.StockChangeInfoBtn);
            this.panel2.Controls.Add(this.StockUpdateBtn);
            this.panel2.Controls.Add(this.StockDeleteInfoBtn);
            this.panel2.Controls.Add(this.StockAddInfoBtn);
            this.panel2.Location = new System.Drawing.Point(584, 533);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 155);
            this.panel2.TabIndex = 9;
            // 
            // StockChangeInfoBtn
            // 
            this.StockChangeInfoBtn.Location = new System.Drawing.Point(156, 95);
            this.StockChangeInfoBtn.Name = "StockChangeInfoBtn";
            this.StockChangeInfoBtn.Size = new System.Drawing.Size(111, 40);
            this.StockChangeInfoBtn.TabIndex = 3;
            this.StockChangeInfoBtn.Text = "Изменить ";
            this.StockChangeInfoBtn.UseVisualStyleBackColor = true;
            this.StockChangeInfoBtn.Click += new System.EventHandler(this.StockChangeInfoBtn_Click);
            // 
            // StockUpdateBtn
            // 
            this.StockUpdateBtn.Location = new System.Drawing.Point(24, 95);
            this.StockUpdateBtn.Name = "StockUpdateBtn";
            this.StockUpdateBtn.Size = new System.Drawing.Size(111, 40);
            this.StockUpdateBtn.TabIndex = 2;
            this.StockUpdateBtn.Text = "Сохранить ";
            this.StockUpdateBtn.UseVisualStyleBackColor = true;
            this.StockUpdateBtn.Click += new System.EventHandler(this.StockUpdateBtn_Click);
            // 
            // StockDeleteInfoBtn
            // 
            this.StockDeleteInfoBtn.Location = new System.Drawing.Point(156, 30);
            this.StockDeleteInfoBtn.Name = "StockDeleteInfoBtn";
            this.StockDeleteInfoBtn.Size = new System.Drawing.Size(111, 40);
            this.StockDeleteInfoBtn.TabIndex = 1;
            this.StockDeleteInfoBtn.Text = "Удалить запись";
            this.StockDeleteInfoBtn.UseVisualStyleBackColor = true;
            this.StockDeleteInfoBtn.Click += new System.EventHandler(this.StockDeleteInfoBtn_Click);
            // 
            // StockAddInfoBtn
            // 
            this.StockAddInfoBtn.Location = new System.Drawing.Point(24, 31);
            this.StockAddInfoBtn.Name = "StockAddInfoBtn";
            this.StockAddInfoBtn.Size = new System.Drawing.Size(111, 40);
            this.StockAddInfoBtn.TabIndex = 0;
            this.StockAddInfoBtn.Text = "Новая запись";
            this.StockAddInfoBtn.UseVisualStyleBackColor = true;
            this.StockAddInfoBtn.Click += new System.EventHandler(this.StockAddInfoBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.CAMarksLbl);
            this.panel3.Controls.Add(this.StockNameTxtBx);
            this.panel3.Controls.Add(this.StockCodeTxtBx);
            this.panel3.Controls.Add(this.StockNameStockLbl);
            this.panel3.Controls.Add(this.StockIdStockLbl);
            this.panel3.Location = new System.Drawing.Point(19, 513);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(395, 188);
            this.panel3.TabIndex = 8;
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
            // StockNameTxtBx
            // 
            this.StockNameTxtBx.Location = new System.Drawing.Point(232, 101);
            this.StockNameTxtBx.Name = "StockNameTxtBx";
            this.StockNameTxtBx.Size = new System.Drawing.Size(143, 20);
            this.StockNameTxtBx.TabIndex = 3;
            // 
            // StockCodeTxtBx
            // 
            this.StockCodeTxtBx.Location = new System.Drawing.Point(232, 60);
            this.StockCodeTxtBx.Name = "StockCodeTxtBx";
            this.StockCodeTxtBx.Size = new System.Drawing.Size(143, 20);
            this.StockCodeTxtBx.TabIndex = 2;
            // 
            // StockNameStockLbl
            // 
            this.StockNameStockLbl.AutoSize = true;
            this.StockNameStockLbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StockNameStockLbl.Location = new System.Drawing.Point(13, 104);
            this.StockNameStockLbl.Name = "StockNameStockLbl";
            this.StockNameStockLbl.Size = new System.Drawing.Size(171, 17);
            this.StockNameStockLbl.TabIndex = 1;
            this.StockNameStockLbl.Text = "Наименование_склада:";
            // 
            // StockIdStockLbl
            // 
            this.StockIdStockLbl.AutoSize = true;
            this.StockIdStockLbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StockIdStockLbl.Location = new System.Drawing.Point(13, 63);
            this.StockIdStockLbl.Name = "StockIdStockLbl";
            this.StockIdStockLbl.Size = new System.Drawing.Size(93, 17);
            this.StockIdStockLbl.TabIndex = 0;
            this.StockIdStockLbl.Text = "Код_склада:";
            // 
            // StockDataGridView
            // 
            this.StockDataGridView.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.StockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StockDataGridView.Location = new System.Drawing.Point(0, 90);
            this.StockDataGridView.Name = "StockDataGridView";
            this.StockDataGridView.Size = new System.Drawing.Size(966, 383);
            this.StockDataGridView.TabIndex = 7;
            this.StockDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StockDataGridView_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.StockRefreshBtn);
            this.panel1.Controls.Add(this.SearchTxtLbl);
            this.panel1.Controls.Add(this.SearchBtn);
            this.panel1.Controls.Add(this.StockSearchTxtBox);
            this.panel1.Controls.Add(this.CounteragentLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 94);
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
            // StockSearchTxtBox
            // 
            this.StockSearchTxtBox.Location = new System.Drawing.Point(771, 31);
            this.StockSearchTxtBox.Name = "StockSearchTxtBox";
            this.StockSearchTxtBox.Size = new System.Drawing.Size(105, 20);
            this.StockSearchTxtBox.TabIndex = 1;
            this.StockSearchTxtBox.TextChanged += new System.EventHandler(this.SearchTxtBox_TextChanged);
            // 
            // CounteragentLbl
            // 
            this.CounteragentLbl.AutoSize = true;
            this.CounteragentLbl.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CounteragentLbl.Location = new System.Drawing.Point(12, 22);
            this.CounteragentLbl.Name = "CounteragentLbl";
            this.CounteragentLbl.Size = new System.Drawing.Size(118, 40);
            this.CounteragentLbl.TabIndex = 0;
            this.CounteragentLbl.Text = "Склад";
            // 
            // StockRefreshBtn
            // 
            this.StockRefreshBtn.Image = global::AppDB.Properties.Resources.Обновить;
            this.StockRefreshBtn.Location = new System.Drawing.Point(584, 14);
            this.StockRefreshBtn.Name = "StockRefreshBtn";
            this.StockRefreshBtn.Size = new System.Drawing.Size(69, 58);
            this.StockRefreshBtn.TabIndex = 3;
            this.StockRefreshBtn.UseVisualStyleBackColor = true;
            this.StockRefreshBtn.Click += new System.EventHandler(this.StockRefreshBtn_Click);
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
            // StockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 714);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.StockDataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "StockForm";
            this.Text = "Таблица \"Склад\"";
            this.Load += new System.EventHandler(this.StockForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button StockChangeInfoBtn;
        private System.Windows.Forms.Button StockUpdateBtn;
        private System.Windows.Forms.Button StockDeleteInfoBtn;
        private System.Windows.Forms.Button StockAddInfoBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label CAMarksLbl;
        private System.Windows.Forms.TextBox StockNameTxtBx;
        private System.Windows.Forms.TextBox StockCodeTxtBx;
        private System.Windows.Forms.Label StockNameStockLbl;
        private System.Windows.Forms.Label StockIdStockLbl;
        private System.Windows.Forms.DataGridView StockDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button StockRefreshBtn;
        private System.Windows.Forms.Label SearchTxtLbl;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox StockSearchTxtBox;
        private System.Windows.Forms.Label CounteragentLbl;
    }
}