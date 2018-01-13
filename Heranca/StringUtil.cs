using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casa.Financas.Entidade
{
    static class StringUtil
    {
        public static string Plurarize(this string texto)
        {
            if (texto.EndsWith("s"))
            {
                return texto;
            }
            else
            {
                return texto + "s";
            }
        }

        public static double Dobro(this double valor)
        {
            return valor * 2;
        }
    }
    
}
