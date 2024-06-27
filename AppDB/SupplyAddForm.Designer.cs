namespace AppDB
{
    partial class SupplyAddForm
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
            this.DateTimePickerSupply = new System.Windows.Forms.DateTimePicker();
            this.StockIdSupplyTxtBx = new System.Windows.Forms.TextBox();
            this.SupplyDateSupplyLbl = new System.Windows.Forms.Label();
            this.StockIdSupplyLbl = new System.Windows.Forms.Label();
            this.CACodeSupplyTxtBx = new System.Windows.Forms.TextBox();
            this.InvoiceCodeSupplyTxtBx = new System.Windows.Forms.TextBox();
            this.CACodeSupplyLbl = new System.Windows.Forms.Label();
            this.InvoiceCodeSupplyLbl = new System.Windows.Forms.Label();
            this.SupplyAddBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddNewInfoLbl = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.DateTimePickerSupply);
            this.panel2.Controls.Add(this.StockIdSupplyTxtBx);
            this.panel2.Controls.Add(this.SupplyDateSupplyLbl);
            this.panel2.Controls.Add(this.StockIdSupplyLbl);
            this.panel2.Controls.Add(this.CACodeSupplyTxtBx);
            this.panel2.Controls.Add(this.InvoiceCodeSupplyTxtBx);
            this.panel2.Controls.Add(this.CACodeSupplyLbl);
            this.panel2.Controls.Add(this.InvoiceCodeSupplyLbl);
            this.panel2.Controls.Add(this.SupplyAddBtn);
            this.panel2.Location = new System.Drawing.Point(12, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(577, 299);
            this.panel2.TabIndex = 5;
            // 
            // DateTimePickerSupply
            // 
            this.DateTimePickerSupply.Location = new System.Drawing.Point(322, 159);
            this.DateTimePickerSupply.Name = "DateTimePickerSupply";
            this.DateTimePickerSupply.Size = new System.Drawing.Size(211, 20);
            this.DateTimePickerSupply.TabIndex = 16;
            // 
            // StockIdSupplyTxtBx
            // 
            this.StockIdSupplyTxtBx.Location = new System.Drawing.Point(322, 121);
            this.StockIdSupplyTxtBx.Name = "StockIdSupplyTxtBx";
            this.StockIdSupplyTxtBx.Size = new System.Drawing.Size(211, 20);
            this.StockIdSupplyTxtBx.TabIndex = 15;
            // 
            // SupplyDateSupplyLbl
            // 
            this.SupplyDateSupplyLbl.AutoSize = true;
            this.SupplyDateSupplyLbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SupplyDateSupplyLbl.Location = new System.Drawing.Point(63, 157);
            this.SupplyDateSupplyLbl.Name = "SupplyDateSupplyLbl";
            this.SupplyDateSupplyLbl.Size = new System.Drawing.Size(164, 24);
            this.SupplyDateSupplyLbl.TabIndex = 14;
            this.SupplyDateSupplyLbl.Text = "Дата_Поставки:";
            // 
            // StockIdSupplyLbl
            // 
            this.StockIdSupplyLbl.AutoSize = true;
            this.StockIdSupplyLbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StockIdSupplyLbl.Location = new System.Drawing.Point(63, 117);
            this.StockIdSupplyLbl.Name = "StockIdSupplyLbl";
            this.StockIdSupplyLbl.Size = new System.Drawing.Size(135, 24);
            this.StockIdSupplyLbl.TabIndex = 13;
            this.StockIdSupplyLbl.Text = "Код_Склада:";
            // 
            // CACodeSupplyTxtBx
            // 
            this.CACodeSupplyTxtBx.Location = new System.Drawing.Point(322, 85);
            this.CACodeSupplyTxtBx.Name = "CACodeSupplyTxtBx";
            this.CACodeSupplyTxtBx.Size = new System.Drawing.Size(211, 20);
            this.CACodeSupplyTxtBx.TabIndex = 12;
            // 
            // InvoiceCodeSupplyTxtBx
            // 
            this.InvoiceCodeSupplyTxtBx.Location = new System.Drawing.Point(322, 44);
            this.InvoiceCodeSupplyTxtBx.Name = "InvoiceCodeSupplyTxtBx";
            this.InvoiceCodeSupplyTxtBx.Size = new System.Drawing.Size(211, 20);
            this.InvoiceCodeSupplyTxtBx.TabIndex = 11;
            // 
            // CACodeSupplyLbl
            // 
            this.CACodeSupplyLbl.AutoSize = true;
            this.CACodeSupplyLbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CACodeSupplyLbl.Location = new System.Drawing.Point(63, 80);
            this.CACodeSupplyLbl.Name = "CACodeSupplyLbl";
            this.CACodeSupplyLbl.Size = new System.Drawing.Size(183, 24);
            this.CACodeSupplyLbl.TabIndex = 10;
            this.CACodeSupplyLbl.Text = "Код_Контрагента:";
            // 
            // InvoiceCodeSupplyLbl
            // 
            this.InvoiceCodeSupplyLbl.AutoSize = true;
            this.InvoiceCodeSupplyLbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InvoiceCodeSupplyLbl.Location = new System.Drawing.Point(63, 39);
            this.InvoiceCodeSupplyLbl.Name = "InvoiceCodeSupplyLbl";
            this.InvoiceCodeSupplyLbl.Size = new System.Drawing.Size(198, 24);
            this.InvoiceCodeSupplyLbl.TabIndex = 9;
            this.InvoiceCodeSupplyLbl.Text = "Номер_Накладной:";
            // 
            // SupplyAddBtn
            // 
            this.SupplyAddBtn.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SupplyAddBtn.Location = new System.Drawing.Point(238, 241);
            this.SupplyAddBtn.Name = "SupplyAddBtn";
            this.SupplyAddBtn.Size = new System.Drawing.Size(88, 23);
            this.SupplyAddBtn.TabIndex = 5;
            this.SupplyAddBtn.Text = "Добавить";
            this.SupplyAddBtn.UseVisualStyleBackColor = true;
            this.SupplyAddBtn.Click += new System.EventHandler(this.SupplyAddBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.AddNewInfoLbl);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 59);
            this.panel1.TabIndex = 4;
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
            // SupplyAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 388);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SupplyAddForm";
            this.Text = "SupplyAddForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker DateTimePickerSupply;
        private System.Windows.Forms.TextBox StockIdSupplyTxtBx;
        private System.Windows.Forms.Label SupplyDateSupplyLbl;
        private System.Windows.Forms.Label StockIdSupplyLbl;
        private System.Windows.Forms.TextBox CACodeSupplyTxtBx;
        private System.Windows.Forms.TextBox InvoiceCodeSupplyTxtBx;
        private System.Windows.Forms.Label CACodeSupplyLbl;
        private System.Windows.Forms.Label InvoiceCodeSupplyLbl;
        private System.Windows.Forms.Button SupplyAddBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AddNewInfoLbl;
    }
}