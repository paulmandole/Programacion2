using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cliente
    {
        int id;
        string nombre;
        string apellido;
        string email;
        string telefono;
        DateTime fechaEvento;

        public Cliente(string nombre, string apellido, string email, string telefono, DateTime fechaEvento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.telefono = telefono;
            this.fechaEvento = fechaEvento;
        }
        public Cliente(int id, string nombre, string apellido, string email, string telefono, DateTime fechaEvento) : this(nombre, apellido, email, telefono, fechaEvento)
        {
            this.id = id;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public DateTime FechaEvento
        {
            get { return fechaEvento; }
            set { fechaEvento = value; }
        }

        public static bool operator ==(Cliente clA, Cliente clB)
        {
            return clA is not null && clB is not null && clA.Id != clB.Id;
        }

        public static bool operator !=(Cliente clA, Cliente clB)
        {
            return !(clA == clB);
        }

        public string mostrarCliente()
        {
            return this.Id + " " +this.Nombre + " " + this.Apellido + " " + this.Email + " " +  this.Telefono + " " + this.fechaEvento.ToString();
        }
        
    }
}
