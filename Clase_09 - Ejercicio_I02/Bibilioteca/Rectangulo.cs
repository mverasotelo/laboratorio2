using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibilioteca
{
    public class Rectangulo : Figura
    {
        protected float baseRectangulo;
        protected float alturaRectangulo;


        public Rectangulo(float baseRectangulo, float alturaRectangulo)
        {
            this.baseRectangulo = baseRectangulo;
            this.alturaRectangulo = alturaRectangulo;
        }


        public override string Dibujar()
        {
            return "Dibujando Rectángulo...";
        }

        public override double CalcularSuperficie()
        {
            return baseRectangulo * alturaRectangulo;
        }

        public override double CalcularPerimetro()
        {
            return (baseRectangulo + alturaRectangulo) * 2;
        }
    }
}
