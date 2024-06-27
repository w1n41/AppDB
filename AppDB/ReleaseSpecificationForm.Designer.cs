namespace AppDB
{
    partial class ReleaseSpecificationForm
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
            this.ReleaseSpecificationChangeInfoBtn = new System.Windows.Forms.Button();
            this.ReleaseSpecificationUpdateBtn = new System.Windows.Forms.Button();
            this.ReleaseSpecificationDeleteInfoBtn = new System.Windows.Forms.Button();
            this.ReleaseSpecificationAddInfoBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductCodeReleaseSpecificationTxtBx = new System.Windows.Forms.TextBox();
            this.InvoiceIdReleaseSpecificationTxtBx = new System.Windows.Forms.TextBox();
            this.ProductNameReleaseSpecificationLbl = new System.Windows.Forms.Label();
            this.InvoiceIdReleaseSpecificationLbl = new System.Windows.Forms.Label();
            this.ReleaseSpecificationDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ReleaseSpecificationRefreshBtn = new System.Windows.Forms.Button();
            this.SearchTxtLbl = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.ReleaseSpecificationSearchTxtBox = new System.Windows.Forms.TextBox();
            this.ReleaseSpecificationLbl = new System.Windows.Forms.Label();
            this.CountOfProductReleaseSpecifacionTxtBx = new System.Windows.Forms.TextBox();
            this.CountOfProductReleaseSpecifacionLbl = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReleaseSpecificationDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(663, 512);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Работа с записями:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.ReleaseSpecificationChangeInfoBtn);
            this.panel2.Controls.Add(this.ReleaseSpecificationUpdateBtn);
            this.panel2.Controls.Add(this.ReleaseSpecificationDeleteInfoBtn);
            this.panel2.Controls.Add(this.ReleaseSpecificationAddInfoBtn);
            this.panel2.Location = new System.Drawing.Point(584, 532);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 155);
            this.panel2.TabIndex = 14;
            // 
            // ReleaseSpecificationChangeInfoBtn
            // 
            this.ReleaseSpecificationChangeInfoBtn.Location = new System.Drawing.Point(156, 95);
            this.ReleaseSpecificationChangeInfoBtn.Name = "ReleaseSpecificationChangeInfoBtn";
            this.ReleaseSpecificationChangeInfoBtn.Size = new System.Drawing.Size(111, 40);
            this.ReleaseSpecificationChangeInfoBtn.TabIndex = 3;
            this.ReleaseSpecificationChangeInfoBtn.Text = "Изменить ";
            this.ReleaseSpecificationChangeInfoBtn.UseVisualStyleBackColor = true;
            this.ReleaseSpecificationChangeInfoBtn.Click += new System.EventHandler(this.ReleaseSpecificationChangeInfoBtn_Click);
            // 
            // ReleaseSpecificationUpdateBtn
            // 
            this.ReleaseSpecificationUpdateBtn.Location = new System.Drawing.Point(24, 95);
            this.ReleaseSpecificationUpdateBtn.Name = "ReleaseSpecificationUpdateBtn";
            this.ReleaseSpecificationUpdateBtn.Size = new System.Drawing.Size(111, 40);
            this.ReleaseSpecificationUpdateBtn.TabIndex = 2;
            this.ReleaseSpecificationUpdateBtn.Text = "Сохранить ";
            this.ReleaseSpecificationUpdateBtn.UseVisualStyleBackColor = true;
            this.ReleaseSpecificationUpdateBtn.Click += new System.EventHandler(this.ReleaseSpetificationUpdateBtn_Click);
            // 
            // ReleaseSpecificationDeleteInfoBtn
            // 
            this.ReleaseSpecificationDeleteInfoBtn.Location = new System.Drawing.Point(156, 30);
            this.ReleaseSpecificationDeleteInfoBtn.Name = "ReleaseSpecificationDeleteInfoBtn";
            this.ReleaseSpecificationDeleteInfoBtn.Size = new System.Drawing.Size(111, 40);
            this.ReleaseSpecificationDeleteInfoBtn.TabIndex = 1;
            this.ReleaseSpecificationDeleteInfoBtn.Text = "Удалить запись";
            this.ReleaseSpecificationDeleteInfoBtn.UseVisualStyleBackColor = true;
            this.ReleaseSpecificationDeleteInfoBtn.Click += new System.EventHandler(this.ReleaseSpecificationDeleteInfoBtn_Click);
            // 
            // ReleaseSpecificationAddInfoBtn
            // 
            this.ReleaseSpecificationAddInfoBtn.Location = new System.Drawing.Point(24, 31);
            this.ReleaseSpecificationAddInfoBtn.Name = "ReleaseSpecificationAddInfoBtn";
            this.ReleaseSpecificationAddInfoBtn.Size = new System.Drawing.Size(111, 40);
            this.ReleaseSpecificationAddInfoBtn.TabIndex = 0;
            this.ReleaseSpecificationAddInfoBtn.Text = "Новая запись";
            this.ReleaseSpecificationAddInfoBtn.UseVisualStyleBackColor = true;
            this.ReleaseSpecificationAddInfoBtn.Click += new System.EventHandler(this.ReleaseSpecificationAddInfoBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.CountOfProductReleaseSpecifacionTxtBx);
            this.panel3.Controls.Add(this.CountOfProductReleaseSpecifacionLbl);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.ProductCodeReleaseSpecificationTxtBx);
            this.panel3.Controls.Add(this.InvoiceIdReleaseSpecificationTxtBx);
            this.panel3.Controls.Add(this.ProductNameReleaseSpecificationLbl);
            this.panel3.Controls.Add(this.InvoiceIdReleaseSpecificationLbl);
            this.panel3.Location = new System.Drawing.Point(19, 512);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(395, 195);
            this.panel3.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(164, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Записи:";
            // 
            // ProductCodeReleaseSpecificationTxtBx
            // 
            this.ProductCodeReleaseSpecificationTxtBx.Location = new System.Drawing.Point(232, 101);
            this.ProductCodeReleaseSpecificationTxtBx.Name = "ProductCodeReleaseSpecificationTxtBx";
            this.ProductCodeReleaseSpecificationTxtBx.Size = new System.Drawing.Size(143, 20);
            this.ProductCodeReleaseSpecificationTxtBx.TabIndex = 3;
            // 
            // InvoiceIdReleaseSpecificationTxtBx
            // 
            this.InvoiceIdReleaseSpecificationTxtBx.Location = new System.Drawing.Point(232, 60);
            this.InvoiceIdReleaseSpecificationTxtBx.Name = "InvoiceIdReleaseSpecificationTxtBx";
            this.InvoiceIdReleaseSpecificationTxtBx.Size = new System.Drawing.Size(143, 20);
            this.InvoiceIdReleaseSpecificationTxtBx.TabIndex = 2;
            // 
            // ProductNameReleaseSpecificationLbl
            // 
            this.ProductNameReleaseSpecificationLbl.AutoSize = true;
            this.ProductNameReleaseSpecificationLbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductNameReleaseSpecificationLbl.Location = new System.Drawing.Point(13, 104);
            this.ProductNameReleaseSpecificationLbl.Name = "ProductNameReleaseSpecificationLbl";
            this.ProductNameReleaseSpecificationLbl.Size = new System.Drawing.Size(93, 17);
            this.ProductNameReleaseSpecificationLbl.TabIndex = 1;
            this.ProductNameReleaseSpecificationLbl.Text = "Код_товара:";
            // 
            // InvoiceIdReleaseSpecificationLbl
            // 
            this.InvoiceIdReleaseSpecificationLbl.AutoSize = true;
            this.InvoiceIdReleaseSpecificationLbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InvoiceIdReleaseSpecificationLbl.Location = new System.Drawing.Point(13, 63);
            this.InvoiceIdReleaseSpecificationLbl.Name = "InvoiceIdReleaseSpecificationLbl";
            this.InvoiceIdReleaseSpecificationLbl.Size = new System.Drawing.Size(141, 17);
            this.InvoiceIdReleaseSpecificationLbl.TabIndex = 0;
            this.InvoiceIdReleaseSpecificationLbl.Text = "Номер_накладной:";
            // 
            // ReleaseSpecificationDataGridView
            // 
            this.ReleaseSpecificationDataGridView.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.ReleaseSpecificationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReleaseSpecificationDataGridView.Location = new System.Drawing.Point(0, 89);
            this.ReleaseSpecificationDataGridView.Name = "ReleaseSpecificationDataGridView";
            this.ReleaseSpecificationDataGridView.Size = new System.Drawing.Size(966, 383);
            this.ReleaseSpecificationDataGridView.TabIndex = 12;
            this.ReleaseSpecificationDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReleaseDataGridView_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.ReleaseSpecificationRefreshBtn);
            this.panel1.Controls.Add(this.SearchTxtLbl);
            this.panel1.Controls.Add(this.SearchBtn);
            this.panel1.Controls.Add(this.ReleaseSpecificationSearchTxtBox);
            this.panel1.Controls.Add(this.ReleaseSpecificationLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 94);
            this.panel1.TabIndex = 11;
            // 
            // ReleaseSpecificationRefreshBtn
            // 
            this.ReleaseSpecificationRefreshBtn.Image = global::AppDB.Properties.Resources.Обновить;
            this.ReleaseSpecificationRefreshBtn.Location = new System.Drawing.Point(584, 14);
            this.ReleaseSpecificationRefreshBtn.Name = "ReleaseSpecificationRefreshBtn";
            this.ReleaseSpecificationRefreshBtn.Size = new System.Drawing.Size(69, 58);
            this.ReleaseSpecificationRefreshBtn.TabIndex = 3;
            this.ReleaseSpecificationRefreshBtn.UseVisualStyleBackColor = true;
            this.ReleaseSpecificationRefreshBtn.Click += new System.EventHandler(this.ReleaseSpecificationRefreshBtn_Click);
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
            // ReleaseSpecificationSearchTxtBox
            // 
            this.ReleaseSpecificationSearchTxtBox.Location = new System.Drawing.Point(771, 31);
            this.ReleaseSpecificationSearchTxtBox.Name = "ReleaseSpecificationSearchTxtBox";
            this.ReleaseSpecificationSearchTxtBox.Size = new System.Drawing.Size(105, 20);
            this.ReleaseSpecificationSearchTxtBox.TabIndex = 1;
            this.ReleaseSpecificationSearchTxtBox.TextChanged += new System.EventHandler(this.SearchTxtBox_TextChanged);
            // 
            // ReleaseSpecificationLbl
            // 
            this.ReleaseSpecificationLbl.AutoSize = true;
            this.ReleaseSpecificationLbl.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReleaseSpecificationLbl.Location = new System.Drawing.Point(12, 22);
            this.ReleaseSpecificationLbl.Name = "ReleaseSpecificationLbl";
            this.ReleaseSpecificationLbl.Size = new System.Drawing.Size(390, 40);
            this.ReleaseSpecificationLbl.TabIndex = 0;
            this.ReleaseSpecificationLbl.Text = "Спецификация отпуска";
            // 
            // CountOfProductReleaseSpecifacionTxtBx
            // 
            this.CountOfProductReleaseSpecifacionTxtBx.Location = new System.Drawing.Point(232, 145);
            this.CountOfProductReleaseSpecifacionTxtBx.Name = "CountOfProductReleaseSpecifacionTxtBx";
            this.CountOfProductReleaseSpecifacionTxtBx.Size = new System.Drawing.Size(143, 20);
            this.CountOfProductReleaseSpecifacionTxtBx.TabIndex = 6;
            // 
            // CountOfProductReleaseSpecifacionLbl
            // 
            this.CountOfProductReleaseSpecifacionLbl.AutoSize = true;
            this.CountOfProductReleaseSpecifacionLbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountOfProductReleaseSpecifacionLbl.Location = new System.Drawing.Point(13, 148);
            this.CountOfProductReleaseSpecifacionLbl.Name = "CountOfProductReleaseSpecifacionLbl";
            this.CountOfProductReleaseSpecifacionLbl.Size = new System.Drawing.Size(95, 17);
            this.CountOfProductReleaseSpecifacionLbl.TabIndex = 5;
            this.CountOfProductReleaseSpecifacionLbl.Text = "Количество:";
            // 
            // ReleaseSpecificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 719);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ReleaseSpecificationDataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "ReleaseSpecificationForm";
            this.Text = "Таблица \"Спецификация отпуска\"";
            this.Load += new System.EventHandler(this.ReleaseSpecificationForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReleaseSpecificationDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ReleaseSpecificationChangeInfoBtn;
        private System.Windows.Forms.Button ReleaseSpecificationUpdateBtn;
        private System.Windows.Forms.Button ReleaseSpecificationDeleteInfoBtn;
        private System.Windows.Forms.Button ReleaseSpecificationAddInfoBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox CountOfProductReleaseSpecifacionTxtBx;
        private System.Windows.Forms.Label CountOfProductReleaseSpecifacionLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProductCodeReleaseSpecificationTxtBx;
        private System.Windows.Forms.TextBox InvoiceIdReleaseSpecificationTxtBx;
        private System.Windows.Forms.Label ProductNameReleaseSpecificationLbl;
        private System.Windows.Forms.Label InvoiceIdReleaseSpecificationLbl;
        private System.Windows.Forms.DataGridView ReleaseSpecificationDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ReleaseSpecificationRefreshBtn;
        private System.Windows.Forms.Label SearchTxtLbl;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox ReleaseSpecificationSearchTxtBox;
        private System.Windows.Forms.Label ReleaseSpecificationLbl;
    }
}