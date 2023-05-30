using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Validar
    {
        public static bool EsDni(string dni) 
        {
            int dniValido;

            if (int.TryParse(dni, out dniValido) && dni.Count() == 8 && dniValido < 99999999 && dniValido > 00000001)
            {
                return true;
            }
            return false;
        }

        public static bool esMatricula(string matricula) 
        {
            if(matricula.Count() == 8 && Regex.IsMatch(matricula, "^[a-zA-Z0-9]*$")) 
            {
                return true;
            }

            return false;
        }

        public static bool esNombreOApellido(string nombre) 
        {
            if (nombre.All(c => Char.IsLetter(c))) 
            {
                return true;
            }

            return false;
        }

        public static bool esEdad(string edad) 
        {
            int edadValida;

            if (int.TryParse(edad, out edadValida) && edadValida > 0 && edadValida < 130) 
            {
                return true;
            }

            return false;
        }
    }
}
