using System;
using AtencionAlCliente;

namespace Clase_07___Eejrcicio_I01
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Cliente c1 = new Cliente("Mercedes",123);
            Cliente c2 = new Cliente("Juan", 124);
            Cliente c3 = new Cliente("Maria", 125);
            Cliente c4 = new Cliente("Daniel", 125);

            Console.WriteLine($"{c3 == c4}");


            Cliente[] clientes = { c1, c2, c3, c4 };

            Negocio n = new Negocio("Banco");

            foreach (Cliente c in clientes)
            {
                if (n + c)
                {
                    Console.WriteLine($"El cliente {c.Nombre} se ha agregado correctamente a la cola con el número {c.Numero}");
                }
                else
                {
                    Console.WriteLine($"El cliente {c.Nombre} no se ha podido agregar correctamente a la cola con el número porque ya habia otro cliente con numero {c.Numero}");
                }
            }


            foreach (Cliente c in clientes)
            {
                if (~n)
                {
                    Console.WriteLine($"El cliente {c.Nombre} se ha sido atendido");
                }
            }
        }
    }
}
