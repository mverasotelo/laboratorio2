using System;
using System.Text;

namespace Biblioteca
{
    public class Ingresante
    {
        private string[] cursos;
        private string direccion;
        private int edad;
        private string genero;
        private string nombre;
        private string pais;

        public Ingresante(string[] cursos, string direccion, int edad, string genero, string nombre, string pais)
        {
            this.cursos = cursos;
            this.direccion = direccion;
            this.edad = edad;
            this.genero = genero;
            this.nombre = nombre;
            this.pais = pais;
        }

        /// <summary>
        /// Muestra informacion sobre el ingresante
        /// </summary>
        /// <returns>string con la informacion</returns>
        public string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendLine($"Nombre: {nombre}");
            retorno.AppendLine($"Edad: {edad}");
            retorno.AppendLine($"Pais: {pais}");
            retorno.AppendLine($"Genero: {genero}");
            retorno.AppendLine($"Direccion: {direccion}");
            retorno.AppendLine($"Cursos:");

            foreach (string curso in cursos)
            {
                retorno.AppendLine($"{curso}");
            }
            return retorno.ToString();
        }
    }
}
