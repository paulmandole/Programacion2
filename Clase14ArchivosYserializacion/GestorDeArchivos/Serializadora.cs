using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Text.Json;

namespace GestorDeArchivos
{
    public  static class Serializadora <T> where T : class,new()
    {
        public static void GuardarXml(T objeto,string path)
        {
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                //le  digo que tipo de objeto va a guardar
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                //guardo el streamwriter y el alumno
                xmlSerializer.Serialize(streamWriter, objeto);
            }
            
        }

        public static T LeerXml(string path)
        {
            using (StreamReader streamReader = new StreamReader(path))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                //tengo que castearlo a la lista de alumnos
                return  xmlSerializer.Deserialize(streamReader) as T;
            }
        }

        public static void GuardarJson(T objeto, string path)
        {
            JsonSerializerOptions option = new JsonSerializerOptions();
            option.WriteIndented = true;
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                string json = JsonSerializer.Serialize(objeto,option);

                ManejadorArchivosTexto.Guardar(path, json);

            }
        }

        public  static T LeerJson(string path)
        {
            string json = ManejadorArchivosTexto.LeerArchivo(path);

            return JsonSerializer.Deserialize<T>(json);
        }
    }
    //en la clase base
    //[XmlInclude(typeof(Profesor))] un decorador para cada una de las clases
    [XmlInclude(typeof(Alumno))]//para poder serializar una clase derivada
    public class Persona
    {
        
    }

    public class Alumno:Persona
    {
        private int edad;
        private string nombre;


        public Alumno()
        {
            
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

    }
}
