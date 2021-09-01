using System;
using System.Text;

namespace Biblioteca
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigo, float precio)
        {
            codigoDeBarra = codigo;
            this.marca = marca;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return marca;
        }


        public float GetPrecio()
        {
            return precio;
        }


        public static string MostrarProducto(Producto p)
        {
            return $"Codigo de barra: {p.codigoDeBarra} | Marca: {p.GetMarca()} | Precio: ${p.precio:N2}";
        }

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            if(!(p1 is null) && !(p2 is null))
            {
                return p1.codigoDeBarra == p2.codigoDeBarra && p1.marca == p2.marca;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            if (!(p1 is null) && !(p2 is null))
            {
                return !(p1 == p2);
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Producto p, string marca)
        {
            return p.marca == marca;
        }

        public static bool operator !=(Producto p1, string marca)
        {
            return !(p1 == marca);
        }
    }
}