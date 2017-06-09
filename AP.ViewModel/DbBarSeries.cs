using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FAMA.AP.Model;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace FAMA.AP.DataLayer
{
    public class DbBarSeries
    {
        public FAMA.AP.Model.BarSeriessModel Selectalldata()
        {
            SqlConnection con = null;

            DataSet ds = null;
            FAMA.AP.Model.BarSeriessModel BSobj = new FAMA.AP.Model.BarSeriessModel();
            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConn"].ToString());
                SqlCommand cmd = new SqlCommand("PR_AP_SEL_SIGNALS]", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;

                ds = new DataSet();
                da.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {

                    BSobj.idEvento = int.Parse(ds.Tables[0].Rows[i]["idEvento"].ToString());
                    BSobj.SenDesc = ds.Tables[0].Rows[i]["SenDesc"].ToString();
                    BSobj.Start = int.Parse(ds.Tables[0].Rows[i]["Start"].ToString());
                    BSobj.End = int.Parse(ds.Tables[0].Rows[i]["idMachineType"].ToString());

                }
                return BSobj;
            }
            catch
            {
                return BSobj;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
