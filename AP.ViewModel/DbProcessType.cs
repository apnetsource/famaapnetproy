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
    public class DbProcessType
    {

        public int InsertData(FAMA.AP.Model.ProcessType objProcessType)
        {
            SqlConnection oCon = null;
            int result = -1;
            try
            {
                using (oCon = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConn"].ToString()))
                {
                    SqlCommand cmd = new SqlCommand("PR_AP_INS_PROCESS_TYPE", oCon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@vcName", objProcessType.Name);
                    cmd.Parameters.AddWithValue("@vcDescription", objProcessType.Description);

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

        public string UpdateData(FAMA.AP.Model.ProcessType objProcessType)
        {
            SqlConnection oCon = null;
            string result = "";
            try
            {
				using (oCon = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConn"].ToString()))
				{
					//Implementar nueva clase de coneccion
					//oCon = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ToString());
					//SqlCommand cmd = new SqlCommand("Usp_InsertUpdateDelete_User", oCon);

					SqlCommand cmd = new SqlCommand("PR_AP_UPD_PROCESS_TYPE", oCon);
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.Parameters.AddWithValue("@idProcessType", objProcessType.IdProcessType);
					cmd.Parameters.AddWithValue("@vcName", objProcessType.Name);
					cmd.Parameters.AddWithValue("@vcDescription", objProcessType.Description);
					cmd.Parameters.AddWithValue("@bActive", objProcessType.active);

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

        public int DeleteData(FAMA.AP.Model.ProcessType objProcessType)
        {
            SqlConnection oCon = null;
            int result = -1;
            try
            {
                using (oCon = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConn"].ToString()))
                {
                    SqlCommand cmd = new SqlCommand("PR_AP_Del_ProcessType", oCon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdProcessType", objProcessType.IdProcessType);
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

        public List<FAMA.AP.Model.ProcessType> Selectalldata()
        {
            SqlConnection oCon = null;

            DataSet ds = null;
            List<FAMA.AP.Model.ProcessType> processTypeList = null;
            try
            {
                oCon = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConn"].ToString());
                SqlCommand cmd = new SqlCommand("PR_AP_SEL_PROCESS_TYPE", oCon);

                cmd.CommandType = CommandType.StoredProcedure;
                oCon.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;

                ds = new DataSet();
                da.Fill(ds);
                processTypeList = new List<FAMA.AP.Model.ProcessType>();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    FAMA.AP.Model.ProcessType uobj = new FAMA.AP.Model.ProcessType();
                    uobj.IdProcessType = int.Parse(ds.Tables[0].Rows[i]["IdProcessType"].ToString());
                    uobj.Name = ds.Tables[0].Rows[i]["vcName"].ToString();
                    uobj.Description = ds.Tables[0].Rows[i]["vcDescription"].ToString();
                    //uobj.active = ds.Tables[0].Rows[i]["active"].ToString();
                    processTypeList.Add(uobj);
                }
                return processTypeList;

            }
            catch
            {
                return processTypeList;
            }
            finally
            {
                oCon.Close();
            }
        }

        //public FAMA.AP.Model.ProcessType SelectDatabyID(string UserID)
        //{
        //    SqlConnection oCon = null;
        //    DataSet ds = null;
        //    FAMA.AP.Model.ProcessType uobj = new FAMA.AP.Model.ProcessType();
        //    try
        //    {
        //        oCon = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ToString());
        //        SqlCommand cmd = new SqlCommand("PR_AP_SEL_PROCESS_TYPE", oCon);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@UserID", UserID);
        //        cmd.Parameters.AddWithValue("@Name", null);
        //        cmd.Parameters.AddWithValue("@Address", null);
        //        cmd.Parameters.AddWithValue("@Mobileno", null);
        //        cmd.Parameters.AddWithValue("@Birthdate", null);
        //        cmd.Parameters.AddWithValue("@EmailID", null);
        //        cmd.Parameters.AddWithValue("@Query", 5);
        //        SqlDataAdapter da = new SqlDataAdapter();
        //        da.SelectCommand = cmd;
        //        ds = new DataSet();
        //        da.Fill(ds);

        //        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        //        {
        //            uobj.IdProcessType = Guid.Parse(ds.Tables[0].Rows[i]["IdProcessType"].ToString());
        //            uobj.Name = ds.Tables[0].Rows[i]["Name"].ToString();
        //            uobj.Description = ds.Tables[0].Rows[i]["Description"].ToString();
        //            //uobj.createDate = ds.Tables[0].Rows[i]["createDate"].ToString();
        //            //uobj.updDate = ds.Tables[0].Rows[i]["updDate"].ToString();
        //            //uobj.active = ds.Tables[0].Rows[i]["active"].ToString();

        //        }
        //        return uobj;
        //    }
        //    catch
        //    {
        //        return uobj;
        //    }
        //    finally
        //    {
        //        oCon.Close();
        //    }
        //}


    }

}
