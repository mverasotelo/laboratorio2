using System;

namespace Biblioteca
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaNacimiento;
        private int dni;

        /// <summary>
        /// Constructor de la clase Persona
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="fechaNacimiento"></param>
        /// <param name="dni"></param>
        public Persona(string nombre, DateTime fechaNacimiento, int dni)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.dni = dni;
        }

        //getters
        /// <summary>
        /// Getter del nombre
        /// </summary>
        /// <returns>nombre</returns>
        public string GetNombre()
        {
            return nombre;
        }

        /// <summary>
        /// Getter del DNI
        /// </summary>
        /// <returns>dni</returns>
        public int GetDNI()
        {
            return dni;
        }

        /// <summary>
        /// Getter de la fecha de nacimiento
        /// </summary>
        /// <returns>fecha de nacimient</returns>
        public DateTime GetFechaNacimiento()
        {
            return fechaNacimiento;
        }

        /// <summary>
        /// Calcula la edad de una persona a partir de su fecha de nacimiento
        /// </summary>
        /// <returns>edad en entero</returns>
        private int CalcularEdad()
        {
            return DateTime.Today.AddTicks(-fechaNacimiento.Ticks).Year - 1;
        }

        /// <summary>
        ///     Muestra la informacion de una persona, incluyendo su nombre, DNI y edad
        /// </summary>
        /// <returns> string con los datos</returns>
        public string Mostrar()
        {
            return $"Nombre: {nombre} - DNI: {dni} - Edad: {CalcularEdad()}";
        }

        /// <summary>
        /// Calcula si es una persona es mayor de edad
        /// </summary>
        /// <returns>Devuelve un string "Es menor" si es menor y "Es mayor de edad" si es mayor</returns>
        public string EsMayorDeEdad()
        {
            if (CalcularEdad() < 18)
            {
                return "Es menor";
            }
            else
            {
                return "Es mayor de edad";
            }
        }
    }
}