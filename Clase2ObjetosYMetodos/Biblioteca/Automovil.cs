using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public  class Automovil
    {
        //atributos
        private const int velocidadMaximaPermitida = 60;
        private string patente;
        private short cantidadPuertas;
        //cuando es estatico es una cualidad que compartiran todos los autos y si lo cambio cambia para todos los autos que cree o vaya a crear 
        //todos los objetos van a apuntar al mismo lado por q es static
        private static short cantidadRuedas;

        //el constructor estatico sirve para inicializar la atributos estaticos es el primero que se ejecuta y se ejecuta
        //una sola vez en todo el ciclo del vida del objeto es contructor del clase no de objeto
        static Automovil()
        {
            Automovil.cantidadRuedas = 4;
        }

        //constructor es un metodo se llama igual q la clase y no tiene retorno 
        public Automovil(string patente)
        {
            this.SetPatente(patente);
            this.cantidadPuertas = 5;
        }

        //sobrecargado de el constructor para que pueda setearle las puertas tambien
        public Automovil(string patente , short cantidadPuertas)
        {
            this.SetPatente(patente);
            this.SetCantidadPuertas(cantidadPuertas);
        }


        //setea la patente de acuerdo a lo que le envian
        public void SetPatente(string patente)
        {
            // valido y asigno falta validar
            this.patente = patente;
        }
        
        //setea la cantidad de puertas de acuerdo a lo que le envian
        public void SetCantidadPuertas(short cantidadPuertas)
        {
            // valido y asigno falta validar
            this.cantidadPuertas = cantidadPuertas;
        }
    }
}
