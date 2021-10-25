using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class CompetenciaNoDisponibleException : Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo)
        {
            nombreClase = clase;
            nombreMetodo = metodo;
        }

        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo, Exception innerException)
            :this(mensaje, clase, metodo)
        {
        }

        public string NombreClase
        {
            get
            {
                return nombreClase;
            }
        }

        public string NombreMetodo
        {
            get
            {
                return nombreMetodo;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Excepción en el método {nombreMetodo} de la clase {nombreClase}");
            sb.AppendLine($"{this.Message}");
            sb.AppendLine($"{this.InnerException}");
            return sb.ToString();
        }
    }
}
