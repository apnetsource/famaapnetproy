using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace FAMA.AP.DataLayer
{
    public class DbCeis
    {

        public int InsertData(FAMA.AP.Model.Ceis objceis)
        {
            SqlConnection con = null;
            int result = -1;
            try
            {
                using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConn"].ToString()))
                {
                    SqlCommand cmd = new SqlCommand("PR_AP_INS_CEIS", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idCeis", objceis.idCeis);
                    cmd.Parameters.AddWithValue("@idMachineType", objceis.CeisType);
                    cmd.Parameters.AddWithValue("@idMachineSet", objceis.CeisSide);
                    cmd.Parameters.AddWithValue("@iSections", objceis.Sections);
                    cmd.Parameters.AddWithValue("@vcProcessType", objceis.ProcessType);                    
                    con.Open();
                    result = int.Parse(cmd.ExecuteScalar().ToString());

                    return result;
                }
            }
            catch (Exception ex)
            {
                return result;

            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }
        public int DeleteData(FAMA.AP.Model.Ceis objceis)
        {
            SqlConnection con = null;
            int result = -1;
            try
            {
                using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConn"].ToString()))
                {
                    SqlCommand cmd = new SqlCommand("PR_AP_DEL_CEIS", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idCeis", objceis.idCeis);
                    con.Open();
                    result = int.Parse(cmd.ExecuteScalar().ToString());
                    return result;
                }
            }
            catch (Exception ex)
            {
                return result;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }
        public FAMA.AP.Model.Ceis Selectalldata()
        {
            SqlConnection con = null;

            DataSet ds = null;
            FAMA.AP.Model.Ceis cobj = new FAMA.AP.Model.Ceis();          
            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConn"].ToString());
                SqlCommand cmd = new SqlCommand("PR_AP_SEL_CEIS]", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;

                ds = new DataSet();
                da.Fill(ds);            
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {

                    cobj.idCeis = int.Parse(ds.Tables[0].Rows[i]["idCeis"].ToString());
                    cobj.CeisType = int.Parse(ds.Tables[0].Rows[i]["idMachineType"].ToString());
                    cobj.CeisTypeDesc = ds.Tables[0].Rows[i]["idMachineType"].ToString();
                    cobj.CeisSide = int.Parse(ds.Tables[0].Rows[i]["idMachineType"].ToString());
                    cobj.CeisSideDesc = ds.Tables[0].Rows[i]["idMachineSet"].ToString();
                    cobj.Sections = int.Parse(ds.Tables[0].Rows[i]["iSections"].ToString());
                    cobj.ProcessType = ds.Tables[0].Rows[i]["vcProcessType"].ToString();                   
                                    
                }
                return cobj;
            }
            catch
            {
                return cobj;
            }
            finally
            {
                con.Close();
            }
        }

    }
}
