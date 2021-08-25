//using System;

namespace Biblioteca
{
    /// <summary>
    ///     Valida que una respuesta sea afirmativa ("S")
    /// </summary>
    public class Validador
    {
        public static bool ValidarRespuesta(string respuesta)
        {
            return (respuesta == "S");
        }
    }
}
