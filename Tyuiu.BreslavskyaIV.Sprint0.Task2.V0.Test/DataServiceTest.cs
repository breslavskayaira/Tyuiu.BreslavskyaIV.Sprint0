using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BreslavskyaIV.Sprint0.Task2.V0.Lib;

namespace Tyuiu.BreslavskyaIV.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Ира";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Ира", res);
        }
    }
}
