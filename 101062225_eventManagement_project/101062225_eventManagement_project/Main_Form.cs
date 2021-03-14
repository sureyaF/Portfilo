using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

       
        private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)

        {

            Application.Exit();

        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer_Form f = new Customer_Form();
            f.ShowDialog();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm f1 = new LoginForm();
            f1.ShowDialog();
        }

        private void btnEventPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Event_Form f2 = new Event_Form();
            f2.ShowDialog();

        }

        private void btnRSVPpage_Click(object sender, EventArgs e)
        {
            this.Hide();
            RSVP_Form1 f3 = new RSVP_Form1();
            f3.ShowDialog();
        }
    }
}
