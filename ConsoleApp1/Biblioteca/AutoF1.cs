using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public AutoF1(string escuderia, short numero)
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



        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Auto Número {numero}");
            sb.AppendLine($"Escudería: {escuderia}");
            if (enCompetencia)
            {
                sb.AppendLine($"Vueltas restantes: {vueltasRestantes}");
                sb.AppendLine($"Cantidad combustible {cantidadCombustible}");
            }
            return sb.ToString();
        }


        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {   
            if(a1.numero == a2.numero && a1.escuderia == a2.escuderia)
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
