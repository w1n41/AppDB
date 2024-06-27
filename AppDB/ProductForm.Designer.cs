namespace AppDB
{
    partial class ProductForm
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
            this.ProductChangeInfoBtn = new System.Windows.Forms.Button();
            this.ProductUpdateBtn = new System.Windows.Forms.Button();
            this.ProductDeleteInfoBtn = new System.Windows.Forms.Button();
            this.ProductAddInfoBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ProductTypeOfProductTxtBx = new System.Windows.Forms.TextBox();
            this.ProductTypeOfProductLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductNameProductTxtBx = new System.Windows.Forms.TextBox();
            this.ProductCodeProductTxtBx = new System.Windows.Forms.TextBox();
            this.ProductNameProductLbl = new System.Windows.Forms.Label();
            this.ProductCodeProductLbl = new System.Windows.Forms.Label();
            this.ProductDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchTxtLbl = new System.Windows.Forms.Label();
            this.ProductSearchTxtBox = new System.Windows.Forms.TextBox();
            this.ProductLbl = new System.Windows.Forms.Label();
            this.ProductDiscountPriceTxtBx = new System.Windows.Forms.TextBox();
            this.ProductDiscountPriceLbl = new System.Windows.Forms.Label();
            this.ProductSellingPriceTxtBx = new System.Windows.Forms.TextBox();
            this.ProductSupplierPriceTxtBx = new System.Windows.Forms.TextBox();
            this.ProductCellingPriceLbl = new System.Windows.Forms.Label();
            this.ProductSupplierPriceLbl = new System.Windows.Forms.Label();
            this.ProductRefreshBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(663, 524);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Работа с записями:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.ProductChangeInfoBtn);
            this.panel2.Controls.Add(this.ProductUpdateBtn);
            this.panel2.Controls.Add(this.ProductDeleteInfoBtn);
            this.panel2.Controls.Add(this.ProductAddInfoBtn);
            this.panel2.Location = new System.Drawing.Point(584, 544);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 155);
            this.panel2.TabIndex = 24;
            // 
            // ProductChangeInfoBtn
            // 
            this.ProductChangeInfoBtn.Location = new System.Drawing.Point(156, 95);
            this.ProductChangeInfoBtn.Name = "ProductChangeInfoBtn";
            this.ProductChangeInfoBtn.Size = new System.Drawing.Size(111, 40);
            this.ProductChangeInfoBtn.TabIndex = 3;
            this.ProductChangeInfoBtn.Text = "Изменить ";
            this.ProductChangeInfoBtn.UseVisualStyleBackColor = true;
            this.ProductChangeInfoBtn.Click += new System.EventHandler(this.ProductChangeInfoBtn_Click);
            // 
            // ProductUpdateBtn
            // 
            this.ProductUpdateBtn.Location = new System.Drawing.Point(24, 95);
            this.ProductUpdateBtn.Name = "ProductUpdateBtn";
            this.ProductUpdateBtn.Size = new System.Drawing.Size(111, 40);
            this.ProductUpdateBtn.TabIndex = 2;
            this.ProductUpdateBtn.Text = "Сохранить ";
            this.ProductUpdateBtn.UseVisualStyleBackColor = true;
            this.ProductUpdateBtn.Click += new System.EventHandler(this.ProductUpdateBtn_Click);
            // 
            // ProductDeleteInfoBtn
            // 
            this.ProductDeleteInfoBtn.Location = new System.Drawing.Point(156, 30);
            this.ProductDeleteInfoBtn.Name = "ProductDeleteInfoBtn";
            this.ProductDeleteInfoBtn.Size = new System.Drawing.Size(111, 40);
            this.ProductDeleteInfoBtn.TabIndex = 1;
            this.ProductDeleteInfoBtn.Text = "Удалить запись";
            this.ProductDeleteInfoBtn.UseVisualStyleBackColor = true;
            this.ProductDeleteInfoBtn.Click += new System.EventHandler(this.ProductDeleteInfoBtn_Click);
            // 
            // ProductAddInfoBtn
            // 
            this.ProductAddInfoBtn.Location = new System.Drawing.Point(24, 31);
            this.ProductAddInfoBtn.Name = "ProductAddInfoBtn";
            this.ProductAddInfoBtn.Size = new System.Drawing.Size(111, 40);
            this.ProductAddInfoBtn.TabIndex = 0;
            this.ProductAddInfoBtn.Text = "Новая запись";
            this.ProductAddInfoBtn.UseVisualStyleBackColor = true;
            this.ProductAddInfoBtn.Click += new System.EventHandler(this.ProductAddInfoBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.ProductDiscountPriceTxtBx);
            this.panel3.Controls.Add(this.ProductDiscountPriceLbl);
            this.panel3.Controls.Add(this.ProductSellingPriceTxtBx);
            this.panel3.Controls.Add(this.ProductSupplierPriceTxtBx);
            this.panel3.Controls.Add(this.ProductCellingPriceLbl);
            this.panel3.Controls.Add(this.ProductSupplierPriceLbl);
            this.panel3.Controls.Add(this.ProductTypeOfProductTxtBx);
            this.panel3.Controls.Add(this.ProductTypeOfProductLbl);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.ProductNameProductTxtBx);
            this.panel3.Controls.Add(this.ProductCodeProductTxtBx);
            this.panel3.Controls.Add(this.ProductNameProductLbl);
            this.panel3.Controls.Add(this.ProductCodeProductLbl);
            this.panel3.Location = new System.Drawing.Point(62, 492);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(395, 257);
            this.panel3.TabIndex = 23;
            // 
            // ProductTypeOfProductTxtBx
            // 
            this.ProductTypeOfProductTxtBx.Location = new System.Drawing.Point(232, 111);
            this.ProductTypeOfProductTxtBx.Name = "ProductTypeOfProductTxtBx";
            this.ProductTypeOfProductTxtBx.Size = new System.Drawing.Size(143, 20);
            this.ProductTypeOfProductTxtBx.TabIndex = 6;
            // 
            // ProductTypeOfProductLbl
            // 
            this.ProductTypeOfProductLbl.AutoSize = true;
            this.ProductTypeOfProductLbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductTypeOfProductLbl.Location = new System.Drawing.Point(13, 114);
            this.ProductTypeOfProductLbl.Name = "ProductTypeOfProductLbl";
            this.ProductTypeOfProductLbl.Size = new System.Drawing.Size(157, 17);
            this.ProductTypeOfProductLbl.TabIndex = 5;
            this.ProductTypeOfProductLbl.Text = "Единица_измерения:";
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
            // ProductNameProductTxtBx
            // 
            this.ProductNameProductTxtBx.Location = new System.Drawing.Point(232, 73);
            this.ProductNameProductTxtBx.Name = "ProductNameProductTxtBx";
            this.ProductNameProductTxtBx.Size = new System.Drawing.Size(143, 20);
            this.ProductNameProductTxtBx.TabIndex = 3;
            // 
            // ProductCodeProductTxtBx
            // 
            this.ProductCodeProductTxtBx.Location = new System.Drawing.Point(232, 38);
            this.ProductCodeProductTxtBx.Name = "ProductCodeProductTxtBx";
            this.ProductCodeProductTxtBx.Size = new System.Drawing.Size(143, 20);
            this.ProductCodeProductTxtBx.TabIndex = 2;
            // 
            // ProductNameProductLbl
            // 
            this.ProductNameProductLbl.AutoSize = true;
            this.ProductNameProductLbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductNameProductLbl.Location = new System.Drawing.Point(13, 76);
            this.ProductNameProductLbl.Name = "ProductNameProductLbl";
            this.ProductNameProductLbl.Size = new System.Drawing.Size(171, 17);
            this.ProductNameProductLbl.TabIndex = 1;
            this.ProductNameProductLbl.Text = "Наименование_товара:";
            // 
            // ProductCodeProductLbl
            // 
            this.ProductCodeProductLbl.AutoSize = true;
            this.ProductCodeProductLbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductCodeProductLbl.Location = new System.Drawing.Point(13, 41);
            this.ProductCodeProductLbl.Name = "ProductCodeProductLbl";
            this.ProductCodeProductLbl.Size = new System.Drawing.Size(93, 17);
            this.ProductCodeProductLbl.TabIndex = 0;
            this.ProductCodeProductLbl.Text = "Код_товара:";
            // 
            // ProductDataGridView
            // 
            this.ProductDataGridView.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.ProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDataGridView.Location = new System.Drawing.Point(-1, 90);
            this.ProductDataGridView.Name = "ProductDataGridView";
            this.ProductDataGridView.Size = new System.Drawing.Size(955, 383);
            this.ProductDataGridView.TabIndex = 22;
            this.ProductDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductDataGridView_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.ProductRefreshBtn);
            this.panel1.Controls.Add(this.SearchTxtLbl);
            this.panel1.Controls.Add(this.SearchBtn);
            this.panel1.Controls.Add(this.ProductSearchTxtBox);
            this.panel1.Controls.Add(this.ProductLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 94);
            this.panel1.TabIndex = 21;
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
            // ProductSearchTxtBox
            // 
            this.ProductSearchTxtBox.Location = new System.Drawing.Point(771, 31);
            this.ProductSearchTxtBox.Name = "ProductSearchTxtBox";
            this.ProductSearchTxtBox.Size = new System.Drawing.Size(105, 20);
            this.ProductSearchTxtBox.TabIndex = 1;
            this.ProductSearchTxtBox.TextChanged += new System.EventHandler(this.SearchTxtBox_TextChanged);
            // 
            // ProductLbl
            // 
            this.ProductLbl.AutoSize = true;
            this.ProductLbl.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductLbl.Location = new System.Drawing.Point(27, 22);
            this.ProductLbl.Name = "ProductLbl";
            this.ProductLbl.Size = new System.Drawing.Size(111, 40);
            this.ProductLbl.TabIndex = 0;
            this.ProductLbl.Text = "Товар";
            // 
            // ProductDiscountPriceTxtBx
            // 
            this.ProductDiscountPriceTxtBx.Location = new System.Drawing.Point(232, 220);
            this.ProductDiscountPriceTxtBx.Name = "ProductDiscountPriceTxtBx";
            this.ProductDiscountPriceTxtBx.Size = new System.Drawing.Size(143, 20);
            this.ProductDiscountPriceTxtBx.TabIndex = 12;
            // 
            // ProductDiscountPriceLbl
            // 
            this.ProductDiscountPriceLbl.AutoSize = true;
            this.ProductDiscountPriceLbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductDiscountPriceLbl.Location = new System.Drawing.Point(13, 223);
            this.ProductDiscountPriceLbl.Name = "ProductDiscountPriceLbl";
            this.ProductDiscountPriceLbl.Size = new System.Drawing.Size(113, 17);
            this.ProductDiscountPriceLbl.TabIndex = 11;
            this.ProductDiscountPriceLbl.Text = "Учетная_цена:";
            // 
            // ProductSellingPriceTxtBx
            // 
            this.ProductSellingPriceTxtBx.Location = new System.Drawing.Point(232, 185);
            this.ProductSellingPriceTxtBx.Name = "ProductSellingPriceTxtBx";
            this.ProductSellingPriceTxtBx.Size = new System.Drawing.Size(143, 20);
            this.ProductSellingPriceTxtBx.TabIndex = 10;
            // 
            // ProductSupplierPriceTxtBx
            // 
            this.ProductSupplierPriceTxtBx.Location = new System.Drawing.Point(232, 150);
            this.ProductSupplierPriceTxtBx.Name = "ProductSupplierPriceTxtBx";
            this.ProductSupplierPriceTxtBx.Size = new System.Drawing.Size(143, 20);
            this.ProductSupplierPriceTxtBx.TabIndex = 9;
            // 
            // ProductCellingPriceLbl
            // 
            this.ProductCellingPriceLbl.AutoSize = true;
            this.ProductCellingPriceLbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductCellingPriceLbl.Location = new System.Drawing.Point(13, 188);
            this.ProductCellingPriceLbl.Name = "ProductCellingPriceLbl";
            this.ProductCellingPriceLbl.Size = new System.Drawing.Size(116, 17);
            this.ProductCellingPriceLbl.TabIndex = 8;
            this.ProductCellingPriceLbl.Text = "Цена_продажи:";
            // 
            // ProductSupplierPriceLbl
            // 
            this.ProductSupplierPriceLbl.AutoSize = true;
            this.ProductSupplierPriceLbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductSupplierPriceLbl.Location = new System.Drawing.Point(13, 153);
            this.ProductSupplierPriceLbl.Name = "ProductSupplierPriceLbl";
            this.ProductSupplierPriceLbl.Size = new System.Drawing.Size(141, 17);
            this.ProductSupplierPriceLbl.TabIndex = 7;
            this.ProductSupplierPriceLbl.Text = "Цена_поставщика:";
            // 
            // ProductRefreshBtn
            // 
            this.ProductRefreshBtn.Image = global::AppDB.Properties.Resources.Обновить;
            this.ProductRefreshBtn.Location = new System.Drawing.Point(584, 14);
            this.ProductRefreshBtn.Name = "ProductRefreshBtn";
            this.ProductRefreshBtn.Size = new System.Drawing.Size(69, 58);
            this.ProductRefreshBtn.TabIndex = 3;
            this.ProductRefreshBtn.UseVisualStyleBackColor = true;
            this.ProductRefreshBtn.Click += new System.EventHandler(this.ProductRefreshBtn_Click);
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
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 761);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ProductDataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "ProductForm";
            this.Text = "Таблица \"Товар\"";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ProductChangeInfoBtn;
        private System.Windows.Forms.Button ProductUpdateBtn;
        private System.Windows.Forms.Button ProductDeleteInfoBtn;
        private System.Windows.Forms.Button ProductAddInfoBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox ProductDiscountPriceTxtBx;
        private System.Windows.Forms.Label ProductDiscountPriceLbl;
        private System.Windows.Forms.TextBox ProductSellingPriceTxtBx;
        private System.Windows.Forms.TextBox ProductSupplierPriceTxtBx;
        private System.Windows.Forms.Label ProductCellingPriceLbl;
        private System.Windows.Forms.Label ProductSupplierPriceLbl;
        private System.Windows.Forms.TextBox ProductTypeOfProductTxtBx;
        private System.Windows.Forms.Label ProductTypeOfProductLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProductNameProductTxtBx;
        private System.Windows.Forms.TextBox ProductCodeProductTxtBx;
        private System.Windows.Forms.Label ProductNameProductLbl;
        private System.Windows.Forms.Label ProductCodeProductLbl;
        private System.Windows.Forms.DataGridView ProductDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ProductRefreshBtn;
        private System.Windows.Forms.Label SearchTxtLbl;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox ProductSearchTxtBox;
        private System.Windows.Forms.Label ProductLbl;
    }
}