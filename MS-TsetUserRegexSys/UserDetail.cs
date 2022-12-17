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
        public static bool PasswordMin8(string userInput)
        {
            string regexCondition = "^[a-zA-Z0-9]{8,}$";
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
