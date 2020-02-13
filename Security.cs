using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aspire2_Project
{
    public partial class Security : Form
    {
        string username = "aspire2_staff";
        string password = "aspire_auckland";
        //staff_portal staff = new staff_portal();

        
        public Security()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           /* if (user_enter.Text == username && pass_enter.Text == password)
            {
                DialogResult result1 = MessageBox.Show("You have been logged in successfully.", "Logged in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result1 == DialogResult.OK)
                {
                    if(staff.IsDisposed == true)
                    {
                        staff = new staff_portal();
                        
                    }
                    staff.Show();

                }
            }*/
        }

       
    }
}
