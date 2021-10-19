using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class CartucheraMultiuso
    {
        public List<IAcciones> acciones;

        public CartucheraMultiuso()
        {
            acciones = new List<IAcciones>();
        }

        public bool RecorrerElementos()
        {
            foreach (IAcciones item in acciones)
            {
                if(item.UnidadesDeEscritura - 1 < 0)
                {
                    if(item is Boligrafo)
                    {
                        item.Recargar(20);
                    }
                    return false;
                }
                item.UnidadesDeEscritura -= 1;
            }
            return true;
        }
    }
}
