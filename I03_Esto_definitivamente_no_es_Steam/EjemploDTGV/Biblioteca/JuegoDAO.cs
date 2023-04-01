using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace Entidades
{
    public static class JuegoDAO
    {
        private static string stringConnection;
        private static SqlCommand command;
        private static SqlConnection connection;

        /// <summary>
        /// Constructor estatico instancia los comando necesarios para conectar con sql
        /// </summary>
        static JuegoDAO()
        {
            stringConnection = "Server=.;Database=EJERCICIOS_UTN;Trusted_Connection = True";
            connection = new SqlConnection(stringConnection);
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }

        /// <summary>
        ///  Elimina de base de datos el juego que coincida con el id recivido
        /// </summary>
        /// <param name="codigoJuego">codigo del juego</param>
        public static void Eliminar(int codigoJuego)
        {
            try
            {
                string query = "delete from JUEGOS where CODIGO_JUEGO = @codigoJuego";

                connection.Open();

                command.CommandText = query;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("codigoJuego", codigoJuego);

                command.ExecuteNonQuery();
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

        /// <summary>
        /// Modifica de la base de datos el juego que recivo
        /// </summary>
        /// <param name="juego">Juego</param>
        public static void Modificar(Juego juego)
        {
            try
            {
                string query = "update JUEGOS set NOMBRE = @nombre,PRECIO = @precio,GENERO = @genero where CODIGO_JUEGO = @codigojuego";

                connection.Open();

                command.CommandText = query;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("codigoJuego", juego.CodigoJuego);
                command.Parameters.AddWithValue("precio", juego.Precio);
                command.Parameters.AddWithValue("nombre", juego.Nombre);
                command.Parameters.AddWithValue("genero", juego.Genero);

                command.ExecuteNonQuery();
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

        /// <summary>
        /// Agrega un juego a la base de datos
        /// </summary>
        /// <param name="juego">Recive un objeto juego a agregar</param>
        public static void Guardar(Juego juego)
        {
            try
            {
                string query = "insert into JUEGOS (CODIGO_USUARIO,NOMBRE,PRECIO,GENERO) values (@codigoUsuario,@nombre,@precio,@genero)";

                connection.Open();

                command.CommandText = query;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("codigoUsuario", juego.CodigoUsuario);
                command.Parameters.AddWithValue("nombre", juego.Nombre);
                command.Parameters.AddWithValue("precio", juego.Precio);
                command.Parameters.AddWithValue("genero", juego.Genero);

                command.ExecuteNonQuery();

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

        public static List<Biblioteca> Leer()
        {
            try
            {
                List<Biblioteca> list = new List<Biblioteca>();
                //join averiguar
                string query = $"SELECT JUEGOS.NOMBRE as juego, JUEGOS.GENERO as genero, JUEGOS.CODIGO_JUEGO as codigoJuego, USUARIOS.USERNAME as usuario " +
                    $"FROM JUEGOS JOIN USUARIOS ON JUEGOS.CODIGO_USUARIO = USUARIOS.CODIGO_USUARIO";

                connection.Open();
                command.CommandText = query;
                
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Biblioteca(Convert.ToInt32(reader["codigoJuego"]), reader["genero"].ToString(),reader["juego"].ToString(), reader["usuario"].ToString()));
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

        public static Juego LeerPorId(int codigoJuego)
        {
            try
            {
                Juego juegoRecuperado = null;
                string query = "Select * from JUEGOS where CODIGO_JUEGO = @codigoDeJuego";

                connection.Open();

                command.CommandText = query;
                command.Parameters.AddWithValue("codigoDeJuego", codigoJuego);
                SqlDataReader sqlDataReader = command.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    juegoRecuperado = new Juego(codigoJuego,Convert.ToInt32(sqlDataReader["CODIGO_USUARIO"]),
                    sqlDataReader["GENERO"].ToString(), sqlDataReader["NOMBRE"].ToString(), Convert.ToDouble(sqlDataReader["PRECIO"]));
                }

                return juegoRecuperado;

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
