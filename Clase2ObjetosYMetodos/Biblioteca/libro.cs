using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class libro
    {
        private List<string> paginas;

        public libro()
        {
            paginas = new List<string>();
        }
        public string this[int index]
        {
            get
            {
                if (index < paginas.Count)
                {
                    return paginas[index];
                }
                else
                {
                    return " ";
                }
            }

            set
            {
                if(index > paginas.Count)
                {
                    paginas.Add(value);
                }
                else 
                {
                    paginas.Insert(index, value);
                }
            }

            
        }
        
    }
}
