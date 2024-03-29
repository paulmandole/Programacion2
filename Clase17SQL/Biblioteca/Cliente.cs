﻿using System;

namespace Biblioteca
{
    public class Cliente
    {
        private int id;
        private string nombre;
        private string direccion;


        public Cliente(string nombre, string direccion)
        {
            this.nombre = nombre;
            this.direccion = direccion;
        }
        public Cliente(int id, string nombre, string direccion):this(nombre,direccion)
        {
            this.id = id;
           
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }


        //tengo q sobrecargar el toString para mostrar sino no anda bien
        public override string ToString()
        {
            return $"{this.nombre}  Domicilio:{this.direccion}"; 
        }

    }
}
