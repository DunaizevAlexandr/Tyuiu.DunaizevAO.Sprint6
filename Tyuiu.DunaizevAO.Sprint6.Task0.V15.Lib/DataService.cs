using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.DunaizevAO.Sprint6.Task0.V15.Lib
{
    public class DataService : ISprint6Task0V15
    {
        public double Calculate(int x)
        {
            double y = Math.Pow(x, 3) + 2 * Math.Pow(x, 2) + 5 * x + 4;
            y = Math.Round(y, 3);
            return y;
        }
    }
}
