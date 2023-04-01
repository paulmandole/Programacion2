using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Negocio
    {
        //aca seria como puesto de atencion
        private PuestoDeAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        public Cliente Cliente
        {
            get { return clientes.Dequeue(); }

            set 
            {
                if (!clientes.Contains(value))
                {
                    clientes.Enqueue(value);
                }
                    
            }
        }

        public int ClientesPendientes
        {
            get { return clientes.Count; }
        }
        private Negocio()
        {
            this.caja = new PuestoDeAtencion(PuestoDeAtencion.EPuesto.caja1);
            this.clientes = new Queue<Cliente>();
        }

        public Negocio(string nombre) :this()
        {
            this.nombre = nombre;
        }

        //mirar si se cambia
        public static bool operator +(Negocio n, Cliente c)
        {
            bool ret = false;
            if(n != c)
            {
                n.clientes.Enqueue(c);
                ret = true;
            }
            return ret;
        }

        public static bool operator ==(Negocio n , Cliente c)
        {
            return n.clientes.Contains(c);
        }
        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator ~(Negocio n)
        {
            bool ret = false;

            if (n.clientes.Count > 0)
            {
                //Negocio.Caja.Atender(negocio.Cliente) negocio.Cliente devuelve el ultimo cliente
                n.caja.Atender(n.Cliente);
                ret = true;
            }
                

            return ret;
        }

    }
}
