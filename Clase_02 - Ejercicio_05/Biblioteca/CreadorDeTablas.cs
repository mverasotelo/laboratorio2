using System.Text;

namespace Biblioteca
{
    public class CreadorDeTablas
    {
        public static string DevolverTabla(int numero)
        {
            StringBuilder retorno = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                retorno.AppendLine($"{numero} x {i} = {numero * i}");
            }
            return retorno.ToString();
        }
    }
}