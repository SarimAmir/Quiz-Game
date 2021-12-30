using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizgame
{
    public partial class quizform : Form
    {
        public quizform()
        {
            InitializeComponent();
        }
        string ansfromdb, ansselect;
        int id = startgame.q_id;
        int p = 0;
        public static string score;
        bool fiftyfifty = false;
  
        returnclass rc = new returnclass();

        private string connectionstring = ConfigurationManager.ConnectionStrings["quizgame"].ConnectionString;

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {

                ansfromdb = rc.scalarReturn("select Q_CORRECTOPTION from questions where q_id=" + id);
                ansselect = radioButton1.Text;
                if (ansselect.Equals(ansfromdb))
                {


                }
                else
                {
                    groupBox1.Visible = false;
                    button1.Visible = false;
                    label1.Visible = false;
                    label2.Visible = false;
                    labelname.Visible = false;
                    resultlabel.Visible = true;
                    resultlabel.Text = "Wrong Answer!\n " + labelname.Text + "You have won " + quizform.score + " amount";
                }
            }
            if (radioButton2.Checked == true)
            {

                ansfromdb = rc.scalarReturn("select Q_CORRECTOPTION from questions where q_id=" +id);
                ansselect = radioButton2.Text;
                if (ansselect.Equals(ansfromdb))
                {


                }
                else
                {
                    groupBox1.Visible = false;
                    button1.Visible = false;
                    label1.Visible = false;
                    label2.Visible = false;
                    labelname.Visible = false;
                    resultlabel.Visible = true;
                    resultlabel.Text = "Wrong Answer!\n " + labelname.Text + "You have won " + quizform.score + " amount";
                }
            }
            if (radioButton3.Checked == true)
            {
                ansfromdb = rc.scalarReturn("select Q_CORRECTOPTION from questions where q_id=" +id);
                ansselect =radioButton3.Text;
                if (ansselect.Equals(ansfromdb))
                {


                }
                else
                {
                    groupBox1.Visible = false;
                    button1.Visible = false;
                    label1.Visible = false;
                    label2.Visible = false;
                    labelname.Visible = false;
                    resultlabel.Visible = true;
                    resultlabel.Text = "Wrong Answer! \n " + labelname.Text + "You have won " + quizform.score + " amount";
                }
            }
            if (radioButton4.Checked == true)
            {
                ansfromdb = rc.scalarReturn("select Q_CORRECTOPTION from questions where q_id=" +id);
                ansselect = radioButton4.Text;
                if (ansselect.Equals(ansfromdb))
                {


                }
                else
                {
                    groupBox1.Visible = false;
                    button1.Visible = false;
                    label1.Visible = false;
                    label2.Visible = false;
                    labelname.Visible = false;
                    resultlabel.Visible = true;
                    resultlabel.Text = "Wrong Answer! \n " + labelname.Text + " You have won " + quizform.score + " amount";
                }
            }
            if (groupBox1.Visible==false)
            {
                //gameover
            }
            else
            {
                displaylables();
                labelcolorchange(p);
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                id++;
                string sql = "select q_question,q_optionA,q_optionB,q_optionC,q_optionD from questions where q_id=" + id;
                try
                {
                    SqlConnection connection = new SqlConnection(connectionstring);
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        label1.Text = reader.GetValue(0).ToString();
                        radioButton1.Text = reader.GetValue(1).ToString();
                        radioButton2.Text = reader.GetValue(2).ToString();
                        radioButton3.Text = reader.GetValue(3).ToString();
                        radioButton4.Text = reader.GetValue(4).ToString();
                        p++;
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("");
                }
            }
        }

        private void quizform_Load(object sender, EventArgs e)
        {
            resultlabel.Visible = false;
            button2.Visible = false;
            Random random = new Random();
            id = random.Next(33, 44);
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            labelname.Text = startgame.NAME;
            if (fiftyfifty==true)
            {
                pictureBox1.Enabled = false;
            }
           

            string sql = "select q_question,q_optionA,q_optionB,q_optionC,q_optionD from questions where q_id=" + id;
            try
            {
                SqlConnection connection = new SqlConnection(connectionstring);
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    label1.Text = reader.GetValue(0).ToString();
                    radioButton1.Text = reader.GetValue(1).ToString();
                    radioButton2.Text = reader.GetValue(2).ToString();
                    radioButton3.Text = reader.GetValue(3).ToString();
                    radioButton4.Text = reader.GetValue(4).ToString();                   

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            labelname.Visible = false;
            resultlabel.Visible = true;
            resultlabel.Text = "Congratulations " + labelname.Text + "\n  You have won " + quizform.score + " amount";
            button1.Visible = false;
            button2.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            fiftyfifty = true;
            returnclass rc = new returnclass();
            string correctoption= rc.scalarReturn("select Q_CORRECTOPTION from questions where q_id="+id);
            if (radioButton1.Text.Equals(correctoption))
            {
                radioButton2.Visible = false;
                radioButton3.Visible = false;
            }
            if (radioButton2.Text.Equals(correctoption))
            {
                radioButton1.Visible = false;
                radioButton3.Visible = false;
            }
            if (radioButton3.Text.Equals(correctoption))
            {
                radioButton1.Visible = false;
                radioButton2.Visible = false;
            }
            if (radioButton4.Text.Equals(correctoption))
            {
                radioButton1.Visible = false;
                radioButton3.Visible = false;
            }

        }
        public void displaylables()
        {
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
        }

        public void labelcolorchange(int p)
        {
            if (p==0)
            {
                label15.BackColor = Color.Orange;
                label15.ForeColor = Color.Purple;
                score = label15.Text;

            }
            if (p == 1)
            {
                label16.BackColor = Color.Orange;
                label16.ForeColor = Color.Purple;
                score = label16.Text;
            }
            if (p == 2)
            {
                label17.BackColor = Color.Orange;
                label17.ForeColor = Color.Purple;
                score = label17.Text;
            }
            if (p == 3)
            {
                label13.BackColor = Color.Orange;
                label13.ForeColor = Color.Purple;
                score = label13.Text;
            }
            if (p == 4)
            {
                label14.BackColor = Color.Orange;
                label14.ForeColor = Color.Purple;
                score = label14.Text;
            }
            if (p == 5)
            {
                label12.BackColor = Color.Orange;
                label12.ForeColor = Color.Purple;
                score = label12.Text;
                button2.Visible = true;
            }
            if (p == 6)
            {
                label10.BackColor = Color.Orange;
                label10.ForeColor = Color.Purple;
                score = label10.Text;
            }
            if (p == 7)
            {
                label8.BackColor = Color.Orange;
                label8.ForeColor = Color.Purple;
                score = label8.Text;
            }
            if (p == 8)
            {
                label3.BackColor = Color.Orange;
                label3.ForeColor = Color.Purple;
                score = label3.Text;
            }
            if (p == 9)
            {
                label4.BackColor = Color.Orange;
                label4.ForeColor = Color.Purple;
                score = label14.Text;
            }
            if (p == 10)
            {
                label5.BackColor = Color.Orange;
                label5.ForeColor = Color.Purple;
                score = label15.Text;
            }
            if (p == 11)
            {
                label6.BackColor = Color.Orange;
                label6.ForeColor = Color.Purple;
                score = label6.Text;
            }
            if (p == 12)
            {
                label11.BackColor = Color.Orange;
                label11.ForeColor = Color.Purple;
                score = label11.Text;
            }
            if (p == 13)
            {
                label9.BackColor = Color.Orange;
                label9.ForeColor = Color.Purple;
                score = label9.Text;
                groupBox1.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                labelname.Visible = false;
                resultlabel.Visible = true;
                resultlabel.Text = "Congratulations " + labelname.Text + "\n  You have won the game and amount of " + quizform.score;
                button1.Visible = false;
                button2.Visible = false;
            }
       

        }
    }
}
