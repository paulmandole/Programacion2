using System;

namespace BibliotecaClase8
{
    //aca le aclaro que estoy heredando de publicacion

    //sealed hace q no se pueda deribar de esta clase
    public sealed class Libro : Publicacion
    {
        public string autor;

        private float precio;

        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        // :base hace q invoque al cosntructo de la clase padre
        public Libro(string titulo,string autor ,DateTime fechaPublicacion) : base(titulo, fechaPublicacion)
        {
            this.autor = autor;
        }

        //new para ocultar la implementacion del metodo heredado de publicaciones decir va a usar este no el que hereda
        public new string MostrarDatos()
        {
            //getType() devuelve el tipo de la instancia es decier el nameSpace y el nombre de la clase . name muestra solo el nombre de la clase
            //reutilizo la funcion mostrar del padre y le agrego los nuevos campos del hijo
            //return $"{base.MostrarDatos()} autor: {this.autor}";            
            return $"{this.GetType().Name} Titulo: {this.Titulo} Autor:{this.autor} - Publicacion: {this.FechaPublicacion.Date}";
        }


    }
}
