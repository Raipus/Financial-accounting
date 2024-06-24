using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms ;
using System.Collections.Generic;

namespace projectMoney.Tests
{
    [TestClass]
    public class ExpensesTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            DateTime time = DateTime.ParseExact("12.12.2023", "dd.MM.yyyy", null);
            int sum = 156;
            string g = "adf";

            Expenses exp = new Expenses(time,sum, g);

            Assert.AreEqual(exp.time, time);
            Assert.AreEqual(exp.money, sum);
            Assert.AreEqual(exp.purchase, g);
        }
    }
}
