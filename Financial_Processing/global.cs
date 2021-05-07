using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Financial_Processing
{
    class global
    {
        
        public string dbconnect()
        {
            string conn = "datasource=127.0.0.1;username=root;database=financial_processing_system;port=3306";
            return conn;
        }
        public static string a_name;
        
    }
}
