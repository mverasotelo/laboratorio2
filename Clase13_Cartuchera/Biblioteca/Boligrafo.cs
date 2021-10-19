using System;

namespace Biblioteca
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.colorTinta = color;
            this.tinta = unidades;
        }

        public float UnidadesDeEscritura
        {
            get
            {
                return tinta;
            }
            set
            {
                tinta = value;
            }
        }

        public ConsoleColor Color
        {
            get
            {
                return colorTinta;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public EscrituraWrapper Escribir(string texto)
        {
            EscrituraWrapper escritura = new EscrituraWrapper(texto, Color);

            foreach (char c in texto)
            {
                tinta -= 0.3F;
            }
            return escritura;
        }

        public bool Recargar(int unidades)
        {
            if (unidades > 0)
            {
                tinta += unidades;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"Boligrafo {Color}\nNivel de tinta: {tinta:N2}";
        }
    }
}
