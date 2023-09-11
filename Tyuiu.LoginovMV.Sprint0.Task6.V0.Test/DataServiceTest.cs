using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LoginovMV.Sprint0.Task6.V0.Lib;

namespace Tyuiu.LoginovMV.Sprint0.Task6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAddArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.AddArray(numbers);
            Assert.AreEqual(15, res);
        }

        public void CheckSubtrArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.SubtrArray(numbers);
            Assert.AreEqual(-15, res);
        }

        public void CheckMultiplicationArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.MultiArray(numbers);
            Assert.AreEqual(120, res);
        }
    }
}
