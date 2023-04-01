using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClaseRepasoExcepciones
{
    public static class LogicaNegocio
    {
        static List<Usuario> listaUsuarios;
        static LogicaNegocio()
        {
            listaUsuarios = new List<Usuario>();
        }
        public static string CargarUsuario(string nombre, int edad)
        {
            try
            {
                if (string.IsNullOrEmpty(nombre))
                {
                    // creo yo la excepcion va a romper poq yo lo pedi y la lanzo fuera de este metodo
                    throw new ErrorDeDatosIngresadosException("Nombre es nulo o vacio");
                }

                if (edad < 0)
                {
                    throw new InvalidOperationException($"Edad no puede ser 0. Recivimos {edad}");
                }
                Usuario unUsuario = new Usuario(nombre, edad);

                return unUsuario.ToString();
            }
            catch (ErrorDeDatosIngresadosException ex)
            {
                
            }
            catch (Exception ex)
            {
                //agreggo mas info a la anterior excepcion
                throw new Exception("Por favor, verificar toda la informacion", ex);
            }

            //return "";
        }
    }
}
