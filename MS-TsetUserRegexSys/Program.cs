using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_TsetUserRegexSys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User Registration using Regex.\n");
            string userInput = "Abc";
            UserDetail.PasswordMin8(userInput);

        }
    }
}
