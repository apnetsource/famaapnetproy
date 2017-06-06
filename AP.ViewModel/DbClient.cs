using FAMA.AP.Model;
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
    public class DbClient
    {
        public int InsertOrUpdClient (FAMA.AP.Model.Client objclt)
        {
            SqlConnection con = null;
            int result = -1;
            try
            {
                using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConn"].ToString()))
                {
                    SqlCommand cmd = new SqlCommand("PR_AP_INS_OR_UPD_CLIENT", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@vcCountry", objclt.Country);
                    cmd.Parameters.AddWithValue("@vcCity", objclt.City);
                    cmd.Parameters.AddWithValue("@vcLocality", objclt.Locality);
                    cmd.Parameters.AddWithValue("@idLineConfiguration", objclt.IdLineConfiguration);
                    cmd.Parameters.AddWithValue("@Client", objclt.NameClient);
                    cmd.Parameters.AddWithValue("@ShortName", objclt.ShortName);
                    cmd.Parameters.AddWithValue("@line", objclt.line);
                    cmd.Parameters.AddWithValue("@oven", objclt.oven);
                    con.Open();
                    result = int.Parse(cmd.ExecuteScalar().ToString());

                    return result;
                }
            }
            catch (Exception ex)
            {
               System.Console.WriteLine(ex);
                return result;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }

        public FAMA.AP.Model.Client FindAll()
        {
            SqlConnection con = null;
            DataSet ds = null;
            FAMA.AP.Model.Client cobj = new FAMA.AP.Model.Client();
            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConn"].ToString());
                SqlCommand cmd = new SqlCommand("PR_AP_SEL_CLIENT", con);

                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;

                ds = new DataSet();
                da.Fill(ds);
                
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    
                    cobj.Country = ds.Tables[0].Rows[i]["vcCountry"].ToString();
                    cobj.City = ds.Tables[0].Rows[i]["vcCity"].ToString();
                    cobj.Locality = ds.Tables[0].Rows[i]["vcLocality"].ToString();
                    cobj.IdLineConfiguration = int.Parse(ds.Tables[0].Rows[i]["idLineConfiguration"].ToString());
                    cobj.NameClient = ds.Tables[0].Rows[i]["vcClient"].ToString();
                    cobj.ShortName = ds.Tables[0].Rows[i]["vcShortName"].ToString();
                    cobj.line = int.Parse(ds.Tables[0].Rows[i]["line"].ToString());
                    cobj.oven = int.Parse(ds.Tables[0].Rows[i]["oven"].ToString());
                }
               return cobj;
            }
                
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
                return cobj;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
