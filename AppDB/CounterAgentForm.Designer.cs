namespace AppDB
{
    partial class CounterAgentForm
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
            this.CARefreshBtn = new System.Windows.Forms.Button();
            this.SearchTxtLbl = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.CASearchTxtBox = new System.Windows.Forms.TextBox();
            this.CounteragentLbl = new System.Windows.Forms.Label();
            this.CounterAgentDataGridView = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CAMarksLbl = new System.Windows.Forms.Label();
            this.CANameTxtBx = new System.Windows.Forms.TextBox();
            this.CACodeTxtBx = new System.Windows.Forms.TextBox();
            this.CANameOfCALbl = new System.Windows.Forms.Label();
            this.CACodeOfCALbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CAChangeInfoBtn = new System.Windows.Forms.Button();
            this.CAUpdateBtn = new System.Windows.Forms.Button();
            this.CADeleteInfoBtn = new System.Windows.Forms.Button();
            this.CAAddInfoBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CounterAgentDataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.CARefreshBtn);
            this.panel1.Controls.Add(this.SearchTxtLbl);
            this.panel1.Controls.Add(this.SearchBtn);
            this.panel1.Controls.Add(this.CASearchTxtBox);
            this.panel1.Controls.Add(this.CounteragentLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(966, 94);
            this.panel1.TabIndex = 0;
            // 
            // CARefreshBtn
            // 
            this.CARefreshBtn.Image = global::AppDB.Properties.Resources.Обновить;
            this.CARefreshBtn.Location = new System.Drawing.Point(584, 14);
            this.CARefreshBtn.Name = "CARefreshBtn";
            this.CARefreshBtn.Size = new System.Drawing.Size(69, 58);
            this.CARefreshBtn.TabIndex = 3;
            this.CARefreshBtn.UseVisualStyleBackColor = true;
            this.CARefreshBtn.Click += new System.EventHandler(this.CARefreshBtn_Click);
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
            // CASearchTxtBox
            // 
            this.CASearchTxtBox.Location = new System.Drawing.Point(771, 31);
            this.CASearchTxtBox.Name = "CASearchTxtBox";
            this.CASearchTxtBox.Size = new System.Drawing.Size(105, 20);
            this.CASearchTxtBox.TabIndex = 1;
            this.CASearchTxtBox.TextChanged += new System.EventHandler(this.SearchTxtBox_TextChanged);
            // 
            // CounteragentLbl
            // 
            this.CounteragentLbl.AutoSize = true;
            this.CounteragentLbl.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CounteragentLbl.Location = new System.Drawing.Point(12, 22);
            this.CounteragentLbl.Name = "CounteragentLbl";
            this.CounteragentLbl.Size = new System.Drawing.Size(201, 40);
            this.CounteragentLbl.TabIndex = 0;
            this.CounteragentLbl.Text = "Контрагент";
            // 
            // CounterAgentDataGridView
            // 
            this.CounterAgentDataGridView.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.CounterAgentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CounterAgentDataGridView.Location = new System.Drawing.Point(0, 89);
            this.CounterAgentDataGridView.Name = "CounterAgentDataGridView";
            this.CounterAgentDataGridView.Size = new System.Drawing.Size(966, 383);
            this.CounterAgentDataGridView.TabIndex = 1;
            this.CounterAgentDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CounterAgentDataGridView_CellClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.CAMarksLbl);
            this.panel3.Controls.Add(this.CANameTxtBx);
            this.panel3.Controls.Add(this.CACodeTxtBx);
            this.panel3.Controls.Add(this.CANameOfCALbl);
            this.panel3.Controls.Add(this.CACodeOfCALbl);
            this.panel3.Location = new System.Drawing.Point(19, 500);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(395, 188);
            this.panel3.TabIndex = 2;
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
            // CANameTxtBx
            // 
            this.CANameTxtBx.Location = new System.Drawing.Point(232, 101);
            this.CANameTxtBx.Name = "CANameTxtBx";
            this.CANameTxtBx.Size = new System.Drawing.Size(143, 20);
            this.CANameTxtBx.TabIndex = 3;
            // 
            // CACodeTxtBx
            // 
            this.CACodeTxtBx.Location = new System.Drawing.Point(232, 60);
            this.CACodeTxtBx.Name = "CACodeTxtBx";
            this.CACodeTxtBx.Size = new System.Drawing.Size(143, 20);
            this.CACodeTxtBx.TabIndex = 2;
            // 
            // CANameOfCALbl
            // 
            this.CANameOfCALbl.AutoSize = true;
            this.CANameOfCALbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CANameOfCALbl.Location = new System.Drawing.Point(13, 104);
            this.CANameOfCALbl.Name = "CANameOfCALbl";
            this.CANameOfCALbl.Size = new System.Drawing.Size(213, 17);
            this.CANameOfCALbl.TabIndex = 1;
            this.CANameOfCALbl.Text = "Наименование_контрагента:";
            // 
            // CACodeOfCALbl
            // 
            this.CACodeOfCALbl.AutoSize = true;
            this.CACodeOfCALbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CACodeOfCALbl.Location = new System.Drawing.Point(13, 63);
            this.CACodeOfCALbl.Name = "CACodeOfCALbl";
            this.CACodeOfCALbl.Size = new System.Drawing.Size(135, 17);
            this.CACodeOfCALbl.TabIndex = 0;
            this.CACodeOfCALbl.Text = "Код_контрагента:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.CAChangeInfoBtn);
            this.panel2.Controls.Add(this.CAUpdateBtn);
            this.panel2.Controls.Add(this.CADeleteInfoBtn);
            this.panel2.Controls.Add(this.CAAddInfoBtn);
            this.panel2.Location = new System.Drawing.Point(584, 520);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 155);
            this.panel2.TabIndex = 3;
            // 
            // CAChangeInfoBtn
            // 
            this.CAChangeInfoBtn.Location = new System.Drawing.Point(156, 95);
            this.CAChangeInfoBtn.Name = "CAChangeInfoBtn";
            this.CAChangeInfoBtn.Size = new System.Drawing.Size(111, 40);
            this.CAChangeInfoBtn.TabIndex = 3;
            this.CAChangeInfoBtn.Text = "Изменить ";
            this.CAChangeInfoBtn.UseVisualStyleBackColor = true;
            this.CAChangeInfoBtn.Click += new System.EventHandler(this.CAChangeInfoBtn_Click);
            // 
            // CAUpdateBtn
            // 
            this.CAUpdateBtn.Location = new System.Drawing.Point(24, 95);
            this.CAUpdateBtn.Name = "CAUpdateBtn";
            this.CAUpdateBtn.Size = new System.Drawing.Size(111, 40);
            this.CAUpdateBtn.TabIndex = 2;
            this.CAUpdateBtn.Text = "Сохранить ";
            this.CAUpdateBtn.UseVisualStyleBackColor = true;
            this.CAUpdateBtn.Click += new System.EventHandler(this.CAUpdateBtn_Click);
            // 
            // CADeleteInfoBtn
            // 
            this.CADeleteInfoBtn.Location = new System.Drawing.Point(156, 30);
            this.CADeleteInfoBtn.Name = "CADeleteInfoBtn";
            this.CADeleteInfoBtn.Size = new System.Drawing.Size(111, 40);
            this.CADeleteInfoBtn.TabIndex = 1;
            this.CADeleteInfoBtn.Text = "Удалить запись";
            this.CADeleteInfoBtn.UseVisualStyleBackColor = true;
            this.CADeleteInfoBtn.Click += new System.EventHandler(this.CADeleteInfoBtn_Click);
            // 
            // CAAddInfoBtn
            // 
            this.CAAddInfoBtn.Location = new System.Drawing.Point(24, 31);
            this.CAAddInfoBtn.Name = "CAAddInfoBtn";
            this.CAAddInfoBtn.Size = new System.Drawing.Size(111, 40);
            this.CAAddInfoBtn.TabIndex = 0;
            this.CAAddInfoBtn.Text = "Новая запись";
            this.CAAddInfoBtn.UseVisualStyleBackColor = true;
            this.CAAddInfoBtn.Click += new System.EventHandler(this.CAAddInfoBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(663, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Работа с записями:";
            // 
            // CounterAgentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 706);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.CounterAgentDataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "CounterAgentForm";
            this.Text = "Таблица \"Контрагент\"";
            this.Load += new System.EventHandler(this.CounterAgentForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CounterAgentDataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CounteragentLbl;
        private System.Windows.Forms.TextBox CASearchTxtBox;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label SearchTxtLbl;
        private System.Windows.Forms.DataGridView CounterAgentDataGridView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label CAMarksLbl;
        private System.Windows.Forms.TextBox CANameTxtBx;
        private System.Windows.Forms.TextBox CACodeTxtBx;
        private System.Windows.Forms.Label CANameOfCALbl;
        private System.Windows.Forms.Label CACodeOfCALbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CAChangeInfoBtn;
        private System.Windows.Forms.Button CAUpdateBtn;
        private System.Windows.Forms.Button CADeleteInfoBtn;
        private System.Windows.Forms.Button CAAddInfoBtn;
        private System.Windows.Forms.Button CARefreshBtn;
    }
}