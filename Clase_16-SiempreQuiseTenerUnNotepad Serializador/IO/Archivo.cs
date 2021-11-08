using System;
using System.IO;

namespace IO
{
    public abstract class Archivo
    {
        protected abstract string Extension { get; }

        public bool ValidarExtension(string ruta)
        {
           if(ValidarSiExisteElArchivo(ruta))
            {
                if(Path.GetExtension(ruta) == Extension)
                {
                    return true;
                }
           }
           throw new ArchivoIncorrectoException($"El archivo no tiene la extensión [{Extension}].");
        }

        public bool ValidarSiExisteElArchivo(string ruta)
        {
            if (File.Exists(ruta))
            {
                return true;
            }
            throw new ArchivoIncorrectoException("Archivo no se encontró");
        }
    }
}
