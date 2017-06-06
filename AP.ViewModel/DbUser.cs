using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace FAMA.AP.DataLayer
{
    public class DbUser
    {

        public int InsertData(FAMA.AP.Model.User objusr)
        {
            SqlConnection con = null;
            int result = -1;
            try
            {
                using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConn"].ToString()))
                {

                    SqlCommand cmd = new SqlCommand("PR_AP_INS_USER", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idUser", objusr.IdUser);
                    cmd.Parameters.AddWithValue("@vcName", objusr.Name);
                    cmd.Parameters.AddWithValue("@vcLastName", objusr.LastName);
                    cmd.Parameters.AddWithValue("@vcAccount", objusr.UserName);
                    cmd.Parameters.AddWithValue("@vcPassword", objusr.Password);
                    cmd.Parameters.AddWithValue("@vcEmail", objusr.EmailAddress);
                    //cmd.Parameters.AddWithValue("@idClient", objusr.idClient); //remplazar cuando ya se tenga login seteado con el cliente-usuario
                    cmd.Parameters.AddWithValue("@idClient", 1); //Para pruebas...
                    cmd.Parameters.AddWithValue("@idProfile", objusr.IdProfile);
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

        public int DeleteData(FAMA.AP.Model.User objusr)
        {
            SqlConnection con = null;
            int result = -1;
            try
            {
                using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConn"].ToString()))
                {
                    SqlCommand cmd = new SqlCommand("PR_AP_DEL_USER", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idUser", objusr.IdUser);
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

        public List<FAMA.AP.Model.User> Selectalldata()
        {
            SqlConnection con = null;

            DataSet ds = null;
            List<FAMA.AP.Model.User> userlist = null;
            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConn"].ToString());
                SqlCommand cmd = new SqlCommand("PR_AP_SEL_USER", con);                
                cmd.CommandType = CommandType.StoredProcedure;               

                con.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;

                ds = new DataSet();
                da.Fill(ds);
                userlist = new List<FAMA.AP.Model.User>();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    FAMA.AP.Model.User uobj = new FAMA.AP.Model.User();
                    uobj.IdUser = Guid.Parse(ds.Tables[0].Rows[i]["idUser"].ToString());
                    uobj.Name = ds.Tables[0].Rows[i]["vcName"].ToString();
                    uobj.LastName = ds.Tables[0].Rows[i]["vcLastName"].ToString();
                    uobj.UserName = ds.Tables[0].Rows[i]["vcAccount"].ToString();
                    uobj.Password = ds.Tables[0].Rows[i]["vcPassword"].ToString();
                    uobj.EmailAddress = ds.Tables[0].Rows[i]["vcEmail"].ToString();
                    uobj.idClient = int.Parse(ds.Tables[0].Rows[i]["idClient"].ToString());
                    uobj.ClientDescription = ds.Tables[0].Rows[i]["vcClientName"].ToString();
                    uobj.IdProfile = int.Parse(ds.Tables[0].Rows[i]["idProfile"].ToString());
                    uobj.ProfileName = ds.Tables[0].Rows[i]["vcProfileDesc"].ToString();
                    userlist.Add(uobj);
                }
                return userlist;
            }
            catch
            {
                return userlist;
            }
            finally
            {
                con.Close();
            }
        }

        
    }
}