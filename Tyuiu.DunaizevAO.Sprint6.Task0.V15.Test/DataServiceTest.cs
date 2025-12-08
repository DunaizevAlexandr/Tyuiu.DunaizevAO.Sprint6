using Tyuiu.DunaizevAO.Sprint6.Task0.V15.Lib;

namespace Tyuiu.DunaizevAO.Sprint6.Task0.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = 4;
            double wait = 64;
            var res = ds.Calculate(a);
            Assert.AreEqual(wait, res);
        }
    }
}
