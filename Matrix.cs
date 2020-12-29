using System;
using System.Runtime.CompilerServices;

namespace Homework.ITAcademy5
{
    public class Matrix
    {
        public int NumberOfRows { get; set; }
        public int NumberOrColumns { get; set; }
        public int[,] TheMatrix { get; set; }

        public void InitializingDimensions()
        {
            Console.WriteLine("Enter the number of rows and columns : (not more than 1000)");

            try
            {
                NumberOfRows = Convert.ToInt32(Console.ReadLine());
                NumberOrColumns = Convert.ToInt32(Console.ReadLine());
                if (NumberOfRows > 1000 || NumberOrColumns > 1000)
                {
                    Console.WriteLine("Too great a value. should be no more than 1000");
                    Environment.Exit(0);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            TheMatrix = new int[NumberOfRows, NumberOrColumns];
            FillingTheMatrix();
        }

        public void FillingTheMatrix()
        {
            var rnd=new Random();
            for (var i = 0; i < NumberOfRows; i++)
            {
                for (var j = 0; j < NumberOrColumns; j++)
                {
                    TheMatrix[i, j] = rnd.Next(1, 100);
                }
            }
            Show();
        }

        public void Show()
        {
            for (var i = 0; i < TheMatrix.GetLength(0); i++)
            {
                for (var j = 0; j < TheMatrix.GetLength(1); j++)
                {
                    Console.Write(TheMatrix[i,j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}