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



namespace Aspire2_Project
{
    public partial class Reg_page : Form
    {
        dashboard dash = new dashboard();
        SqlCommand cmd;
        SqlConnection con;
        DataSet ds = new DataSet();
        Security login = new Security();
        staff_portal portal = new staff_portal();
            










        public Reg_page()
        {
            InitializeComponent();

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (pl_name_first.Text == "" || pl_name_last.Text == "" || pl_email.Text == "" || pl_num.Text == "" || team_selected.Text == "(Please select the game)" || team_selected.Text == ""
                || (team_no.Text == "(Select)" && checkBox1.Checked == false) || team_no.Text == "" || player_no.Text == "" || (player_no.Text == "(Select)" && checkBox1.Checked == false))
            {
                MessageBox.Show("Please fill all the field before registration", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Aspire2;Integrated Security=True");





                cmd = new SqlCommand("SELECT COUNT (*) FROM Table1 WHERE Sport= '" + team_selected.Text + "' AND TeamNo= '" + team_no.Text + "' AND PlayerNo= '" + player_no.Text + "'", con);
                con.Open();
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {



                    MessageBox.Show("The record already exists");



                }


                else if (checkBox1.Checked == false)
                {

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                    cmd = new SqlCommand("Insert into Table1 (FirstName,LastName,Email,Phone,Sport,TeamNo,PlayerNo,TeamPlayer,Time) values(@FirstName,@LastName,@Email,@Phone,@Sport,@TeamNo,@PlayerNo,@TeamPlayer,@Time)", con);
                    cmd.Parameters.AddWithValue("@FirstName", pl_name_first.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@LastName", pl_name_last.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@Email", pl_email.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@Phone", pl_num.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@Sport", team_selected.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@TeamNo", team_no.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@PlayerNo", player_no.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@TeamPlayer", "YES");
                    cmd.Parameters.AddWithValue("@Time", DateTime.Now);
                    int a = cmd.ExecuteNonQuery();
                    if (a != 0)
                    {
                        MessageBox.Show("Saved");

                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                    con.Close();

                    pl_name_first.Text = "";
                    pl_name_last.Text = "";
                    pl_email.Text = "";
                    pl_num.Text = "";
                    team_selected.Text = "(Please select the game)";
                    team_no.Text = "(Select)";
                    player_no.Text = "(Select)";
                }
                else if (checkBox1.Checked == true)
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                    cmd = new SqlCommand("Insert into Table1 (FirstName,LastName, Email,Phone,Sport,TeamNo,PlayerNo,TeamPlayer,Time) values(@FirstName,@LastName,@Email,@Phone,@Sport,@TeamNo,@PlayerNo,@TeamPlayer,@Time)", con);
                    cmd.Parameters.AddWithValue("@FirstName", pl_name_first.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@LastName", pl_name_last.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@Email", pl_email.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@Phone", pl_num.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@Sport", team_selected.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@TeamNo", "NA");
                    cmd.Parameters.AddWithValue("@PlayerNo", "NA");
                    cmd.Parameters.AddWithValue("@TeamPlayer", "NO");
                    cmd.Parameters.AddWithValue("@Time", DateTime.Now);
                    int a = cmd.ExecuteNonQuery();
                    if (a != 0)
                    {
                        MessageBox.Show("Saved");

                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                    con.Close();

                    pl_name_first.Text = "";
                    pl_name_last.Text = "";
                    pl_email.Text = "";
                    pl_num.Text = "";
                    team_selected.Text = "(Please select the game)";
                    team_no.Text = "(Select)";
                    player_no.Text = "(Select)";
                }
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            /*if (login.IsDisposed == true)
            {
                login = new Security();
            }
            login.Show();*/
            portal.Show();

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                team_no.Enabled = false;
                team_no.Text = "(Select)";
                player_no.Enabled = false;
                player_no.Text = "(Select)";
            }
            else
            {
                team_no.Enabled = true;
                team_no.Text = "(Select)";
                player_no.Enabled = true;
                player_no.Text = "(Select)";
            }
            
        }

        private void Reg_page_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if(dash.IsDisposed == true)
            {
                dash = new dashboard();
            }
            dash.Show();
        }

        private void Reg_page_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
            {
                
            }
            else
            {
                this.Close(); 
            }

        }

        private void Reg_page_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Reg_page_Enter(object sender, EventArgs e)
        {
            
        }

        private void Team_no_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome back!");
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {


        }
    }
}
