using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class AutoF1 : VehiculoDeCarrera
    {
        private short caballosDeFuerza;

        public AutoF1(string escuderia, short numero)
            :base(escuderia, numero)
        {
        }

        public AutoF1(string escuderia, short numero, short caballosDeFuerza)
        : this(escuderia, numero)
        {
            this.caballosDeFuerza = caballosDeFuerza;
        }

        public short CaballosDeFuerza
        {
            get
            {
                return caballosDeFuerza;
            }
            set
            {
                this.caballosDeFuerza = value;
            }

        }
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatos());
            sb.AppendLine($"Caballos de fuerza: {caballosDeFuerza}");
            return sb.ToString();
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            if (a1 == a2 && a1.caballosDeFuerza == a2.caballosDeFuerza)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
    }
}
