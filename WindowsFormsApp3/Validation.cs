using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace WindowsFormsApp3
{
    class Validation
    {
        public bool isValidEmailAddress(String s)
        {
            if (string.IsNullOrEmpty(s))
                return false;
            else
            {
                var regex = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
                return regex.IsMatch(s) && !s.EndsWith(".");
            }
        }
        
        public bool isValidContactNumber(String num)
        {
            return Regex.Match(num, @"^(\+[0-9]{9})$").Success ;
        }

        static bool ValidateDate(string date, out DateTime dt)
        {
            bool isValid = DateTime.TryParseExact(date, "yyyyMMdd", null, 0, out dt);
            if (!isValid) return false;
            DateTime min = new DateTime(1967, 1, 1);
            DateTime max = new DateTime(3000, 1, 1);
            if (dt < min || dt > max) return false;
            return true;
        }

        public static bool IsNumber(string s)
        {
            return s.All(char.IsDigit);
        }

       
    }
}
