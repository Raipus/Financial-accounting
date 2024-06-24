using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using projectMoney;
using System.Collections.Generic;

namespace projectMoney.Tests
{
    [TestClass]
    public class GainTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            DateTime time = DateTime.ParseExact("12.12.2023", "dd.MM.yyyy", null);
            int sum = 156;
            string g = "adf";

            Gain gain = new Gain(time, sum, g);

            Assert.AreEqual(gain.time, time);
            Assert.AreEqual(gain.money, sum);
            Assert.AreEqual(gain.from, g);
        }
    }
}
