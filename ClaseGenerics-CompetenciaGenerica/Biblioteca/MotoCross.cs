using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class MotoCross : VehiculoDeCarrera
    {
        private short cilindrada;

        public MotoCross(string escuderia, short numero)
            : base(escuderia, numero)
        {
        }

        public MotoCross(string escuderia, short numero, short cilindrada)
        : this(escuderia, numero)
        {
            this.cilindrada = cilindrada;
        }

        public short Cilindrada
        {
            get
            {
                return cilindrada;
            }
            set
            {
                this.cilindrada = value;
            }
        }

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatos());
            sb.AppendLine($"Cilindrada: {cilindrada}");
            return sb.ToString();
        }

        public static bool operator ==(MotoCross m1, MotoCross m2)
        {
            if (m1 == m2 && m1.cilindrada == m2.cilindrada)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(MotoCross m1, MotoCross m2)
        {
            return !(m1 == m2);
        }
    }
}
