using System;
using System.Text;// para poder usar stringbuilder

namespace Clase2Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string comision = "2.c";
            StringBuilder stringBuilder = new StringBuilder();//es un objeto crea un objeto con el new

            stringBuilder.Append("hola");
            stringBuilder.Append($"mundo{Environment.NewLine}");//Environment.newLine hace un salto de linea es un \n pero sirve siempre en cualquier sistema opearativo

            stringBuilder.AppendLine("programacion 2");//appendline hace un salto de linea al final 

            stringBuilder.AppendFormat("comision {0}", comision);//es como el que uso para mostrar pero con el stringBuilder



            Console.WriteLine(stringBuilder.ToString());

        }
    }
}
