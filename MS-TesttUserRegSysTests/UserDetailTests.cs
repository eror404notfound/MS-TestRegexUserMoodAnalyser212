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
        [DataRow("Abc45678")]    //pass
        [DataRow("Abcd567890")]   //pass
        [DataRow("a2345678")]     //fail
        [DataRow("Abc123")]    //fail
        public void TestFirstName(string userInput)
        {
            
            bool output = UserDetail.UpperCase1Numeric1(userInput); 
            Assert.AreEqual(output, true);
        }
    }
}