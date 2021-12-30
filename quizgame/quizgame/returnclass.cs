using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace quizgame
{
    class returnclass
    {
        private string connstring = ConfigurationManager.ConnectionStrings["quizgame"].ConnectionString;

        public string scalarReturn(string q)
        {
            string s = " ";
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(q, con);
                s = cmd.ExecuteScalar().ToString();
            }
            catch (Exception)
            {

                s = " ";
            }
            return s;
        }
    }
}
