namespace AppDB
{
    partial class PriceRegisterAddForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.PriceRegisterAddBtn = new System.Windows.Forms.Button();
            this.ProductCodeTxtBx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddNewInfoLbl = new System.Windows.Forms.Label();
            this.PriceOfReleasePriceRegisterTxtBx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PriceRegisterDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.PriceRegisterDateTimePicker);
            this.panel2.Controls.Add(this.PriceOfReleasePriceRegisterTxtBx);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.PriceRegisterAddBtn);
            this.panel2.Controls.Add(this.ProductCodeTxtBx);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(577, 278);
            this.panel2.TabIndex = 3;
            // 
            // PriceRegisterAddBtn
            // 
            this.PriceRegisterAddBtn.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceRegisterAddBtn.Location = new System.Drawing.Point(234, 224);
            this.PriceRegisterAddBtn.Name = "PriceRegisterAddBtn";
            this.PriceRegisterAddBtn.Size = new System.Drawing.Size(88, 23);
            this.PriceRegisterAddBtn.TabIndex = 5;
            this.PriceRegisterAddBtn.Text = "Добавить";
            this.PriceRegisterAddBtn.UseVisualStyleBackColor = true;
            this.PriceRegisterAddBtn.Click += new System.EventHandler(this.PriceRegisterAddBtn_Click);
            // 
            // ProductCodeTxtBx
            // 
            this.ProductCodeTxtBx.Location = new System.Drawing.Point(340, 99);
            this.ProductCodeTxtBx.Name = "ProductCodeTxtBx";
            this.ProductCodeTxtBx.Size = new System.Drawing.Size(209, 20);
            this.ProductCodeTxtBx.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(49, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Код_Товара:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(49, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Дата:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.AddNewInfoLbl);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 59);
            this.panel1.TabIndex = 2;
            // 
            // AddNewInfoLbl
            // 
            this.AddNewInfoLbl.AutoSize = true;
            this.AddNewInfoLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNewInfoLbl.Location = new System.Drawing.Point(199, 21);
            this.AddNewInfoLbl.Name = "AddNewInfoLbl";
            this.AddNewInfoLbl.Size = new System.Drawing.Size(179, 19);
            this.AddNewInfoLbl.TabIndex = 0;
            this.AddNewInfoLbl.Text = "Создание новой записи.";
            // 
            // PriceOfReleasePriceRegisterTxtBx
            // 
            this.PriceOfReleasePriceRegisterTxtBx.Location = new System.Drawing.Point(340, 163);
            this.PriceOfReleasePriceRegisterTxtBx.Name = "PriceOfReleasePriceRegisterTxtBx";
            this.PriceOfReleasePriceRegisterTxtBx.Size = new System.Drawing.Size(209, 20);
            this.PriceOfReleasePriceRegisterTxtBx.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(49, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Цена_продажи:";
            // 
            // PriceRegisterDateTimePicker
            // 
            this.PriceRegisterDateTimePicker.Location = new System.Drawing.Point(340, 33);
            this.PriceRegisterDateTimePicker.Name = "PriceRegisterDateTimePicker";
            this.PriceRegisterDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.PriceRegisterDateTimePicker.TabIndex = 8;
            // 
            // PriceRegisterAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 386);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PriceRegisterAddForm";
            this.Text = "PriceRegisterAddForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button PriceRegisterAddBtn;
        private System.Windows.Forms.TextBox ProductCodeTxtBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AddNewInfoLbl;
        private System.Windows.Forms.DateTimePicker PriceRegisterDateTimePicker;
        private System.Windows.Forms.TextBox PriceOfReleasePriceRegisterTxtBx;
        private System.Windows.Forms.Label label3;
    }
}