using System;

namespace Biblioteca
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;

        public Lapiz(int unidades)
        {
            tamanioMina = unidades;
        }

        ConsoleColor IAcciones.Color
        {
            get
            {
                return ConsoleColor.Gray;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        float IAcciones.UnidadesDeEscritura
        {
            get
            {
                return tamanioMina;
            }
            set 
            {
                tamanioMina = value;
            }
        }

        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            if(texto is not null)
            {
                if (texto.Length * 0.1 < tamanioMina)
                {
                    foreach (char c in texto)
                    {
                        if(c!=' ')
                        {
                            tamanioMina -= 0.1F;
                        }
                    }
                    return new EscrituraWrapper(texto, ((IAcciones)this).Color); ;
                }
            }
            return null;
        }

        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Lapiz {((IAcciones)this).Color}\nNivel de tinta: {tamanioMina:N2}";
        }
    }
}
