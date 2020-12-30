using System;
using System.Threading;
using System.Threading.Tasks;

namespace Homework.ITAcademy5
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstMatrix = new Matrix();
            firstMatrix.InitializingDimensions();

            var secondMatrix = new Matrix();
            secondMatrix.InitializingDimensions();

            if (firstMatrix.NumberOfRows != secondMatrix.NumberOrColumns || firstMatrix.NumberOrColumns != secondMatrix.NumberOfRows)
            {
                Console.WriteLine("The number of rows in the first matrix is not equal to the number of columns in the second");
                Environment.Exit(0);
            }
            else
            {
                var thirdMatrix = new Matrix { TheMatrix = MultiplyMatrix(firstMatrix, secondMatrix) };

                Console.WriteLine("Result matrix");
                thirdMatrix.Show();
            }
        }

        public static int[,] MultiplyMatrix(Matrix first, Matrix second)
        {
            var resultMatrix = new int[first.NumberOfRows, second.NumberOrColumns];

            var commonLength = first.NumberOrColumns;

            Parallel.For(0, resultMatrix.GetLength(0), (i) =>
            {
                for (var j = 0; j < resultMatrix.GetLength(1); j++)
                {
                    var nextVal = 0;

                    for (var k = 0; k < commonLength; k++)
                    {
                        nextVal += first.TheMatrix[i, k] * second.TheMatrix[k, j];
                    }

                    resultMatrix[i, j] = nextVal;
                }
            });
            return resultMatrix;
        }
    }
}


