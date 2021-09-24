using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibilioteca
{
    public sealed class Cuadrado : Rectangulo
    {
        public Cuadrado(float lado) : base(lado, lado)
        {
        }

        public override string Dibujar()
        {
            return "Dibujando Cuadrado...";
        }
    }
}
