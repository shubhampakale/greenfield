using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DBTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string conString = @"data source=shc-sql-01.database.windows.net ; database=HangFireCatalog_VG; User Id=tmgreadonly; Password=#p7P>Wzs;"; //connection string define data source
            IDbConnection con = new SqlConnection(conString);

            string query = "select * from products_shubham";
            IDbCommand cmd = new SqlCommand(query, con as SqlConnection);  //Firing Query 
            try
            {
                con.Open();
                IDataReader dr = cmd.ExecuteReader();  //capture the object
                while(dr.Read())
                {
                    string name = dr["Name"].ToString();
                    string description = dr["Description"].ToString();
                    int quantity = int.Parse(dr["Quantity"].ToString());
                    Console.WriteLine(name + " " + description + " " + quantity);
                }
                dr.Close();
            }
            catch (SqlException ex) 
            {
                Console.WriteLine(ex.Message);        
            }
            finally 
            { 
                con.Close();
            }
            
            
            
        }
    }
}
