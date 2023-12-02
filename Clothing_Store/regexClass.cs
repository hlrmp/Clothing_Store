using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clothing_Store
{
    internal class regexClass
    {
        public static string letters = @"^[a-zA-Z]+$";
        public static string numbers = @"^09[0-9]{9}$";
        public static string age = @"^[0-9]{1,3}$";
        public static string schar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
        public static string mix = @"^[A-Za-z0-9]";
    }
}
