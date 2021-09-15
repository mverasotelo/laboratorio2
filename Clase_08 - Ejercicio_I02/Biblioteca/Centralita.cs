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
        }

        public Centralita(string nombreEmpresa)
        {
        }

        public string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine($"Razon Social: {razonSocial}");
            retorno.AppendLine($"Razon Social: {razonSocial}");
            retorno.AppendLine($"Razon Social: {razonSocial}");

            retorno.AppendLine("       Llamadas realizadas:");
            foreach (Llamada llamada in listaDeLlamadas)
            {
                retorno.AppendLine($"{llamada.Mostrar()}");

            }

            return retorno.ToString();
        }

        private float CalcularGanancia()
        {
            return 0;
        }

        public void OrdenarLlamadas()
        {
        }
    }
}
