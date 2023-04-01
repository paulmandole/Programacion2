using System;
using Biblioteca;

namespace Clase20Eventos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temporizador temporizador = new Temporizador();
            // asocio el evento con el metodo que quiero siempre y cuando respete la firma del delegado
            temporizador.OnTiempoFinalizado += NotificarTiempoCumplido;
            //para desasociar con -=
            //temporizador.OnTiempoFinalizado -= NotificarTiempoCumplido;

            temporizador.OnTiempoRestante += MostrarTiempoRestante;

            temporizador.Ejecutar(5);
        }
        public static void MostrarTiempoRestante(int segundos)
        {
            Console.WriteLine($"Quedan {segundos} segundos");
        }
        private static void NotificarTiempoCumplido()
        {
            Console.WriteLine("Se cumplio el tiempo");
        }
    }
}
