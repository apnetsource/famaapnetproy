using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace FAMA.AP.DataLayer
{
    public class DbSections
    {
        public List<FAMA.AP.Model.Sections> SelectAll()
        {
            SqlConnection con = null;
            DataSet ds = null;
            List<FAMA.AP.Model.Sections> sectionList = null;

            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConn"].ToString());
                SqlCommand cmd = new SqlCommand("PR_AP_SEL_SECTIONS", con);

                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;

                ds = new DataSet();
                da.Fill(ds);
                sectionList = new List<FAMA.AP.Model.Sections>();
                for (int i = 0; i<ds.Tables[0].Rows.Count; i++)
                {
                    FAMA.AP.Model.Sections sobj = new Model.Sections();
                    sobj.idActiveSections = int.Parse(ds.Tables[0].Rows[i]["idActiveSections"].ToString());
                    sobj.active = Convert.ToBoolean(ds.Tables[0].Rows[i]["bActive"].ToString());
                    sectionList.Add(sobj);
                }
                System.Console.WriteLine(sectionList);
                return sectionList;
            }
            
            catch(Exception ex)
            {
                System.Console.WriteLine(ex);
                return sectionList;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }

        public  FAMA.AP.Model.Sections SelectSectionById (int idSection)
        {
            SqlConnection con = null;
            DataSet ds = null;
            FAMA.AP.Model.Sections sobj = new Model.Sections();
            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConn"].ToString());
                SqlCommand cmd = new SqlCommand("PR_AP_SEL_SECTIONS_BY_ID", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.Parameters.AddWithValue("@idSection", idSection);
                
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                ds = new DataSet();
                da.Fill(ds);

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    sobj.idActiveSections = int.Parse(ds.Tables[0].Rows[i]["idActiveSections"].ToString());
                    sobj.idProcessType = int.Parse(ds.Tables[0].Rows[i]["idProcessType"].ToString());
                    sobj.idProcess = int.Parse(ds.Tables[0].Rows[i]["idProcess"].ToString());
                    sobj.name = ds.Tables[0].Rows[i]["Section"].ToString();
                    sobj.active = Convert.ToBoolean(ds.Tables[0].Rows[i]["bActive"].ToString());
                }
                return sobj;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
                return sobj;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }
    }
}
