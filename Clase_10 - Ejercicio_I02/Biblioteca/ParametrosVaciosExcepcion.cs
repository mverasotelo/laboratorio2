using System;

namespace Biblioteca
{
    public class ParametrosVaciosExcepcion : Exception
    {
        public ParametrosVaciosExcepcion(string message)
            :this(message, null)
        {
        }
        public ParametrosVaciosExcepcion(string message, Exception inner)
            :base(message, inner)
        {
        }
    }
}
