using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        private string razonSocial;

        public Centralita()
        {
            listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            razonSocial = nombreEmpresa;
        }

        //property

        public float GananciasPorLocal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }

        public float GananciasPorTodas
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }
        public List<Llamada> Llamadas
        {
            get
            {
                return listaDeLlamadas;
            }
        }

        /// <summary>
        /// Muestra la informacion de la centralita
        /// </summary>
        /// <returns></returns>
        private string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine($"Razon Social: {razonSocial}");
            retorno.AppendLine($"Ganancia total: ${GananciasPorTodas:N2}");
            retorno.AppendLine($"Ganancia llamadas locales: ${GananciasPorLocal:N2}");
            retorno.AppendLine($"Ganancia llamadas provinciales: ${GananciasPorProvincial:N2}\n");

            retorno.AppendLine("Llamadas realizadas:");
            foreach (Llamada llamada in listaDeLlamadas)
            {
                if (llamada is Local)
                {
                    retorno.Append($"- {((Local)llamada).ToString()}");
                }
                else
                {
                    retorno.Append($"- {((Provincial)llamada).ToString()}");
                }


            }
            retorno.AppendLine("\n==================================================================");

            return retorno.ToString();
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float ganancia = 0;
            if (tipo == Llamada.TipoLlamada.Local)
            {
                foreach (Llamada llamada in Llamadas)
                {
                    if (llamada is Local)
                    {
                        ganancia = ganancia + ((Local)llamada).CostoLlamada;
                    }
                }
            }
            else if (tipo == Llamada.TipoLlamada.Provincial)
            {
                foreach (Llamada llamada in Llamadas)
                {
                    if (llamada is Provincial)
                    {
                        ganancia = ganancia + ((Provincial)llamada).CostoLlamada;
                    }
                }
            }
            else
            {
                foreach (Llamada llamada in Llamadas)
                {
                    if (llamada is Provincial)
                    {
                        ganancia = ganancia + ((Provincial)llamada).CostoLlamada;
                    }
                    else
                    {
                        ganancia = ganancia + ((Local)llamada).CostoLlamada;
                    }
                }
            }
            return ganancia;
        }

        public void OrdenarLlamadas()
        {
        }


        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            if (nuevaLlamada is not null)
            {
                listaDeLlamadas.Add(nuevaLlamada);
            }
        }

        /// <summary>
        /// Sobreescribe el metodo ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Mostrar();
        }

        /// <summary>
        /// Sobrecarga del operador ==. Utiliza la sobrecarga del operador == de la clase Llamada.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="llamada"></param>
        /// <returns></returns>
        public static bool operator ==(Centralita c, Llamada llamada)
        {
            if (c.listaDeLlamadas.Count != 0)
            {
                foreach (Llamada llam in c.listaDeLlamadas)
                {
                    if (llam == llamada)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        #region Sobrecargas

        /// <summary>
        /// Sobrecarga del operador !=. Utiliza la sobrecarga del operador == de la clase Llamada.
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }

        /// <summary>
        /// Sobrecarga del operador suma. Utiliza la sobrecarga del operador == de Centralita.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="llamada"></param>
        /// <returns></returns>
        public static Centralita operator +(Centralita c, Llamada llamada)
        {
            if (c == llamada)
            {
                return c;
            }
            c.AgregarLlamada(llamada);
            return c;
        }
        #endregion

    }
}
