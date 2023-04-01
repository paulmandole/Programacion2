
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class GestorSQLProductos
    {
        private static string cadenaConexion;
        static GestorSQLProductos()
        {
            GestorSQLProductos.cadenaConexion = "Server=.;Database=SalonEventos;Trusted_Connection=True;";
        }

        public static List<Producto> LeerDatos()
        {
            List<Producto> productos = new List<Producto>();

            string query = "select * from Productos";

            using (SqlConnection connection = new SqlConnection(GestorSQLProductos.cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int idProducto = reader.GetInt32(0);
                    int cantidad = reader.GetInt32(1);
                    string nombre = reader.GetString(2);

                    Producto producto = new Producto(idProducto, cantidad, nombre);
                    productos.Add(producto);
                }
            }

            return productos;
        }


        public static Producto LeerDatosPorId(int id)
        {
            Producto producto = null;

            string query = "select * from Productos where idProducto=@id";
            using (SqlConnection connection = new SqlConnection(GestorSQLProductos.cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("id", id);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int cantidad = reader.GetInt32(1);
                    string nombre = reader.GetString(2);
                    producto = new Producto(id, cantidad, nombre);
                }
            }

            return producto;
        }


        public static void Alta(Producto producto)
        {
            string query = "insert into Productos (nombre, cantidad) values (@nombre,@cantidad)";
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(GestorSQLProductos.cadenaConexion);
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("nombre", producto.Nombre);
                cmd.Parameters.AddWithValue("cantidad", producto.Cantidad);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public static void Borrar(int id)
        {


            string query = "delete from Productos where idProducto = @id";
            using (SqlConnection connection = new SqlConnection(GestorSQLProductos.cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("id", id);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void Actualizar(Producto producto, int id)
        {
            string query = "update Productos set nombre=@nombre, cantidad=@cantidad where idProducto = @id";
            using (SqlConnection connection = new SqlConnection(GestorSQLProductos.cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("nombre", producto.Nombre);
                cmd.Parameters.AddWithValue("cantidad", producto.Cantidad);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }

}

