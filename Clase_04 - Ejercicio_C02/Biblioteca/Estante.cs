using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacionEstante):this(capacidad)
        {
            this.ubicacionEstante = ubicacionEstante;
        }

        public Producto[] GetProductos()
        {
            return productos;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine($"Ubicacion del estante: {e.ubicacionEstante}");
            retorno.AppendLine("Productos:");

            foreach (Producto p in e.productos)
            {
                if (!(p is null))
                {
                    retorno.AppendLine($"{Producto.MostrarProducto(p)}");
                }
            }
            return retorno.ToString();
        }


        public static bool operator ==(Estante e, Producto p)
        {
            bool retorno = false;
            foreach (Producto prod in e.productos)
            {
                if (!(prod is null) && prod == p)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        public static bool operator +(Estante e, Producto p)
        {
            if(e != p)
            {
                for(int i=0; i < e.productos.Length; i++)
                {
                    if(e.productos[i] is null)
                    {
                        e.productos[i] = p;
                        return true;
                    }
                }
            }
            return false;
        }

        public static Estante operator -(Estante e, Producto p)
        {
            if (e == p)
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (e.productos[i] == p)
                    {
                        e.productos[i] = null;
                        break; ;
                    }
                }
            }
            return e;
        }

    }

}
