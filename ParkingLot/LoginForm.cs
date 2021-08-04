using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Objects;
using System.Data.Objects.DataClasses;

namespace ParkingLot
{
    public partial class LoginForm : Form
    {

        private SampleContext cxt;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }               

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            cxt = new SampleContext();
            
            try
            {

                if (cxt.AuthUsers.Where(r=>r.Username==textBoxUserName.Text 
                    && r.Password==textBoxPassword.Text).Count() > 0)
                {
                    //MessageBox.Show("Valid User");
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("...check you credentials");
                }        
                
                   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            

        }
    }
}
