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
    public partial class RSVP_Form1 : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\reyaf\source\repos\101062225_eventManagement_project\DB\ContactDB.mdf;Integrated Security=True;Connect Timeout=30");
      
        int RSVPId = 0;
        public RSVP_Form1()
        {
            InitializeComponent();
        }

        private void Btn_GetEvent_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                /*
                 * SqlDataAdapter sqlDa = new SqlDataAdapter("EventViewOrSearch", sqlCon);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                */
                SqlCommand cmd = new SqlCommand("EventViewOrSearch", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                //Add your parameters
                cmd.Parameters.AddWithValue("@EventName", txtEvent.Text.Trim());
                //Declare your data adapter
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                SqlDataAdapter sqlDa1 = new SqlDataAdapter("CreateRSVPevent", sqlCon);
                DataTable dt1 = new DataTable();
                sqlDa1.Fill(dt1);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbxEvt.Items.Add(dt.Rows[i]["EventName"]);

                }

                for (int j = 0; j < dt1.Rows.Count; j++)
                {
                    cbxFirst.Items.Add(dt1.Rows[j]["FirstName"]);
                    cbxBook.Items.Add(dt1.Rows[j]["BookingId"]);
                    cbxLast.Items.Add(dt1.Rows[j]["LastName"]);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid Entry");
            }
        }

       

      

        private void BtnRsave_Click(object sender, EventArgs e)
        {

            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                if (btnSave.Text == "Save")
                {
                    SqlCommand sqlCmd = new SqlCommand("AddRSVPevent", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Add");
                    sqlCmd.Parameters.AddWithValue("@RSVPId", 0);
                    sqlCmd.Parameters.AddWithValue("@EventName", txtEvent.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@FirstName", txtFirst.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@BookingId", txtbook.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@LastName", txtlast.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Saved Successfully");
                }
                else
                {
                    SqlCommand sqlCmd = new SqlCommand("AddRSVPevent", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Edit");
                    sqlCmd.Parameters.AddWithValue("@RSVPId", RSVPId);
                    sqlCmd.Parameters.AddWithValue("@EventName", txtEvent.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@FirstName", txtFirst.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@BookingId", txtbook.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@LastName", txtlast.Text.Trim());
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
        void FillRSVPDataGridView()

        {

            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            SqlCommand cmd = new SqlCommand("RSVPViewOrSearch", sqlCon);
            cmd.CommandType = CommandType.StoredProcedure;
            //Add your parameters
            cmd.Parameters.AddWithValue("@FirstName", txtRSVPsearch.Text.Trim());
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvRSVP.DataSource = dt.DefaultView;

            sqlCon.Close();
           
        }
        void RSVPReset()
        {
            txtEvent.Text = txtFirst.Text = txtbook.Text = txtlast.Text = "";
            btnSave.Text = "Save";
            RSVPId = 0;
            btnRdelete.Enabled = false;
        }
        private void BtnRdelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand("RSVPDeletion", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@RSVPId", RSVPId);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully");
                RSVPReset();
                FillRSVPDataGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR MESSAGE");
            }
        }

        private void BtnRSVPsearch_Click(object sender, EventArgs e)
        {
            try
            {
                FillRSVPDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid Entry");
            }

        }

        private void BtnRreset_Click(object sender, EventArgs e)
        {
            RSVPReset();

        }
        private void Btn_GetEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtEvent.Text = cbxEvt.SelectedItem.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid Entry");
            }
        }
        private void CbxFname_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                txtFirst.Text = cbxFirst.SelectedItem.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid Entry");
            }
        }

        private void CbxBooking_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                txtbook.Text = cbxBook.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid Entry");
            }

        }

        private void CbxLname_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                txtlast.Text = cbxLast.SelectedItem.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid Entry");
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            Event_Form f1 = new Event_Form();
            f1.ShowDialog();
        }

        private void RSVP_Form1_Load(object sender, EventArgs e)
        {
            RSVPReset();
            FillRSVPDataGridView();
        }

        private void DgvRSVP_DoubleClick(object sender, EventArgs e)
        {
            if (dgvRSVP.CurrentRow.Index != -1)
            {
                RSVPId = Convert.ToInt32(dgvRSVP.CurrentRow.Cells[0].Value.ToString());
                txtEvent.Text = dgvRSVP.CurrentRow.Cells[1].Value.ToString();
                txtFirst.Text = dgvRSVP.CurrentRow.Cells[2].Value.ToString();
                txtbook.Text = dgvRSVP.CurrentRow.Cells[3].Value.ToString();
                txtlast.Text = dgvRSVP.CurrentRow.Cells[4].Value.ToString();
                btnSave.Text = "Update";
                btnRdelete.Enabled = true;
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Event_Form f1 = new Event_Form();
            f1.ShowDialog();
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Main_Form f2 = new Main_Form();
            f2.ShowDialog();
        }

        private void TxteEvent_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtEvent.Text))
            {
                e.Cancel = true;
                txtEvent.Focus();
                errorProviderApp.SetError(txtEvent, "Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txtEvent, "");
            }
        }

        private void TxtFirst_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirst.Text))
            {
                e.Cancel = true;
                txtFirst.Focus();
                errorProviderApp.SetError(txtFirst, "Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txtFirst, "");
            }
        }

        private void TxtBook_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void Txtlast_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtlast.Text))
            {
                e.Cancel = true;
                txtlast.Focus();
                errorProviderApp.SetError(txtlast, "Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txtlast, "");
            }
        }
    }
}

