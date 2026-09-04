using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ErmakovSE.Sprint0.Task2.V0.Lib;
namespace Tyuiu.ErmakovSE.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Сава";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет///, Сава", res);
        }
    }
}
