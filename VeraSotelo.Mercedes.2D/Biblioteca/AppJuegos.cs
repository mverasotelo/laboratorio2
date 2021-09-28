﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class AppJuegos : Aplicacion
    {
        public AppJuegos(string nombre, SistemaOperativo sistemaOperativo, int tamanioMb) : 
            base(nombre, sistemaOperativo, tamanioMb)
        {
        }

        public override int Tamanio
        {
            get
            {
                return tamanioMb;
            }
        }
    }
}
