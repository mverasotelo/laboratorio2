using System;

namespace Biblioteca
{
    public class Cliente
    {
        private string nombreYApellido;
        private string domicilio;
        private int telefono;

        public Cliente(string nombreYApellido, string domicilio, int telefono)
        {
            this.nombreYApellido = nombreYApellido;
            this.domicilio = domicilio;
            this.telefono = telefono;
        }
    }
}
