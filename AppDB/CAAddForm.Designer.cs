namespace AppDB
{
    partial class CAAddForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddNewInfoLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CACodeTxtBx = new System.Windows.Forms.TextBox();
            this.CANameTxtBx = new System.Windows.Forms.TextBox();
            this.CAAddBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.AddNewInfoLbl);
            this.panel1.Location = new System.Drawing.Point(38, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 59);
            this.panel1.TabIndex = 0;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.CAAddBtn);
            this.panel2.Controls.Add(this.CANameTxtBx);
            this.panel2.Controls.Add(this.CACodeTxtBx);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(38, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(577, 215);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(49, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Код контрагента:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(49, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Наименование контрагента:";
            // 
            // CACodeTxtBx
            // 
            this.CACodeTxtBx.Location = new System.Drawing.Point(340, 34);
            this.CACodeTxtBx.Name = "CACodeTxtBx";
            this.CACodeTxtBx.Size = new System.Drawing.Size(209, 20);
            this.CACodeTxtBx.TabIndex = 3;
            // 
            // CANameTxtBx
            // 
            this.CANameTxtBx.Location = new System.Drawing.Point(340, 99);
            this.CANameTxtBx.Name = "CANameTxtBx";
            this.CANameTxtBx.Size = new System.Drawing.Size(209, 20);
            this.CANameTxtBx.TabIndex = 4;
            // 
            // CAAddBtn
            // 
            this.CAAddBtn.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CAAddBtn.Location = new System.Drawing.Point(238, 167);
            this.CAAddBtn.Name = "CAAddBtn";
            this.CAAddBtn.Size = new System.Drawing.Size(88, 23);
            this.CAAddBtn.TabIndex = 5;
            this.CAAddBtn.Text = "Добавить";
            this.CAAddBtn.UseVisualStyleBackColor = true;
            this.CAAddBtn.Click += new System.EventHandler(this.CAAddBtn_Click);
            // 
            // CAAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 325);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CAAddForm";
            this.Text = "CAAddForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AddNewInfoLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button CAAddBtn;
        private System.Windows.Forms.TextBox CANameTxtBx;
        private System.Windows.Forms.TextBox CACodeTxtBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}