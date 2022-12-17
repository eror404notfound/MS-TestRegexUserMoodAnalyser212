using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MS_TsetUserRegexSys
{
    public class UserDetail
    {
        public static bool Email(string userInput)
        {
            string regexCondition = "^[a-z0-9]{1,}([._+-]{1}[a-z0-9]{1,}){0,1}[@]{1}[a-z0-9]{1,}[.]{1}[a-zA-Z]{2,3}([.]{1}[a-z]{2,3}){0,1}$";
            if (Regex.IsMatch(userInput, regexCondition))
            {
                Console.WriteLine("Validated successfully!\n");
                return true;
            }
            else
            {
                Console.WriteLine("Entered Details are not in required format.Please try again!\n");
                return false;
            }
        }
    }
}
