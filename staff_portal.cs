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
    public partial class staff_portal : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Aspire2;Integrated Security=True");
        
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public staff_portal()
        {
            InitializeComponent();
            Displaydata();
        }

        private void Staff_portal_Load(object sender, EventArgs e)
        {
            Displaydata();

        }

        public void Displaydata()
        {
            con.Open();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("SELECT * FROM Table1", con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
                
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            con.Open();
            da = new SqlDataAdapter("select * from Table1 WHERE FirstName='"+textBox1.Text.ToUpper()+"'", con);
            dt = new DataTable();
            da.Fill(dt); 
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Displaydata();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            con.Open();
            da = new SqlDataAdapter("delete from Table1 WHERE FirstName='" + textBox3.Text.ToUpper() + "'", con);          
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            Displaydata();                        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
