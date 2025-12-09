using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.DunaizevAO.Sprint6.Task1.V7.Lib
{
    public class DataService : ISprint6Task1V7
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double del = (Math.Cos(x) + x);
                if (del == 0)
                {
                    y = 0;
                }
                else
                    y = Math.Round(((2 * x - 3) / del) + 5, 2);
                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}
