using Biblioteca;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Biblioteca
{
    public class GestorSQL
    {
        private static string cadenaConexion;
        static GestorSQL()
        {
            GestorSQL.cadenaConexion = "Server=.;Database=SalonEventos;Trusted_Connection=True;";
        }


        public static List<Cliente> LeerDatos()
        {
            List<Cliente> clientes = new List<Cliente>();

            string query = "select * from clientes";
            using (SqlConnection connection = new SqlConnection(GestorSQL.cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string nombre = reader.GetString(1);
                    string apellido = reader.GetString(2);
                    string email = reader.GetString(3);
                    string telefono = reader.GetString(4);
                    DateTime fechaEvento = reader.GetDateTime(5);
                    Cliente cliente = new Cliente(id, nombre, apellido,email,telefono,fechaEvento);
                    clientes.Add(cliente);
                }    
            }

            return clientes;
        }


        public static Cliente LeerDatosPorId(int id)
        {
            Cliente cliente = null;

            string query = "select * from clientes where id=@id";
            using (SqlConnection connection = new SqlConnection(GestorSQL.cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("id",id);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
  
                    string nombre = reader.GetString(1);
                    string apellido = reader.GetString(2);
                    string email = reader.GetString(3);
                    string telefono = reader.GetString(4);
                    DateTime fechaEvento = reader.GetDateTime(5);
                    cliente = new Cliente(id, nombre,apellido, email, telefono,fechaEvento);

                }
            }

            return cliente;
        }
        public static void Alta(Cliente cliente)
        {
            string query = "insert into clientes (nombre, apellido, email, telefono, fecha) values (@nombre,@apellido,@email,@telefono,@fecha)";
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(GestorSQL.cadenaConexion);
                connection.Open();
                SqlCommand cmd = new SqlCommand(query,connection);
                cmd.Parameters.AddWithValue("nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("apellido", cliente.Apellido);
                cmd.Parameters.AddWithValue("email", cliente.Email);
                cmd.Parameters.AddWithValue("telefono", cliente.Telefono);
                cmd.Parameters.AddWithValue("fecha", cliente.FechaEvento);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if(connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close(); 
                }
            }
        }

        public static void Borrar(int id)
        {


            string query = "delete from clientes where id = @id";
            using (SqlConnection connection = new SqlConnection(GestorSQL.cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("id", id);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void Actualizar(Cliente cliente, int id)
        {
            string query = "update clientes set nombre=@nombre, apellido=@apellido, email=@email, telefono=@telefono, fecha=@fechaEvento where id = @id";
            using (SqlConnection connection = new SqlConnection(GestorSQL.cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("apellido", cliente.Apellido);
                cmd.Parameters.AddWithValue("email", cliente.Email);
                cmd.Parameters.AddWithValue("telefono", cliente.Telefono);
                cmd.Parameters.AddWithValue("fechaEvento", cliente.FechaEvento);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
