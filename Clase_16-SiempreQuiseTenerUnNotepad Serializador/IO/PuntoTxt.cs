using System.IO;

namespace IO
{
    public class PuntoTxt : Archivo, IArchivo<string>
    {
        protected override string Extension
        {
            get
            {
                return ".txt";
            }
        }

        public void Guardar(string ruta, string contenido)
        {
            if (ValidarSiExisteElArchivo(ruta))
            {
                Escribir(ruta, contenido);
            }
        }

        public void GuardarComo(string ruta, string contenido)
        {
            if (ValidarExtension(ruta))
            {
                Escribir(ruta,contenido);
            }
        }

        public string Leer(string ruta)
        {
            string retorno = "";
            if (ValidarSiExisteElArchivo(ruta))
            {
                using (StreamReader streamReader = new StreamReader(ruta))
                {
                    retorno = streamReader.ReadToEnd();
                }
            }
            return retorno;
        }

        private void Escribir(string ruta, string contenido)
        {
            using (StreamWriter streamWriter = new StreamWriter(ruta))
            {
                streamWriter.Write(contenido);
            }
        }
    }
}
