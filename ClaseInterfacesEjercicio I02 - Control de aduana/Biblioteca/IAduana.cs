using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public interface IAduana
    {
        Decimal Impuestos { get; }
        Decimal AplicarImpuestos();
    }
}
