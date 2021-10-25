using System;
using System.IO;

namespace Archivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); //trae ruta absotula al escritorio
            string rutaMisDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            //VerificarSO();
            //ObtenerInfoPC();
            //ObtenerInfoAlmac();
            ////CrearDirectorioEnEscritorio("ClaseArchivos");
            //Console.WriteLine(Path.GetFullPath(".")); //Ruta absoluta a mi posicion
            //Console.WriteLine(Path.GetRelativePath(rutaEscritorio,".")); //Ruta relativa desde el escritorio a mi posicion
            //Console.WriteLine(Path.GetRelativePath(".",rutaEscritorio)); //Ruta relativa desde mi posicion al escritorio
            //Console.WriteLine(Path.GetRelativePath(rutaMisDocumentos, rutaEscritorio)); //Ruta relativa desde mi posicion al escritorio
            
            //string[] archivos = Directory.GetFiles("."); //Devuelve string con archivos existentes en al ruta especificada

            //foreach(string a in archivos)
            //{
            //    Console.WriteLine(a);
            //}

            //string rutaArchivoDdl = Path.Combine(".", "Archivos.dll"); //Devuelve ruta al archivo
            //Console.WriteLine(Path.GetExtension(rutaArchivoDdl)); //Devuelve extension del archivo de la ruta
            //Console.WriteLine(Path.GetFileName(rutaArchivoDdl)); //Devuelve nombre completo
            //Console.WriteLine(Path.GetFileNameWithoutExtension(rutaArchivoDdl)); //Devuelve nombre sin extension
            //Console.WriteLine(Path.HasExtension(rutaArchivoDdl)); //Devuelve si tiene extension
            //Console.WriteLine(Path.GetRandomFileName()); 

            EscribirArchivoTextoConStreamWriter("archivo.txt");
            //LeerArchivoTextoConStreamWriterConFinally();
            LeerArchivoTextoConFile();

        }

        static void EscribirArchivoTextoConStreamWriter(string nombre)
        {
            string ruta = CrearDirectorioEnEscritorio("Archivos");
            using (StreamWriter sw = new StreamWriter(Path.Combine(ruta, nombre), true))
            {
                sw.WriteLine("Hola mundo!");
            }
        }

        static void EscribirArchivoTextoConStreamWriterConFinally(string nombre)
        {
            StreamWriter sw = null;
            try
            {
                string ruta = CrearDirectorioEnEscritorio("Archivos");
                sw = new StreamWriter(Path.Combine(ruta, nombre), true);
                sw.WriteLine("Hola mundo!");
                sw.WriteLine("Chau mundo!");
            }
            finally
            {
                if(sw is not null)
                {
                    sw.Close();
                    sw.Dispose();
                }
            }
        }

        static void LeerArchivoTextoConStreamWriter()
        {
            string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string ruta = Path.Combine(rutaEscritorio, "Archivos", "archivo.txt");

            using (StreamReader sr = new StreamReader(ruta))
            {
                while (sr.EndOfStream)
                {
                    string lineaTexto = sr.ReadLine();
                    Console.WriteLine(lineaTexto);
                }
            }
        }

        static void LeerArchivoTextoConFile()
        {
            string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string ruta = Path.Combine(rutaEscritorio, "Archivos", "archivo.txt");

            if (File.Exists(ruta))
            {
                string texto = File.ReadAllText(ruta);
                Console.WriteLine(texto);
            }
        }

        static void LeerArchivoTextoConStreamWriterConFinally()
        {
            StreamReader sr = null;
            try
            {
                string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string ruta = Path.Combine(rutaEscritorio, "Archivos", "archivo.txt");
                sr = new StreamReader(ruta);

                while (sr.EndOfStream)
                {
                    string lineaTexto = sr.ReadLine();
                    Console.WriteLine(lineaTexto);
                }
            }
            finally
            {
                if (sr is not null)
                {
                    sr.Close();
                    sr.Dispose();
                }
            }
        }

        static void VerificarSO()
        {
            Console.WriteLine($"Es Linux? {OperatingSystem.IsLinux()}");
            Console.WriteLine($"Es Windows? {OperatingSystem.IsWindows()}");
            Console.WriteLine("---------------");
        }

        static void ObtenerInfoPC()
        {
            Console.WriteLine($"Es 64BITS? {Environment.Is64BitProcess}");
            Console.WriteLine($"Usuario: {Environment.UserName}");
            Console.WriteLine("---------------");
        }

        static void ObtenerInfoAlmac()
        {
            DriveInfo[] volumenes = DriveInfo.GetDrives();

            foreach(DriveInfo drive in volumenes)
            {
                Console.WriteLine($"Nombre:{drive.Name}");
                Console.WriteLine($"Tipo: {drive.DriveType}");
                Console.WriteLine($"Tamaño: {drive.TotalSize} B");
                Console.WriteLine($"Tamaño disponible: {drive.AvailableFreeSpace} B");

                Console.WriteLine("---------------");
            }

        }
        static string CrearDirectorioEnEscritorio(string nombreDirectorio)
        {
            string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); //trae ruta absotula al escritorio
            string rutaNuevoDirectorio = Path.Combine(rutaEscritorio, nombreDirectorio);
            if (!Directory.Exists(rutaNuevoDirectorio))
            {
                Directory.CreateDirectory(rutaNuevoDirectorio);
            }
            return rutaNuevoDirectorio;
        }
    }
}
