using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
/*
     Author: SUREYA FARAH
        ID:101062225
      FINAL ASSIGNMENT 
Steps to Run programe:
1) Change Sql Connection string to your local data source
2) make sure all DB folder is imported and you can see 3 table contact, event, rsvp
3)make sure stored procedure are imported as well
4) run program
*/
namespace _101062225_eventManagement_project
{
    public partial class Customer_Form : Form
    {

        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\reyaf\source\repos\101062225_eventManagement_project\DB\ContactDB.mdf;Integrated Security=True;Connect Timeout=30");
        int CustomerId = 0;
      
        public Customer_Form()
        {

            InitializeComponent();
        }

        

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                if (btnSave.Text == "Save")
                {
                    if (ValidateChildren(ValidationConstraints.Enabled)) { 
                        SqlCommand sqlCmd = new SqlCommand("ContactAddorEdit", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@mode", "Add");
                        sqlCmd.Parameters.AddWithValue("@CustomerId", 0);
                        sqlCmd.Parameters.AddWithValue("@FirstName", txtFname.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@LastName", txtLname.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@PhoneNumber", txtPhone.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@BookingId", txtBooking.Text.Trim());
                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Saved Successfully");
                    }
                }
                else
                {
                    SqlCommand sqlCmd = new SqlCommand("ContactAddorEdit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Edit");
                    sqlCmd.Parameters.AddWithValue("@CustomerId", CustomerId);
                    sqlCmd.Parameters.AddWithValue("@FirstName", txtFname.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@LastName", txtLname.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@PhoneNumber", txtPhone.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@BookingId", txtBooking.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Updated Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            finally
            {
                sqlCon.Close();
            }
        }
        void FillDataGridView()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("ContactViewOrSearch", sqlCon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@ContactName", txtSearch.Text.Trim());
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dgvContacts.DataSource = dtbl;

            sqlCon.Close();
        }
        private void btnReset_Click_1(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                FillDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid Entry");
            }
        }

        private void dgvContacts_DoubleClick(object sender, EventArgs e)
        {
            if (dgvContacts.CurrentRow.Index != -1)
            {
                CustomerId = Convert.ToInt32(dgvContacts.CurrentRow.Cells[0].Value.ToString());
                txtFname.Text = dgvContacts.CurrentRow.Cells[1].Value.ToString();
                txtLname.Text = dgvContacts.CurrentRow.Cells[2].Value.ToString();
                txtPhone.Text = dgvContacts.CurrentRow.Cells[3].Value.ToString();
                txtBooking.Text = dgvContacts.CurrentRow.Cells[4].Value.ToString();
                btnSave.Text = "Update";
                btnDelete.Enabled = true;
            }
        }
        void Reset()
        {
            txtFname.Text = txtLname.Text = txtPhone.Text = txtBooking.Text = "";
            btnSave.Text = "Save";
            CustomerId = 0;
            btnDelete.Enabled = false;
        }

        private void Customer_Form_Load(object sender, EventArgs e)
        {
            Reset();
            FillDataGridView();
           
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand("ContactDeletion", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@CustomerId", CustomerId);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully");
                Reset();
                FillDataGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR MESSAGE");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            Event_Form f1 = new Event_Form();
            f1.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Form f2 = new Main_Form();
            f2.ShowDialog();
        }

        private void txtFname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFname.Text))
            {
                e.Cancel = true;
                txtFname.Focus();
                errorProviderApp.SetError(txtFname, "Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txtFname, "");
            }
        }

        private void txtLname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLname.Text))
            {
                e.Cancel = true;
                txtLname.Focus();
                errorProviderApp.SetError(txtLname, "Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txtLname, "");
            }
        }

        private void TxtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                e.Cancel = true;
                txtPhone.Focus();
                errorProviderApp.SetError(txtPhone, " should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txtPhone, "");
            }
        }

        private void TxtBooking_Validating(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBooking.Text))
            {
              
                txtBooking.Focus();
                errorProviderApp.SetError(txtBooking, "Booking should not be left blank!");
            }
            else
            {
              
                errorProviderApp.SetError(txtBooking, "");
            }

        }
    }
}
