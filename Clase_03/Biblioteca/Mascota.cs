using System;

namespace Biblioteca
{
    public class Mascota
    {
        private string nombre;
        private DateTime fechaNacimiento;
        private string especie;

        public Mascota(string nombre, DateTime fechaNacimiento, string especie)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.especie = especie;
        }
        public string GetNombre()
        {
            return nombre;
        }

        public void SetNombre(string nuevoNombre)
        {
            nombre = nuevoNombre.Trim();
        }

        public string GetEspecie()
        {
            return especie;
        }

        public void SetEspecie(string nuevaEspecie)
        {
            nombre = nuevaEspecie.Trim();
        }
    }
}
