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
        public void FirstNameTest()
        {

            string userInput = "Abc";
            bool output = UserDetail.LastName(userInput);

            Assert.AreEqual(output, true);
        }
    }
}