using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class VehiculoDeCarrera
    {
        protected short cantidadCombustible;
        protected bool enCompetencia;
        protected string escuderia;
        protected short numero;
        protected short vueltasRestantes;

        public VehiculoDeCarrera(string escuderia, short numero)
        {
            this.escuderia = escuderia;
            this.numero = numero;
            this.enCompetencia = false;
            this.vueltasRestantes = 0;
            this.cantidadCombustible = 0;
        }

        public bool EnCompetencia
        {
            get
            {
                return enCompetencia;
            }
            set
            {
                this.enCompetencia = value;
            }
        }

        public short CantidadCombustible
        {
            get
            {
                return cantidadCombustible;
            }
            set
            {
                this.cantidadCombustible = value;
            }
        }

        public short VueltasRestantes
        {
            get
            {
                return vueltasRestantes;
            }
            set
            {
                this.vueltasRestantes = value;
            }
        }
        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Número {numero}");
            sb.AppendLine($"Escudería: {escuderia}");
            if (enCompetencia)
            {
                sb.AppendLine($"Vueltas restantes: {vueltasRestantes}");
                sb.AppendLine($"Cantidad combustible: {cantidadCombustible}");
            }
            return sb.ToString();
        }


        public static bool operator ==(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            if (v1.numero == v2.numero && v1.escuderia == v2.escuderia)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return !(v1 == v2);
        }
    }
}
