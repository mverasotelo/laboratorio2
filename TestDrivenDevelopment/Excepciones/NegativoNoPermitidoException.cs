using System;

namespace Excepciones
{
    public class NegativoNoPermitidoException : Exception
    {
        public NegativoNoPermitidoException(string message, Exception inner)
            :base(message, inner)
        {
        }

        public NegativoNoPermitidoException(string message)
            :this(message, null)
        {
        }
    }
}
