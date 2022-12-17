using Microsoft.VisualStudio.TestTools.UnitTesting;
using MS_TsetUserRegexSys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_TsetUserRegexSys.Tests
{
    [TestClass()]
    public class UserDetailTests
    {
        [TestMethod()]
        [DataRow("abc@bl.com")]    //pass
        [DataRow("abc.xyz@bl.co.in")]   //pass
        [DataRow("abc123@gmail.a")]     //fail
        [DataRow("abc.@gmail.com")]    //fail
        public void TestFirstName(string userInput)
        {
           
            bool output = UserDetail.Email(userInput);     

            
            Assert.AreEqual(output, true);
        }
    }
}