namespace AppDB
{
    partial class ReleaseAddForm
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
            this.StockIdReleaseTxtBx = new System.Windows.Forms.TextBox();
            this.ReleaseDateReleaseLbl = new System.Windows.Forms.Label();
            this.StockIdReleaseLbl = new System.Windows.Forms.Label();
            this.CACodeReleaseTxtBx = new System.Windows.Forms.TextBox();
            this.InvoiceCodeReleaseTxtBx = new System.Windows.Forms.TextBox();
            this.CACodeReleaseLbl = new System.Windows.Forms.Label();
            this.InvoiceCodeReleaseLbl = new System.Windows.Forms.Label();
            this.ReleaseAddBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddNewInfoLbl = new System.Windows.Forms.Label();
            this.DateTimePickerRelease = new System.Windows.Forms.DateTimePicker();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.DateTimePickerRelease);
            this.panel2.Controls.Add(this.StockIdReleaseTxtBx);
            this.panel2.Controls.Add(this.ReleaseDateReleaseLbl);
            this.panel2.Controls.Add(this.StockIdReleaseLbl);
            this.panel2.Controls.Add(this.CACodeReleaseTxtBx);
            this.panel2.Controls.Add(this.InvoiceCodeReleaseTxtBx);
            this.panel2.Controls.Add(this.CACodeReleaseLbl);
            this.panel2.Controls.Add(this.InvoiceCodeReleaseLbl);
            this.panel2.Controls.Add(this.ReleaseAddBtn);
            this.panel2.Location = new System.Drawing.Point(12, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(577, 299);
            this.panel2.TabIndex = 3;
            // 
            // StockIdReleaseTxtBx
            // 
            this.StockIdReleaseTxtBx.Location = new System.Drawing.Point(322, 121);
            this.StockIdReleaseTxtBx.Name = "StockIdReleaseTxtBx";
            this.StockIdReleaseTxtBx.Size = new System.Drawing.Size(211, 20);
            this.StockIdReleaseTxtBx.TabIndex = 15;
            // 
            // ReleaseDateReleaseLbl
            // 
            this.ReleaseDateReleaseLbl.AutoSize = true;
            this.ReleaseDateReleaseLbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReleaseDateReleaseLbl.Location = new System.Drawing.Point(63, 157);
            this.ReleaseDateReleaseLbl.Name = "ReleaseDateReleaseLbl";
            this.ReleaseDateReleaseLbl.Size = new System.Drawing.Size(151, 24);
            this.ReleaseDateReleaseLbl.TabIndex = 14;
            this.ReleaseDateReleaseLbl.Text = "Дата_Отпуска:";
            // 
            // StockIdReleaseLbl
            // 
            this.StockIdReleaseLbl.AutoSize = true;
            this.StockIdReleaseLbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StockIdReleaseLbl.Location = new System.Drawing.Point(63, 117);
            this.StockIdReleaseLbl.Name = "StockIdReleaseLbl";
            this.StockIdReleaseLbl.Size = new System.Drawing.Size(135, 24);
            this.StockIdReleaseLbl.TabIndex = 13;
            this.StockIdReleaseLbl.Text = "Код_Склада:";
            // 
            // CACodeReleaseTxtBx
            // 
            this.CACodeReleaseTxtBx.Location = new System.Drawing.Point(322, 85);
            this.CACodeReleaseTxtBx.Name = "CACodeReleaseTxtBx";
            this.CACodeReleaseTxtBx.Size = new System.Drawing.Size(211, 20);
            this.CACodeReleaseTxtBx.TabIndex = 12;
            // 
            // InvoiceCodeReleaseTxtBx
            // 
            this.InvoiceCodeReleaseTxtBx.Location = new System.Drawing.Point(322, 44);
            this.InvoiceCodeReleaseTxtBx.Name = "InvoiceCodeReleaseTxtBx";
            this.InvoiceCodeReleaseTxtBx.Size = new System.Drawing.Size(211, 20);
            this.InvoiceCodeReleaseTxtBx.TabIndex = 11;
            // 
            // CACodeReleaseLbl
            // 
            this.CACodeReleaseLbl.AutoSize = true;
            this.CACodeReleaseLbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CACodeReleaseLbl.Location = new System.Drawing.Point(63, 80);
            this.CACodeReleaseLbl.Name = "CACodeReleaseLbl";
            this.CACodeReleaseLbl.Size = new System.Drawing.Size(183, 24);
            this.CACodeReleaseLbl.TabIndex = 10;
            this.CACodeReleaseLbl.Text = "Код_Контрагента:";
            // 
            // InvoiceCodeReleaseLbl
            // 
            this.InvoiceCodeReleaseLbl.AutoSize = true;
            this.InvoiceCodeReleaseLbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InvoiceCodeReleaseLbl.Location = new System.Drawing.Point(63, 39);
            this.InvoiceCodeReleaseLbl.Name = "InvoiceCodeReleaseLbl";
            this.InvoiceCodeReleaseLbl.Size = new System.Drawing.Size(198, 24);
            this.InvoiceCodeReleaseLbl.TabIndex = 9;
            this.InvoiceCodeReleaseLbl.Text = "Номер_Накладной:";
            // 
            // ReleaseAddBtn
            // 
            this.ReleaseAddBtn.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReleaseAddBtn.Location = new System.Drawing.Point(238, 241);
            this.ReleaseAddBtn.Name = "ReleaseAddBtn";
            this.ReleaseAddBtn.Size = new System.Drawing.Size(88, 23);
            this.ReleaseAddBtn.TabIndex = 5;
            this.ReleaseAddBtn.Text = "Добавить";
            this.ReleaseAddBtn.UseVisualStyleBackColor = true;
            this.ReleaseAddBtn.Click += new System.EventHandler(this.ReleaseAddBtn_Click);
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
            this.AddNewInfoLbl.Location = new System.Drawing.Point(193, 21);
            this.AddNewInfoLbl.Name = "AddNewInfoLbl";
            this.AddNewInfoLbl.Size = new System.Drawing.Size(179, 19);
            this.AddNewInfoLbl.TabIndex = 0;
            this.AddNewInfoLbl.Text = "Создание новой записи.";
            // 
            // DateTimePickerRelease
            // 
            this.DateTimePickerRelease.Location = new System.Drawing.Point(322, 159);
            this.DateTimePickerRelease.Name = "DateTimePickerRelease";
            this.DateTimePickerRelease.Size = new System.Drawing.Size(211, 20);
            this.DateTimePickerRelease.TabIndex = 16;
            // 
            // ReleaseAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 385);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ReleaseAddForm";
            this.Text = "ReleaseAddForn";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ReleaseAddBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AddNewInfoLbl;
        private System.Windows.Forms.TextBox StockIdReleaseTxtBx;
        private System.Windows.Forms.Label ReleaseDateReleaseLbl;
        private System.Windows.Forms.Label StockIdReleaseLbl;
        private System.Windows.Forms.TextBox CACodeReleaseTxtBx;
        private System.Windows.Forms.TextBox InvoiceCodeReleaseTxtBx;
        private System.Windows.Forms.Label CACodeReleaseLbl;
        private System.Windows.Forms.Label InvoiceCodeReleaseLbl;
        private System.Windows.Forms.DateTimePicker DateTimePickerRelease;
    }
}