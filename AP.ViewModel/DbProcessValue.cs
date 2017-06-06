using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using FAMA.AP.Model;

namespace FAMA.AP.DataLayer
{
    public class DbProcessValue
    {

        public List<ProcessValue> FindAllMechanismBySectionAndEvent()
        {
            SqlConnection con = null;

            DataSet ds = null;
            List<ProcessValue> processList = null;

            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConn"].ToString());
                SqlCommand cmd = new SqlCommand("PR_AP_SEL_MECHANISM", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idProcessType", 1);
                cmd.Parameters.AddWithValue("@idEvent", 1);

                con.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;

                ds = new DataSet();
                da.Fill(ds);

                processList = new List<ProcessValue>();


                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ProcessValue pobj = new ProcessValue();
                    
                    pobj.fTotals = int.Parse(ds.Tables[0].Rows[i]["fTotEv"].ToString());
                    pobj.fTotEv = int.Parse(ds.Tables[0].Rows[i]["fTotals"].ToString());
                    pobj.tmpName = ds.Tables[0].Rows[i]["vcName"].ToString();

                    processList.Add(pobj);

                }
                return processList;
            }
            catch
            {
                return processList;
            }
            finally
            {
                con.Close();
            }
        }

    }
}
