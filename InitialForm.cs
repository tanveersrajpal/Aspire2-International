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
    public partial class InitialForm : Form
    {
        Reg_page reg = new Reg_page();
        public InitialForm()
        {
            InitializeComponent();
        }

        private void InitialForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void InitialForm_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if(textBox1.Text == "sport_aspire")
                {
                    if (reg.IsDisposed == true)
                    {
                        reg = new Reg_page();
                    }
                    
                    reg.Show();
                    this.Hide();
                    

                }
                
                else
                {
                    MessageBox.Show("Wrong ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                



            }
            
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void InitialForm_Load(object sender, EventArgs e)
        {

        }
    }
}
