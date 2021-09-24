using System;

namespace Biblioteca
{
    public abstract class Sobrescrito
    {

        protected string miAtributo;

        public Sobrescrito() :base()
        {
        }

        abstract public string MiPropiedad { get; }

        abstract public string MiMetodo();

        public override string ToString()
        {
            return "¡Este es mi método ToString sobrescrito!";
        }

        public override bool Equals(object obj)
        {
            return obj.GetType() == typeof(Sobrescrito);
        }

        public override int GetHashCode()
        {
            return 1142510181;
        }
    }
}
