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
    public partial class dashboard : Form
    {
        
        TeamName team = new TeamName();
        NewTeam newt = new NewTeam();
        cards crd = new cards();



        public dashboard()
        {
            InitializeComponent();
            GetSettings();
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
        public void GetSettings()
        {
            teamno1.Text = Properties.Settings.Default.team1;
            teamno2.Text = Properties.Settings.Default.team2;

            gurkaw.Text = Properties.Settings.Default.team1w;
            gurkal.Text = Properties.Settings.Default.team1l;
            gurkad.Text = Properties.Settings.Default.team1d;
            gurkatp.Text = Properties.Settings.Default.team1tp;
            gurkap.Text = Properties.Settings.Default.team1p;


            pannaw.Text = Properties.Settings.Default.team2w;
            pannal.Text = Properties.Settings.Default.team2l;
            pannad.Text = Properties.Settings.Default.team2d;
            pannatp.Text = Properties.Settings.Default.team2tp;
            pannap.Text = Properties.Settings.Default.team2p;

            kaplakw.Text = Properties.Settings.Default.team3w;
            kaplakl.Text = Properties.Settings.Default.team3l;
            kaplakd.Text = Properties.Settings.Default.team3d;
            kaplaktp.Text = Properties.Settings.Default.team3tp;
            kaplakp.Text = Properties.Settings.Default.team3p;

            thugw.Text = Properties.Settings.Default.team4w;
            thugl.Text = Properties.Settings.Default.team4l;
            thugd.Text = Properties.Settings.Default.team4d;
            thugtp.Text = Properties.Settings.Default.team4tp;
            thugp.Text = Properties.Settings.Default.team4p;

            missw.Text = Properties.Settings.Default.team5w;
            missl.Text = Properties.Settings.Default.team5l;
            missd.Text = Properties.Settings.Default.team5d;
            misstp.Text = Properties.Settings.Default.team5tp;
            missp.Text = Properties.Settings.Default.team5p;

            aspire2w.Text = Properties.Settings.Default.team6w;
            aspire2l.Text = Properties.Settings.Default.team6l;
            aspire2d.Text = Properties.Settings.Default.team6d;
            aspire2tp.Text = Properties.Settings.Default.team6tp;
            aspire2p.Text = Properties.Settings.Default.team6p;

            gurka2w.Text = Properties.Settings.Default.team7w;
            gurka2l.Text = Properties.Settings.Default.team7l;
            gurka2d.Text = Properties.Settings.Default.team7d;
            gurka2tp.Text = Properties.Settings.Default.team7tp;
            gurka2p.Text = Properties.Settings.Default.team7p;

            mayanksw.Text = Properties.Settings.Default.team8w;
            mayanksl.Text = Properties.Settings.Default.team8l;
            mayanksd.Text = Properties.Settings.Default.team8d;
            mayankstp.Text = Properties.Settings.Default.team8tp;
            mayanksp.Text = Properties.Settings.Default.team8p;

        }

        private void Label5_Click(object sender, EventArgs e)
        {
            int tm1 = Convert.ToInt32(textBox1.Text);
            ++tm1;
            textBox1.Text = Convert.ToString(tm1);

        }
        public void SaveSetting()
        {
            Properties.Settings.Default.team1w = gurkaw.Text;
            Properties.Settings.Default.team1l = gurkal.Text;
            Properties.Settings.Default.team1d = gurkad.Text;
            Properties.Settings.Default.team1tp = gurkatp.Text;
            Properties.Settings.Default.team1p = gurkap.Text;

            Properties.Settings.Default.team2w = pannaw.Text;
            Properties.Settings.Default.team2l = pannal.Text;
            Properties.Settings.Default.team2d = pannad.Text;
            Properties.Settings.Default.team2tp = pannatp.Text;
            Properties.Settings.Default.team2p = pannap.Text;

            Properties.Settings.Default.team3w = kaplakw.Text;
            Properties.Settings.Default.team3l = kaplakl.Text;
            Properties.Settings.Default.team3d = kaplakd.Text;
            Properties.Settings.Default.team3tp = kaplaktp.Text;
            Properties.Settings.Default.team3p = kaplakp.Text;

            Properties.Settings.Default.team4w = thugw.Text;
            Properties.Settings.Default.team4l = thugl.Text;
            Properties.Settings.Default.team4d = thugd.Text;
            Properties.Settings.Default.team4tp = thugtp.Text;
            Properties.Settings.Default.team4p = thugp.Text;

            Properties.Settings.Default.team5w = missw.Text;
            Properties.Settings.Default.team5l = missl.Text;
            Properties.Settings.Default.team5d = missd.Text;
            Properties.Settings.Default.team5tp = misstp.Text;
            Properties.Settings.Default.team5p = missp.Text;

            Properties.Settings.Default.team6w = aspire2w.Text;
            Properties.Settings.Default.team6l = aspire2l.Text;
            Properties.Settings.Default.team6d = aspire2d.Text;
            Properties.Settings.Default.team6tp = aspire2tp.Text;
            Properties.Settings.Default.team6p = aspire2p.Text;

            Properties.Settings.Default.team7w = gurka2w.Text;
            Properties.Settings.Default.team7l = gurka2l.Text;
            Properties.Settings.Default.team7d = gurka2d.Text;
            Properties.Settings.Default.team7tp = gurka2tp.Text;
            Properties.Settings.Default.team7p = gurka2p.Text;

            Properties.Settings.Default.team8w = mayanksw.Text;
            Properties.Settings.Default.team8l = mayanksl.Text;
            Properties.Settings.Default.team8d = mayanksd.Text;
            Properties.Settings.Default.team8tp = mayankstp.Text;
            Properties.Settings.Default.team8p = mayanksp.Text;

            Properties.Settings.Default.Save();
        }

        
        

        private void Button1_Click(object sender, EventArgs e)
        {
            
            GetSettings();
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (teamno1.Text != "" && teamno2.Text != "")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to start a new match? If you click 'Yes', the current match will be terminated", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    textBox1.Text = "0";
                    textBox2.Text = "0";
                    teamno1.Text = null;
                    teamno2.Text = null;
                    if(newt.IsDisposed == true)
                    {
                        newt = new NewTeam();
                    }

                    newt.Show();
                }
                
                
            }
            else if (teamno1.Text == "" && teamno2.Text == "")
            {
                textBox1.Text = "0";
                textBox2.Text = "0";
                teamno1.Text = null;
                teamno2.Text = null;
                if (newt.IsDisposed == true)
                {
                    newt = new NewTeam();
                }

                newt.Show();
            }



        }

        
        private void Label6_Click(object sender, EventArgs e)
        {
            int tm1 = Convert.ToInt32(textBox1.Text);
            --tm1;
            textBox1.Text = Convert.ToString(tm1);
        }

        private void Label7_Click(object sender, EventArgs e)
        {
            int tm2 = Convert.ToInt32(textBox2.Text);
            ++tm2;
            textBox2.Text = Convert.ToString(tm2);
        }

        private void Label8_Click(object sender, EventArgs e)
        {
            int tm2 = Convert.ToInt32(textBox2.Text);
            --tm2;
            textBox2.Text = Convert.ToString(tm2);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (teamno1.Text == "" || teamno2.Text == "")
            {
                MessageBox.Show("There are no teams selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result1 = MessageBox.Show("Are you sure you want to end the match?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result1 == DialogResult.Yes)
                {
                    string tm1;
                    string tm2;
                    int score1;
                    int score2;

                    tm1 = teamno1.Text;
                    tm2 = teamno2.Text;
                    score1 = Convert.ToInt32(textBox1.Text);
                    score2 = Convert.ToInt32(textBox2.Text);
                    if ((score1 > score2) || (score2 > score1) || (score1 == score2))
                    {
                        if (tm1 == "Gurka FC" && tm2 == "Panna")
                        {
                            int a = Convert.ToInt32(gurkap.Text);
                            ++a;
                            gurkap.Text = a.ToString();

                            int b = Convert.ToInt32(pannap.Text);
                            ++b;
                            pannap.Text = b.ToString();

                            if (score1 > score2)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(gurkaw.Text);
                                    x = x + 1;
                                    gurkaw.Text = x.ToString();

                                    int z = Convert.ToInt32(gurkatp.Text);
                                    z = z + 3;
                                    gurkatp.Text = z.ToString();

                                    int y = Convert.ToInt32(pannal.Text);
                                    y = y + 1;
                                    pannal.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 > score1)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(gurkal.Text);
                                    x = x + 1;
                                    gurkal.Text = x.ToString();

                                    int z = Convert.ToInt32(pannatp.Text);
                                    z = z + 3;
                                    pannatp.Text = z.ToString();

                                    int y = Convert.ToInt32(pannaw.Text);
                                    y = y + 1;
                                    pannaw.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 == score1)
                            {
                                DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(gurkad.Text);
                                    x = x + 1;
                                    gurkad.Text = x.ToString();

                                    int z = Convert.ToInt32(pannatp.Text);
                                    z = z + 1;
                                    pannatp.Text = z.ToString();

                                    int zz = Convert.ToInt32(gurkatp.Text);
                                    zz = zz + 1;
                                    gurkatp.Text = zz.ToString();

                                    int y = Convert.ToInt32(pannad.Text);
                                    y = y + 1;
                                    pannad.Text = y.ToString();
                                    f_null();
                                }


                            }

                        }

                        //second

                        else if (tm1 == "Gurka FC" && tm2 == "Kaplak FC")
                        {
                            int a = Convert.ToInt32(gurkap.Text);
                            ++a;
                            gurkap.Text = a.ToString();

                            int b = Convert.ToInt32(kaplakp.Text);
                            ++b;
                            kaplakp.Text = b.ToString();
                            if (score1 > score2)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(gurkaw.Text);
                                    x = x + 1;
                                    gurkaw.Text = x.ToString();

                                    int z = Convert.ToInt32(gurkatp.Text);
                                    z = z + 3;
                                    gurkatp.Text = z.ToString();

                                    int y = Convert.ToInt32(kaplakl.Text);
                                    y = y + 1;
                                    kaplakl.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 > score1)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(gurkal.Text);
                                    x = x + 1;
                                    gurkal.Text = x.ToString();

                                    int z = Convert.ToInt32(kaplaktp.Text);
                                    z = z + 3;
                                    kaplaktp.Text = z.ToString();

                                    int y = Convert.ToInt32(kaplakw.Text);
                                    y = y + 1;
                                    kaplakw.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 == score1)
                            {
                                DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(gurkad.Text);
                                    x = x + 1;
                                    gurkad.Text = x.ToString();

                                    int z = Convert.ToInt32(kaplaktp.Text);
                                    z = z + 1;
                                    kaplaktp.Text = z.ToString();

                                    int zz = Convert.ToInt32(gurkatp.Text);
                                    zz = zz + 1;
                                    gurkatp.Text = zz.ToString();

                                    int y = Convert.ToInt32(kaplakd.Text);
                                    y = y + 1;
                                    kaplakd.Text = y.ToString();
                                    f_null();
                                }


                            }
                        }
                        //next

                        else if (tm1 == "Gurka FC" && tm2 == "Thug FC")
                        {
                            int a = Convert.ToInt32(gurkap.Text);
                            ++a;
                            gurkap.Text = a.ToString();

                            int b = Convert.ToInt32(thugp.Text);
                            ++b;
                            thugp.Text = b.ToString();
                            if (score1 > score2)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(gurkaw.Text);
                                    x = x + 1;
                                    gurkaw.Text = x.ToString();

                                    int z = Convert.ToInt32(gurkatp.Text);
                                    z = z + 3;
                                    gurkatp.Text = z.ToString();

                                    int y = Convert.ToInt32(thugl.Text);
                                    y = y + 1;
                                    thugl.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 > score1)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(gurkal.Text);
                                    x = x + 1;
                                    gurkal.Text = x.ToString();

                                    int z = Convert.ToInt32(thugtp.Text);
                                    z = z + 3;
                                    thugtp.Text = z.ToString();

                                    int y = Convert.ToInt32(thugw.Text);
                                    y = y + 1;
                                    thugw.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 == score1)
                            {
                                DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(gurkad.Text);
                                    x = x + 1;
                                    gurkad.Text = x.ToString();

                                    int z = Convert.ToInt32(thugtp.Text);
                                    z = z + 1;
                                    thugtp.Text = z.ToString();

                                    int zz = Convert.ToInt32(gurkatp.Text);
                                    zz = zz + 1;
                                    gurkatp.Text = zz.ToString();

                                    int y = Convert.ToInt32(thugd.Text);
                                    y = y + 1;
                                    thugd.Text = y.ToString();
                                    f_null();
                                }


                            }
                        }

                        // next

                        else if (tm1 == "Gurka FC" && tm2 == "Miss Fits")
                        {
                            int a = Convert.ToInt32(gurkap.Text);
                            ++a;
                            gurkap.Text = a.ToString();

                            int b = Convert.ToInt32(missp.Text);
                            ++b;
                            missp.Text = b.ToString();
                            if (score1 > score2)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(gurkaw.Text);
                                    x = x + 1;
                                    gurkaw.Text = x.ToString();

                                    int z = Convert.ToInt32(gurkatp.Text);
                                    z = z + 3;
                                    gurkatp.Text = z.ToString();

                                    int y = Convert.ToInt32(missl.Text);
                                    y = y + 1;
                                    missl.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 > score1)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(gurkal.Text);
                                    x = x + 1;
                                    gurkal.Text = x.ToString();

                                    int z = Convert.ToInt32(misstp.Text);
                                    z = z + 3;
                                    misstp.Text = z.ToString();

                                    int y = Convert.ToInt32(missw.Text);
                                    y = y + 1;
                                    missw.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 == score1)
                            {
                                DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(gurkad.Text);
                                    x = x + 1;
                                    gurkad.Text = x.ToString();

                                    int z = Convert.ToInt32(misstp.Text);
                                    z = z + 1;
                                    misstp.Text = z.ToString();

                                    int zz = Convert.ToInt32(gurkatp.Text);
                                    zz = zz + 1;
                                    gurkatp.Text = zz.ToString();

                                    int y = Convert.ToInt32(missd.Text);
                                    y = y + 1;
                                    missd.Text = y.ToString();
                                    f_null();
                                }


                            }



                        }








                        else if (tm1 == "Gurka FC" && tm2 == "Aspire2")
                        {
                            int a = Convert.ToInt32(gurkap.Text);
                            ++a;
                            gurkap.Text = a.ToString();

                            int b = Convert.ToInt32(aspire2p.Text);
                            ++b;
                            aspire2p.Text = b.ToString();
                            if (score1 > score2)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(gurkaw.Text);
                                    x = x + 1;
                                    gurkaw.Text = x.ToString();

                                    int z = Convert.ToInt32(gurkatp.Text);
                                    z = z + 3;
                                    gurkatp.Text = z.ToString();

                                    int y = Convert.ToInt32(aspire2l.Text);
                                    y = y + 1;
                                    aspire2l.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 > score1)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(gurkal.Text);
                                    x = x + 1;
                                    gurkal.Text = x.ToString();

                                    int z = Convert.ToInt32(aspire2tp.Text);
                                    z = z + 3;
                                    aspire2tp.Text = z.ToString();

                                    int y = Convert.ToInt32(aspire2w.Text);
                                    y = y + 1;
                                    aspire2w.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 == score1)
                            {
                                DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(gurkad.Text);
                                    x = x + 1;
                                    gurkad.Text = x.ToString();

                                    int z = Convert.ToInt32(aspire2tp.Text);
                                    z = z + 1;
                                    aspire2tp.Text = z.ToString();

                                    int zz = Convert.ToInt32(gurkatp.Text);
                                    zz = zz + 1;
                                    gurkatp.Text = zz.ToString();

                                    int y = Convert.ToInt32(aspire2d.Text);
                                    y = y + 1;
                                    aspire2d.Text = y.ToString();
                                    f_null();
                                }


                            }



                        }
                        else if (tm1 == "Gurka FC" && tm2 == "Gurka FC 2")
                        {
                            int a = Convert.ToInt32(gurkap.Text);
                            ++a;
                            gurkap.Text = a.ToString();

                            int b = Convert.ToInt32(gurka2p.Text);
                            ++b;
                            gurka2p.Text = b.ToString();
                            if (score1 > score2)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(gurkaw.Text);
                                    x = x + 1;
                                    gurkaw.Text = x.ToString();

                                    int z = Convert.ToInt32(gurkatp.Text);
                                    z = z + 3;
                                    gurkatp.Text = z.ToString();

                                    int y = Convert.ToInt32(gurka2l.Text);
                                    y = y + 1;
                                    gurka2l.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 > score1)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(gurkal.Text);
                                    x = x + 1;
                                    gurkal.Text = x.ToString();

                                    int z = Convert.ToInt32(gurka2tp.Text);
                                    z = z + 3;
                                    gurka2tp.Text = z.ToString();

                                    int y = Convert.ToInt32(gurka2w.Text);
                                    y = y + 1;
                                    gurka2w.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 == score1)
                            {
                                DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(gurkad.Text);
                                    x = x + 1;
                                    gurkad.Text = x.ToString();

                                    int z = Convert.ToInt32(gurka2tp.Text);
                                    z = z + 1;
                                    gurka2tp.Text = z.ToString();

                                    int zz = Convert.ToInt32(gurkatp.Text);
                                    zz = zz + 1;
                                    gurkatp.Text = zz.ToString();

                                    int y = Convert.ToInt32(gurka2d.Text);
                                    y = y + 1;
                                    gurka2d.Text = y.ToString();
                                    f_null();
                                }


                            }



                        }

                        else if (tm1 == "Gurka FC" && tm2 == "Mayanks")
                        {
                            int a = Convert.ToInt32(gurkap.Text);
                            ++a;
                            gurkap.Text = a.ToString();

                            int b = Convert.ToInt32(mayanksp.Text);
                            ++b;
                            mayanksp.Text = b.ToString();
                            if (score1 > score2)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(gurkaw.Text);
                                    x = x + 1;
                                    gurkaw.Text = x.ToString();

                                    int z = Convert.ToInt32(gurkatp.Text);
                                    z = z + 3;
                                    gurkatp.Text = z.ToString();

                                    int y = Convert.ToInt32(mayanksl.Text);
                                    y = y + 1;
                                    mayanksl.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 > score1)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(gurkal.Text);
                                    x = x + 1;
                                    gurkal.Text = x.ToString();

                                    int z = Convert.ToInt32(mayankstp.Text);
                                    z = z + 3;
                                    mayankstp.Text = z.ToString();

                                    int y = Convert.ToInt32(mayanksw.Text);
                                    y = y + 1;
                                    mayanksw.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 == score1)
                            {
                                DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(gurkad.Text);
                                    x = x + 1;
                                    gurkad.Text = x.ToString();

                                    int z = Convert.ToInt32(mayankstp.Text);
                                    z = z + 1;
                                    mayankstp.Text = z.ToString();

                                    int zz = Convert.ToInt32(gurkatp.Text);
                                    zz = zz + 1;
                                    gurkatp.Text = zz.ToString();

                                    int y = Convert.ToInt32(mayanksd.Text);
                                    y = y + 1;
                                    mayanksd.Text = y.ToString();
                                    f_null();
                                }


                            }







                            //set one finished.



                            else if (tm1 == "Panna" && tm2 == "Gurka FC")
                            {
                                int a2 = Convert.ToInt32(pannap.Text);
                                ++a2;
                                pannap.Text = a.ToString();

                                int b2 = Convert.ToInt32(gurkap.Text);
                                ++b2;
                                gurkap.Text = b.ToString();
                                if (score1 > score2)
                                {
                                    DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                    if (result == DialogResult.OK)
                                    {
                                        int x = Convert.ToInt32(pannaw.Text);
                                        x = x + 1;
                                        pannaw.Text = x.ToString();

                                        int z = Convert.ToInt32(pannatp.Text);
                                        z = z + 3;
                                        pannatp.Text = z.ToString();

                                        int y = Convert.ToInt32(gurkal.Text);
                                        y = y + 1;
                                        gurkal.Text = y.ToString();
                                        f_null();
                                    }


                                }
                                else if (score2 > score1)
                                {
                                    DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                    if (result == DialogResult.OK)
                                    {
                                        int x = Convert.ToInt32(pannal.Text);
                                        x = x + 1;
                                        pannal.Text = x.ToString();

                                        int z = Convert.ToInt32(gurkatp.Text);
                                        z = z + 3;
                                        gurkatp.Text = z.ToString();

                                        int y = Convert.ToInt32(gurkaw.Text);
                                        y = y + 1;
                                        gurkaw.Text = y.ToString();
                                        f_null();
                                    }


                                }
                                else if (score2 == score1)
                                {
                                    DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                    if (result == DialogResult.OK)
                                    {
                                        int x = Convert.ToInt32(pannad.Text);
                                        x = x + 1;
                                        pannad.Text = x.ToString();

                                        int z = Convert.ToInt32(pannatp.Text);
                                        z = z + 1;
                                        pannatp.Text = z.ToString();

                                        int zz = Convert.ToInt32(gurkatp.Text);
                                        zz = zz + 1;
                                        gurkatp.Text = zz.ToString();

                                        int y = Convert.ToInt32(gurkad.Text);
                                        y = y + 1;
                                        gurkad.Text = y.ToString();
                                        f_null();
                                    }


                                }

                            }

                            //second

                            else if (tm1 == "Panna" && tm2 == "Kaplak FC")
                            {
                                int a2 = Convert.ToInt32(pannap.Text);
                                ++a2;
                                pannap.Text = a2.ToString();

                                int b2 = Convert.ToInt32(kaplakp.Text);
                                ++b2;
                                kaplakp.Text = b2.ToString();
                                if (score1 > score2)
                                {
                                    DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                    if (result == DialogResult.OK)
                                    {
                                        int x = Convert.ToInt32(pannaw.Text);
                                        x = x + 1;
                                        pannaw.Text = x.ToString();

                                        int z = Convert.ToInt32(pannatp.Text);
                                        z = z + 3;
                                        pannatp.Text = z.ToString();

                                        int y = Convert.ToInt32(kaplakl.Text);
                                        y = y + 1;
                                        kaplakl.Text = y.ToString();
                                        f_null();
                                    }


                                }
                                else if (score2 > score1)
                                {
                                    DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                    if (result == DialogResult.OK)
                                    {
                                        int x = Convert.ToInt32(pannal.Text);
                                        x = x + 1;
                                        pannal.Text = x.ToString();

                                        int z = Convert.ToInt32(kaplaktp.Text);
                                        z = z + 3;
                                        kaplaktp.Text = z.ToString();

                                        int y = Convert.ToInt32(kaplakw.Text);
                                        y = y + 1;
                                        kaplakw.Text = y.ToString();
                                        f_null();
                                    }


                                }
                                else if (score2 == score1)
                                {
                                    DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                    if (result == DialogResult.OK)
                                    {
                                        int x = Convert.ToInt32(pannad.Text);
                                        x = x + 1;
                                        pannad.Text = x.ToString();

                                        int z = Convert.ToInt32(kaplaktp.Text);
                                        z = z + 1;
                                        kaplaktp.Text = z.ToString();

                                        int zz = Convert.ToInt32(pannatp.Text);
                                        zz = zz + 1;
                                        pannatp.Text = zz.ToString();

                                        int y = Convert.ToInt32(kaplakd.Text);
                                        y = y + 1;
                                        kaplakd.Text = y.ToString();
                                        f_null();
                                    }


                                }
                            }
                            //next

                            else if (tm1 == "Panna" && tm2 == "Thug FC")
                            {
                                int a2 = Convert.ToInt32(pannap.Text);
                                ++a2;
                                pannap.Text = a2.ToString();

                                int b2 = Convert.ToInt32(thugp.Text);
                                ++b2;
                                thugp.Text = b2.ToString();
                                if (score1 > score2)
                                {
                                    DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                    if (result == DialogResult.OK)
                                    {
                                        int x = Convert.ToInt32(pannaw.Text);
                                        x = x + 1;
                                        pannaw.Text = x.ToString();

                                        int z = Convert.ToInt32(pannatp.Text);
                                        z = z + 3;
                                        pannatp.Text = z.ToString();

                                        int y = Convert.ToInt32(thugl.Text);
                                        y = y + 1;
                                        thugl.Text = y.ToString();
                                        f_null();
                                    }


                                }
                                else if (score2 > score1)
                                {
                                    DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                    if (result == DialogResult.OK)
                                    {
                                        int x = Convert.ToInt32(pannal.Text);
                                        x = x + 1;
                                        pannal.Text = x.ToString();

                                        int z = Convert.ToInt32(thugtp.Text);
                                        z = z + 3;
                                        thugtp.Text = z.ToString();

                                        int y = Convert.ToInt32(thugw.Text);
                                        y = y + 1;
                                        thugw.Text = y.ToString();
                                        f_null();
                                    }


                                }
                                else if (score2 == score1)
                                {
                                    DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                    if (result == DialogResult.OK)
                                    {
                                        int x = Convert.ToInt32(pannad.Text);
                                        x = x + 1;
                                        pannad.Text = x.ToString();

                                        int z = Convert.ToInt32(thugtp.Text);
                                        z = z + 1;
                                        thugtp.Text = z.ToString();

                                        int zz = Convert.ToInt32(pannatp.Text);
                                        zz = zz + 1;
                                        pannatp.Text = zz.ToString();

                                        int y = Convert.ToInt32(thugd.Text);
                                        y = y + 1;
                                        thugd.Text = y.ToString();
                                        f_null();
                                    }


                                }
                            }

                            // next

                            else if (tm1 == "Panna" && tm2 == "Miss Fits")
                            {
                                int a2 = Convert.ToInt32(pannap.Text);
                                ++a2;
                                pannap.Text = a2.ToString();

                                int b2 = Convert.ToInt32(missp.Text);
                                ++b2;
                                missp.Text = b2.ToString();
                                if (score1 > score2)
                                {
                                    DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                    if (result == DialogResult.OK)
                                    {
                                        int x = Convert.ToInt32(pannaw.Text);
                                        x = x + 1;
                                        pannaw.Text = x.ToString();

                                        int z = Convert.ToInt32(pannatp.Text);
                                        z = z + 3;
                                        pannatp.Text = z.ToString();

                                        int y = Convert.ToInt32(missl.Text);
                                        y = y + 1;
                                        missl.Text = y.ToString();
                                        f_null();
                                    }


                                }
                                else if (score2 > score1)
                                {
                                    DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                    if (result == DialogResult.OK)
                                    {
                                        int x = Convert.ToInt32(pannal.Text);
                                        x = x + 1;
                                        pannal.Text = x.ToString();

                                        int z = Convert.ToInt32(misstp.Text);
                                        z = z + 3;
                                        misstp.Text = z.ToString();

                                        int y = Convert.ToInt32(missw.Text);
                                        y = y + 1;
                                        missw.Text = y.ToString();
                                        f_null();
                                    }


                                }
                                else if (score2 == score1)
                                {
                                    DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                    if (result == DialogResult.OK)
                                    {
                                        int x = Convert.ToInt32(pannad.Text);
                                        x = x + 1;
                                        pannad.Text = x.ToString();

                                        int z = Convert.ToInt32(misstp.Text);
                                        z = z + 1;
                                        misstp.Text = z.ToString();

                                        int zz = Convert.ToInt32(pannatp.Text);
                                        zz = zz + 1;
                                        pannatp.Text = zz.ToString();

                                        int y = Convert.ToInt32(missd.Text);
                                        y = y + 1;
                                        missd.Text = y.ToString();
                                        f_null();
                                    }


                                }



                            }






                        }

                        else if (tm1 == "Panna" && tm2 == "Aspire2")
                        {
                            int a2 = Convert.ToInt32(pannap.Text);
                            ++a2;
                            pannap.Text = a2.ToString();

                            int b2 = Convert.ToInt32(aspire2p.Text);
                            ++b2;
                            aspire2p.Text = b2.ToString();
                            if (score1 > score2)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(pannaw.Text);
                                    x = x + 1;
                                    pannaw.Text = x.ToString();

                                    int z = Convert.ToInt32(pannatp.Text);
                                    z = z + 3;
                                    pannatp.Text = z.ToString();

                                    int y = Convert.ToInt32(aspire2l.Text);
                                    y = y + 1;
                                    aspire2l.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 > score1)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(pannal.Text);
                                    x = x + 1;
                                    pannal.Text = x.ToString();

                                    int z = Convert.ToInt32(aspire2tp.Text);
                                    z = z + 3;
                                    aspire2tp.Text = z.ToString();

                                    int y = Convert.ToInt32(aspire2w.Text);
                                    y = y + 1;
                                    aspire2w.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 == score1)
                            {
                                DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(pannad.Text);
                                    x = x + 1;
                                    pannad.Text = x.ToString();

                                    int z = Convert.ToInt32(aspire2tp.Text);
                                    z = z + 1;
                                    aspire2tp.Text = z.ToString();

                                    int zz = Convert.ToInt32(pannatp.Text);
                                    zz = zz + 1;
                                    pannatp.Text = zz.ToString();

                                    int y = Convert.ToInt32(aspire2d.Text);
                                    y = y + 1;
                                    aspire2d.Text = y.ToString();
                                    f_null();
                                }


                            }



                        }
                        else if (tm1 == "Panna" && tm2 == "Gurka FC 2")
                        {
                            int a2 = Convert.ToInt32(pannap.Text);
                            ++a2;
                            pannap.Text = a2.ToString();

                            int b2 = Convert.ToInt32(gurka2p.Text);
                            ++b2;
                            gurka2p.Text = b2.ToString();
                            if (score1 > score2)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(pannaw.Text);
                                    x = x + 1;
                                    pannaw.Text = x.ToString();

                                    int z = Convert.ToInt32(pannatp.Text);
                                    z = z + 3;
                                    pannatp.Text = z.ToString();

                                    int y = Convert.ToInt32(gurka2l.Text);
                                    y = y + 1;
                                    gurka2l.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 > score1)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(pannal.Text);
                                    x = x + 1;
                                    pannal.Text = x.ToString();

                                    int z = Convert.ToInt32(gurka2tp.Text);
                                    z = z + 3;
                                    gurka2tp.Text = z.ToString();

                                    int y = Convert.ToInt32(gurka2w.Text);
                                    y = y + 1;
                                    gurka2w.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 == score1)
                            {
                                DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(pannad.Text);
                                    x = x + 1;
                                    pannad.Text = x.ToString();

                                    int z = Convert.ToInt32(gurka2tp.Text);
                                    z = z + 1;
                                    gurka2tp.Text = z.ToString();

                                    int zz = Convert.ToInt32(pannatp.Text);
                                    zz = zz + 1;
                                    pannatp.Text = zz.ToString();

                                    int y = Convert.ToInt32(gurka2d.Text);
                                    y = y + 1;
                                    gurka2d.Text = y.ToString();
                                    f_null();
                                }


                            }



                        }

                        else if (tm1 == "Panna" && tm2 == "Mayanks")
                        {
                            int a2 = Convert.ToInt32(pannap.Text);
                            ++a2;
                            pannap.Text = a2.ToString();

                            int b2 = Convert.ToInt32(mayanksp.Text);
                            ++b2;
                            mayanksp.Text = b2.ToString();
                            if (score1 > score2)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(pannaw.Text);
                                    x = x + 1;
                                    pannaw.Text = x.ToString();

                                    int z = Convert.ToInt32(pannatp.Text);
                                    z = z + 3;
                                    pannatp.Text = z.ToString();

                                    int y = Convert.ToInt32(mayanksl.Text);
                                    y = y + 1;
                                    mayanksl.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 > score1)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(pannal.Text);
                                    x = x + 1;
                                    pannal.Text = x.ToString();

                                    int z = Convert.ToInt32(mayankstp.Text);
                                    z = z + 3;
                                    mayankstp.Text = z.ToString();

                                    int y = Convert.ToInt32(mayanksw.Text);
                                    y = y + 1;
                                    mayanksw.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 == score1)
                            {
                                DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(pannad.Text);
                                    x = x + 1;
                                    pannad.Text = x.ToString();

                                    int z = Convert.ToInt32(mayankstp.Text);
                                    z = z + 1;
                                    mayankstp.Text = z.ToString();

                                    int zz = Convert.ToInt32(pannatp.Text);
                                    zz = zz + 1;
                                    pannatp.Text = zz.ToString();

                                    int y = Convert.ToInt32(mayanksd.Text);
                                    y = y + 1;
                                    mayanksd.Text = y.ToString();
                                    f_null();
                                }


                            }



                        }

                        //Third set starts here  dfsdfsdfsdfsdfsdfsd


                        else if (tm1 == "Kaplak FC" && tm2 == "Gurka FC")
                        {
                            int a3 = Convert.ToInt32(kaplakp.Text);
                            ++a3;
                            kaplakp.Text = a3.ToString();

                            int b3 = Convert.ToInt32(gurkap.Text);
                            ++b3;
                            gurkap.Text = b3.ToString();
                            if (score1 > score2)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(kaplakw.Text);
                                    x = x + 1;
                                    kaplakw.Text = x.ToString();

                                    int z = Convert.ToInt32(kaplaktp.Text);
                                    z = z + 3;
                                    kaplaktp.Text = z.ToString();

                                    int y = Convert.ToInt32(gurkal.Text);
                                    y = y + 1;
                                    gurkal.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 > score1)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(kaplakl.Text);
                                    x = x + 1;
                                    kaplakl.Text = x.ToString();

                                    int z = Convert.ToInt32(gurkatp.Text);
                                    z = z + 3;
                                    gurkatp.Text = z.ToString();

                                    int y = Convert.ToInt32(gurkaw.Text);
                                    y = y + 1;
                                    gurkaw.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 == score1)
                            {
                                DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(kaplakd.Text);
                                    x = x + 1;
                                    kaplakd.Text = x.ToString();

                                    int z = Convert.ToInt32(kaplaktp.Text);
                                    z = z + 1;
                                    kaplaktp.Text = z.ToString();

                                    int zz = Convert.ToInt32(gurkatp.Text);
                                    zz = zz + 1;
                                    gurkatp.Text = zz.ToString();

                                    int y = Convert.ToInt32(gurkad.Text);
                                    y = y + 1;
                                    pannad.Text = y.ToString();
                                    f_null();
                                }


                            }

                        }

                        //second

                        else if (tm1 == "Kaplak FC" && tm2 == "Panna")
                        {
                            int a3 = Convert.ToInt32(kaplakp.Text);
                            ++a3;
                            kaplakp.Text = a3.ToString();

                            int b3 = Convert.ToInt32(pannap.Text);
                            ++b3;
                            pannap.Text = b3.ToString();
                            if (score1 > score2)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(kaplakw.Text);
                                    x = x + 1;
                                    kaplakw.Text = x.ToString();

                                    int z = Convert.ToInt32(kaplaktp.Text);
                                    z = z + 3;
                                    kaplaktp.Text = z.ToString();

                                    int y = Convert.ToInt32(pannal.Text);
                                    y = y + 1;
                                    pannal.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 > score1)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(kaplakl.Text);
                                    x = x + 1;
                                    kaplakl.Text = x.ToString();

                                    int z = Convert.ToInt32(pannatp.Text);
                                    z = z + 3;
                                    pannatp.Text = z.ToString();

                                    int y = Convert.ToInt32(pannaw.Text);
                                    y = y + 1;
                                    pannaw.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 == score1)
                            {
                                DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(kaplakd.Text);
                                    x = x + 1;
                                    kaplakd.Text = x.ToString();

                                    int z = Convert.ToInt32(kaplaktp.Text);
                                    z = z + 1;
                                    kaplaktp.Text = z.ToString();

                                    int zz = Convert.ToInt32(pannatp.Text);
                                    zz = zz + 1;
                                    pannatp.Text = zz.ToString();

                                    int y = Convert.ToInt32(pannad.Text);
                                    y = y + 1;
                                    pannad.Text = y.ToString();
                                    f_null();
                                }


                            }
                        }
                        //next

                        else if (tm1 == "Kaplak FC" && tm2 == "Thug FC")
                        {
                            int a3 = Convert.ToInt32(kaplakp.Text);
                            ++a3;
                            kaplakp.Text = a3.ToString();

                            int b3 = Convert.ToInt32(thugp.Text);
                            ++b3;
                            thugp.Text = b3.ToString();
                            if (score1 > score2)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(kaplakw.Text);
                                    x = x + 1;
                                    kaplakw.Text = x.ToString();

                                    int z = Convert.ToInt32(kaplaktp.Text);
                                    z = z + 3;
                                    kaplaktp.Text = z.ToString();

                                    int y = Convert.ToInt32(thugl.Text);
                                    y = y + 1;
                                    thugl.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 > score1)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(kaplakl.Text);
                                    x = x + 1;
                                    kaplakl.Text = x.ToString();

                                    int z = Convert.ToInt32(thugtp.Text);
                                    z = z + 3;
                                    thugtp.Text = z.ToString();

                                    int y = Convert.ToInt32(thugw.Text);
                                    y = y + 1;
                                    thugw.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 == score1)
                            {
                                DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(kaplakd.Text);
                                    x = x + 1;
                                    kaplakd.Text = x.ToString();

                                    int z = Convert.ToInt32(thugtp.Text);
                                    z = z + 1;
                                    thugtp.Text = z.ToString();

                                    int zz = Convert.ToInt32(kaplaktp.Text);
                                    zz = zz + 1;
                                    kaplaktp.Text = zz.ToString();

                                    int y = Convert.ToInt32(thugd.Text);
                                    y = y + 1;
                                    thugd.Text = y.ToString();
                                    f_null();
                                }


                            }
                        }

                        // next

                        else if (tm1 == "Kaplak FC" && tm2 == "Miss Fits")
                        {
                            int a3 = Convert.ToInt32(kaplakp.Text);
                            ++a3;
                            kaplakp.Text = a3.ToString();

                            int b3 = Convert.ToInt32(missp.Text);
                            ++b3;
                            missp.Text = b3.ToString();
                            if (score1 > score2)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(kaplakw.Text);
                                    x = x + 1;
                                    kaplakw.Text = x.ToString();

                                    int z = Convert.ToInt32(kaplaktp.Text);
                                    z = z + 3;
                                    kaplaktp.Text = z.ToString();

                                    int y = Convert.ToInt32(missl.Text);
                                    y = y + 1;
                                    missl.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 > score1)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(kaplakl.Text);
                                    x = x + 1;
                                    kaplakl.Text = x.ToString();

                                    int z = Convert.ToInt32(misstp.Text);
                                    z = z + 3;
                                    misstp.Text = z.ToString();

                                    int y = Convert.ToInt32(missw.Text);
                                    y = y + 1;
                                    missw.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 == score1)
                            {
                                DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(kaplakd.Text);
                                    x = x + 1;
                                    kaplakd.Text = x.ToString();

                                    int z = Convert.ToInt32(misstp.Text);
                                    z = z + 1;
                                    misstp.Text = z.ToString();

                                    int zz = Convert.ToInt32(kaplaktp.Text);
                                    zz = zz + 1;
                                    kaplaktp.Text = zz.ToString();

                                    int y = Convert.ToInt32(missd.Text);
                                    y = y + 1;
                                    missd.Text = y.ToString();
                                    f_null();
                                }


                            }



                        }

                        else if (tm1 == "Kaplak FC" && tm2 == "Aspire2")
                        {
                            int a3 = Convert.ToInt32(kaplakp.Text);
                            ++a3;
                            kaplakp.Text = a3.ToString();

                            int b3 = Convert.ToInt32(aspire2p.Text);
                            ++b3;
                            aspire2p.Text = b3.ToString();
                            if (score1 > score2)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(kaplakw.Text);
                                    x = x + 1;
                                    kaplakw.Text = x.ToString();

                                    int z = Convert.ToInt32(kaplaktp.Text);
                                    z = z + 3;
                                    kaplaktp.Text = z.ToString();

                                    int y = Convert.ToInt32(aspire2l.Text);
                                    y = y + 1;
                                    aspire2l.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 > score1)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(kaplakl.Text);
                                    x = x + 1;
                                    kaplakl.Text = x.ToString();

                                    int z = Convert.ToInt32(aspire2tp.Text);
                                    z = z + 3;
                                    aspire2tp.Text = z.ToString();

                                    int y = Convert.ToInt32(aspire2w.Text);
                                    y = y + 1;
                                    aspire2w.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 == score1)
                            {
                                DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(kaplakd.Text);
                                    x = x + 1;
                                    kaplakd.Text = x.ToString();

                                    int z = Convert.ToInt32(aspire2tp.Text);
                                    z = z + 1;
                                    aspire2tp.Text = z.ToString();

                                    int zz = Convert.ToInt32(kaplaktp.Text);
                                    zz = zz + 1;
                                    kaplaktp.Text = zz.ToString();

                                    int y = Convert.ToInt32(aspire2d.Text);
                                    y = y + 1;
                                    aspire2d.Text = y.ToString();
                                    f_null();
                                }


                            }



                        }
                        else if (tm1 == "Kaplak FC" && tm2 == "Gurka FC 2")
                        {
                            int a3 = Convert.ToInt32(kaplakp.Text);
                            ++a3;
                            kaplakp.Text = a3.ToString();

                            int b3 = Convert.ToInt32(gurka2p.Text);
                            ++b3;
                            gurka2p.Text = b3.ToString();
                            if (score1 > score2)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(kaplakw.Text);
                                    x = x + 1;
                                    kaplakw.Text = x.ToString();

                                    int z = Convert.ToInt32(kaplaktp.Text);
                                    z = z + 3;
                                    kaplaktp.Text = z.ToString();

                                    int y = Convert.ToInt32(gurka2l.Text);
                                    y = y + 1;
                                    gurka2l.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 > score1)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(kaplakl.Text);
                                    x = x + 1;
                                    kaplakl.Text = x.ToString();

                                    int z = Convert.ToInt32(gurka2tp.Text);
                                    z = z + 3;
                                    gurka2tp.Text = z.ToString();

                                    int y = Convert.ToInt32(gurka2w.Text);
                                    y = y + 1;
                                    gurka2w.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 == score1)
                            {
                                DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(kaplakd.Text);
                                    x = x + 1;
                                    kaplakd.Text = x.ToString();

                                    int z = Convert.ToInt32(gurka2tp.Text);
                                    z = z + 1;
                                    gurka2tp.Text = z.ToString();

                                    int zz = Convert.ToInt32(kaplaktp.Text);
                                    zz = zz + 1;
                                    kaplaktp.Text = zz.ToString();

                                    int y = Convert.ToInt32(gurka2d.Text);
                                    y = y + 1;
                                    gurka2d.Text = y.ToString();
                                    f_null();
                                }


                            }



                        }

                        else if (tm1 == "Kaplak FC" && tm2 == "Mayanks")
                        {
                            int a3 = Convert.ToInt32(kaplakp.Text);
                            ++a3;
                            kaplakp.Text = a3.ToString();

                            int b3 = Convert.ToInt32(mayanksp.Text);
                            ++b3;
                            mayanksp.Text = b3.ToString();
                            if (score1 > score2)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(kaplakw.Text);
                                    x = x + 1;
                                    kaplakw.Text = x.ToString();

                                    int z = Convert.ToInt32(kaplaktp.Text);
                                    z = z + 3;
                                    kaplaktp.Text = z.ToString();

                                    int y = Convert.ToInt32(mayanksl.Text);
                                    y = y + 1;
                                    mayanksl.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 > score1)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(kaplakl.Text);
                                    x = x + 1;
                                    kaplakl.Text = x.ToString();

                                    int z = Convert.ToInt32(mayankstp.Text);
                                    z = z + 3;
                                    mayankstp.Text = z.ToString();

                                    int y = Convert.ToInt32(mayanksw.Text);
                                    y = y + 1;
                                    mayanksw.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 == score1)
                            {
                                DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(kaplakd.Text);
                                    x = x + 1;
                                    kaplakd.Text = x.ToString();

                                    int z = Convert.ToInt32(mayankstp.Text);
                                    z = z + 1;
                                    mayankstp.Text = z.ToString();

                                    int zz = Convert.ToInt32(kaplaktp.Text);
                                    zz = zz + 1;
                                    kaplaktp.Text = zz.ToString();

                                    int y = Convert.ToInt32(mayanksd.Text);
                                    y = y + 1;
                                    mayanksd.Text = y.ToString();
                                    f_null();
                                }


                            }



                        }

                        //fourth set strts herer
                        //dfsdfdsf
                        //fourth


                        else if (tm1 == "Thug FC" && tm2 == "Gurka FC")
                        {
                            int a4 = Convert.ToInt32(thugp.Text);
                            ++a4;
                            thugp.Text = a4.ToString();

                            int b4 = Convert.ToInt32(gurkap.Text);
                            ++b4;
                            gurkap.Text = b4.ToString();
                            if (score1 > score2)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(thugw.Text);
                                    x = x + 1;
                                    thugw.Text = x.ToString();

                                    int z = Convert.ToInt32(thugtp.Text);
                                    z = z + 3;
                                    thugtp.Text = z.ToString();

                                    int y = Convert.ToInt32(gurkal.Text);
                                    y = y + 1;
                                    gurkal.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 > score1)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(thugl.Text);
                                    x = x + 1;
                                    thugl.Text = x.ToString();

                                    int z = Convert.ToInt32(gurkatp.Text);
                                    z = z + 3;
                                    gurkatp.Text = z.ToString();

                                    int y = Convert.ToInt32(gurkaw.Text);
                                    y = y + 1;
                                    gurkaw.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 == score1)
                            {
                                DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(thugd.Text);
                                    x = x + 1;
                                    thugd.Text = x.ToString();

                                    int z = Convert.ToInt32(thugtp.Text);
                                    z = z + 1;
                                    thugtp.Text = z.ToString();

                                    int zz = Convert.ToInt32(gurkatp.Text);
                                    zz = zz + 1;
                                    gurkatp.Text = zz.ToString();

                                    int y = Convert.ToInt32(gurkad.Text);
                                    y = y + 1;
                                    gurkad.Text = y.ToString();
                                    f_null();
                                }


                            }

                        }

                        //second

                        else if (tm1 == "Thug FC" && tm2 == "Panna")
                        {
                            int a4 = Convert.ToInt32(thugp.Text);
                            ++a4;
                            thugp.Text = a4.ToString();

                            int b4 = Convert.ToInt32(pannap.Text);
                            ++b4;
                            pannap.Text = b4.ToString();
                            if (score1 > score2)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(thugw.Text);
                                    x = x + 1;
                                    thugw.Text = x.ToString();

                                    int z = Convert.ToInt32(thugtp.Text);
                                    z = z + 3;
                                    thugtp.Text = z.ToString();

                                    int y = Convert.ToInt32(pannal.Text);
                                    y = y + 1;
                                    pannal.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 > score1)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(thugl.Text);
                                    x = x + 1;
                                    thugl.Text = x.ToString();

                                    int z = Convert.ToInt32(pannatp.Text);
                                    z = z + 3;
                                    pannatp.Text = z.ToString();

                                    int y = Convert.ToInt32(pannaw.Text);
                                    y = y + 1;
                                    pannaw.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 == score1)
                            {
                                DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(thugd.Text);
                                    x = x + 1;
                                    thugd.Text = x.ToString();

                                    int z = Convert.ToInt32(thugtp.Text);
                                    z = z + 1;
                                    thugtp.Text = z.ToString();

                                    int zz = Convert.ToInt32(pannatp.Text);
                                    zz = zz + 1;
                                    pannatp.Text = zz.ToString();

                                    int y = Convert.ToInt32(pannad.Text);
                                    y = y + 1;
                                    pannad.Text = y.ToString();
                                    f_null();
                                }


                            }
                        }
                        //next

                        else if (tm1 == "Thug FC" && tm2 == "Kaplak FC")
                        {
                            int a4 = Convert.ToInt32(thugp.Text);
                            ++a4;
                            thugp.Text = a4.ToString();

                            int b4 = Convert.ToInt32(kaplakp.Text);
                            ++b4;
                            kaplakp.Text = b4.ToString();
                            if (score1 > score2)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(thugw.Text);
                                    x = x + 1;
                                    thugw.Text = x.ToString();

                                    int z = Convert.ToInt32(thugtp.Text);
                                    z = z + 3;
                                    thugtp.Text = z.ToString();

                                    int y = Convert.ToInt32(kaplakl.Text);
                                    y = y + 1;
                                    kaplakl.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 > score1)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(thugl.Text);
                                    x = x + 1;
                                    thugl.Text = x.ToString();

                                    int z = Convert.ToInt32(kaplaktp.Text);
                                    z = z + 3;
                                    kaplaktp.Text = z.ToString();

                                    int y = Convert.ToInt32(kaplakw.Text);
                                    y = y + 1;
                                    kaplakw.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 == score1)
                            {
                                DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(thugd.Text);
                                    x = x + 1;
                                    thugd.Text = x.ToString();

                                    int z = Convert.ToInt32(kaplaktp.Text);
                                    z = z + 1;
                                    kaplaktp.Text = z.ToString();

                                    int zz = Convert.ToInt32(thugtp.Text);
                                    zz = zz + 1;
                                    thugtp.Text = zz.ToString();

                                    int y = Convert.ToInt32(kaplakd.Text);
                                    y = y + 1;
                                    kaplakd.Text = y.ToString();
                                    f_null();
                                }


                            }
                        }

                        // next

                        else if (tm1 == "Thug FC" && tm2 == "Miss Fits")
                        {
                            int a4 = Convert.ToInt32(thugp.Text);
                            ++a4;
                            thugp.Text = a4.ToString();

                            int b4 = Convert.ToInt32(missp.Text);
                            ++b4;
                            missp.Text = b4.ToString();
                            if (score1 > score2)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(thugw.Text);
                                    x = x + 1;
                                    thugw.Text = x.ToString();

                                    int z = Convert.ToInt32(thugtp.Text);
                                    z = z + 3;
                                    thugtp.Text = z.ToString();

                                    int y = Convert.ToInt32(missl.Text);
                                    y = y + 1;
                                    missl.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 > score1)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(thugl.Text);
                                    x = x + 1;
                                    thugl.Text = x.ToString();

                                    int z = Convert.ToInt32(misstp.Text);
                                    z = z + 3;
                                    misstp.Text = z.ToString();

                                    int y = Convert.ToInt32(missw.Text);
                                    y = y + 1;
                                    missw.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 == score1)
                            {
                                DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(thugd.Text);
                                    x = x + 1;
                                    thugd.Text = x.ToString();

                                    int z = Convert.ToInt32(misstp.Text);
                                    z = z + 1;
                                    misstp.Text = z.ToString();

                                    int zz = Convert.ToInt32(thugtp.Text);
                                    zz = zz + 1;
                                    thugtp.Text = zz.ToString();

                                    int y = Convert.ToInt32(missd.Text);
                                    y = y + 1;
                                    missd.Text = y.ToString();
                                    f_null();
                                }


                            }



                        }

                        else if (tm1 == "Thug FC" && tm2 == "Aspire2")
                        {
                            int a4 = Convert.ToInt32(thugp.Text);
                            ++a4;
                            thugp.Text = a4.ToString();

                            int b4 = Convert.ToInt32(aspire2p.Text);
                            ++b4;
                            aspire2p.Text = b4.ToString();
                            if (score1 > score2)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(thugw.Text);
                                    x = x + 1;
                                    thugw.Text = x.ToString();

                                    int z = Convert.ToInt32(thugtp.Text);
                                    z = z + 3;
                                    thugtp.Text = z.ToString();

                                    int y = Convert.ToInt32(aspire2l.Text);
                                    y = y + 1;
                                    aspire2l.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 > score1)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(thugl.Text);
                                    x = x + 1;
                                    thugl.Text = x.ToString();

                                    int z = Convert.ToInt32(aspire2tp.Text);
                                    z = z + 3;
                                    aspire2tp.Text = z.ToString();

                                    int y = Convert.ToInt32(aspire2w.Text);
                                    y = y + 1;
                                    aspire2w.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 == score1)
                            {
                                DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(thugd.Text);
                                    x = x + 1;
                                    thugd.Text = x.ToString();

                                    int z = Convert.ToInt32(aspire2tp.Text);
                                    z = z + 1;
                                    aspire2tp.Text = z.ToString();

                                    int zz = Convert.ToInt32(thugtp.Text);
                                    zz = zz + 1;
                                    thugtp.Text = zz.ToString();

                                    int y = Convert.ToInt32(aspire2d.Text);
                                    y = y + 1;
                                    aspire2d.Text = y.ToString();
                                    f_null();
                                }


                            }



                        }
                        else if (tm1 == "Thug FC" && tm2 == "Gurka FC 2")
                        {
                            int a4 = Convert.ToInt32(thugp.Text);
                            ++a4;
                            thugp.Text = a4.ToString();

                            int b4 = Convert.ToInt32(gurka2p.Text);
                            ++b4;
                            gurka2p.Text = b4.ToString();
                            if (score1 > score2)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(thugw.Text);
                                    x = x + 1;
                                    thugw.Text = x.ToString();

                                    int z = Convert.ToInt32(thugtp.Text);
                                    z = z + 3;
                                    thugtp.Text = z.ToString();

                                    int y = Convert.ToInt32(gurka2l.Text);
                                    y = y + 1;
                                    gurka2l.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 > score1)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(thugl.Text);
                                    x = x + 1;
                                    thugl.Text = x.ToString();

                                    int z = Convert.ToInt32(gurka2tp.Text);
                                    z = z + 3;
                                    gurka2tp.Text = z.ToString();

                                    int y = Convert.ToInt32(gurka2w.Text);
                                    y = y + 1;
                                    gurka2w.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 == score1)
                            {
                                DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(thugd.Text);
                                    x = x + 1;
                                    thugd.Text = x.ToString();

                                    int z = Convert.ToInt32(gurka2tp.Text);
                                    z = z + 1;
                                    gurka2tp.Text = z.ToString();

                                    int zz = Convert.ToInt32(thugtp.Text);
                                    zz = zz + 1;
                                    thugtp.Text = zz.ToString();

                                    int y = Convert.ToInt32(gurka2d.Text);
                                    y = y + 1;
                                    gurka2d.Text = y.ToString();
                                    f_null();
                                }


                            }



                        }

                        else if (tm1 == "Thug FC" && tm2 == "Mayanks")
                        {
                            int a4 = Convert.ToInt32(thugp.Text);
                            ++a4;
                            thugp.Text = a4.ToString();

                            int b4 = Convert.ToInt32(mayanksp.Text);
                            ++b4;
                            mayanksp.Text = b4.ToString();
                            if (score1 > score2)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(thugw.Text);
                                    x = x + 1;
                                    thugw.Text = x.ToString();

                                    int z = Convert.ToInt32(thugtp.Text);
                                    z = z + 3;
                                    thugtp.Text = z.ToString();

                                    int y = Convert.ToInt32(mayanksl.Text);
                                    y = y + 1;
                                    mayanksl.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 > score1)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(thugl.Text);
                                    x = x + 1;
                                    thugl.Text = x.ToString();

                                    int z = Convert.ToInt32(mayankstp.Text);
                                    z = z + 3;
                                    mayankstp.Text = z.ToString();

                                    int y = Convert.ToInt32(mayanksw.Text);
                                    y = y + 1;
                                    mayanksw.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 == score1)
                            {
                                DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(thugd.Text);
                                    x = x + 1;
                                    thugd.Text = x.ToString();

                                    int z = Convert.ToInt32(mayankstp.Text);
                                    z = z + 1;
                                    mayankstp.Text = z.ToString();

                                    int zz = Convert.ToInt32(thugtp.Text);
                                    zz = zz + 1;
                                    thugtp.Text = zz.ToString();

                                    int y = Convert.ToInt32(mayanksd.Text);
                                    y = y + 1;
                                    mayanksd.Text = y.ToString();
                                    f_null();
                                }


                            }



                        }

                        // panel five
                        //
                        //five
                        //give

                        else if (tm1 == "Miss Fits" && tm2 == "Gurka FC")
                        {

                            int a5 = Convert.ToInt32(missp.Text);
                            ++a5;
                            missp.Text = a5.ToString();

                            int b5 = Convert.ToInt32(gurkap.Text);
                            ++b5;
                            gurkap.Text = b5.ToString();
                            if (score1 > score2)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(missw.Text);
                                    x = x + 1;
                                    missw.Text = x.ToString();

                                    int z = Convert.ToInt32(misstp.Text);
                                    z = z + 3;
                                    misstp.Text = z.ToString();

                                    int y = Convert.ToInt32(gurkal.Text);
                                    y = y + 1;
                                    gurkal.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 > score1)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(missl.Text);
                                    x = x + 1;
                                    missl.Text = x.ToString();

                                    int z = Convert.ToInt32(gurkatp.Text);
                                    z = z + 3;
                                    gurkatp.Text = z.ToString();

                                    int y = Convert.ToInt32(gurkaw.Text);
                                    y = y + 1;
                                    gurkaw.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 == score1)
                            {
                                DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(missd.Text);
                                    x = x + 1;
                                    missd.Text = x.ToString();

                                    int z = Convert.ToInt32(misstp.Text);
                                    z = z + 1;
                                    misstp.Text = z.ToString();

                                    int zz = Convert.ToInt32(gurkatp.Text);
                                    zz = zz + 1;
                                    gurkatp.Text = zz.ToString();

                                    int y = Convert.ToInt32(gurkad.Text);
                                    y = y + 1;
                                    gurkad.Text = y.ToString();
                                    f_null();
                                }


                            }

                        }

                        //second

                        else if (tm1 == "Miss Fits" && tm2 == "Panna")
                        {
                            int a5 = Convert.ToInt32(missp.Text);
                            ++a5;
                            missp.Text = a5.ToString();

                            int b5 = Convert.ToInt32(pannap.Text);
                            ++b5;
                            pannap.Text = b5.ToString();
                            if (score1 > score2)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(missw.Text);
                                    x = x + 1;
                                    missw.Text = x.ToString();

                                    int z = Convert.ToInt32(misstp.Text);
                                    z = z + 3;
                                    misstp.Text = z.ToString();

                                    int y = Convert.ToInt32(pannal.Text);
                                    y = y + 1;
                                    pannal.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 > score1)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(missl.Text);
                                    x = x + 1;
                                    missl.Text = x.ToString();

                                    int z = Convert.ToInt32(pannatp.Text);
                                    z = z + 3;
                                    pannatp.Text = z.ToString();

                                    int y = Convert.ToInt32(pannaw.Text);
                                    y = y + 1;
                                    pannaw.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 == score1)
                            {
                                DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(missd.Text);
                                    x = x + 1;
                                    missd.Text = x.ToString();

                                    int z = Convert.ToInt32(misstp.Text);
                                    z = z + 1;
                                    misstp.Text = z.ToString();

                                    int zz = Convert.ToInt32(pannatp.Text);
                                    zz = zz + 1;
                                    pannatp.Text = zz.ToString();

                                    int y = Convert.ToInt32(pannad.Text);
                                    y = y + 1;
                                    pannad.Text = y.ToString();
                                    f_null();
                                }


                            }
                        }
                        //next

                        else if (tm1 == "Miss Fits" && tm2 == "Kaplak FC")
                        {
                            int a5 = Convert.ToInt32(missp.Text);
                            ++a5;
                            missp.Text = a5.ToString();

                            int b5 = Convert.ToInt32(kaplakp.Text);
                            ++b5;
                            kaplakp.Text = b5.ToString();
                            if (score1 > score2)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(missw.Text);
                                    x = x + 1;
                                    missw.Text = x.ToString();

                                    int z = Convert.ToInt32(misstp.Text);
                                    z = z + 3;
                                    misstp.Text = z.ToString();

                                    int y = Convert.ToInt32(kaplakl.Text);
                                    y = y + 1;
                                    kaplakl.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 > score1)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(missl.Text);
                                    x = x + 1;
                                    missl.Text = x.ToString();

                                    int z = Convert.ToInt32(kaplaktp.Text);
                                    z = z + 3;
                                    kaplaktp.Text = z.ToString();

                                    int y = Convert.ToInt32(kaplakw.Text);
                                    y = y + 1;
                                    kaplakw.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 == score1)
                            {
                                DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(missd.Text);
                                    x = x + 1;
                                    missd.Text = x.ToString();

                                    int z = Convert.ToInt32(kaplaktp.Text);
                                    z = z + 1;
                                    kaplaktp.Text = z.ToString();

                                    int zz = Convert.ToInt32(misstp.Text);
                                    zz = zz + 1;
                                    misstp.Text = zz.ToString();

                                    int y = Convert.ToInt32(kaplakd.Text);
                                    y = y + 1;
                                    kaplakd.Text = y.ToString();
                                    f_null();
                                }


                            }
                        }

                        // next

                        else if (tm1 == "Miss Fits" && tm2 == "Thug FC")
                        {
                            int a5 = Convert.ToInt32(missp.Text);
                            ++a5;
                            missp.Text = a5.ToString();

                            int b5 = Convert.ToInt32(thugp.Text);
                            ++b5;
                            thugp.Text = b5.ToString();
                            if (score1 > score2)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(missw.Text);
                                    x = x + 1;
                                    missw.Text = x.ToString();

                                    int z = Convert.ToInt32(misstp.Text);
                                    z = z + 3;
                                    misstp.Text = z.ToString();

                                    int y = Convert.ToInt32(thugl.Text);
                                    y = y + 1;
                                    thugl.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 > score1)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(missl.Text);
                                    x = x + 1;
                                    missl.Text = x.ToString();

                                    int z = Convert.ToInt32(thugtp.Text);
                                    z = z + 3;
                                    thugtp.Text = z.ToString();

                                    int y = Convert.ToInt32(thugw.Text);
                                    y = y + 1;
                                    thugw.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 == score1)
                            {
                                DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(missd.Text);
                                    x = x + 1;
                                    missd.Text = x.ToString();

                                    int z = Convert.ToInt32(misstp.Text);
                                    z = z + 1;
                                    misstp.Text = z.ToString();

                                    int zz = Convert.ToInt32(thugtp.Text);
                                    zz = zz + 1;
                                    thugtp.Text = zz.ToString();

                                    int y = Convert.ToInt32(thugd.Text);
                                    y = y + 1;
                                    thugd.Text = y.ToString();
                                    f_null();
                                }


                            }



                        }

                        else if (tm1 == "Miss Fits" && tm2 == "Aspire2")
                        {
                            int a5 = Convert.ToInt32(missp.Text);
                            ++a5;
                            missp.Text = a5.ToString();

                            int b5 = Convert.ToInt32(aspire2p.Text);
                            ++b5;
                            aspire2p.Text = b5.ToString();
                            if (score1 > score2)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(missw.Text);
                                    x = x + 1;
                                    missw.Text = x.ToString();

                                    int z = Convert.ToInt32(misstp.Text);
                                    z = z + 3;
                                    misstp.Text = z.ToString();

                                    int y = Convert.ToInt32(aspire2l.Text);
                                    y = y + 1;
                                    aspire2l.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 > score1)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(missl.Text);
                                    x = x + 1;
                                    missl.Text = x.ToString();

                                    int z = Convert.ToInt32(aspire2tp.Text);
                                    z = z + 3;
                                    aspire2tp.Text = z.ToString();

                                    int y = Convert.ToInt32(aspire2w.Text);
                                    y = y + 1;
                                    aspire2w.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 == score1)
                            {
                                DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(missd.Text);
                                    x = x + 1;
                                    missd.Text = x.ToString();

                                    int z = Convert.ToInt32(aspire2tp.Text);
                                    z = z + 1;
                                    aspire2tp.Text = z.ToString();

                                    int zz = Convert.ToInt32(misstp.Text);
                                    zz = zz + 1;
                                    misstp.Text = zz.ToString();

                                    int y = Convert.ToInt32(aspire2d.Text);
                                    y = y + 1;
                                    aspire2d.Text = y.ToString();
                                    f_null();
                                }


                            }



                        }
                        else if (tm1 == "Miss Fits" && tm2 == "Gurka FC 2")
                        {
                            int a5 = Convert.ToInt32(missp.Text);
                            ++a5;
                            missp.Text = a5.ToString();

                            int b5 = Convert.ToInt32(gurka2p.Text);
                            ++b5;
                            gurka2p.Text = b5.ToString();
                            if (score1 > score2)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(missw.Text);
                                    x = x + 1;
                                    missw.Text = x.ToString();

                                    int z = Convert.ToInt32(misstp.Text);
                                    z = z + 3;
                                    misstp.Text = z.ToString();

                                    int y = Convert.ToInt32(gurka2l.Text);
                                    y = y + 1;
                                    gurka2l.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 > score1)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(missl.Text);
                                    x = x + 1;
                                    missl.Text = x.ToString();

                                    int z = Convert.ToInt32(gurka2tp.Text);
                                    z = z + 3;
                                    gurka2tp.Text = z.ToString();

                                    int y = Convert.ToInt32(gurka2w.Text);
                                    y = y + 1;
                                    gurka2w.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 == score1)
                            {
                                DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(missd.Text);
                                    x = x + 1;
                                    missd.Text = x.ToString();

                                    int z = Convert.ToInt32(gurka2tp.Text);
                                    z = z + 1;
                                    gurka2tp.Text = z.ToString();

                                    int zz = Convert.ToInt32(misstp.Text);
                                    zz = zz + 1;
                                    misstp.Text = zz.ToString();

                                    int y = Convert.ToInt32(gurka2d.Text);
                                    y = y + 1;
                                    gurka2d.Text = y.ToString();
                                    f_null();
                                }


                            }



                        }

                        else if (tm1 == "Miss Fits" && tm2 == "Mayanks")
                        {
                            int a5 = Convert.ToInt32(missp.Text);
                            ++a5;
                            missp.Text = a5.ToString();

                            int b5 = Convert.ToInt32(mayanksp.Text);
                            ++b5;
                            mayanksp.Text = b5.ToString();
                            if (score1 > score2)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(missw.Text);
                                    x = x + 1;
                                    missw.Text = x.ToString();

                                    int z = Convert.ToInt32(misstp.Text);
                                    z = z + 3;
                                    misstp.Text = z.ToString();

                                    int y = Convert.ToInt32(mayanksl.Text);
                                    y = y + 1;
                                    mayanksl.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 > score1)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(missl.Text);
                                    x = x + 1;
                                    missl.Text = x.ToString();

                                    int z = Convert.ToInt32(mayankstp.Text);
                                    z = z + 3;
                                    mayankstp.Text = z.ToString();

                                    int y = Convert.ToInt32(mayanksw.Text);
                                    y = y + 1;
                                    mayanksw.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 == score1)
                            {
                                DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(missd.Text);
                                    x = x + 1;
                                    missd.Text = x.ToString();

                                    int z = Convert.ToInt32(mayankstp.Text);
                                    z = z + 1;
                                    mayankstp.Text = z.ToString();

                                    int zz = Convert.ToInt32(misstp.Text);
                                    zz = zz + 1;
                                    misstp.Text = zz.ToString();

                                    int y = Convert.ToInt32(mayanksd.Text);
                                    y = y + 1;
                                    mayanksd.Text = y.ToString();
                                    f_null();
                                }


                            }



                        }


                        // panel sic
                        //six
                        //six
                        //six
                        //six


                        //sixxx
                        else if (tm1 == "Aspire2" && tm2 == "Gurka FC")
                        {
                            int a6 = Convert.ToInt32(aspire2p.Text);
                            ++a6;
                            aspire2p.Text = a6.ToString();

                            int b6 = Convert.ToInt32(gurkap.Text);
                            ++b6;
                            gurkap.Text = b6.ToString();
                            if (score1 > score2)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(aspire2w.Text);
                                    x = x + 1;
                                    aspire2w.Text = x.ToString();

                                    int z = Convert.ToInt32(aspire2tp.Text);
                                    z = z + 3;
                                    aspire2tp.Text = z.ToString();

                                    int y = Convert.ToInt32(gurkal.Text);
                                    y = y + 1;
                                    gurkal.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 > score1)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(aspire2l.Text);
                                    x = x + 1;
                                    aspire2l.Text = x.ToString();

                                    int z = Convert.ToInt32(gurkatp.Text);
                                    z = z + 3;
                                    gurkatp.Text = z.ToString();

                                    int y = Convert.ToInt32(gurkaw.Text);
                                    y = y + 1;
                                    gurkaw.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 == score1)
                            {
                                DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(aspire2d.Text);
                                    x = x + 1;
                                    aspire2d.Text = x.ToString();

                                    int z = Convert.ToInt32(aspire2tp.Text);
                                    z = z + 1;
                                    aspire2tp.Text = z.ToString();

                                    int zz = Convert.ToInt32(gurkatp.Text);
                                    zz = zz + 1;
                                    gurkatp.Text = zz.ToString();

                                    int y = Convert.ToInt32(gurkad.Text);
                                    y = y + 1;
                                    gurkad.Text = y.ToString();
                                    f_null();
                                }


                            }

                        }

                        //second

                        else if (tm1 == "Aspire2" && tm2 == "Panna")
                        {
                            int a6 = Convert.ToInt32(aspire2p.Text);
                            ++a6;
                            aspire2p.Text = a6.ToString();

                            int b6 = Convert.ToInt32(pannap.Text);
                            ++b6;
                            pannap.Text = b6.ToString();
                            if (score1 > score2)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(aspire2w.Text);
                                    x = x + 1;
                                    aspire2w.Text = x.ToString();

                                    int z = Convert.ToInt32(aspire2tp.Text);
                                    z = z + 3;
                                    aspire2tp.Text = z.ToString();

                                    int y = Convert.ToInt32(pannal.Text);
                                    y = y + 1;
                                    pannal.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 > score1)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(aspire2l.Text);
                                    x = x + 1;
                                    aspire2l.Text = x.ToString();

                                    int z = Convert.ToInt32(pannatp.Text);
                                    z = z + 3;
                                    pannatp.Text = z.ToString();

                                    int y = Convert.ToInt32(pannaw.Text);
                                    y = y + 1;
                                    pannaw.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 == score1)
                            {
                                DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(aspire2d.Text);
                                    x = x + 1;
                                    aspire2d.Text = x.ToString();

                                    int z = Convert.ToInt32(aspire2tp.Text);
                                    z = z + 1;
                                    aspire2tp.Text = z.ToString();

                                    int zz = Convert.ToInt32(pannatp.Text);
                                    zz = zz + 1;
                                    pannatp.Text = zz.ToString();

                                    int y = Convert.ToInt32(pannad.Text);
                                    y = y + 1;
                                    pannad.Text = y.ToString();
                                    f_null();
                                }


                            }
                        }
                        //next

                        else if (tm1 == "Aspire2" && tm2 == "Kaplak FC")
                        {
                            int a6 = Convert.ToInt32(aspire2p.Text);
                            ++a6;
                            aspire2p.Text = a6.ToString();

                            int b6 = Convert.ToInt32(kaplakp.Text);
                            ++b6;
                            kaplakp.Text = b6.ToString();
                            if (score1 > score2)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(aspire2w.Text);
                                    x = x + 1;
                                    aspire2w.Text = x.ToString();

                                    int z = Convert.ToInt32(aspire2tp.Text);
                                    z = z + 3;
                                    aspire2tp.Text = z.ToString();

                                    int y = Convert.ToInt32(kaplakl.Text);
                                    y = y + 1;
                                    kaplakl.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 > score1)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(aspire2l.Text);
                                    x = x + 1;
                                    aspire2l.Text = x.ToString();

                                    int z = Convert.ToInt32(kaplaktp.Text);
                                    z = z + 3;
                                    kaplaktp.Text = z.ToString();

                                    int y = Convert.ToInt32(kaplakw.Text);
                                    y = y + 1;
                                    kaplakw.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 == score1)
                            {
                                DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(aspire2d.Text);
                                    x = x + 1;
                                    aspire2d.Text = x.ToString();

                                    int z = Convert.ToInt32(kaplaktp.Text);
                                    z = z + 1;
                                    kaplaktp.Text = z.ToString();

                                    int zz = Convert.ToInt32(aspire2tp.Text);
                                    zz = zz + 1;
                                    aspire2tp.Text = zz.ToString();

                                    int y = Convert.ToInt32(kaplakd.Text);
                                    y = y + 1;
                                    kaplakd.Text = y.ToString();
                                    f_null();
                                }


                            }
                        }

                        // next

                        else if (tm1 == "Aspire2" && tm2 == "Thug FC")
                        {
                            int a6 = Convert.ToInt32(aspire2p.Text);
                            ++a6;
                            aspire2p.Text = a6.ToString();

                            int b6 = Convert.ToInt32(thugp.Text);
                            ++b6;
                            thugp.Text = b6.ToString();
                            if (score1 > score2)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(aspire2w.Text);
                                    x = x + 1;
                                    aspire2w.Text = x.ToString();

                                    int z = Convert.ToInt32(aspire2tp.Text);
                                    z = z + 3;
                                    aspire2tp.Text = z.ToString();

                                    int y = Convert.ToInt32(thugl.Text);
                                    y = y + 1;
                                    thugl.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 > score1)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(aspire2l.Text);
                                    x = x + 1;
                                    aspire2l.Text = x.ToString();

                                    int z = Convert.ToInt32(thugtp.Text);
                                    z = z + 3;
                                    thugtp.Text = z.ToString();

                                    int y = Convert.ToInt32(thugw.Text);
                                    y = y + 1;
                                    thugw.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 == score1)
                            {
                                DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(aspire2d.Text);
                                    x = x + 1;
                                    aspire2d.Text = x.ToString();

                                    int z = Convert.ToInt32(aspire2tp.Text);
                                    z = z + 1;
                                    aspire2tp.Text = z.ToString();

                                    int zz = Convert.ToInt32(thugtp.Text);
                                    zz = zz + 1;
                                    thugtp.Text = zz.ToString();

                                    int y = Convert.ToInt32(thugd.Text);
                                    y = y + 1;
                                    thugd.Text = y.ToString();
                                    f_null();
                                }


                            }



                        }

                        else if (tm1 == "Aspire2" && tm2 == "Miss Fits")
                        {
                            int a6 = Convert.ToInt32(aspire2p.Text);
                            ++a6;
                            aspire2p.Text = a6.ToString();

                            int b6 = Convert.ToInt32(missp.Text);
                            ++b6;
                            missp.Text = b6.ToString();
                            if (score1 > score2)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(aspire2w.Text);
                                    x = x + 1;
                                    aspire2w.Text = x.ToString();

                                    int z = Convert.ToInt32(aspire2tp.Text);
                                    z = z + 3;
                                    aspire2tp.Text = z.ToString();

                                    int y = Convert.ToInt32(missl.Text);
                                    y = y + 1;
                                    missl.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 > score1)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(aspire2l.Text);
                                    x = x + 1;
                                    aspire2l.Text = x.ToString();

                                    int z = Convert.ToInt32(misstp.Text);
                                    z = z + 3;
                                    misstp.Text = z.ToString();

                                    int y = Convert.ToInt32(missw.Text);
                                    y = y + 1;
                                    missw.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 == score1)
                            {
                                DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(aspire2d.Text);
                                    x = x + 1;
                                    aspire2d.Text = x.ToString();

                                    int z = Convert.ToInt32(aspire2tp.Text);
                                    z = z + 1;
                                    aspire2tp.Text = z.ToString();

                                    int zz = Convert.ToInt32(misstp.Text);
                                    zz = zz + 1;
                                    misstp.Text = zz.ToString();

                                    int y = Convert.ToInt32(missd.Text);
                                    y = y + 1;
                                    missd.Text = y.ToString();
                                    f_null();
                                }


                            }



                        }
                        else if (tm1 == "Aspire2" && tm2 == "Gurka FC 2")
                        {
                            int a6 = Convert.ToInt32(aspire2p.Text);
                            ++a6;
                            aspire2p.Text = a6.ToString();

                            int b6 = Convert.ToInt32(gurka2p.Text);
                            ++b6;
                            gurka2p.Text = b6.ToString();
                            if (score1 > score2)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(aspire2w.Text);
                                    x = x + 1;
                                    aspire2w.Text = x.ToString();

                                    int z = Convert.ToInt32(aspire2tp.Text);
                                    z = z + 3;
                                    aspire2tp.Text = z.ToString();

                                    int y = Convert.ToInt32(gurka2l.Text);
                                    y = y + 1;
                                    gurka2l.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 > score1)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(aspire2l.Text);
                                    x = x + 1;
                                    aspire2l.Text = x.ToString();

                                    int z = Convert.ToInt32(gurka2tp.Text);
                                    z = z + 3;
                                    gurka2tp.Text = z.ToString();

                                    int y = Convert.ToInt32(gurka2w.Text);
                                    y = y + 1;
                                    gurka2w.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 == score1)
                            {
                                DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(aspire2d.Text);
                                    x = x + 1;
                                    aspire2d.Text = x.ToString();

                                    int z = Convert.ToInt32(gurka2tp.Text);
                                    z = z + 1;
                                    gurka2tp.Text = z.ToString();

                                    int zz = Convert.ToInt32(aspire2tp.Text);
                                    zz = zz + 1;
                                    aspire2tp.Text = zz.ToString();

                                    int y = Convert.ToInt32(gurka2d.Text);
                                    y = y + 1;
                                    gurka2d.Text = y.ToString();
                                    f_null();
                                }


                            }



                        }

                        else if (tm1 == "Aspire2" && tm2 == "Mayanks")
                        {
                            int a6 = Convert.ToInt32(aspire2p.Text);
                            ++a6;
                            aspire2p.Text = a6.ToString();

                            int b6 = Convert.ToInt32(mayanksp.Text);
                            ++b6;
                            mayanksp.Text = b6.ToString();
                            if (score1 > score2)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(aspire2w.Text);
                                    x = x + 1;
                                    aspire2w.Text = x.ToString();

                                    int z = Convert.ToInt32(aspire2tp.Text);
                                    z = z + 3;
                                    aspire2tp.Text = z.ToString();

                                    int y = Convert.ToInt32(mayanksl.Text);
                                    y = y + 1;
                                    mayanksl.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 > score1)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(aspire2l.Text);
                                    x = x + 1;
                                    aspire2l.Text = x.ToString();

                                    int z = Convert.ToInt32(mayankstp.Text);
                                    z = z + 3;
                                    mayankstp.Text = z.ToString();

                                    int y = Convert.ToInt32(mayanksw.Text);
                                    y = y + 1;
                                    mayanksw.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 == score1)
                            {
                                DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(aspire2d.Text);
                                    x = x + 1;
                                    aspire2d.Text = x.ToString();

                                    int z = Convert.ToInt32(mayankstp.Text);
                                    z = z + 1;
                                    mayankstp.Text = z.ToString();

                                    int zz = Convert.ToInt32(aspire2tp.Text);
                                    zz = zz + 1;
                                    aspire2tp.Text = zz.ToString();

                                    int y = Convert.ToInt32(mayanksd.Text);
                                    y = y + 1;
                                    mayanksd.Text = y.ToString();
                                    f_null();
                                }


                            }



                        }
                        //seven
                        // seven

                        // seven
                        //seven

                        else if (tm1 == "Gurka FC 2" && tm2 == "Gurka FC")
                        {
                            int a7 = Convert.ToInt32(gurka2p.Text);
                            ++a7;
                            gurka2p.Text = a7.ToString();

                            int b7 = Convert.ToInt32(gurkap.Text);
                            ++b7;
                            gurkap.Text = b7.ToString();
                            if (score1 > score2)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(gurka2w.Text);
                                    x = x + 1;
                                    gurka2w.Text = x.ToString();

                                    int z = Convert.ToInt32(gurka2tp.Text);
                                    z = z + 3;
                                    gurka2tp.Text = z.ToString();

                                    int y = Convert.ToInt32(gurkal.Text);
                                    y = y + 1;
                                    gurkal.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 > score1)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(gurka2l.Text);
                                    x = x + 1;
                                    gurka2l.Text = x.ToString();

                                    int z = Convert.ToInt32(gurkatp.Text);
                                    z = z + 3;
                                    gurkatp.Text = z.ToString();

                                    int y = Convert.ToInt32(gurkaw.Text);
                                    y = y + 1;
                                    gurkaw.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 == score1)
                            {
                                DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(gurka2d.Text);
                                    x = x + 1;
                                    gurka2d.Text = x.ToString();

                                    int z = Convert.ToInt32(gurka2tp.Text);
                                    z = z + 1;
                                    gurka2tp.Text = z.ToString();

                                    int zz = Convert.ToInt32(gurkatp.Text);
                                    zz = zz + 1;
                                    gurkatp.Text = zz.ToString();

                                    int y = Convert.ToInt32(gurkad.Text);
                                    y = y + 1;
                                    gurkad.Text = y.ToString();
                                    f_null();
                                }


                            }

                        }

                        //second

                        else if (tm1 == "Gurka FC 2" && tm2 == "Panna")
                        {
                            int a7 = Convert.ToInt32(gurka2p.Text);
                            ++a7;
                            gurka2p.Text = a7.ToString();

                            int b7 = Convert.ToInt32(pannap.Text);
                            ++b7;
                            pannap.Text = b7.ToString();
                            if (score1 > score2)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(gurka2w.Text);
                                    x = x + 1;
                                    gurka2w.Text = x.ToString();

                                    int z = Convert.ToInt32(gurka2tp.Text);
                                    z = z + 3;
                                    gurka2tp.Text = z.ToString();

                                    int y = Convert.ToInt32(pannal.Text);
                                    y = y + 1;
                                    pannal.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 > score1)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(gurka2l.Text);
                                    x = x + 1;
                                    gurka2l.Text = x.ToString();

                                    int z = Convert.ToInt32(pannatp.Text);
                                    z = z + 3;
                                    pannatp.Text = z.ToString();

                                    int y = Convert.ToInt32(pannaw.Text);
                                    y = y + 1;
                                    pannaw.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 == score1)
                            {
                                DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(gurka2d.Text);
                                    x = x + 1;
                                    gurka2d.Text = x.ToString();

                                    int z = Convert.ToInt32(gurka2tp.Text);
                                    z = z + 1;
                                    gurka2tp.Text = z.ToString();

                                    int zz = Convert.ToInt32(pannatp.Text);
                                    zz = zz + 1;
                                    pannatp.Text = zz.ToString();

                                    int y = Convert.ToInt32(pannad.Text);
                                    y = y + 1;
                                    pannad.Text = y.ToString();
                                    f_null();
                                }


                            }
                        }
                        //next

                        else if (tm1 == "Gurka FC 2" && tm2 == "Kaplak FC")
                        {
                            int a7 = Convert.ToInt32(gurka2p.Text);
                            ++a7;
                            gurka2p.Text = a7.ToString();

                            int b7 = Convert.ToInt32(kaplakp.Text);
                            ++b7;
                            kaplakp.Text = b7.ToString();
                            if (score1 > score2)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(gurka2w.Text);
                                    x = x + 1;
                                    gurka2w.Text = x.ToString();

                                    int z = Convert.ToInt32(gurka2tp.Text);
                                    z = z + 3;
                                    gurka2tp.Text = z.ToString();

                                    int y = Convert.ToInt32(kaplakl.Text);
                                    y = y + 1;
                                    kaplakl.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 > score1)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(gurka2l.Text);
                                    x = x + 1;
                                    gurka2l.Text = x.ToString();

                                    int z = Convert.ToInt32(kaplaktp.Text);
                                    z = z + 3;
                                    kaplaktp.Text = z.ToString();

                                    int y = Convert.ToInt32(kaplakw.Text);
                                    y = y + 1;
                                    kaplakw.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 == score1)
                            {
                                DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(gurka2d.Text);
                                    x = x + 1;
                                    gurka2d.Text = x.ToString();

                                    int z = Convert.ToInt32(kaplaktp.Text);
                                    z = z + 1;
                                    kaplaktp.Text = z.ToString();

                                    int zz = Convert.ToInt32(gurka2tp.Text);
                                    zz = zz + 1;
                                    gurka2tp.Text = zz.ToString();

                                    int y = Convert.ToInt32(kaplakd.Text);
                                    y = y + 1;
                                    kaplakd.Text = y.ToString();
                                    f_null();
                                }


                            }
                        }

                        // next

                        else if (tm1 == "Gurka FC 2" && tm2 == "Thug FC")
                        {
                            int a7 = Convert.ToInt32(gurka2p.Text);
                            ++a7;
                            gurka2p.Text = a7.ToString();

                            int b7 = Convert.ToInt32(thugp.Text);
                            ++b7;
                            thugp.Text = b7.ToString();
                            if (score1 > score2)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(gurka2w.Text);
                                    x = x + 1;
                                    gurka2w.Text = x.ToString();

                                    int z = Convert.ToInt32(gurka2tp.Text);
                                    z = z + 3;
                                    gurka2tp.Text = z.ToString();

                                    int y = Convert.ToInt32(thugl.Text);
                                    y = y + 1;
                                    thugl.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 > score1)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(gurka2l.Text);
                                    x = x + 1;
                                    gurka2l.Text = x.ToString();

                                    int z = Convert.ToInt32(thugtp.Text);
                                    z = z + 3;
                                    thugtp.Text = z.ToString();

                                    int y = Convert.ToInt32(thugw.Text);
                                    y = y + 1;
                                    thugw.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 == score1)
                            {
                                DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(gurka2d.Text);
                                    x = x + 1;
                                    gurka2d.Text = x.ToString();

                                    int z = Convert.ToInt32(gurka2tp.Text);
                                    z = z + 1;
                                    gurka2tp.Text = z.ToString();

                                    int zz = Convert.ToInt32(thugtp.Text);
                                    zz = zz + 1;
                                    thugtp.Text = zz.ToString();

                                    int y = Convert.ToInt32(thugd.Text);
                                    y = y + 1;
                                    thugd.Text = y.ToString();
                                    f_null();
                                }


                            }



                        }

                        else if (tm1 == "Gurka FC 2" && tm2 == "Miss Fits")
                        {
                            int a7 = Convert.ToInt32(gurka2p.Text);
                            ++a7;
                            gurka2p.Text = a7.ToString();

                            int b7 = Convert.ToInt32(missp.Text);
                            ++b7;
                            missp.Text = b7.ToString();
                            if (score1 > score2)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(gurka2w.Text);
                                    x = x + 1;
                                    gurka2w.Text = x.ToString();

                                    int z = Convert.ToInt32(gurka2tp.Text);
                                    z = z + 3;
                                    gurka2tp.Text = z.ToString();

                                    int y = Convert.ToInt32(missl.Text);
                                    y = y + 1;
                                    missl.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 > score1)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(gurka2l.Text);
                                    x = x + 1;
                                    gurka2l.Text = x.ToString();

                                    int z = Convert.ToInt32(misstp.Text);
                                    z = z + 3;
                                    misstp.Text = z.ToString();

                                    int y = Convert.ToInt32(missw.Text);
                                    y = y + 1;
                                    missw.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 == score1)
                            {
                                DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(gurka2d.Text);
                                    x = x + 1;
                                    gurka2d.Text = x.ToString();

                                    int z = Convert.ToInt32(gurka2tp.Text);
                                    z = z + 1;
                                    gurka2tp.Text = z.ToString();

                                    int zz = Convert.ToInt32(misstp.Text);
                                    zz = zz + 1;
                                    misstp.Text = zz.ToString();

                                    int y = Convert.ToInt32(missd.Text);
                                    y = y + 1;
                                    missd.Text = y.ToString();
                                    f_null();
                                }


                            }



                        }
                        else if (tm1 == "Gurka FC 2" && tm2 == "Aspire2")
                        {
                            int a7 = Convert.ToInt32(gurka2p.Text);
                            ++a7;
                            gurka2p.Text = a7.ToString();

                            int b7 = Convert.ToInt32(aspire2p.Text);
                            ++b7;
                            aspire2p.Text = b7.ToString();
                            if (score1 > score2)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(gurka2w.Text);
                                    x = x + 1;
                                    gurka2w.Text = x.ToString();

                                    int z = Convert.ToInt32(gurka2tp.Text);
                                    z = z + 3;
                                    gurka2tp.Text = z.ToString();

                                    int y = Convert.ToInt32(aspire2l.Text);
                                    y = y + 1;
                                    aspire2l.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 > score1)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(gurka2l.Text);
                                    x = x + 1;
                                    gurka2l.Text = x.ToString();

                                    int z = Convert.ToInt32(aspire2tp.Text);
                                    z = z + 3;
                                    aspire2tp.Text = z.ToString();

                                    int y = Convert.ToInt32(aspire2w.Text);
                                    y = y + 1;
                                    aspire2w.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 == score1)
                            {
                                DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(gurka2d.Text);
                                    x = x + 1;
                                    gurka2d.Text = x.ToString();

                                    int z = Convert.ToInt32(gurka2tp.Text);
                                    z = z + 1;
                                    gurka2tp.Text = z.ToString();

                                    int zz = Convert.ToInt32(aspire2tp.Text);
                                    zz = zz + 1;
                                    aspire2tp.Text = zz.ToString();

                                    int y = Convert.ToInt32(aspire2d.Text);
                                    y = y + 1;
                                    aspire2d.Text = y.ToString();
                                    f_null();
                                }


                            }



                        }

                        else if (tm1 == "Gurka FC 2" && tm2 == "Mayanks")
                        {
                            int a7 = Convert.ToInt32(gurka2p.Text);
                            ++a7;
                            gurka2p.Text = a7.ToString();

                            int b7 = Convert.ToInt32(mayanksp.Text);
                            ++b7;
                            mayanksp.Text = b7.ToString();
                            if (score1 > score2)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(gurka2w.Text);
                                    x = x + 1;
                                    gurka2w.Text = x.ToString();

                                    int z = Convert.ToInt32(gurka2tp.Text);
                                    z = z + 3;
                                    gurka2tp.Text = z.ToString();

                                    int y = Convert.ToInt32(mayanksl.Text);
                                    y = y + 1;
                                    mayanksl.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 > score1)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(gurka2l.Text);
                                    x = x + 1;
                                    gurka2l.Text = x.ToString();

                                    int z = Convert.ToInt32(mayankstp.Text);
                                    z = z + 3;
                                    mayankstp.Text = z.ToString();

                                    int y = Convert.ToInt32(mayanksw.Text);
                                    y = y + 1;
                                    mayanksw.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 == score1)
                            {
                                DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(gurka2d.Text);
                                    x = x + 1;
                                    gurka2d.Text = x.ToString();

                                    int z = Convert.ToInt32(mayankstp.Text);
                                    z = z + 1;
                                    mayankstp.Text = z.ToString();

                                    int zz = Convert.ToInt32(gurka2tp.Text);
                                    zz = zz + 1;
                                    gurka2tp.Text = zz.ToString();

                                    int y = Convert.ToInt32(mayanksd.Text);
                                    y = y + 1;
                                    mayanksd.Text = y.ToString();
                                    f_null();
                                }


                            }



                        }
                        //eight
                        //eight

                        //eight
                        //eight
                        else if (tm1 == "Mayanks" && tm2 == "Gurka FC")
                        {
                            int a8 = Convert.ToInt32(mayanksp.Text);
                            ++a8;
                            mayanksp.Text = a8.ToString();

                            int b8 = Convert.ToInt32(gurkap.Text);
                            ++b8;
                            gurkap.Text = b8.ToString();
                            if (score1 > score2)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(mayanksw.Text);
                                    x = x + 1;
                                    mayanksw.Text = x.ToString();

                                    int z = Convert.ToInt32(mayankstp.Text);
                                    z = z + 3;
                                    mayankstp.Text = z.ToString();

                                    int y = Convert.ToInt32(gurkal.Text);
                                    y = y + 1;
                                    gurkal.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 > score1)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(mayanksl.Text);
                                    x = x + 1;
                                    mayanksl.Text = x.ToString();

                                    int z = Convert.ToInt32(gurkatp.Text);
                                    z = z + 3;
                                    gurkatp.Text = z.ToString();

                                    int y = Convert.ToInt32(gurkaw.Text);
                                    y = y + 1;
                                    gurkaw.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 == score1)
                            {
                                DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(mayanksd.Text);
                                    x = x + 1;
                                    mayanksd.Text = x.ToString();

                                    int z = Convert.ToInt32(mayankstp.Text);
                                    z = z + 1;
                                    mayankstp.Text = z.ToString();

                                    int zz = Convert.ToInt32(gurkatp.Text);
                                    zz = zz + 1;
                                    gurkatp.Text = zz.ToString();

                                    int y = Convert.ToInt32(gurkad.Text);
                                    y = y + 1;
                                    gurkad.Text = y.ToString();
                                    f_null();
                                }


                            }

                        }

                        //second

                        else if (tm1 == "Mayanks" && tm2 == "Panna")
                        {
                            int a8 = Convert.ToInt32(mayanksp.Text);
                            ++a8;
                            mayanksp.Text = a8.ToString();

                            int b8 = Convert.ToInt32(pannap.Text);
                            ++b8;
                            pannap.Text = b8.ToString();
                            if (score1 > score2)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(mayanksw.Text);
                                    x = x + 1;
                                    mayanksw.Text = x.ToString();

                                    int z = Convert.ToInt32(mayankstp.Text);
                                    z = z + 3;
                                    mayankstp.Text = z.ToString();

                                    int y = Convert.ToInt32(pannal.Text);
                                    y = y + 1;
                                    pannal.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 > score1)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(mayanksl.Text);
                                    x = x + 1;
                                    mayanksl.Text = x.ToString();

                                    int z = Convert.ToInt32(pannatp.Text);
                                    z = z + 3;
                                    pannatp.Text = z.ToString();

                                    int y = Convert.ToInt32(pannaw.Text);
                                    y = y + 1;
                                    pannaw.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 == score1)
                            {
                                DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(mayanksd.Text);
                                    x = x + 1;
                                    mayanksd.Text = x.ToString();

                                    int z = Convert.ToInt32(mayankstp.Text);
                                    z = z + 1;
                                    mayankstp.Text = z.ToString();

                                    int zz = Convert.ToInt32(pannatp.Text);
                                    zz = zz + 1;
                                    pannatp.Text = zz.ToString();

                                    int y = Convert.ToInt32(pannad.Text);
                                    y = y + 1;
                                    pannad.Text = y.ToString();
                                    f_null();
                                }


                            }
                        }
                        //next

                        else if (tm1 == "Mayanks" && tm2 == "Kaplak FC")
                        {
                            int a8 = Convert.ToInt32(mayanksp.Text);
                            ++a8;
                            mayanksp.Text = a8.ToString();

                            int b8 = Convert.ToInt32(kaplakp.Text);
                            ++b8;
                            kaplakp.Text = b8.ToString();
                            if (score1 > score2)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(mayanksw.Text);
                                    x = x + 1;
                                    mayanksw.Text = x.ToString();

                                    int z = Convert.ToInt32(mayankstp.Text);
                                    z = z + 3;
                                    mayankstp.Text = z.ToString();

                                    int y = Convert.ToInt32(kaplakl.Text);
                                    y = y + 1;
                                    kaplakl.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 > score1)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(mayanksl.Text);
                                    x = x + 1;
                                    mayanksl.Text = x.ToString();

                                    int z = Convert.ToInt32(kaplaktp.Text);
                                    z = z + 3;
                                    kaplaktp.Text = z.ToString();

                                    int y = Convert.ToInt32(kaplakw.Text);
                                    y = y + 1;
                                    kaplakw.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 == score1)
                            {
                                DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(mayanksd.Text);
                                    x = x + 1;
                                    mayanksd.Text = x.ToString();

                                    int z = Convert.ToInt32(kaplaktp.Text);
                                    z = z + 1;
                                    kaplaktp.Text = z.ToString();

                                    int zz = Convert.ToInt32(mayankstp.Text);
                                    zz = zz + 1;
                                    mayankstp.Text = zz.ToString();

                                    int y = Convert.ToInt32(kaplakd.Text);
                                    y = y + 1;
                                    kaplakd.Text = y.ToString();
                                    f_null();
                                }


                            }
                        }

                        // next

                        else if (tm1 == "Mayanks" && tm2 == "Thug FC")
                        {
                            int a8 = Convert.ToInt32(mayanksp.Text);
                            ++a8;
                            mayanksp.Text = a8.ToString();

                            int b8 = Convert.ToInt32(thugp.Text);
                            ++b8;
                            thugp.Text = b8.ToString();
                            if (score1 > score2)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(mayanksw.Text);
                                    x = x + 1;
                                    mayanksw.Text = x.ToString();

                                    int z = Convert.ToInt32(mayankstp.Text);
                                    z = z + 3;
                                    mayankstp.Text = z.ToString();

                                    int y = Convert.ToInt32(thugl.Text);
                                    y = y + 1;
                                    thugl.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 > score1)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(mayanksl.Text);
                                    x = x + 1;
                                    mayanksl.Text = x.ToString();

                                    int z = Convert.ToInt32(thugtp.Text);
                                    z = z + 3;
                                    thugtp.Text = z.ToString();

                                    int y = Convert.ToInt32(thugw.Text);
                                    y = y + 1;
                                    thugw.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 == score1)
                            {
                                DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(mayanksd.Text);
                                    x = x + 1;
                                    mayanksd.Text = x.ToString();

                                    int z = Convert.ToInt32(mayankstp.Text);
                                    z = z + 1;
                                    mayankstp.Text = z.ToString();

                                    int zz = Convert.ToInt32(thugtp.Text);
                                    zz = zz + 1;
                                    thugtp.Text = zz.ToString();

                                    int y = Convert.ToInt32(thugd.Text);
                                    y = y + 1;
                                    thugd.Text = y.ToString();
                                    f_null();
                                }


                            }



                        }

                        else if (tm1 == "Mayanks" && tm2 == "Miss Fits")
                        {
                            int a8 = Convert.ToInt32(mayanksp.Text);
                            ++a8;
                            mayanksp.Text = a8.ToString();

                            int b8 = Convert.ToInt32(missp.Text);
                            ++b8;
                            missp.Text = b8.ToString();
                            if (score1 > score2)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(mayanksw.Text);
                                    x = x + 1;
                                    mayanksw.Text = x.ToString();

                                    int z = Convert.ToInt32(mayankstp.Text);
                                    z = z + 3;
                                    mayankstp.Text = z.ToString();

                                    int y = Convert.ToInt32(missl.Text);
                                    y = y + 1;
                                    missl.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 > score1)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(mayanksl.Text);
                                    x = x + 1;
                                    mayanksl.Text = x.ToString();

                                    int z = Convert.ToInt32(misstp.Text);
                                    z = z + 3;
                                    misstp.Text = z.ToString();

                                    int y = Convert.ToInt32(missw.Text);
                                    y = y + 1;
                                    missw.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 == score1)
                            {
                                DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(mayanksd.Text);
                                    x = x + 1;
                                    mayanksd.Text = x.ToString();

                                    int z = Convert.ToInt32(mayankstp.Text);
                                    z = z + 1;
                                    mayankstp.Text = z.ToString();

                                    int zz = Convert.ToInt32(misstp.Text);
                                    zz = zz + 1;
                                    misstp.Text = zz.ToString();

                                    int y = Convert.ToInt32(missd.Text);
                                    y = y + 1;
                                    missd.Text = y.ToString();
                                    f_null();
                                }


                            }



                        }
                        else if (tm1 == "Mayanks" && tm2 == "Aspire2")
                        {
                            int a8 = Convert.ToInt32(mayanksp.Text);
                            ++a8;
                            mayanksp.Text = a8.ToString();

                            int b8 = Convert.ToInt32(aspire2p.Text);
                            ++b8;
                            aspire2p.Text = b8.ToString();
                            if (score1 > score2)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(mayanksw.Text);
                                    x = x + 1;
                                    mayanksw.Text = x.ToString();

                                    int z = Convert.ToInt32(mayankstp.Text);
                                    z = z + 3;
                                    mayankstp.Text = z.ToString();

                                    int y = Convert.ToInt32(aspire2l.Text);
                                    y = y + 1;
                                    aspire2l.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 > score1)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(mayanksl.Text);
                                    x = x + 1;
                                    mayanksl.Text = x.ToString();

                                    int z = Convert.ToInt32(aspire2tp.Text);
                                    z = z + 3;
                                    aspire2tp.Text = z.ToString();

                                    int y = Convert.ToInt32(aspire2w.Text);
                                    y = y + 1;
                                    aspire2w.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 == score1)
                            {
                                DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(mayanksd.Text);
                                    x = x + 1;
                                    mayanksd.Text = x.ToString();

                                    int z = Convert.ToInt32(mayankstp.Text);
                                    z = z + 1;
                                    mayankstp.Text = z.ToString();

                                    int zz = Convert.ToInt32(aspire2tp.Text);
                                    zz = zz + 1;
                                    aspire2tp.Text = zz.ToString();

                                    int y = Convert.ToInt32(aspire2d.Text);
                                    y = y + 1;
                                    aspire2d.Text = y.ToString();
                                    f_null();
                                }


                            }



                        }

                        else if (tm1 == "Mayanks" && tm2 == "Gurka FC 2")
                        {
                            int a8 = Convert.ToInt32(mayanksp.Text);
                            ++a8;
                            mayanksp.Text = a8.ToString();

                            int b8 = Convert.ToInt32(gurka2p.Text);
                            ++b8;
                            gurka2p.Text = b8.ToString();
                            if (score1 > score2)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm1 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(mayanksw.Text);
                                    x = x + 1;
                                    mayanksw.Text = x.ToString();

                                    int z = Convert.ToInt32(mayankstp.Text);
                                    z = z + 3;
                                    mayankstp.Text = z.ToString();

                                    int y = Convert.ToInt32(gurka2l.Text);
                                    y = y + 1;
                                    gurka2l.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 > score1)
                            {
                                DialogResult result = MessageBox.Show("Team " + tm2 + " won the match", "Winner", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(mayanksl.Text);
                                    x = x + 1;
                                    mayanksl.Text = x.ToString();

                                    int z = Convert.ToInt32(gurka2tp.Text);
                                    z = z + 3;
                                    gurka2tp.Text = z.ToString();

                                    int y = Convert.ToInt32(gurka2w.Text);
                                    y = y + 1;
                                    gurka2w.Text = y.ToString();
                                    f_null();
                                }


                            }
                            else if (score2 == score1)
                            {
                                DialogResult result = MessageBox.Show("The match was DRAW", "Draw", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    int x = Convert.ToInt32(mayanksd.Text);
                                    x = x + 1;
                                    mayanksd.Text = x.ToString();

                                    int z = Convert.ToInt32(mayankstp.Text);
                                    z = z + 1;
                                    mayankstp.Text = z.ToString();

                                    int zz = Convert.ToInt32(gurka2tp.Text);
                                    zz = zz + 1;
                                    gurka2tp.Text = zz.ToString();

                                    int y = Convert.ToInt32(gurka2d.Text);
                                    y = y + 1;
                                    gurka2d.Text = y.ToString();
                                    f_null();
                                }


                            }



                        }






                    }
                }

                SaveSetting();
            }
            

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            NewTeam newt = new NewTeam();
            newt.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            gurkaw.ReadOnly = false;
            gurkal.ReadOnly = false;
            gurkad.ReadOnly = false;
            gurkatp.ReadOnly = false;
            gurkap.ReadOnly = false;

            gurkaw.BackColor = Color.DarkGray;
            gurkal.BackColor = Color.DarkGray;
            gurkad.BackColor = Color.DarkGray;
            gurkatp.BackColor = Color.DarkGray;
            gurkap.BackColor = Color.DarkGray;

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            pannaw.ReadOnly = false;
            pannal.ReadOnly = false;
            pannad.ReadOnly = false;
            pannatp.ReadOnly = false;
            pannap.ReadOnly = false;

            pannaw.BackColor = Color.DarkGray;
            pannal.BackColor = Color.DarkGray;
            pannad.BackColor = Color.DarkGray;
            pannatp.BackColor = Color.DarkGray;
            pannap.BackColor = Color.DarkGray;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            kaplakw.ReadOnly = false;
            kaplakl.ReadOnly = false;
            kaplakd.ReadOnly = false;
            kaplaktp.ReadOnly = false;
            kaplakp.ReadOnly = false;

            kaplakw.BackColor = Color.DarkGray;
            kaplakl.BackColor = Color.DarkGray;
            kaplakd.BackColor = Color.DarkGray;
            kaplaktp.BackColor = Color.DarkGray;
            kaplakp.BackColor = Color.DarkGray;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            SaveSetting();
            gurkaw.ReadOnly = true;
            gurkal.ReadOnly = true;
            gurkad.ReadOnly = true;
            gurkatp.ReadOnly = true;
            gurkap.ReadOnly = true;

            gurkaw.BackColor = Color.White;
            gurkal.BackColor = Color.White;
            gurkad.BackColor = Color.White;
            gurkatp.BackColor = Color.White;
            gurkap.BackColor = Color.White;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            SaveSetting();
            pannaw.ReadOnly = true;
            pannal.ReadOnly = true;
            pannad.ReadOnly = true;
            pannatp.ReadOnly = true;
            pannap.ReadOnly = true;

            pannaw.BackColor = Color.White;
            pannal.BackColor = Color.White;
            pannad.BackColor = Color.White;
            pannatp.BackColor = Color.White;
            pannap.BackColor = Color.White;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            SaveSetting();
            kaplakw.ReadOnly = true;
            kaplakl.ReadOnly = true;
            kaplakd.ReadOnly = true;
            kaplaktp.ReadOnly = true;
            kaplakp.ReadOnly = true;

            kaplakw.BackColor = Color.White;
            kaplakl.BackColor = Color.White;
            kaplakd.BackColor = Color.White;
            kaplaktp.BackColor = Color.White;
            kaplakp.BackColor = Color.White;
        }

        private void f_null()
        {
            teamno1.Text = null;
            teamno2.Text = null;
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            thugw.ReadOnly = false;
            thugl.ReadOnly = false;
            thugd.ReadOnly = false;
            thugtp.ReadOnly = false;
            thugp.ReadOnly = false;

            thugw.BackColor = Color.DarkGray;
            thugl.BackColor = Color.DarkGray;
            thugd.BackColor = Color.DarkGray;
            thugtp.BackColor = Color.DarkGray;
            thugp.BackColor = Color.DarkGray;
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            SaveSetting();
            thugw.ReadOnly = true;
            thugl.ReadOnly = true;
            thugd.ReadOnly = true;
            thugtp.ReadOnly = true;
            thugp.ReadOnly = true;

            thugw.BackColor = Color.White;
            thugl.BackColor = Color.White;
            thugd.BackColor = Color.White;
            thugtp.BackColor = Color.White;
            thugp.BackColor = Color.White;
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            missw.ReadOnly = false;
            missl.ReadOnly = false;
            missd.ReadOnly = false;
            misstp.ReadOnly = false;
            missp.ReadOnly = false;

            missw.BackColor = Color.DarkGray;
            missl.BackColor = Color.DarkGray;
            missd.BackColor = Color.DarkGray;
            misstp.BackColor = Color.DarkGray;
            missp.BackColor = Color.DarkGray;
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            aspire2w.ReadOnly = false;
            aspire2l.ReadOnly = false;
            aspire2d.ReadOnly = false;
            aspire2tp.ReadOnly = false;
            aspire2p.ReadOnly = false;

            aspire2w.BackColor = Color.DarkGray;
            aspire2l.BackColor = Color.DarkGray;
            aspire2d.BackColor = Color.DarkGray;
            aspire2tp.BackColor = Color.DarkGray;
            aspire2p.BackColor = Color.DarkGray;
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            gurka2w.ReadOnly = false;
            gurka2l.ReadOnly = false;
            gurka2d.ReadOnly = false;
            gurka2tp.ReadOnly = false;
            gurka2p.ReadOnly = false;

            gurka2w.BackColor = Color.DarkGray;
            gurka2l.BackColor = Color.DarkGray;
            gurka2d.BackColor = Color.DarkGray;
            gurka2tp.BackColor = Color.DarkGray;
            gurka2p.BackColor = Color.DarkGray;
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            mayanksw.ReadOnly = false;
            mayanksl.ReadOnly = false;
            mayanksd.ReadOnly = false;
            mayankstp.ReadOnly = false;
            mayanksp.ReadOnly = false;

            mayanksw.BackColor = Color.DarkGray;
            mayanksl.BackColor = Color.DarkGray;
            mayanksd.BackColor = Color.DarkGray;
            mayankstp.BackColor = Color.DarkGray;
            mayanksp.BackColor = Color.DarkGray;
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            SaveSetting();
            missw.ReadOnly = true;
            missl.ReadOnly = true;
            missd.ReadOnly = true;
            misstp.ReadOnly = true;
            missp.ReadOnly = true;

            missw.BackColor = Color.White;
            missl.BackColor = Color.White;
            missd.BackColor = Color.White;
            misstp.BackColor = Color.White;
            missp.BackColor = Color.White;
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            SaveSetting();
            aspire2w.ReadOnly = true;
            aspire2l.ReadOnly = true;
            aspire2d.ReadOnly = true;
            aspire2tp.ReadOnly = true;
            aspire2p.ReadOnly = true;

            aspire2w.BackColor = Color.White;
            aspire2l.BackColor = Color.White;
            aspire2d.BackColor = Color.White;
            aspire2tp.BackColor = Color.White;
            aspire2p.BackColor = Color.White;
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            SaveSetting();
            gurka2w.ReadOnly = true;
            gurka2l.ReadOnly = true;
            gurka2d.ReadOnly = true;
            gurka2tp.ReadOnly = true;
            gurka2p.ReadOnly = true;

            gurka2w.BackColor = Color.White;
            gurka2l.BackColor = Color.White;
            gurka2d.BackColor = Color.White;
            gurka2tp.BackColor = Color.White;
            gurka2p.BackColor = Color.White;
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            SaveSetting();
            mayanksw.ReadOnly = true;
            mayanksl.ReadOnly = true;
            mayanksd.ReadOnly = true;
            gurka2p.ReadOnly = true;

            mayanksw.BackColor = Color.White;
            mayanksl.BackColor = Color.White;
            mayanksd.BackColor = Color.White;
            mayankstp.BackColor = Color.White;
            mayanksp.BackColor = Color.White;
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            gurkaw.Text = "0";
            gurkal.Text = "0";
            gurkad.Text = "0";
            gurkap.Text = "0";
            gurkatp.Text = "0";

            pannaw.Text = "0";
            pannal.Text = "0";
            pannad.Text = "0";
            pannap.Text = "0";
            pannatp.Text = "0";

            kaplakw.Text = "0";
            kaplakl.Text = "0";
            kaplakd.Text = "0";
            kaplakp.Text = "0";
            kaplaktp.Text = "0";

            thugw.Text = "0";
            thugl.Text = "0";
            thugd.Text = "0";
            thugp.Text = "0";
            thugtp.Text = "0";

            missw.Text = "0";
            missl.Text = "0";
            missd.Text = "0";
            missp.Text = "0";
            misstp.Text = "0";

            aspire2w.Text = "0";
            aspire2l.Text = "0";
            aspire2d.Text = "0";
            aspire2p.Text = "0";
            aspire2tp.Text = "0";

            gurka2w.Text = "0";
            gurka2l.Text = "0";
            gurka2d.Text = "0";
            gurka2p.Text = "0";
            gurka2tp.Text = "0";

            mayanksw.Text = "0";
            mayanksl.Text = "0";
            mayanksd.Text = "0";
            mayanksp.Text = "0";
            mayankstp.Text = "0";

            SaveSetting();







        }

        private void Button21_Click(object sender, EventArgs e)
        {
            
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button28_Click(object sender, EventArgs e)
        {
            gurkay.ReadOnly = false;
            gurkar.ReadOnly = false;
            pannay.ReadOnly = false;
            pannay.ReadOnly = false;
            kaplaky.ReadOnly = false;
            kaplakr.ReadOnly = false;
            thugy.ReadOnly = false;
            thugr.ReadOnly = false;
            missy.ReadOnly = false;
            missr.ReadOnly = false;
            aspire2y.ReadOnly = false;
            aspire2r.ReadOnly = false;
            gurka2y.ReadOnly = false;
            gurka2r.ReadOnly = false;
            mayanksy.ReadOnly = false;
            mayanksr.ReadOnly = false;

            gurkay.BackColor = Color.Gray;
            gurkar.BackColor = Color.Gray;
            pannay.BackColor = Color.Gray;
            pannay.BackColor = Color.Gray;
            kaplaky.BackColor = Color.Gray;
            kaplakr.BackColor = Color.Gray;
            thugy.BackColor = Color.Gray;
            thugr.BackColor = Color.Gray;
            missy.BackColor = Color.Gray;
            missr.BackColor = Color.Gray;
            aspire2y.BackColor = Color.Gray;
            aspire2r.BackColor = Color.Gray;
            gurka2y.BackColor = Color.Gray;
            gurka2r.BackColor = Color.Gray;
            mayanksy.BackColor = Color.Gray;
            mayanksr.BackColor = Color.Gray;
        }

        private void Button21_Click_1(object sender, EventArgs e)
        {
            gurkay.ReadOnly = true;
            gurkar.ReadOnly = true;
            pannay.ReadOnly = true;
            pannay.ReadOnly = true;
            kaplaky.ReadOnly = true;
            kaplakr.ReadOnly = true;
            thugy.ReadOnly = true;
            thugr.ReadOnly = true;
            missy.ReadOnly = true;
            missr.ReadOnly = true;
            aspire2y.ReadOnly = true;
            aspire2r.ReadOnly = true;
            gurka2y.ReadOnly = true;
            gurka2r.ReadOnly = true;
            mayanksy.ReadOnly = true;
            mayanksr.ReadOnly = true;

            gurkay.BackColor = Color.White;
            gurkar.BackColor = Color.White;
            pannay.BackColor = Color.White;
            pannay.BackColor = Color.White;
            kaplaky.BackColor = Color.White;
            kaplakr.BackColor = Color.White;
            thugy.BackColor = Color.White;
            thugr.BackColor = Color.White;
            missy.BackColor = Color.White;
            missr.BackColor = Color.White;
            aspire2y.BackColor = Color.White;
            aspire2r.BackColor = Color.White;
            gurka2y.BackColor = Color.White;
            gurka2r.BackColor = Color.White;
            mayanksy.BackColor = Color.White;
            mayanksr.BackColor = Color.White;
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(crd.IsDisposed == true)
            
            {
                crd = new cards();
            }
            crd.Show();
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (crd.IsDisposed == true)

            {
                crd = new cards();
            }
            crd.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

