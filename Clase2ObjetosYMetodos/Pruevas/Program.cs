using System;

namespace Pruevas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] binarios  = Decimal.GetBits(250000034);
            for (int i = 0; i < binarios.Length; i++)
            {
                Console.WriteLine(binarios[i]);
            }
            
        }
    }
}
