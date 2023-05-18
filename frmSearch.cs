using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace CarsDatabase
{
    public partial class frmSearch : Form
    {
        string connectionString = "Data Source=C:\\data\\hire.db;Version=3;";

        public frmSearch()
        {
            InitializeComponent();
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            frmCboField.Items.Add("Make");
            frmCboField.Items.Add("EngineSize");
            frmCboField.Items.Add("RentalPerDay");
            frmCboField.Items.Add("Available");
            frmCboField.SelectedIndex = 0;

            frmCboOperator.Items.Add("=");
            frmCboOperator.Items.Add("<");
            frmCboOperator.Items.Add(">");
            frmCboOperator.Items.Add("<=");
            frmCboOperator.Items.Add(">=");
            frmCboOperator.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (frmTxtValue.Text != "")
            {
                try
                {
                    string sql = String.Format("SELECT VehicleRegNo, Make, EngineSize, DateRegistered, '€' || CAST(RentalPerDay AS varchar) AS RentalPerDay, Available FROM tblCar WHERE {0} {1} @Third", frmCboField.SelectedItem, frmCboOperator.SelectedItem);

                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();
                        using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@Third", frmTxtValue.Text);

                            DataTable table = new DataTable();
                            using (SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command))
                            {
                                dataAdapter.Fill(table);
                            }
                            tblCarDataGridView.DataSource = table;

                            if (tblCarDataGridView.Rows.Count == 0)
                            {
                                MessageBox.Show("There is no match!");
                            }
                        }
                    }
                }
                catch (SQLiteException)
                {
                    MessageBox.Show("Error in your query!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Something is wrong, try again");
                }
            }
            else
            {
                MessageBox.Show("You need to enter value text!");
            }
        }
    }
}
