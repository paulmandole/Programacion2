using System;

namespace Clase10_Execepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int divisor = 0;
            try
            {
                //genera excepciones
                throw new NotImplementedException("Lanzar excepcion");
                //throw new Exception("Lanzar excepcion");
                // double d = 5 / divisor;
            }
            //mas especifico se ponen arriba de exeption
            //catch (NotImplementedException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //esta usa la que creo yo
            catch (ConexionNoEstablecidaException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("-----------------------");
            }

            //este es generico se hace cargo de todos
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //hace el seguimiento de todo y lo muestra
                Console.WriteLine(ex.StackTrace);
            }


            //forma de re lanzar la misma exepcion que capture
            //catch (Exception)
            //{
            //    throw;
            //}

            //relanzo una exepcion con el historial es deir la exeption que capture
            //catch (NotImplementedException ex)
            //{
            //    throw new Exception(ex.Message);
            //}

            //se ejecuta siempre falle o no
            finally
            {
                Console.WriteLine("Se imprimer siempre");
                Console.ReadKey();
            }
        }
    }
    internal class ConexionNoEstablecidaException : Exception
    {
        public ConexionNoEstablecidaException() : base("Mensaje preterminado")
        {
        }

        public ConexionNoEstablecidaException(string message) : base(message)
        { 
        }

        public ConexionNoEstablecidaException(string message, Exception innerException):base(message, innerException)
        {
            
        }


    }
}
