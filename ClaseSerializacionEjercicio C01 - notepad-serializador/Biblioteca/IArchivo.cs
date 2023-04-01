using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public interface IArchivo<T>
    {
        void Guardar(string path, T contenido);
        void GuardarComo(string path, T contenido);
        T Leer(string path);
    }
}
