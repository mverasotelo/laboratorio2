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
            return (notaPrimerParcial + (float)notaSegundoParcial) / 2;
        }

        /// <summary>
        /// Define la nota final de un alumno. Si el alumno no alcanza el 4 en ambos parciales, la nota es -1, si si lo hizo, la nota se define mediante la generacion de un numero random entre 6 y 10.
        /// </summary>
        /// <returns>nota final</returns>
        public double CalcularNotaFinal()
        {
            double notaFinal = -1;
            if (notaPrimerParcial >= 4 && notaSegundoParcial >= 4)
            {
                notaFinal = random.Next(6, 11);
            }
            return notaFinal;
        }

        /// <summary>
        /// Muestra la informacion de un estudiante en formato string
        /// </summary>
        /// <returns>string con info</returns>
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

