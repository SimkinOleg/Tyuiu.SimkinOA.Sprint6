
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SimkinOA.Sprint6.Task3.V18.Lib
{
    public class DataService : ISprint6Task3V18
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rowToCheck = 3;
            if (matrix.GetLength(0) > rowToCheck)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[rowToCheck, j] % 2 == 0)
                    {
                        matrix[rowToCheck, j] = 0;
                    }
                }
            }
            return matrix;
        }
    }
}