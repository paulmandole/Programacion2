using System;

namespace ClaseRepasoExcepciones
{
    internal class Usuario
    {
        static void Main(string[] args)
        {
            string[] arrayPlabras = new string[5] {"  pepe ","juana","martina",null,"pocho"};

            try
            {
                string resultado = DevolverPalabra(arrayPlabras, "pocho");
                Console.WriteLine(GuardarEnBaseDeDatos(resultado));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Error controlado");
                
            }

            //protejo mi codigo de metodos que no son hechos por mi 
            try
            {
                DevolverPalabraPorIndice(1);
            }
            catch (Exception ex)
            {

                throw;
            }

            Console.WriteLine("\n\n App Terminada");

            Console.ReadKey();
        }
        private static string DevolverPalabra(string[] fuenteDatos, string PalabraBuscar)
        {
            
            for (int i = 0; i < fuenteDatos.Length; i++)
            {
                try
                {
                    //busqueda exacta trim saca espacios
                    if (fuenteDatos[i].Trim().ToLower() == PalabraBuscar.Trim().ToLower())
                        return fuenteDatos[i].Trim();
                }
                catch (IndexOutOfRangeException ex)
                {
                    
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine("Fallo porque encontro algo null");
                }
                catch (Exception ex)
                {

                    Console.WriteLine($"Fallo al comparar {fuenteDatos[i]}");
                }
             
                    
            }
            return "No esta";
        }

        static string GuardarEnBaseDeDatos(string palabra)
        {
            return $"se guardo la palbra {palabra} en base de datos";
        }
        private static string DevolverPalabraPorIndice(int indice)
        {
            ///
            return "No esta";
        }

    }
 
}
