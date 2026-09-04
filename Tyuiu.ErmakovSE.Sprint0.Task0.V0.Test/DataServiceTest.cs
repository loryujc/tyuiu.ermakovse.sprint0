using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using tyuiu.ermakovse.sprint0.task2.v0.lib;
namespace tyuiu.ermakovse.sprint0.task2.v0.test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Сава";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Сава", res);
        }
    }
}
