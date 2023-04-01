using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Carta :Papel,IMensaje
    {
        public string sello;
        List<Carta> cartaList;

        
        public Carta(string tipo, int cantHojas) : base(tipo, cantHojas)
        {
            
        }
        public string AbrirCarta()
        {
            return "AbriendoCartar..";
        }

        public string EnviarMendaje()
        {
            return "esta es una declaracion de guerra";
        }
    }
}
