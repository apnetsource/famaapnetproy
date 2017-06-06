using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAMA.AP.DataLayer
{
    public class DbLogIn
    {
        public int CheckUser(string UserName, string Password)
        {
            SqlConnection con = null;
            int result = -1;
            try
            {
                using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConn"].ToString()))
                {
                    SqlCommand cmd = new SqlCommand("SP_AP_CHKUSER", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@vcAccount", UserName);
                    cmd.Parameters.AddWithValue("@vcPassword", Password);
                    con.Open();
                    result = int.Parse(cmd.ExecuteScalar().ToString());
                    return result;
                }
            }
            catch(Exception e)
            {
                return result;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }
    }
}
