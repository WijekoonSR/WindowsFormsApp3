using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;

namespace WindowsFormsApp3
{
    class DbConnection
    {
        private SqlConnection sqlconnection;
        public DbConnection() {
            sqlconnection = new SqlConnection(@"Data Source=(localDB)\Backhoe_DB;Initial Catalog=Database;Integrated Security=True");
        }
        public SqlConnection getDbConnection() {
            return sqlconnection;
        }

        public void closeConnection() {
            sqlconnection.Close();
        }

        public void startConnection() {
            sqlconnection.Open();
        }
    }
}
/*
 SqlConnection con = new SqlConnection(@"string link");
 SqlCommand com = new SqlCommand("select name from customer", con);
 SqlDataReader read = com.executeQuery();    
 foreach(sqlDataReader.read()){
 txt.addItems(sqlDatareader.getString());
    }
     
     
     
     
     */

    