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
        [DataRow("91 9212354865")]    //pass
        [DataRow("91 9945812348")]   //pass
        [DataRow("91 08545641236")]     //fail
        [DataRow("919354789654 ")]    //fail
        public void TestFristName(string userInput)
        {
            
            bool output = UserDetail.MobileNo(userInput);  

            Assert.AreEqual(output, true);
        }
    }
}