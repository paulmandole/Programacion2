using System;

namespace Biblioteca
{
    public static class ConversorDeTemperatura
    {
        public const float ceroAbsoluto = 273.15f;

        /// <summary>
        /// Convierte grados celcius a kelvin
        /// </summary>
        /// <param name="temperaturaCelsius">recive la temparatura en celcius a transformar</param>
        /// <returns>retorna los grados kelvin que se transformo</returns>
        public static float ConvertirCelsiusAKelvin(float temperaturaCelsius)
        {
            return temperaturaCelsius + ceroAbsoluto;
        }

        public static float ConvertirKelvinACelsius(float temperaturaKelvin)
        {
            return temperaturaKelvin - ceroAbsoluto;
        }

    }
}
