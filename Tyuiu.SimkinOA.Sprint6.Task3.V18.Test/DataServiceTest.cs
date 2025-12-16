using Tyuiu.SimkinOA.Sprint6.Task3.V18.Lib;
namespace Tyuiu.SimkinOA.Sprint6.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckMatrix()
        {
            DataService ds = new DataService();

            int[,] matrix = { { -19, -19, 1, 18, 7 },
                             { 5, 3, -4, -6, -12 },
                             { -15, 6, 2, 2, -14, },
                             { -9, -10, 15, -5, -6 },
                             { -13, -15, -9, 7, 1 } };

            int[,] expectedMatrix = { { -19, -19, 1, 18, 7 },
                             { 5, 3, -4, -6, -12 },
                             { -15, 6, 2, 2, -14, },
                             { -9, 0, 15, -5, 0 },
                             { -13, -15, -9, 7, 1 } };

            int[,] resultMatrix = ds.Calculate(matrix);


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Assert.AreEqual(expectedMatrix[i, j], resultMatrix[i, j],
                        $"Mismatch at position [{i}, {j}]. Expected: {expectedMatrix[i, j]}, Actual: {resultMatrix[i, j]}");
                }
            }
        }
    }
}