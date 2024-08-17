using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

//--------------------------------------------------------------------------------------------------------------------
//
//En esta parte de codigo o mas bien en esta clase nos encargaremos de hacer la conexion a nuestra base de datos.
//
//--------------------------------------------------------------------------------------------------------------------

namespace HospitalPractica
{
    public class BaseDatos
    {
        private readonly string connectionString = "Server=localhost;Database=HospitalDB;Trusted_Connection=True;";

        public DataTable ExecuteQuery(string query, params SqlParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddRange(parameters);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public void ExecuteNonQuery(string query, params SqlParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddRange(parameters);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
