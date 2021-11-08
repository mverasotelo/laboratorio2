﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace IO
{
    public class PuntoJson<T> : Archivo, IArchivo<T>
        where T: class
    {
        protected override string Extension
        {
            get
            {
                return ".json";
            }
        }

        public void Guardar(string ruta, T contenido)
        {
            if (ValidarExtension(ruta) && ValidarSiExisteElArchivo(ruta))
            {
                Serializar(ruta, contenido);
            }
        }

        public void GuardarComo(string ruta, T contenido)
        {
            if (ValidarExtension(ruta))
            {
                Serializar(ruta, contenido);
            }
        }

        public T Leer(string ruta)
        {
            T retorno = null;
            if (ValidarExtension(ruta) && ValidarSiExisteElArchivo(ruta))
            {
                using (StreamReader streamReader = new StreamReader(ruta))
                {
                    retorno = JsonSerializer.Deserialize<T>(streamReader.ReadToEnd());
                }
            }
            return retorno;
        }

        private void Serializar(string ruta, T contenido)
        {
            using (StreamWriter streamWriter = new StreamWriter(ruta))
            {
                string contenidoJson = JsonSerializer.Serialize(contenido);
                streamWriter.Write(contenidoJson);
            }
        }
    }
}
