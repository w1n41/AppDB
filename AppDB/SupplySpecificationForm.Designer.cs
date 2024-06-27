namespace AppDB
{
    partial class SupplySpecificationForm
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
            this.SupplySpecificationChangeInfoBtn = new System.Windows.Forms.Button();
            this.SupplySpecificationUpdateBtn = new System.Windows.Forms.Button();
            this.SupplySpecificationDeleteInfoBtn = new System.Windows.Forms.Button();
            this.SupplySpecificationAddInfoBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CountOfProductSupplySpecifacionTxtBx = new System.Windows.Forms.TextBox();
            this.CountOfProductSupplySpecifacionLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductCodeSupplySpecificationTxtBx = new System.Windows.Forms.TextBox();
            this.InvoiceIdSupplySpecificationTxtBx = new System.Windows.Forms.TextBox();
            this.ProductNameSupplySpecificationLbl = new System.Windows.Forms.Label();
            this.InvoiceIdSupplySpecificationLbl = new System.Windows.Forms.Label();
            this.SupplySpecificationDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SupplySpecificationRefreshBtn = new System.Windows.Forms.Button();
            this.SearchTxtLbl = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SupplySpecificationSearchTxtBox = new System.Windows.Forms.TextBox();
            this.SupplySpecificationLbl = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SupplySpecificationDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(657, 518);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Работа с записями:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.SupplySpecificationChangeInfoBtn);
            this.panel2.Controls.Add(this.SupplySpecificationUpdateBtn);
            this.panel2.Controls.Add(this.SupplySpecificationDeleteInfoBtn);
            this.panel2.Controls.Add(this.SupplySpecificationAddInfoBtn);
            this.panel2.Location = new System.Drawing.Point(578, 538);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 155);
            this.panel2.TabIndex = 19;
            // 
            // SupplySpecificationChangeInfoBtn
            // 
            this.SupplySpecificationChangeInfoBtn.Location = new System.Drawing.Point(156, 95);
            this.SupplySpecificationChangeInfoBtn.Name = "SupplySpecificationChangeInfoBtn";
            this.SupplySpecificationChangeInfoBtn.Size = new System.Drawing.Size(111, 40);
            this.SupplySpecificationChangeInfoBtn.TabIndex = 3;
            this.SupplySpecificationChangeInfoBtn.Text = "Изменить ";
            this.SupplySpecificationChangeInfoBtn.UseVisualStyleBackColor = true;
            this.SupplySpecificationChangeInfoBtn.Click += new System.EventHandler(this.SupplySpecificationChangeInfoBtn_Click);
            // 
            // SupplySpecificationUpdateBtn
            // 
            this.SupplySpecificationUpdateBtn.Location = new System.Drawing.Point(24, 95);
            this.SupplySpecificationUpdateBtn.Name = "SupplySpecificationUpdateBtn";
            this.SupplySpecificationUpdateBtn.Size = new System.Drawing.Size(111, 40);
            this.SupplySpecificationUpdateBtn.TabIndex = 2;
            this.SupplySpecificationUpdateBtn.Text = "Сохранить ";
            this.SupplySpecificationUpdateBtn.UseVisualStyleBackColor = true;
            this.SupplySpecificationUpdateBtn.Click += new System.EventHandler(this.SupplySpetificationUpdateBtn_Click);
            // 
            // SupplySpecificationDeleteInfoBtn
            // 
            this.SupplySpecificationDeleteInfoBtn.Location = new System.Drawing.Point(156, 30);
            this.SupplySpecificationDeleteInfoBtn.Name = "SupplySpecificationDeleteInfoBtn";
            this.SupplySpecificationDeleteInfoBtn.Size = new System.Drawing.Size(111, 40);
            this.SupplySpecificationDeleteInfoBtn.TabIndex = 1;
            this.SupplySpecificationDeleteInfoBtn.Text = "Удалить запись";
            this.SupplySpecificationDeleteInfoBtn.UseVisualStyleBackColor = true;
            this.SupplySpecificationDeleteInfoBtn.Click += new System.EventHandler(this.SupplySpecificationDeleteInfoBtn_Click);
            // 
            // SupplySpecificationAddInfoBtn
            // 
            this.SupplySpecificationAddInfoBtn.Location = new System.Drawing.Point(24, 31);
            this.SupplySpecificationAddInfoBtn.Name = "SupplySpecificationAddInfoBtn";
            this.SupplySpecificationAddInfoBtn.Size = new System.Drawing.Size(111, 40);
            this.SupplySpecificationAddInfoBtn.TabIndex = 0;
            this.SupplySpecificationAddInfoBtn.Text = "Новая запись";
            this.SupplySpecificationAddInfoBtn.UseVisualStyleBackColor = true;
            this.SupplySpecificationAddInfoBtn.Click += new System.EventHandler(this.SupplySpecificationAddInfoBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.CountOfProductSupplySpecifacionTxtBx);
            this.panel3.Controls.Add(this.CountOfProductSupplySpecifacionLbl);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.ProductCodeSupplySpecificationTxtBx);
            this.panel3.Controls.Add(this.InvoiceIdSupplySpecificationTxtBx);
            this.panel3.Controls.Add(this.ProductNameSupplySpecificationLbl);
            this.panel3.Controls.Add(this.InvoiceIdSupplySpecificationLbl);
            this.panel3.Location = new System.Drawing.Point(63, 512);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(395, 195);
            this.panel3.TabIndex = 18;
            // 
            // CountOfProductSupplySpecifacionTxtBx
            // 
            this.CountOfProductSupplySpecifacionTxtBx.Location = new System.Drawing.Point(232, 145);
            this.CountOfProductSupplySpecifacionTxtBx.Name = "CountOfProductSupplySpecifacionTxtBx";
            this.CountOfProductSupplySpecifacionTxtBx.Size = new System.Drawing.Size(143, 20);
            this.CountOfProductSupplySpecifacionTxtBx.TabIndex = 6;
            // 
            // CountOfProductSupplySpecifacionLbl
            // 
            this.CountOfProductSupplySpecifacionLbl.AutoSize = true;
            this.CountOfProductSupplySpecifacionLbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountOfProductSupplySpecifacionLbl.Location = new System.Drawing.Point(13, 148);
            this.CountOfProductSupplySpecifacionLbl.Name = "CountOfProductSupplySpecifacionLbl";
            this.CountOfProductSupplySpecifacionLbl.Size = new System.Drawing.Size(95, 17);
            this.CountOfProductSupplySpecifacionLbl.TabIndex = 5;
            this.CountOfProductSupplySpecifacionLbl.Text = "Количество:";
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
            // ProductCodeSupplySpecificationTxtBx
            // 
            this.ProductCodeSupplySpecificationTxtBx.Location = new System.Drawing.Point(232, 101);
            this.ProductCodeSupplySpecificationTxtBx.Name = "ProductCodeSupplySpecificationTxtBx";
            this.ProductCodeSupplySpecificationTxtBx.Size = new System.Drawing.Size(143, 20);
            this.ProductCodeSupplySpecificationTxtBx.TabIndex = 3;
            // 
            // InvoiceIdSupplySpecificationTxtBx
            // 
            this.InvoiceIdSupplySpecificationTxtBx.Location = new System.Drawing.Point(232, 60);
            this.InvoiceIdSupplySpecificationTxtBx.Name = "InvoiceIdSupplySpecificationTxtBx";
            this.InvoiceIdSupplySpecificationTxtBx.Size = new System.Drawing.Size(143, 20);
            this.InvoiceIdSupplySpecificationTxtBx.TabIndex = 2;
            // 
            // ProductNameSupplySpecificationLbl
            // 
            this.ProductNameSupplySpecificationLbl.AutoSize = true;
            this.ProductNameSupplySpecificationLbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductNameSupplySpecificationLbl.Location = new System.Drawing.Point(13, 104);
            this.ProductNameSupplySpecificationLbl.Name = "ProductNameSupplySpecificationLbl";
            this.ProductNameSupplySpecificationLbl.Size = new System.Drawing.Size(93, 17);
            this.ProductNameSupplySpecificationLbl.TabIndex = 1;
            this.ProductNameSupplySpecificationLbl.Text = "Код_товара:";
            // 
            // InvoiceIdSupplySpecificationLbl
            // 
            this.InvoiceIdSupplySpecificationLbl.AutoSize = true;
            this.InvoiceIdSupplySpecificationLbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InvoiceIdSupplySpecificationLbl.Location = new System.Drawing.Point(13, 63);
            this.InvoiceIdSupplySpecificationLbl.Name = "InvoiceIdSupplySpecificationLbl";
            this.InvoiceIdSupplySpecificationLbl.Size = new System.Drawing.Size(141, 17);
            this.InvoiceIdSupplySpecificationLbl.TabIndex = 0;
            this.InvoiceIdSupplySpecificationLbl.Text = "Номер_накладной:";
            // 
            // SupplySpecificationDataGridView
            // 
            this.SupplySpecificationDataGridView.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.SupplySpecificationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SupplySpecificationDataGridView.Location = new System.Drawing.Point(0, 91);
            this.SupplySpecificationDataGridView.Name = "SupplySpecificationDataGridView";
            this.SupplySpecificationDataGridView.Size = new System.Drawing.Size(955, 383);
            this.SupplySpecificationDataGridView.TabIndex = 17;
            this.SupplySpecificationDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SupplyDataGridView_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.SupplySpecificationRefreshBtn);
            this.panel1.Controls.Add(this.SearchTxtLbl);
            this.panel1.Controls.Add(this.SearchBtn);
            this.panel1.Controls.Add(this.SupplySpecificationSearchTxtBox);
            this.panel1.Controls.Add(this.SupplySpecificationLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 94);
            this.panel1.TabIndex = 16;
            // 
            // SupplySpecificationRefreshBtn
            // 
            this.SupplySpecificationRefreshBtn.Image = global::AppDB.Properties.Resources.Обновить;
            this.SupplySpecificationRefreshBtn.Location = new System.Drawing.Point(584, 14);
            this.SupplySpecificationRefreshBtn.Name = "SupplySpecificationRefreshBtn";
            this.SupplySpecificationRefreshBtn.Size = new System.Drawing.Size(69, 58);
            this.SupplySpecificationRefreshBtn.TabIndex = 3;
            this.SupplySpecificationRefreshBtn.UseVisualStyleBackColor = true;
            this.SupplySpecificationRefreshBtn.Click += new System.EventHandler(this.SupplySpecificationRefreshBtn_Click);
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
            // SupplySpecificationSearchTxtBox
            // 
            this.SupplySpecificationSearchTxtBox.Location = new System.Drawing.Point(771, 31);
            this.SupplySpecificationSearchTxtBox.Name = "SupplySpecificationSearchTxtBox";
            this.SupplySpecificationSearchTxtBox.Size = new System.Drawing.Size(105, 20);
            this.SupplySpecificationSearchTxtBox.TabIndex = 1;
            this.SupplySpecificationSearchTxtBox.TextChanged += new System.EventHandler(this.SearchTxtBox_TextChanged);
            // 
            // SupplySpecificationLbl
            // 
            this.SupplySpecificationLbl.AutoSize = true;
            this.SupplySpecificationLbl.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SupplySpecificationLbl.Location = new System.Drawing.Point(12, 22);
            this.SupplySpecificationLbl.Name = "SupplySpecificationLbl";
            this.SupplySpecificationLbl.Size = new System.Drawing.Size(414, 40);
            this.SupplySpecificationLbl.TabIndex = 0;
            this.SupplySpecificationLbl.Text = "Спецификация поставки";
            // 
            // SupplySpecificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 719);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.SupplySpecificationDataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "SupplySpecificationForm";
            this.Text = "Таблица \"Спецификация поставки\"";
            this.Load += new System.EventHandler(this.SupplySpecificationForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SupplySpecificationDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button SupplySpecificationChangeInfoBtn;
        private System.Windows.Forms.Button SupplySpecificationUpdateBtn;
        private System.Windows.Forms.Button SupplySpecificationDeleteInfoBtn;
        private System.Windows.Forms.Button SupplySpecificationAddInfoBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox CountOfProductSupplySpecifacionTxtBx;
        private System.Windows.Forms.Label CountOfProductSupplySpecifacionLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProductCodeSupplySpecificationTxtBx;
        private System.Windows.Forms.TextBox InvoiceIdSupplySpecificationTxtBx;
        private System.Windows.Forms.Label ProductNameSupplySpecificationLbl;
        private System.Windows.Forms.Label InvoiceIdSupplySpecificationLbl;
        private System.Windows.Forms.DataGridView SupplySpecificationDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SupplySpecificationRefreshBtn;
        private System.Windows.Forms.Label SearchTxtLbl;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox SupplySpecificationSearchTxtBox;
        private System.Windows.Forms.Label SupplySpecificationLbl;
    }
}