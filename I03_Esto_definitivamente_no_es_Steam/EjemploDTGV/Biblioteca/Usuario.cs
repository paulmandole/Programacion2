using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        private int codigoUsuario;
        private string userName;

        public int CodigoUsuario { get => codigoUsuario;}

        public Usuario(int codigoUsuario, string userName)
        {
            this.codigoUsuario = codigoUsuario;
            this.userName = userName;
        }

        public override string ToString()
        {
            return $"{this.userName}";
        }
    }
}
