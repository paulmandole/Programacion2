using System;

namespace BibliotecaClase9
{
    // calse abstracta no se instancia es decir no pudeo hacer x = new Animal()
    //se usa da molde
    public abstract class Animal
    {
        public string nombre;


        public Animal(string nombre)
        {
            this.nombre = nombre;
        }

        //puede tener propiedades abstractas
        public abstract string JuegoFavorito { get; }

        //no tiene cuerpo me obliga a implementar este metodo en sus hijos
        public abstract string EmitirSonido();
        //lo hago en los hijos con el override


        ////para poder sobre escrivir el metodo en los hijos
        //public virtual string EmitirSonido()
        //{
        //    return "Emitiendo Sonido....";
        //}
        public string Pensar()
        {
            return "Estoy pensando...";
        }
        public static bool operator ==(Animal g1, Animal g2)
        {
            return g1 is not null && g2 is not null && g1.nombre == g2.nombre;
        }
        public static bool operator !=(Animal g1, Animal g2)
        {
            return !(g1 == g2);
        }
    }

    public class Perro : Animal
    {
        public override string JuegoFavorito
        {
            get { return "Pelota"; }
        }
        public Perro(string nombre) : base(nombre)
        { 
        }
        //overrride para cambiar la iplementacion del padre
        public override string EmitirSonido()
        {
            return "Wooof";
        }
        public new string Pensar()
        {
            return "Los perros piensan."; 
        }


    }

    public class Gato : Animal
    {
        string jugueteFav;

        public override string JuegoFavorito
        {
            get { return this.jugueteFav; }
        }
        public Gato(string nombre):base (nombre)
        {
           
        }
        public override string EmitirSonido()
        {
            return "Miaaau";
        }
        public new string Pensar()
        {
            return "los gatos piensan";
        }

        public static bool operator ==(Gato g1, Gato g2)
        {
            //hago el casteo para q me tome el del padre
            return (Animal)g1 == g2 && g1.jugueteFav == g2.jugueteFav;
        }
        public static bool operator !=(Gato g1, Gato g2)
        {
            return !(g1 == g2);
        }

        //sobrcarga de Equals es como el == 
        public override bool Equals(object obj)
        {
            //as es un perador intenta convertir el tipo de la izquierda al de la derecha si no puede devuelve null
            //si no hago esto le paso cualquier otro objet que no se gato y se rompe
            Gato gato = obj as Gato;
            return gato is not null && this == gato;
        }



    }
    public class Gatito : Gato 
    {
        public Gatito(string nombre) : base(nombre)
        {
        }
    }
}
