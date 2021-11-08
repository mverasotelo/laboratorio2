﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public class ArchivoIncorrectoException : Exception
    {

        string mensaje;

        public ArchivoIncorrectoException(string mensaje)
            :base(mensaje)
        {
        }
    }
}
