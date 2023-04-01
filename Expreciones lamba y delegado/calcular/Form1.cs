using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcular
{
    
    public partial class Form1 : Form
    {
        private List<Persona> personas;

        //declaracion de un delegado no se puede declarar adentro de metodos es un tipo
        public delegate string MiMetodo(int i);
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEje_Click(object sender, EventArgs e)
        {
            //arroy function se usan para ordenar o cosas asi 

            //   arg1   arg2  retorno nombre de la funcion           argque recive              operacion
            Func<int, int, float>       dividir               =         (x,y)          =>          x / x;
            //Func<int, int, float> dividir = (x, y) =>
            //{
            //     return x / x;
            //};


            txt3.Text = dividir(4, 2).ToString();
        }

        //ordenamiento normal
        private static int OrdenarPorDni(Persona a, Persona b)
        {
            if (a.Dni > b.Dni)
                return 1;
            else if (a.Dni < b.Dni)
                return -1;
            else
                return 0;
        }

        private void btOrdenar_Click(object sender, EventArgs e)
        {
            this.personas = new List<Persona>();

            this.personas.Add(new Persona() { Dni = 3});
            this.personas.Add(new Persona() { Dni = 1 });
            this.personas.Add(new Persona() { Dni = 2 });
            this.personas.Add(new Persona() { Dni = 6 }); 

             //ordenamiento con landa
            Func<Persona, Persona, int> ordenamiento = (a, b) =>
            {
                if (a.Dni > b.Dni)
                    return 1;
                else if (a.Dni < b.Dni)
                    return -1;
                else
                    return 0;
            };

            //le paso la funcion en el parentesis
            this.personas.Sort((a, b) =>
            {
                if (a.Dni > b.Dni)
                    return 1;
                else if (a.Dni < b.Dni)
                    return -1;
                else
                    return 0;
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //para declarar delegados
            MiMetodo a = (entero) => entero.ToString();
            MiMetodo b = Algo;
        }

        private string Algo(int i)
        {
            return "";
        }
    }
}
