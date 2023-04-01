using System;
using Biblioteca;

namespace Clase2ObjetosYMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float temperaturaCelcius = 30;
            float temperaturaKelvin = 297;
            float gradosConvertidos;

            gradosConvertidos = ConversorDeTemperatura.ConvertirCelsiusAKelvin(temperaturaCelcius);
            Console.WriteLine("Los grados convertidos a celsius son:{0}", gradosConvertidos);

            gradosConvertidos = ConversorDeTemperatura.ConvertirKelvinACelsius(temperaturaKelvin);
            Console.WriteLine("Los grados convertidos a celsius son:{0}", gradosConvertidos);
            

        }
    }
}
