using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace FAMA.AP.DataLayer
{
    static public class DbProfile
    {
        static public List<FAMA.AP.Model.Profile> Selectalldata()
        {
            SqlConnection con = null;

            DataSet ds = null;
            List<FAMA.AP.Model.Profile> plist = null;
            try
            {

                using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConn"].ToString()))
                {

                    SqlCommand cmd = new SqlCommand("PR_AP_SEL_PROFILE", con);

                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;

                    ds = new DataSet();
                    da.Fill(ds);
                    plist = new List<FAMA.AP.Model.Profile>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        FAMA.AP.Model.Profile pobj = new FAMA.AP.Model.Profile();
                        pobj.idProfile = int.Parse(ds.Tables[0].Rows[i]["idProfile"].ToString());
                        pobj.ProfileName = ds.Tables[0].Rows[i]["vcDescription"].ToString();

                        plist.Add(pobj);
                    }
                    return plist;
                }
            }
            catch
            {
                return plist;
            }
            finally
            {
                con.Close();

            }
        }
    }
}
