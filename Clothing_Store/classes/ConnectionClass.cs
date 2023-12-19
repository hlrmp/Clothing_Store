using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace Clothing_Store
{
    internal class ConnectionClass
    {
        //public static string conn = @"Data Source=REICHEL28\SQLEXPRESS01;Initial Catalog=Clothing_Database;Integrated Security=True";
       public static string conn = @"Data Source=REICHEL28\SQLEXPRESS01;Initial Catalog=ClothingStoreDatabase;Integrated Security=True";
      
    //   public static string TimeandDate = DateTime.Now.ToString("yyyy-MM-dd T-HH:mm:ssss");


        public static bool activity(int userId , string Description) 
        { 
            SqlConnection con = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand();

            cmd = new SqlCommand(" insert into Activity_Logs (User_id,Description,Date) values (@userId,@Description, getDate())", con);

            cmd.Parameters.Add("@userId", userId);
            cmd.Parameters.Add("@Description", Description);
        //    cmd.Parameters.Add("@Date", getDate());
           
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

    }
}
