﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Email : IMensaje 
    {
        private string origen;
        private string email;

        public Email(string origen, string email)
        {
            this.origen = origen;
            this.email = email;
        }

        public string EnviarMendaje()
        {
            return "Flata mucho para terminar? :)  ";
        }
    }
}
