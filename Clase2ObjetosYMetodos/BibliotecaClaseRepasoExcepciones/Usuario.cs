using System;

namespace BibliotecaClaseRepasoExcepciones
{
    public class Usuario
    {
        string nombre;
        int edad;

        public Usuario(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        public override string ToString()
        {
            return $"Los datos son Nombre:{this.nombre} Edad: {this.edad}";
        }
    }
}
