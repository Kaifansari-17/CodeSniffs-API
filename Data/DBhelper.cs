using Microsoft.Data.SqlClient;
using System.Data;



using System.Configuration;

namespace CodeSniffs.API.Data
{
    public  class DbHelper
    {
        // Change connection string name if needed
        private  readonly string _connectionString;

        public DbHelper(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("dbsc");
        }

        

        // 1️⃣ Execute SELECT query → returns DataTable
        public  DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }

        // 2️⃣ Execute INSERT / UPDATE / DELETE → returns rows affected
        public  int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            int rowsAffected;

            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                con.Open();
                rowsAffected = cmd.ExecuteNonQuery();
            }

            return rowsAffected;
        }

        // 3️⃣ Execute Scalar → returns single value (count, id, etc.)
        public  object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            object result;

            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                con.Open();
                result = cmd.ExecuteScalar();
            }

            return result;
        }

        // 4️⃣ Execute Stored Procedure → DataTable
        public  DataTable ExecuteStoredProcedure(string spName, SqlParameter[] parameters = null)
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(spName, con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }
    }
}
