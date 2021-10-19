using System;

namespace Biblioteca
{
    public interface IAcciones
    {
        ConsoleColor Color { get; set; }

        float UnidadesDeEscritura{ get; set;}

        EscrituraWrapper Escribir(string texto);

        bool Recargar(int unidades);

    }
}
