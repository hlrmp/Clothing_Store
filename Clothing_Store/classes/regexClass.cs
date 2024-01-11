using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Clothing_Store
{
    internal class regexClass
    {
        public static string letters = @"^[a-zA-Z][a-zA-Z\\s]+$";
        public static string numbers = @"^09[0-9]{9}$";
        public static string age = @"^[0-9]{1,3}$";
        public static string schar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
        public static string mix = @"^[A-Za-z0-9]";
        public static string Intg = @"^[0-9]+$";
        public static string doub = @"^[0-9]+[.[0-9]{0,2}]?";






    }
   
}
