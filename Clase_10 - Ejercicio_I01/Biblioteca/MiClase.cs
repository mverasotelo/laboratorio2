using System;

namespace Biblioteca
{
    public class MiClase
    {
        public MiClase()
        {
            MetodoEstatico();
        }

        public MiClase(Exception e)
            :this()
        {
            new MiClase();
        }


        public static void MetodoEstatico()
        {
            throw new DivideByZeroException();
        }
    }
}
