using System;

namespace Homework.ITAcademy5
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix firstMatrix = new Matrix();
            firstMatrix.InitializingDimensions();

            Matrix secondMatrix = new Matrix();
            secondMatrix.InitializingDimensions();

            if (firstMatrix.NumberOfRows != secondMatrix.NumberOrColumns)
            {
                Console.WriteLine("The number of rows in the first matrix is not equal to the number of columns in the second");
                Environment.Exit(0);
            }
            else
            {

            }
        }
    }
}

