using System;

namespace EjercicioParcial
{
    public abstract class A
    {
        public abstract string MetodoLoco();
    }

    public class B : A
    {
        public override string MetodoLoco()
        {
            return "fALSE";
        }
    }

    public class C : B
    {
        public override string MetodoLoco()
        {
            return $"{base.MetodoLoco()} it fanny";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            B b = new C();
            A a = b;
            Console.WriteLine(a.MetodoLoco());
        }
    }
}
