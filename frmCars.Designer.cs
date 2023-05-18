namespace CarsDatabase
{
    partial class frmCars
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVehicleReg = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblEngineSize = new System.Windows.Forms.Label();
            this.lblDateRegistered = new System.Windows.Forms.Label();
            this.lblRentalPerDay = new System.Windows.Forms.Label();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.frmVehicleReg = new System.Windows.Forms.TextBox();
            this.CarsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hireDataSet1 = new CarsDatabase.HireDataSet();
            this.frmEngineSize = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.vehicleReg = new System.Windows.Forms.ToolTip(this.components);
            this.make = new System.Windows.Forms.ToolTip(this.components);
            this.frmMake = new System.Windows.Forms.TextBox();
            this.rentalPerDay = new System.Windows.Forms.ToolTip(this.components);
            this.frmRentalPerDay = new System.Windows.Forms.TextBox();
            this.engineSize = new System.Windows.Forms.ToolTip(this.components);
            this.dateRegistered = new System.Windows.Forms.ToolTip(this.components);
            this.frmDateReg = new System.Windows.Forms.DateTimePicker();
            this.availableCar = new System.Windows.Forms.ToolTip(this.components);
            this.frmAvailable = new System.Windows.Forms.CheckBox();
            this.tblCarTableAdapter1 = new CarsDatabase.HireDataSetTableAdapters.tblCarTableAdapter();
            this.tableAdapterManager1 = new CarsDatabase.HireDataSetTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.CarsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hireDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Magneto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(580, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(745, 86);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bowman Car Hire";
            // 
            // lblVehicleReg
            // 
            this.lblVehicleReg.AutoSize = true;
            this.lblVehicleReg.Location = new System.Drawing.Point(93, 293);
            this.lblVehicleReg.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblVehicleReg.Name = "lblVehicleReg";
            this.lblVehicleReg.Size = new System.Drawing.Size(407, 37);
            this.lblVehicleReg.TabIndex = 1;
            this.lblVehicleReg.Text = "Vehicle registration number";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(93, 410);
            this.lblMake.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(94, 37);
            this.lblMake.TabIndex = 2;
            this.lblMake.Text = "Make";
            // 
            // lblEngineSize
            // 
            this.lblEngineSize.AutoSize = true;
            this.lblEngineSize.Location = new System.Drawing.Point(93, 509);
            this.lblEngineSize.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblEngineSize.Name = "lblEngineSize";
            this.lblEngineSize.Size = new System.Drawing.Size(181, 37);
            this.lblEngineSize.TabIndex = 3;
            this.lblEngineSize.Text = "Engine size";
            // 
            // lblDateRegistered
            // 
            this.lblDateRegistered.AutoSize = true;
            this.lblDateRegistered.Location = new System.Drawing.Point(93, 618);
            this.lblDateRegistered.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblDateRegistered.Name = "lblDateRegistered";
            this.lblDateRegistered.Size = new System.Drawing.Size(234, 37);
            this.lblDateRegistered.TabIndex = 4;
            this.lblDateRegistered.Text = "Date registered";
            // 
            // lblRentalPerDay
            // 
            this.lblRentalPerDay.AutoSize = true;
            this.lblRentalPerDay.Location = new System.Drawing.Point(93, 731);
            this.lblRentalPerDay.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblRentalPerDay.Name = "lblRentalPerDay";
            this.lblRentalPerDay.Size = new System.Drawing.Size(223, 37);
            this.lblRentalPerDay.TabIndex = 5;
            this.lblRentalPerDay.Text = "Rental per day";
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Location = new System.Drawing.Point(93, 857);
            this.lblAvailable.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(146, 37);
            this.lblAvailable.TabIndex = 6;
            this.lblAvailable.Text = "Available";
            // 
            // frmVehicleReg
            // 
            this.frmVehicleReg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CarsBindingSource, "VehicleRegNo", true));
            this.frmVehicleReg.Location = new System.Drawing.Point(600, 293);
            this.frmVehicleReg.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.frmVehicleReg.Name = "frmVehicleReg";
            this.frmVehicleReg.Size = new System.Drawing.Size(419, 44);
            this.frmVehicleReg.TabIndex = 7;
            this.vehicleReg.SetToolTip(this.frmVehicleReg, "Enter vehicle registration number");
            // 
            // CarsBindingSource
            // 
            this.CarsBindingSource.DataMember = "tblCar";
            this.CarsBindingSource.DataSource = this.hireDataSet1;
            // 
            // hireDataSet1
            // 
            this.hireDataSet1.DataSetName = "HireDataSet";
            this.hireDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmEngineSize
            // 
            this.frmEngineSize.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CarsBindingSource, "EngineSize", true));
            this.frmEngineSize.Location = new System.Drawing.Point(600, 489);
            this.frmEngineSize.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.frmEngineSize.Name = "frmEngineSize";
            this.frmEngineSize.Size = new System.Drawing.Size(419, 44);
            this.frmEngineSize.TabIndex = 9;
            this.engineSize.SetToolTip(this.frmEngineSize, "Enter engine size");
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnUpdate.FlatAppearance.BorderSize = 2;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(1467, 219);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(263, 111);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(1467, 348);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(263, 105);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.addButton_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDelete.FlatAppearance.BorderSize = 2;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(1467, 470);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(263, 108);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSearch.FlatAppearance.BorderSize = 2;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(1467, 595);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(263, 102);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(1467, 715);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(263, 114);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnExit.FlatAppearance.BorderSize = 2;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(1467, 846);
            this.btnExit.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(263, 102);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnFirst.FlatAppearance.BorderSize = 2;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Location = new System.Drawing.Point(143, 1025);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(256, 114);
            this.btnFirst.TabIndex = 19;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.firstButton_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.AutoSize = true;
            this.btnPrevious.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnPrevious.FlatAppearance.BorderSize = 2;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Location = new System.Drawing.Point(390, 1025);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(256, 114);
            this.btnPrevious.TabIndex = 20;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // btnNext
            // 
            this.btnNext.AutoSize = true;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnNext.FlatAppearance.BorderSize = 2;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(1042, 1025);
            this.btnNext.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(256, 114);
            this.btnNext.TabIndex = 21;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // btnLast
            // 
            this.btnLast.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnLast.FlatAppearance.BorderSize = 2;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.Location = new System.Drawing.Point(1289, 1025);
            this.btnLast.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(256, 114);
            this.btnLast.TabIndex = 22;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.lastButton_Click);
            // 
            // txtOrder
            // 
            this.txtOrder.Location = new System.Drawing.Point(673, 1061);
            this.txtOrder.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(349, 44);
            this.txtOrder.TabIndex = 23;
            this.txtOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmMake
            // 
            this.frmMake.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CarsBindingSource, "Make ", true));
            this.frmMake.Location = new System.Drawing.Point(600, 387);
            this.frmMake.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.frmMake.Name = "frmMake";
            this.frmMake.Size = new System.Drawing.Size(568, 44);
            this.frmMake.TabIndex = 24;
            this.make.SetToolTip(this.frmMake, "Enter the make of the vehicle");
            // 
            // frmRentalPerDay
            // 
            this.frmRentalPerDay.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CarsBindingSource, "RentalPerDay ", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.frmRentalPerDay.Location = new System.Drawing.Point(600, 731);
            this.frmRentalPerDay.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.frmRentalPerDay.Name = "frmRentalPerDay";
            this.frmRentalPerDay.Size = new System.Drawing.Size(568, 44);
            this.frmRentalPerDay.TabIndex = 28;
            this.rentalPerDay.SetToolTip(this.frmRentalPerDay, "Enter the price of rent per day");
            // 
            // frmDateReg
            // 
            this.frmDateReg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CarsBindingSource, "DateRegistered ", true));
            this.frmDateReg.Location = new System.Drawing.Point(600, 595);
            this.frmDateReg.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.frmDateReg.Name = "frmDateReg";
            this.frmDateReg.Size = new System.Drawing.Size(625, 44);
            this.frmDateReg.TabIndex = 25;
            this.dateRegistered.SetToolTip(this.frmDateReg, "Enter the date of registration");
            // 
            // frmAvailable
            // 
            this.frmAvailable.AutoSize = true;
            this.frmAvailable.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.CarsBindingSource, "Available ", true));
            this.frmAvailable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.frmAvailable.Location = new System.Drawing.Point(600, 857);
            this.frmAvailable.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.frmAvailable.Name = "frmAvailable";
            this.frmAvailable.Size = new System.Drawing.Size(34, 33);
            this.frmAvailable.TabIndex = 29;
            this.availableCar.SetToolTip(this.frmAvailable, "Is car available?");
            this.frmAvailable.UseVisualStyleBackColor = true;
            // 
            // tblCarTableAdapter1
            // 
            this.tblCarTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.tblCarTableAdapter = this.tblCarTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = CarsDatabase.HireDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(55, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1352, 763);
            this.panel1.TabIndex = 30;
            // 
            // frmCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1818, 1267);
            this.Controls.Add(this.frmAvailable);
            this.Controls.Add(this.frmRentalPerDay);
            this.Controls.Add(this.frmDateReg);
            this.Controls.Add(this.frmMake);
            this.Controls.Add(this.txtOrder);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.frmEngineSize);
            this.Controls.Add(this.frmVehicleReg);
            this.Controls.Add(this.lblAvailable);
            this.Controls.Add(this.lblRentalPerDay);
            this.Controls.Add(this.lblDateRegistered);
            this.Controls.Add(this.lblEngineSize);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.lblVehicleReg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "frmCars";
            this.Text = "TaskA Cars AlenKrga  ";
            this.Load += new System.EventHandler(this.frmCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CarsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hireDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVehicleReg;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblEngineSize;
        private System.Windows.Forms.Label lblDateRegistered;
        private System.Windows.Forms.Label lblRentalPerDay;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.TextBox frmVehicleReg;
        private System.Windows.Forms.TextBox frmEngineSize;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.TextBox txtOrder;
        private HireDataSet hireDataSet1;
        private HireDataSetTableAdapters.tblCarTableAdapter tblCarTableAdapter1;
        private HireDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource CarsBindingSource;
        private System.Windows.Forms.ToolTip vehicleReg;
        private System.Windows.Forms.ToolTip make;
        private System.Windows.Forms.ToolTip engineSize;
        private System.Windows.Forms.ToolTip dateRegistered;
        private System.Windows.Forms.ToolTip rentalPerDay;
        private System.Windows.Forms.ToolTip availableCar;
        private System.Windows.Forms.TextBox frmMake;
        private System.Windows.Forms.DateTimePicker frmDateReg;
        private System.Windows.Forms.TextBox frmRentalPerDay;
        private System.Windows.Forms.CheckBox frmAvailable;
        private System.Windows.Forms.Panel panel1;
    }
}