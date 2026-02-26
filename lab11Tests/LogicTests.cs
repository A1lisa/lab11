using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void LuckTest()
        {
            var a = Logic.Compare("123123");
            Assert.AreEqual("число счастливое", a);
        }

        [TestMethod()]
        public void UnluckTest()
        {
            var a = Logic.Compare("856524");
            Assert.AreEqual("число несчастливое", a);
        }

        [TestMethod()]
        public void not6Test() {
            var a = Logic.Compare("85");
            Assert.AreEqual("число не шестизначное", a);
        }
     

    }
}