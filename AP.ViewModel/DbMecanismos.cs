using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace FAMA.AP.DataLayer
{
    public class DbMecanismos
    {

        public int InsertData(FAMA.AP.Model.Mecanismos objMecanismos)
        {
            SqlConnection oCon = null;
            int result = -1;
            try
            {
                using (oCon = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConn"].ToString()))
                {
                    SqlCommand cmd = new SqlCommand("PR_AP_INS_PROCESS_TYPE", oCon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@vcName", objMecanismos.Nemotecnico);
                    cmd.Parameters.AddWithValue("@vcDescription", objMecanismos.Mecanismo);

                    oCon.Open();
                    result = int.Parse(cmd.ExecuteNonQuery().ToString());
                    return result;
                }
            }
            catch (Exception ex)
            {
                return result;

            }
            finally
            {
                oCon.Close();
                oCon.Dispose();
            }
        }

        public string UpdateData(FAMA.AP.Model.Mecanismos objMecanismos)
        {
            SqlConnection oCon = null;
            string result = "";
            try
            {
				using (oCon = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConn"].ToString()))
				{
					SqlCommand cmd = new SqlCommand("PR_AP_UPD_PROCESS_TYPE", oCon);
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.Parameters.AddWithValue("@idProcessType", objMecanismos.IdMecanismo);
					cmd.Parameters.AddWithValue("@vcName", objMecanismos.Nemotecnico);
					cmd.Parameters.AddWithValue("@vcDescription", objMecanismos.Mecanismo);
					cmd.Parameters.AddWithValue("@bActive", objMecanismos.TipoValvula);

					oCon.Open();
					result = cmd.ExecuteNonQuery().ToString();
					return result;
				}
            }
            catch(Exception ex)
            {
                return result = ex.ToString();
            }
            finally
            {
                oCon.Close();
            }
        }

        public int DeleteData(FAMA.AP.Model.Mecanismos objMecanismos)
        {
            SqlConnection oCon = null;
            int result = -1;
            try
            {
                using (oCon = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConn"].ToString()))
                {
                    SqlCommand cmd = new SqlCommand("PR_AP_Del_ProcessType", oCon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdProcessType", objMecanismos.IdMecanismo);
                    oCon.Open();
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
                oCon.Close();
                oCon.Dispose();
            }
        }

        public List<FAMA.AP.Model.Mecanismos> Selectalldata()
        {
            SqlConnection oCon = null;

            DataSet ds = null;
            List<FAMA.AP.Model.Mecanismos> MecanismosList = null;
            try
            {
                oCon = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConn"].ToString());
                SqlCommand cmd = new SqlCommand("PR_AP_SEL_MACHINE_TYPE", oCon);

                cmd.CommandType = CommandType.StoredProcedure;
                oCon.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;

                ds = new DataSet();
                da.Fill(ds);
                MecanismosList = new List<FAMA.AP.Model.Mecanismos>();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    FAMA.AP.Model.Mecanismos uobj = new FAMA.AP.Model.Mecanismos();
                    uobj.IdMecanismo = int.Parse(ds.Tables[0].Rows[i]["IdMecanismo"].ToString());
                    uobj.Nemotecnico = ds.Tables[0].Rows[i]["Nemotecnico"].ToString();
                    uobj.Mecanismo = ds.Tables[0].Rows[i]["Mecanismo"].ToString();
                    uobj.TipoValvula = int.Parse(ds.Tables[0].Rows[i]["TipoValvula"].ToString());
                    MecanismosList.Add(uobj);
                }
                return MecanismosList;

            }
            catch
            {
                return MecanismosList;
            }
            finally
            {
                oCon.Close();
            }
        }
    }

}
