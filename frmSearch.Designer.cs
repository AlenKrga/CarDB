namespace CarsDatabase
{
    partial class frmSearch
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.frmTxtValue = new System.Windows.Forms.TextBox();
            this.frmCboOperator = new System.Windows.Forms.ComboBox();
            this.frmCboField = new System.Windows.Forms.ComboBox();
            this.frmValueLabel = new System.Windows.Forms.Label();
            this.frmOperatorLabel = new System.Windows.Forms.Label();
            this.frmFieldLabel = new System.Windows.Forms.Label();
            this.tblCarDataGridView = new System.Windows.Forms.DataGridView();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.frmTxtValue);
            this.groupBox1.Controls.Add(this.frmCboOperator);
            this.groupBox1.Controls.Add(this.frmCboField);
            this.groupBox1.Controls.Add(this.frmValueLabel);
            this.groupBox1.Controls.Add(this.frmOperatorLabel);
            this.groupBox1.Controls.Add(this.frmFieldLabel);
            this.groupBox1.Location = new System.Drawing.Point(89, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.groupBox1.Size = new System.Drawing.Size(1650, 313);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // frmTxtValue
            // 
            this.frmTxtValue.Location = new System.Drawing.Point(953, 185);
            this.frmTxtValue.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.frmTxtValue.Name = "frmTxtValue";
            this.frmTxtValue.Size = new System.Drawing.Size(437, 44);
            this.frmTxtValue.TabIndex = 5;
            // 
            // frmCboOperator
            // 
            this.frmCboOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.frmCboOperator.FormattingEnabled = true;
            this.frmCboOperator.Location = new System.Drawing.Point(592, 185);
            this.frmCboOperator.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.frmCboOperator.Name = "frmCboOperator";
            this.frmCboOperator.Size = new System.Drawing.Size(257, 45);
            this.frmCboOperator.TabIndex = 4;
            // 
            // frmCboField
            // 
            this.frmCboField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.frmCboField.FormattingEnabled = true;
            this.frmCboField.Location = new System.Drawing.Point(73, 185);
            this.frmCboField.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.frmCboField.Name = "frmCboField";
            this.frmCboField.Size = new System.Drawing.Size(394, 45);
            this.frmCboField.TabIndex = 3;
            // 
            // frmValueLabel
            // 
            this.frmValueLabel.AutoSize = true;
            this.frmValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmValueLabel.Location = new System.Drawing.Point(944, 85);
            this.frmValueLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.frmValueLabel.Name = "frmValueLabel";
            this.frmValueLabel.Size = new System.Drawing.Size(147, 55);
            this.frmValueLabel.TabIndex = 2;
            this.frmValueLabel.Text = "Value";
            // 
            // frmOperatorLabel
            // 
            this.frmOperatorLabel.AutoSize = true;
            this.frmOperatorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmOperatorLabel.Location = new System.Drawing.Point(583, 85);
            this.frmOperatorLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.frmOperatorLabel.Name = "frmOperatorLabel";
            this.frmOperatorLabel.Size = new System.Drawing.Size(214, 55);
            this.frmOperatorLabel.TabIndex = 1;
            this.frmOperatorLabel.Text = "Operator";
            // 
            // frmFieldLabel
            // 
            this.frmFieldLabel.AutoSize = true;
            this.frmFieldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmFieldLabel.Location = new System.Drawing.Point(63, 85);
            this.frmFieldLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.frmFieldLabel.Name = "frmFieldLabel";
            this.frmFieldLabel.Size = new System.Drawing.Size(127, 55);
            this.frmFieldLabel.TabIndex = 0;
            this.frmFieldLabel.Text = "Field";
            // 
            // tblCarDataGridView
            // 
            this.tblCarDataGridView.AllowUserToAddRows = false;
            this.tblCarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblCarDataGridView.Location = new System.Drawing.Point(89, 472);
            this.tblCarDataGridView.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.tblCarDataGridView.Name = "tblCarDataGridView";
            this.tblCarDataGridView.RowHeadersWidth = 123;
            this.tblCarDataGridView.Size = new System.Drawing.Size(1905, 803);
            this.tblCarDataGridView.TabIndex = 2;
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.White;
            this.btnRun.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.Location = new System.Drawing.Point(1759, 81);
            this.btnRun.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(235, 116);
            this.btnRun.TabIndex = 3;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1759, 215);
            this.btnClose.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(235, 116);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmSearch
            // 
            this.AcceptButton = this.btnRun;
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(2163, 1327);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.tblCarDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "frmSearch";
            this.Text = "TaskA Search AlenKrga";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox frmTxtValue;
        private System.Windows.Forms.ComboBox frmCboOperator;
        private System.Windows.Forms.Label frmValueLabel;
        private System.Windows.Forms.Label frmOperatorLabel;
        private System.Windows.Forms.Label frmFieldLabel;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView tblCarDataGridView;
        private System.Windows.Forms.ComboBox frmCboField;
    }
}