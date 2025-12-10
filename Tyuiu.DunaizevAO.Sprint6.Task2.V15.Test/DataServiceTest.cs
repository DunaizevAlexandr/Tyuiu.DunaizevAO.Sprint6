using Tyuiu.DunaizevAO.Sprint6.Task2.V15.Lib;

namespace Tyuiu.DunaizevAO.Sprint6.Task2.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = -5;
            int end = 5;

            int len = end - start + 1;

            double[] value;
            value = new double[len];

            value[0] = 70.14;
            value[1] = 55.21;
            value[2] = 41.05;
            value[3] = 27.96;
            value[4] = 15.48;
            value[5] = 1;
            value[6] = -13.06;
            value[7] = -28.16;
            value[8] = -42.96;
            value[9] = -56.77;
            value[10] = -69.83;


            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(start, end);
            CollectionAssert.AreEqual(res, value);
        }
    }
}
