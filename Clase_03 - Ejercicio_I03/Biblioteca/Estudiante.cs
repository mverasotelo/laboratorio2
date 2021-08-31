using System;
using System.Text;

namespace Biblioteca
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        static Random random;

        static Estudiante()
        {
            random = new Random();
        }

        public Estudiante(string apellido, string legajo, string nombre)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }

        public void SetNotaSegundoParcial(int nota)
        {
            notaSegundoParcial = nota;
        }

        public void SetNotaPrimerParcial(int nota)
        {
            notaPrimerParcial = nota;
        }

        private float CalcularPromedio()
        {
            return (notaPrimerParcial + (float)notaSegundoParcial) / 2; //con castear uno solo ya esta
        }

        public double CalcularNotaFinal()
        {
            double notaFinal = -1;
            if (notaPrimerParcial >= 4 && notaSegundoParcial >= 4)
            {
                notaFinal = random.Next(6, 11);
            }

            return notaFinal;
        }

        public string Mostrar()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine($"Nombre y Apellido: {nombre} {apellido} - Legajo: {legajo}");
            info.AppendLine($"Nota Primer Parcial: {notaPrimerParcial} - Nota Segundo Parcial: {notaSegundoParcial}");
            info.AppendLine($"Promedio: {CalcularPromedio()}");
            info.AppendLine($"Nota final: {CalcularNotaFinal()}");
            return info.ToString();
        }
    }
}

