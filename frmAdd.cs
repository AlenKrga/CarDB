﻿using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace CarsDatabase
{
    public partial class frmAdd : Form
    {
        string connectionString = "Data Source=C:\\data\\hire.db;Version=3;";

        private frmCars parentForm; // Reference to frmCars

        public frmAdd(frmCars parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        public frmAdd()
        {
            InitializeComponent();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string vehicleReg = frmVehicleRegInput.Text;
            string make = frmMakeInput.Text;
            string engineSize = frmEngineSizeInput.Text;
            string rentalPerDay = frmRentPerDayNumeric.Value.ToString();
            string dateCarRegistered = frmDateRegistered.Value.ToString(); // Convert to string
            bool available = frmAvailableCheck.Checked;

            // Perform data validation here if needed

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO tblCar (VehicleRegNo, Make, EngineSize, DateRegistered, RentalPerDay, Available) VALUES (@VehicleRegNo, @Make, @EngineSize, @DateRegistered, @RentalPerDay, @Available)";

                using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@VehicleRegNo", vehicleReg);
                    command.Parameters.AddWithValue("@Make", make);
                    command.Parameters.AddWithValue("@EngineSize", engineSize);
                    command.Parameters.AddWithValue("@DateRegistered", dateCarRegistered);
                    command.Parameters.AddWithValue("@RentalPerDay", rentalPerDay); // Use string value
                    command.Parameters.AddWithValue("@Available", available);

                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Car added successfully.");

            ClearInputs();
            parentForm?.ReloadData();
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearInputs()
        {
            frmVehicleRegInput.Text = "";
            frmMakeInput.Text = "";
            frmEngineSizeInput.Text = "";
            frmRentPerDayNumeric.Text = "";
            frmDateRegistered.ResetText();
            frmAvailableCheck.Checked = false;
        }

        private void vehicleRegInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void makeInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void engineSizeInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateRegInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void RentPerDayNumeric_ValueChanged(object sender, EventArgs e)
        {

        }

        private void availableCheckMark_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RentPerDay_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
