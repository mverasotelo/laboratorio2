﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IO
{
    public class PuntoXml<T> : Archivo, IArchivo<T>
       where T : class
    {
        protected override string Extension
        {
            get
            {
                return ".xml";
            }
        }

        public void Guardar(string ruta, T contenido)
        {
            if (ValidarSiExisteElArchivo(ruta))
            {
                using (StreamWriter streamWriter = new StreamWriter(ruta))
                {
                    Serializar(ruta, contenido);
                }
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
            if (ValidarSiExisteElArchivo(ruta))
            {
                using (StreamReader streamReader = new StreamReader(ruta))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    retorno = xmlSerializer.Deserialize(streamReader) as T;
                }
            }
            return retorno;
        }

        private void Serializar(string ruta, T contenido)
        {
            using (StreamWriter streamWriter = new StreamWriter(ruta))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                xmlSerializer.Serialize(streamWriter, contenido);
            }
        }
    }
}