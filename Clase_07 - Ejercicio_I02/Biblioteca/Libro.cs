using System;
using System.Collections.Generic;

namespace Biblioteca
{
    public class Libro
    {
        private List<string> paginas;

        public Libro()
        {
            paginas = new List<string>();
        }
        public List<string> Paginas
        {
            get
            {
                return paginas;
            }
        }


        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < paginas.Count)
                { 
                    return paginas[index];
                }
                else
                {
                    return "";
                }
            }
            set
            {
                if (paginas is not null && index >= 0 && index < paginas.Count)
                {
                     paginas[index] = value;
                }
                else
                {
                    paginas.Add(value);
                }
            }
        }
    }
}
