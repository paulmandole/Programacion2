using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ingresante
    {
        private string[] cursos;
        private string direccion;
        private int edad;
        private string genero;
        private string nombre;
        private string pais;

        public Ingresante(string[] cursos, string direccion, int edad, string genero, string nombre, string pais)
        {
            this.cursos = cursos;
            this.direccion = direccion;
            this.edad = edad;
            this.genero = genero;
            this.nombre = nombre;
            this.pais = pais;
        }

        public string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat($"Nombre:{this.nombre}\tEdad:{this.edad}\tDireccion:{this.direccion}\tGenero:{this.genero}\tPais:{this.pais}\nCursos:\n");
            for (int i = 0; i < cursos.Length; i++)
            {
                if (!string.IsNullOrEmpty(cursos[i]))
                {
                    stringBuilder.AppendFormat($"{cursos[i]}\n");
                }
            }
            return stringBuilder.ToString();
        }
    }
}
