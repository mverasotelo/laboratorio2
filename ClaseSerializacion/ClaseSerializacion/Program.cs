using System;
using System.IO;
using System.Xml.Serialization;

namespace ClaseSerializacion
{
    class Program
    {
        static void Main(string[] args)
        {
            string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string ruta = Path.Combine(rutaEscritorio, "persona.xml");

            Alumno p = new Alumno();
            p.Nombre = "Mercedes";
            p.Edad = 32;
            p.Sexo = 'f';
            p.Legajo = 1234;

            SerializarAXml(ruta, p);
            Alumno p2 = DeserializarAXml<Alumno>(ruta);

            Console.WriteLine(p2.ToString());
        }

        public static void SerializarAXml<T>(string ruta, T objeto)
        {
            using (StreamWriter streamWriter = new StreamWriter(ruta))
            {
                XmlSerializer xml = new XmlSerializer(typeof(T));
                xml.Serialize(streamWriter, objeto);
            }
        }

        public static T DeserializarAXml<T>(string ruta)
            where T: class
        {
            using (StreamReader streamReader = new StreamReader(ruta))
            {
                XmlSerializer xml = new XmlSerializer(typeof(T));
                T objeto = xml.Deserialize(streamReader) as T;
                return objeto;
            }
        }
    }

    [XmlInclude(typeof(Alumno))]
    public class Persona
    {
        private string nombre;
        private int edad;
        private char sexo;

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                edad = value;
            }
        }

        public char Sexo
        {
            get
            {
                return sexo;
            }
            set
            {
                sexo = value;
            }
        }

        public override string ToString()
        {
            return $"{nombre} - Edad: {edad} - Sexo: {sexo}";
        }
    }

    public class Alumno : Persona
    {
        private int legajo;

        public int Legajo
        {
            get
            {
                return legajo;
            }
            set
            {
                legajo = value;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()} - Legajo: {legajo}";
        }
    }
}
