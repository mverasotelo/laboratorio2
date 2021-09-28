using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Dispositivo
    {
        private static List<Aplicacion> appInstaladas;
        private static SistemaOperativo sistemaOperativo;

        static Dispositivo()
        {
            Dispositivo.appInstaladas = new List<Aplicacion>();
            Dispositivo.sistemaOperativo = SistemaOperativo.ANDROID;
        }
        public static string ObtenerInformacionDispositivo()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine($"Sistema Operativo: {sistemaOperativo}\n");
            
            if (appInstaladas.Count > 0)
            {
                foreach (Aplicacion a in appInstaladas)
                {
                    retorno.AppendLine(a.ObtenerInformacionApp());
                }
            }
            return retorno.ToString();
        }

        public static bool InstalarApp(Aplicacion app)
        {
            if(app.SistemaOperativo == sistemaOperativo)
            {
                if (appInstaladas != app)
                {
                    appInstaladas += app;
                    return true;
                }
            }
            return false;
        }
    }
}
