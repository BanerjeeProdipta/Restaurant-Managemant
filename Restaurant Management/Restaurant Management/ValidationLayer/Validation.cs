using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant_Management.ApplicationLayer;
using System.Text.RegularExpressions;

namespace Restaurant_Management.ValidationLayer
{
    public static class Validation
    {
        internal static bool IsStringValid(string value)
        {
            if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
                return false;

            else
                return true;
        }

        internal static bool IsIntValid(string value)
        {
            int x;
            return Int32.TryParse(value, out x);
        }


        internal static bool IsEmailValid(string value)
        {

            Regex re = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");  //Regex for valid email
            Match match = re.Match(value);
            if (match.Success)
            {
                return true;
            }

            else
                return false;
        }


        internal static bool IsPhoneValid(string value)  //Phone Num valid for Bangladesh
        {

            if (value.Length == 11)
            {
                return true;
            }
            else
            {
                return false;
            }
        }










    }
}
