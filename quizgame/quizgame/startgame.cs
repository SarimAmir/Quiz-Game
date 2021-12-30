using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace quizgame
{
    public partial class startgame : Form
    {
        
        string ansfromdb, ansselect;
        returnclass rc = new returnclass();
        public static int q_id;
        private string connectionstring = ConfigurationManager.ConnectionStrings["quizgame"].ConnectionString;
        public static string NAME;
        public startgame()
        {
            InitializeComponent();
        }

        private void startgame_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;
            textBox1.Visible = false;
            button2.Visible = false;
            Random random = new Random();
            q_id = random.Next(33, 44);
            string sql = "select q_question,q_optionA,q_optionB,q_optionC,q_optionD from questions where q_id="+q_id;
            try
            {
                SqlConnection connection = new SqlConnection(connectionstring);
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql,connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    label1.Text = reader.GetValue(0).ToString();
                    checkBox1.Text = reader.GetValue(1).ToString();
                    checkBox2.Text = reader.GetValue(2).ToString();
                    checkBox3.Text = reader.GetValue(3).ToString();
                    checkBox4.Text = reader.GetValue(4).ToString();

                    checkBox5.Text = reader.GetValue(1).ToString();
                    checkBox6.Text = reader.GetValue(2).ToString();
                    checkBox7.Text = reader.GetValue(3).ToString();
                    checkBox8.Text = reader.GetValue(4).ToString();

                    checkBox9.Text = reader.GetValue(1).ToString();
                    checkBox10.Text = reader.GetValue(2).ToString();
                    checkBox11.Text = reader.GetValue(3).ToString();
                    checkBox12.Text = reader.GetValue(4).ToString();



                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("");
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
               
                ansfromdb = rc.scalarReturn("select Q_CORRECTOPTION from questions where q_id=" + q_id);
                ansselect = checkBox1.Text;
                if (ansselect.Equals(ansfromdb))
                {
                    
                  
                }
                else
                {
                    groupBox1.Visible = false;
                }
            }
           if (checkBox2.Checked == true)
            {
               
                ansfromdb = rc.scalarReturn("select Q_CORRECTOPTION from questions where q_id=" + q_id);
                ansselect = checkBox2.Text;
                if (ansselect.Equals(ansfromdb))
                {
                    
                   
                }
                else
                {
                    groupBox1.Visible = false;
                }
            }
            if (checkBox3.Checked == true)
            {
                ansfromdb = rc.scalarReturn("select Q_CORRECTOPTION from questions where q_id=" + q_id);
                ansselect = checkBox3.Text;
                if (ansselect.Equals(ansfromdb))
                {
                    
                    
                }
                else
                {
                    groupBox1.Visible = false;
                }
            }
            if (checkBox4.Checked == true)
            {
                ansfromdb = rc.scalarReturn("select Q_CORRECTOPTION from questions where q_id=" + q_id);
                ansselect = checkBox4.Text;
                if (ansselect.Equals(ansfromdb))
                {
                    
                    
                }
                else
                {
                    groupBox1.Visible = false;
                }
            }
            if (checkBox5.Checked == true)
            {
                ansfromdb = rc.scalarReturn("select Q_CORRECTOPTION from questions where q_id=" + q_id);
                ansselect = checkBox5.Text;
                if (ansselect.Equals(ansfromdb))
                {
                   
                   
                }
                else
                {
                    groupBox2.Visible = false;
                }
            }
            if (checkBox6.Checked == true)
            {
                ansfromdb = rc.scalarReturn("select Q_CORRECTOPTION from questions where q_id=" + q_id);
                ansselect = checkBox6.Text;
                if (ansselect.Equals(ansfromdb))
                {
                    
                   
                }
                else
                {
                    groupBox2.Visible = false;
                }
            }

            if (checkBox7.Checked == true)
            {
                ansfromdb = rc.scalarReturn("select Q_CORRECTOPTION from questions where q_id=" + q_id);
                ansselect = checkBox7.Text;
                if (ansselect.Equals(ansfromdb))
                {
                    
                    
                }
                else
                {
                    groupBox2.Visible = false;
                }
            }
            if (checkBox8.Checked == true)
            {
                ansfromdb = rc.scalarReturn("select Q_CORRECTOPTION from questions where q_id=" + q_id);
                ansselect = checkBox8.Text;
                if (ansselect.Equals(ansfromdb))
                {
                   
                   
                }
                else
                {
                    groupBox2.Visible = false;
                }
            }
            if (checkBox9.Checked == true)
            {
                ansfromdb = rc.scalarReturn("select Q_CORRECTOPTION from questions where q_id=" + q_id);
                ansselect = checkBox9.Text;
                if (ansselect.Equals(ansfromdb))
                {
                    
                    
                }
                else
                {
                    groupBox3.Visible = false;
                }
            }
            if (checkBox10.Checked == true)
            {
                ansfromdb = rc.scalarReturn("select Q_CORRECTOPTION from questions where q_id=" + q_id);
                ansselect = checkBox10.Text;
                if (ansselect.Equals(ansfromdb))
                {
                    
                   
                }
                else
                {
                    groupBox3.Visible = false;
                }
            }
            if (checkBox11.Checked == true)
            {
                ansfromdb = rc.scalarReturn("select Q_CORRECTOPTION from questions where q_id=" + q_id);
                ansselect = checkBox11.Text;
                if (ansselect.Equals(ansfromdb))
                {

                }
                else
                {
                    groupBox3.Visible = false;
                }

            }
            if (checkBox12.Checked == true)
            {

                ansfromdb = rc.scalarReturn("select Q_CORRECTOPTION from questions where q_id=" + q_id);
                ansselect = checkBox12.Text;
                if (ansselect.Equals(ansfromdb))
                {
                    
                    
                }
                else
                {
                    groupBox3.Visible = false;
                    
                }
                
            }
            q_id++;
            string sql = "select q_question,q_optionA,q_optionB,q_optionC,q_optionD from questions where q_id=" + q_id;
            try
            {
                SqlConnection connection = new SqlConnection(connectionstring);
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    label1.Text = reader.GetValue(0).ToString();
                    checkBox1.Text = reader.GetValue(1).ToString();
                    checkBox2.Text = reader.GetValue(2).ToString();
                    checkBox3.Text = reader.GetValue(3).ToString();
                    checkBox4.Text = reader.GetValue(4).ToString();

                    checkBox5.Text = reader.GetValue(1).ToString();
                    checkBox6.Text = reader.GetValue(2).ToString();
                    checkBox7.Text = reader.GetValue(3).ToString();
                    checkBox8.Text = reader.GetValue(4).ToString();

                    checkBox9.Text = reader.GetValue(1).ToString();
                    checkBox10.Text = reader.GetValue(2).ToString();
                    checkBox11.Text = reader.GetValue(3).ToString();
                    checkBox12.Text = reader.GetValue(4).ToString();



                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("");
            }
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            if (groupBox1.Visible==false && groupBox2.Visible==false && groupBox3.Visible==true)
            {
                label1.Visible = false;
                label2.Visible = true;
                label3.Visible = true;
                textBox1.Visible = true;
                groupBox3.Visible = false;
                button1.Visible = false;
                button2.Visible = true;
                label3.Text = "PLAYER 3 IS SELECTED";
                string name;
                name = textBox1.Text;
                

            }
            if (groupBox2.Visible == false && groupBox3.Visible == false && groupBox1.Visible==true)
            {
                label1.Visible = false;
                label2.Visible = true;
                label3.Visible = true;
                textBox1.Visible = true;
                groupBox1.Visible = false;
                button1.Visible = false;
                button2.Visible = true;
                label3.Text = "PLAYER 1 IS SELECTED";
                string name;
                name = textBox1.Text;
            }
            if (groupBox1.Visible == false && groupBox3.Visible == false && groupBox2.Visible==true)
            {
                label1.Visible = false;
                label2.Visible = true;
                label3.Visible = true;
                textBox1.Visible = true;
                groupBox2.Visible = false;
                button1.Visible = false;
                button2.Visible = true;
                label3.Text = "PLAYER 2 IS SELECTED";
                string name;
                name = textBox1.Text;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            NAME = textBox1.Text;
            quizform quizform = new quizform();
            quizform.Show();
            this.Hide();
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
