using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public static class ExtensionColors
    {
        public static bool IsPrimaryColor(this string inString)
        {
            string[] primaryColor = { "Red", "Yellow", "Blue", "Orange" };
            foreach (var color in primaryColor)
            {
                if (inString.Equals(color, StringComparison.CurrentCultureIgnoreCase))
                    return true;
            }
            return false;
        }
    }
}
