using System;
using System.Runtime.CompilerServices;
using Biblioteca;

namespace Eventos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temporizador temporizador = new Temporizador();
            //asocio el metodo al evento 
            temporizador.OnTiempoFinalizado += MostarTiempoCumplido;
            temporizador.OnTiempoRestante += MostrarTiempoRestante;

            //des asociar
            //temporizador.OnTiempoFinalizado -= MostarTiempoCumplido;

            //llamo a la funcion luego de asociarlo sino falla
            temporizador.Ejecutar(3);





        }
        public static void MostrarTiempoRestante(int segundos)
        {
            Console.Clear();
            Console.WriteLine($"quedan {segundos} segundos");
        }

        //metodo q quiero que reaccione al evento tiene q tener la misma firma que el delegado
        public static void MostarTiempoCumplido()
        {
            Console.WriteLine("Se cumplio el tiempo");
        }
    }
}
