using System;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace Biblioteca
{
    public class Persona
    {
        public string nombre;
        public string apellido;

        public Persona()
        {
            
        }
        public Persona(string nombre, string apellido):this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }
        public static void GuardarXml(Persona p)
        {
            try
            {
                using (StreamWriter stream = new StreamWriter(@"F:\practica de clases hechas por mi\SerializacionEjercicio I04 - La siempre clásica y eficaz receta\miXml.xml"))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Persona));

                    xmlSerializer.Serialize(stream, p);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static Persona LeerXml()
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(@"F:\practica de clases hechas por mi\SerializacionEjercicio I04 - La siempre clásica y eficaz receta\miXml.xml"))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Persona));

                    return xmlSerializer.Deserialize(streamReader) as Persona;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        public static void GuardarJson(Persona p)
        {
            JsonSerializerOptions opcion = new JsonSerializerOptions();
            opcion.WriteIndented = true;

            try
            {
                using (StreamWriter stream = new StreamWriter(@"F:\practica de clases hechas por mi\SerializacionEjercicio I04 - La siempre clásica y eficaz receta\miJson.json"))
                {
                    string Json = JsonSerializer.Serialize(p,opcion);

                    stream.WriteLine(Json);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        public static Persona LeerJson()
        {
            try
            {
                string json = LeerArchivo(@"F:\practica de clases hechas por mi\SerializacionEjercicio I04 - La siempre clásica y eficaz receta\miJson.json");

                return JsonSerializer.Deserialize<Persona>(json);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static string LeerArchivo(string path)
        {
            try
            {
                //using no tengo q cerrarlo
                using (StreamReader streamReader = new StreamReader(path))
                {
                    //lee todo lo del archivo
                    return streamReader.ReadToEnd();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        public override string ToString()
        {
            return $"Nombre:{this.nombre}Apellido:{this.apellido}";
        }
    }
}
