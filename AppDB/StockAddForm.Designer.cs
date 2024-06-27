namespace AppDB
{
    partial class StockAddForm
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
            this.StockAddBtn = new System.Windows.Forms.Button();
            this.StockNameTxtBx = new System.Windows.Forms.TextBox();
            this.StockCodeTxtBx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddNewInfoLbl = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.StockAddBtn);
            this.panel2.Controls.Add(this.StockNameTxtBx);
            this.panel2.Controls.Add(this.StockCodeTxtBx);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(577, 215);
            this.panel2.TabIndex = 3;
            // 
            // StockAddBtn
            // 
            this.StockAddBtn.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StockAddBtn.Location = new System.Drawing.Point(244, 166);
            this.StockAddBtn.Name = "StockAddBtn";
            this.StockAddBtn.Size = new System.Drawing.Size(88, 23);
            this.StockAddBtn.TabIndex = 5;
            this.StockAddBtn.Text = "Добавить";
            this.StockAddBtn.UseVisualStyleBackColor = true;
            this.StockAddBtn.Click += new System.EventHandler(this.StockAddBtn_Click);
            // 
            // StockNameTxtBx
            // 
            this.StockNameTxtBx.Location = new System.Drawing.Point(340, 99);
            this.StockNameTxtBx.Name = "StockNameTxtBx";
            this.StockNameTxtBx.Size = new System.Drawing.Size(209, 20);
            this.StockNameTxtBx.TabIndex = 4;
            // 
            // StockCodeTxtBx
            // 
            this.StockCodeTxtBx.Location = new System.Drawing.Point(340, 34);
            this.StockCodeTxtBx.Name = "StockCodeTxtBx";
            this.StockCodeTxtBx.Size = new System.Drawing.Size(209, 20);
            this.StockCodeTxtBx.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(49, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Наименование склада:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(49, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Код склада:";
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
            // StockAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 323);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "StockAddForm";
            this.Text = "StockAddForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button StockAddBtn;
        private System.Windows.Forms.TextBox StockNameTxtBx;
        private System.Windows.Forms.TextBox StockCodeTxtBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AddNewInfoLbl;
    }
}