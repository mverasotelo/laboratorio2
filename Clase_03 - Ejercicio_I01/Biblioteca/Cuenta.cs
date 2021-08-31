using System;

namespace Biblioteca
{
    public class Cuenta
    {
        private string titular;
        private float cantidad;

        /// <summary>
        /// Constructor de la clase Cuenta
        /// </summary>
        /// <param name="titular"></param>
        /// <param name="cantidad"></param>
        public Cuenta(string titular, float cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        /// <summary>
        /// Getter de titular
        /// </summary>
        /// <returns></returns>
        public string GetTitular()
        {
            return titular;
        }

        /// <summary>
        /// Getter de cantidad
        /// </summary>
        /// <returns>cantidad</returns>
        public float GetCantidad()
        {
            return cantidad;
        }

        /// <summary>
        /// Muestra la info de una cuenta
        /// </summary>
        /// <returns>string con la info</returns>
        public string Mostrar()
        {
            string info = $"{titular} - $ {cantidad:N2}";
       
            return info;
        }

        /// <summary>
        /// Ingresa un monto pasado por parametro de la cantidad
        /// </summary>
        /// <param name="monto">monto a ingresar</param>
        public void Ingresar(float monto)
        {
            if (monto > 0)
            {
                cantidad += monto;
            }
        }

        /// <summary>
        /// Retira un monto pasado por parametro de la cantidad
        /// </summary>
        /// <param name="monto">monto a retirar</param>
        public void Retirar(float monto)
        {
            if (monto > 0)
            {
                cantidad -= monto;
            }
        }

    }
}
