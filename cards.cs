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
    public partial class cards : Form
    {
        SqlCommand cmd;
        SqlConnection con;


        public cards()
        {
            InitializeComponent();
            DisplayData();
        }

        private void Button1_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Aspire2;Integrated Security=True");
            DataSet ds = new DataSet();
            con.Open();
            cmd = new SqlCommand("Insert into card (PlayerName,CardType) values(@PlayerName,@CardType)", con);
            cmd.Parameters.AddWithValue("@PlayerName", textBox1.Text.ToUpper());
            cmd.Parameters.AddWithValue("@CardType", comboBox1.Text.ToUpper());            
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);            
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
            textBox1.Text = "";
            comboBox1.Text = "(Select)";
            DisplayData();

        }

        private void Cards_Load(object sender, EventArgs e)
        {
           

        }
        public void DisplayData()
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Aspire2;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            con.Open();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("SELECT * FROM card", con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
