using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.DunaizevAO.Sprint6.Task4.V12.Lib
{
    public class DataService : ISprint6Task4V12
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res;
            int len = stopValue - startValue + 1;
            res = new double[len];
            double temp_res;
            int cnt = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (3*x + 0.5 == 0)
                {
                    temp_res = 0;
                    cnt++;
                }
                else
                {
                    temp_res = Math.Round((Math.Sin(x) + (2)/(3*x + 0.5) - 2*Math.Cos(x) * 2*x), 2);
                    res[cnt] = temp_res;
                    cnt++;
                }
            }
            return res;
        }
    }
}
