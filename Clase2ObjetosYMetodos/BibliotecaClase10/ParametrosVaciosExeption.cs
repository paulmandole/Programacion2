using System;

namespace BibliotecaClase10
{
    public class ParametrosVaciosExeption :Exception
    {

        public ParametrosVaciosExeption(string mensaje):this(mensaje,null)
        { 
        }
        public ParametrosVaciosExeption(string mensaje, Exception inner) : base(mensaje, inner)
        {
            
        }
    }
}
