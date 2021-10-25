using System;
using System.Text;

namespace Biblioteca
{
    public abstract class Paquete
    {
        private string codigoSeguimiento;
        protected decimal costoEnvio;
        private string destino;
        private string origen;
        private double pesoKg;

        protected Paquete(string codigoSeguimiento, decimal costoEnvio, string destino, string origen, double pesoKg)
        {
            this.codigoSeguimiento = codigoSeguimiento;
            this.costoEnvio = costoEnvio;
            this.destino = destino;
            this.origen = origen;
            this.pesoKg = pesoKg;
        }

        public abstract bool TienePrioridad { get; }

        public string ObtenerInformacionDePaquete()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Código de seguimiento: {codigoSeguimiento}");
            sb.AppendLine($"Costo de envío: ${costoEnvio:N2}");
            sb.AppendLine($"Orígen: {origen}");
            sb.AppendLine($"Destino: {destino}");
            sb.AppendLine($"Peso: {pesoKg}");
            sb.AppendLine($"Tiene prioridad: {TienePrioridad}");

            return sb.ToString();
        }
    }
}
