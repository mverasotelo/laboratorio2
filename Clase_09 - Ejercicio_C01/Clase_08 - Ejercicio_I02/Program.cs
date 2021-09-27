using System;
using Centralita;

namespace Clase_08___Ejercicio_I02
{
    class Program
    {
        static void Main(string[] args)
        {
            Centralita.Centralita c = new Centralita.Centralita("Fede Center");

            // Mis 4 llamadas
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial l2 = new Provincial("Morón", Provincial.Franjas.Franja_1, 21, "Bernal");
            Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
            Provincial l4 = new Provincial(l2.NroOrigen, Provincial.Franjas.Franja_3, l2.Duracion, l2.NroDestino);

            // Las llamadas se irán registrando en la Centralita.
            // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.
            c += l1;
            c += l2;
            c += l3;
            c += l4;

            c.OrdenarLlamadas();
            Console.WriteLine(c.ToString());

            Console.ReadKey();
        }
    }
}
