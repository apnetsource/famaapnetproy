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
    public class DbMechanism
    {
        public List<Mechanism> FindAllMechanismBySectionAndEvent()
        {
            SqlConnection con = null;

            DataSet ds = null;
            List<Mechanism> mechanismList = null;
            

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

                mechanismList = new List<Mechanism>();
                

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    Mechanism mobj = new Mechanism();
                    

                    mobj.name = ds.Tables[0].Rows[i]["vcName"].ToString();
                    //pobj.fTotals = int.Parse(ds.Tables[0].Rows[i]["fTotEv"].ToString());
                    //mobj.idTags = int.Parse(ds.Tables[0].Rows[i]["idTags"].ToString());
                    mechanismList.Add(mobj);
                    
                }
                return mechanismList;
            }
            catch
            {
                return mechanismList;
            }
            finally
            {
                con.Close();
            }
        }

        public List<Mechanism> SelectAll()
        {
            SqlConnection con = null;
            List<Mechanism> mechanismArray = null;

            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConn"].ToString());

                //String sql = "Select vcName,idTags,idActions from [ap_Mechanism] where idEvent = 1 and idProcessType = 1";
                String sql = "Select name,idTags,idActions from [Mechanism] where idSets = 2 and idProcessType = 1";

                con.Open();

                using (var command = new SqlCommand(sql, con))
                {

                    mechanismArray = new List<Mechanism>();
                    using (var reader = command.ExecuteReader())
                    {
                        // Check is the reader has any rows at all before starting to read.
                        if (reader.HasRows)
                        {
                            // Read advances to the next row.
                            while (reader.Read())
                            {
                                Mechanism mechanism = new Mechanism();
                                

                                mechanism.name = reader["vcName"].ToString();
                                mechanism.idTags = int.Parse(reader["idTags"].ToString());
                                mechanism.idProcessType = int.Parse(reader["idProcessType"].ToString());
                                mechanismArray.Add(mechanism);
                            }
                        }
                    }
                    return mechanismArray;
                }
            }
            catch
            {
                return mechanismArray;
            }
            finally
            {
                con.Close();
            }
           
        }

    }
}
