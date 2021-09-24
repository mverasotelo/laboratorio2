using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibilioteca
{
    public sealed class Circulo : Figura
    {
        private float radio;

        public Circulo(float radio) : base()
        {
            this.radio = radio;
        }

        public override string Dibujar()
        {
            return "Dibujando Círculo...";
        }

        public override double CalcularSuperficie()
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        public override double CalcularPerimetro()
        {
            return Math.PI * radio * 2;
        }

    }
}
