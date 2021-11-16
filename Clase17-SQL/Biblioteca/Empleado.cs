using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Empleado
    {
        private int idEmpleado;
        private string nombre;
        private string apellido;
        private float salario;

        public Empleado(string nombre, string apellido, float salario)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.salario = salario;
        }

        public int IdEmpleado { get => idEmpleado; }
        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }
        public float Salario { get => salario;}

        public string Mostrar()
        {
            return $"{IdEmpleado} - {Nombre} {Apellido} - ${Salario}";
        }
    }
}
