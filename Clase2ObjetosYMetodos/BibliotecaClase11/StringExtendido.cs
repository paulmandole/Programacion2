using System;

namespace BibliotecaClase11
{
    public static class StringExtendido
    {
        //s es la instancia que invoca no esun paramatro q le paso
        public static int ContarPalabras(this String s)
        {
            if (string.IsNullOrEmpty(s))
            {
                throw new ArgumentNullException();
            }
                
            //split devuelve un array de chars separado por el caracter q le pase
            return s.Split(new char[] {' ','-'}).Length;
        }
    }
}
