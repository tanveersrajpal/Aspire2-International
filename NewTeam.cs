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
    public partial class NewTeam : Form
    {
        TeamName team = new TeamName();
        
        public NewTeam()
        {
            InitializeComponent();
        }

        public void SaveSettings()
        {
            Properties.Settings.Default.team1 = tm1.Text;
            Properties.Settings.Default.team2 = tm2.Text;
            Properties.Settings.Default.Save();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (tm1.Text == tm2.Text)
            {
                MessageBox.Show("The two teams must be different", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SaveSettings();
                this.Hide();
            }
        }

        private void Tm_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tm_2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NewTeam_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {

        }

        private void NewTeam_Load(object sender, EventArgs e)
        {

        }

        private void tm_1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
