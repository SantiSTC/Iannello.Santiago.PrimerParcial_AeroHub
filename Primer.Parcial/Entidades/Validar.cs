using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Validar
    {
        public static bool EsDni(int dni) 
        {
            if(dni.ToString().Count() == 8 && dni < 99999999 && dni > 00000001) 
            {
                return true;
            }
            return false;
        }

        public static bool EsDni(string dni) 
        {
            int dniValido;

            if (int.TryParse(dni, out dniValido) && dni.Count() == 8 && dniValido < 99999999 && dniValido > 00000001)
            {
                return true;
            }
            return false;
        }
    }
}
