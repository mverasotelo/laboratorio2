using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class AppMusical : Aplicacion
    {
        private List<string> listaCanciones;

        /// <summary>
        /// Constructor de la clase AppMusical
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="sistemaOperativo"></param>
        /// <param name="tamanioMb"></param>
        public AppMusical(string nombre, SistemaOperativo sistemaOperativo, int tamanioMb)
            :base(nombre, sistemaOperativo, tamanioMb)
        {
        }

        /// <summary>
        /// Sobrecarga del constructor de la clase AppMusical
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="sistemaOperativo"></param>
        /// <param name="tamanioMb"></param>
        public AppMusical(string nombre, SistemaOperativo sistemaOperativo, int tamanioMb, List<string> listaCanciones) 
            :this(nombre, sistemaOperativo, tamanioMb)
        {
            this.listaCanciones = listaCanciones;
        }


        public override int Tamanio
        {
            get
            {
                if(listaCanciones is not null)
                {
                    return tamanioMb + listaCanciones.Count * 2;
                }
                else
                {
                    return tamanioMb;
                }
            }
        }

        /// <summary>
        /// Muestra informacion de la App
        /// </summary>
        /// <returns></returns>
        public override string ObtenerInformacionApp()
        {
            StringBuilder retorno = new StringBuilder();


            retorno.AppendLine($"{base.ObtenerInformacionApp()}\n");
            if(listaCanciones is not null && listaCanciones.Count > 0)
            {
                retorno.AppendLine("Lista de canciones:");
                foreach (string c in listaCanciones)
                {
                    retorno.AppendLine(c);
                }
            }

            return retorno.ToString();
        }
    }
}
