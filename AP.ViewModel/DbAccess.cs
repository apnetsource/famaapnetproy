using System;
using System.Data;
using System.Data.SqlClient;

namespace AP.DataAccess
{
    static class DbAccess
    {

        static bool isConnectionAlive(SqlConnection conn, string dbConexion)
        {
            bool connStatus = false;
            SqlCommand sqlCmd = new SqlCommand("Select 1", conn);
            try
            {               
                int i = int.Parse(sqlCmd.ExecuteScalar().ToString());
                connStatus = true;
            }
            catch
            {
                connStatus = false;
            }

            if (!connStatus)
            {
               
                for (int index = 1; index <= 5; index++)
                {
                    try
                    {
                        System.Threading.Thread.Sleep(1000);
                        if (conn.State == ConnectionState.Open)
                        {
                            conn = new SqlConnection(dbConexion);
                            conn.Open();
                        }
                        connStatus = true;
                        break;
                    }
                    catch
                    {
                        connStatus = false;
                    }
                    finally
                    {
                        conn.Dispose();
                    }
                }                
           }

            return connStatus;
        }
    }
}
