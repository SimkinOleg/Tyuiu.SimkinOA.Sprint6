using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SimkinOA.Sprint6.Task1.V20.Lib
{
    public class DataService : ISprint6Task1V20
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] values = new double[stopValue - startValue + 1];
            int index = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (Math.Cos(x) - 2 * x == 0)
                {
                    values[index] = 0;
                    index++;
                    continue;
                }
                values[index] = Math.Round((2 * x - 3) / (Math.Cos(x) - 2 * x) + 5 * x - Math.Sin(x), 2);
                index++;
            }
            return values;
        }
    }
}