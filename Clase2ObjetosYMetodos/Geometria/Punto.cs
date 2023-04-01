using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Punto
    {
        private readonly int y;
        private readonly int x;

        public int GetY()
        {
            return this.y;
        }

        public int GetX()
        {
            return this.x;
        }

        public Punto(int y, int x)
        {
            this.y = y;
            this.x = x;
        }
    }
}
