using System;
using System.Collections.Generic;

namespace BibliotecaClase12
{
    public class Gondola
    {
        List<Lacteo> lacteoList;

        public Gondola()
        {
            lacteoList = new List<Lacteo>();
        }

        

        public List<Lacteo> ListaLacteos
        {
            get { return lacteoList; }
            set { lacteoList = value; }
        }

    }
}
