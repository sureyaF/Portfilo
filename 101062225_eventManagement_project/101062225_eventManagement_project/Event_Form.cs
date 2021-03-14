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
using Microsoft.VisualBasic.CompilerServices;
using System.Text.RegularExpressions;

namespace _101062225_eventManagement_project
{
    public partial class Event_Form : Form
    {

        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\reyaf\source\repos\101062225_eventManagement_project\DB\ContactDB.mdf;Integrated Security=True;Connect Timeout=30");
       
        int EventId = 0;
     
        public Event_Form()
        {
            InitializeComponent();
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer_Form f1 = new Customer_Form();
            f1.ShowDialog();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            RSVP_Form1 f2 = new RSVP_Form1();
            f2.ShowDialog();
        }

        private void Event_Form_Load(object sender, EventArgs e)
        {
            EventReset();
            FillSearchDataGridView();
           // FillEventDataGridView();
        }
        private void DgvEvents_DoubleClick(object sender, EventArgs e)
        {
            if (dgvEvents.CurrentRow.Index != -1)
            {
                EventId = Convert.ToInt32(dgvEvents.CurrentRow.Cells[0].Value.ToString());
                txtEventName.Text = dgvEvents.CurrentRow.Cells[1].Value.ToString();
                txtEventDate.Text = dgvEvents.CurrentRow.Cells[2].Value.ToString();
                txtPeople.Text = dgvEvents.CurrentRow.Cells[3].Value.ToString();
                txtVenue.Text = dgvEvents.CurrentRow.Cells[4].Value.ToString();
                btnEventSave.Text = "Update";
                btnEventDelete.Enabled = true;
            }

        }
      /*  void FillEventDataGridView()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("EventByNameViewOrSearch", sqlCon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@EventName", txtEventSearch.Text.Trim());
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dgvEvents.DataSource = dtbl;

            sqlCon.Close();
        }*/
        void FillSearchDataGridView()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("EventByNameViewOrSearch", sqlCon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@EventName", txtEventSearch.Text.Trim());
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dgvEvents.DataSource = dtbl;

            sqlCon.Close();
        }

        void EventReset()
        {
            txtEventName.Text = txtEventDate.Text = txtPeople.Text = txtVenue.Text= "";
            btnEventSave.Text = "Save";
            EventId = 0;
            btnEventDelete.Enabled = false;
        }
      

        

        private void BtnEventSearch_Click(object sender, EventArgs e)
        {

            try
            {
                FillSearchDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid Entry");
            }


        }

        

        private void BtnEventDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand("EventDeletion", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@EventId", EventId);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully");
                EventReset();
                FillSearchDataGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR MESSAGE");
            }
        }

        private void BtnEventSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                if (btnEventSave.Text == "Save")
                {
                    SqlCommand sqlCmd = new SqlCommand("EventAddorEdit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Add");
                    sqlCmd.Parameters.AddWithValue("@EventId", 0);
                    sqlCmd.Parameters.AddWithValue("@EventName", txtEventName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@EventDate", txtEventDate.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@PeopleAttending", txtPeople.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@EventVenue", txtVenue.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Saved Successfully");
                }
                else
                {
                    SqlCommand sqlCmd = new SqlCommand("EventAddorEdit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Edit");
                    sqlCmd.Parameters.AddWithValue("@EventId", EventId);
                    sqlCmd.Parameters.AddWithValue("@EventName", txtEventName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@EventDate", txtEventDate.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@PeopleAttending", txtPeople.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@EventVenue", txtVenue.Text.Trim());
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

        private void BtnEventReset_Click(object sender, EventArgs e)
        {

            EventReset();
            FillSearchDataGridView();
        }

        private void txtEventName_Validatin(object sender, CancelEventArgs e)
        {
            
                 if (string.IsNullOrWhiteSpace(txtEventName.Text)) {
                    e.Cancel = true;
                    txtEventName.Focus();
                    errorProvider1.SetError(txtEventName, "Name should not be left blank!");
                    }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(txtEventName, "");
                }
        }


        
        private void TxtVenue_Validating(object sender, CancelEventArgs e)
        {
             if (string.IsNullOrWhiteSpace(txtVenue.Text))
            {
                e.Cancel = true;
                txtEventDate.Focus();
                errorProvider1.SetError(txtVenue, "Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtVenue, "");
            }
        }

        private void TxtPeople_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void TxtDate_Validating(object sender, CancelEventArgs e)
        {
            Regex reg = new Regex(@"^(\d{1,2})/(\d{1,2})/(\d{4})$");
            Match m = reg.Match(txtEventDate.Text);
            if (m.Success)
            {
                int dd = int.Parse(m.Groups[1].Value);
                int mm = int.Parse(m.Groups[2].Value);
                int yyyy = int.Parse(m.Groups[3].Value);
                e.Cancel = dd < 1 || dd > 31 || mm < 1 || mm > 12 || yyyy > 2020;
            }
            else e.Cancel = true;
            if (e.Cancel)
            {
                if (MessageBox.Show("Wrong date format. The correct format is dd/mm/yyyy\n+ dd should be between 1 and 31.\n+ mm should be between 1 and 12.\n+ yyyy should be before 2013", "Invalid date", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                    e.Cancel = false;
            }
        }
    }
}
