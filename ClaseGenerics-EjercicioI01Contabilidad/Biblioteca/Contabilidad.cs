using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
   public class Contabilidad<T,U>
        where T: Documento
        where U: Documento, new()
    {
        public List<U> ingresos;
        public List<T> egresos;

        public Contabilidad()
        {
            ingresos = new List<U>();
            egresos = new List<T>();
        }

        public static bool operator +(Contabilidad<T,U> contabilidad, T egreso)
        {
            if(contabilidad is not null && egreso is not null)
            {
                foreach(T t in contabilidad.egresos)
                {
                    if (t == egreso)
                    {
                        return false;
                    }
                }
                contabilidad.egresos.Add(egreso);
                return true;
            }
            return false;
        }


        public static bool operator +(Contabilidad<T, U> contabilidad, U ingreso)
        {
            if (contabilidad is not null && ingreso is not null)
            {
                foreach (T t in contabilidad.egresos)
                {
                    if (t == ingreso)
                    {
                        return false;
                    }
                }
                contabilidad.ingresos.Add(ingreso);
                return true;
            }
            return false;
        }

    }
}
