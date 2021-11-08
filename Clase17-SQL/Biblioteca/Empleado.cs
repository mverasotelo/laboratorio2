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
        private bool estaActivo;

        public Empleado(int idEmpleado, string nombre, string apellido, float salario)
        {
            this.idEmpleado = idEmpleado;
            this.nombre = nombre;
            this.apellido = apellido;
            this.salario = salario;
        }

        public string Mostrar()
        {
            return $"{idEmpleado} - {nombre} {apellido} - ${salario}";
        }
    }
}
