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
    public class DbMaquina
    {

        public int InsertData(FAMA.AP.Model.Maquina objMaquina)
        {
            SqlConnection oCon = null;
            int result = -1;
            try
            {
                using (oCon = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConn"].ToString()))
                {
                    SqlCommand cmd = new SqlCommand("PR_AP_INS_PROCESS_TYPE", oCon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@vcName", objMaquina.vcName);
                    cmd.Parameters.AddWithValue("@vcDescription", objMaquina.vcDescription);
                    cmd.Parameters.AddWithValue("@vcDescription", objMaquina.bActivo);
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

        public string UpdateData(FAMA.AP.Model.Maquina objMaquina)
        {
            SqlConnection oCon = null;
            string result = "";
            try
            {
				using (oCon = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConn"].ToString()))
				{
					SqlCommand cmd = new SqlCommand("PR_AP_UPD_PROCESS_TYPE", oCon);
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.Parameters.AddWithValue("@idProcessType", objMaquina.idMachineType);
                    cmd.Parameters.AddWithValue("@vcName", objMaquina.vcName);
                    cmd.Parameters.AddWithValue("@vcDescription", objMaquina.vcDescription);
                    cmd.Parameters.AddWithValue("@vcDescription", objMaquina.bActivo);

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

        public int DeleteData(FAMA.AP.Model.Maquina objMaquina)
        {
            SqlConnection oCon = null;
            int result = -1;
            try
            {
                using (oCon = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConn"].ToString()))
                {
                    SqlCommand cmd = new SqlCommand("PR_AP_Del_ProcessType", oCon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdProcessType", objMaquina.idMachineType);
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

        public List<FAMA.AP.Model.Maquina> Selectalldata()
        {
            SqlConnection oCon = null;

            DataSet ds = null;
            List<FAMA.AP.Model.Maquina> MaquinasList = null;
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
                MaquinasList = new List<FAMA.AP.Model.Maquina>();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    FAMA.AP.Model.Maquina uobj = new FAMA.AP.Model.Maquina();
                    uobj.idMachineType = int.Parse(ds.Tables[0].Rows[i]["idMachineType"].ToString());
                    uobj.vcName = ds.Tables[0].Rows[i]["vcName"].ToString();
                    uobj.vcDescription = ds.Tables[0].Rows[i]["vcDescription"].ToString();
                    uobj.bActivo = Convert.ToBoolean(ds.Tables[0].Rows[i]["bActivo"].ToString());
                    MaquinasList.Add(uobj);
                }
                return MaquinasList;

            }
            catch
            {
                return MaquinasList;
            }
            finally
            {
                oCon.Close();
            }
        }
    }

}
