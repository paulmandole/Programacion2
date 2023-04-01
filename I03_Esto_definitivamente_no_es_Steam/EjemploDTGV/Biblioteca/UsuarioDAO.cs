using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public static class UsuarioDAO
    {
        private static string stringConnection;
        private static SqlCommand command;
        private static SqlConnection connection;

        /// <summary>
        /// Constructor estatico instancia los comando necesarios para conectar con sql
        /// </summary>
        static UsuarioDAO()
        {
            stringConnection = "Server=.;Database=EJERCICIOS_UTN;Trusted_Connection = True";
            connection = new SqlConnection(stringConnection);
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }

        public static List<Usuario> Leer()
        {
            try
            {
                List<Usuario> list = new List<Usuario>();
                string query = "select * from USUARIOS";

                connection.Open();

                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                    int codigoUsuario = reader.GetInt32(0);
                    string userName = reader.GetString(3);

                    Usuario usuario = new Usuario(codigoUsuario, userName);

                    list.Add(usuario);
                }

                return list;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (connection is not null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
