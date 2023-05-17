using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILMS.Data_Access_Layer
{
    class DataAccess:IDisposable
    {
        protected SqlConnection connection;
        protected SqlCommand command;

        public DataAccess()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ILMS"].ConnectionString);
            connection.Open();
        }

        public SqlDataReader GetData(String sql)
        {
            command = new SqlCommand(sql,connection);
            return command.ExecuteReader();
        }

        public int ExecuteQuery(String sql)
        {
            command = new SqlCommand(sql, connection);
            return command.ExecuteNonQuery();
        }

        public void Dispose()
        {
            connection.Close();
        }
    }
}
