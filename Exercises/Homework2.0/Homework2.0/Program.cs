using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2._0
{
    class Program
    {
        static void print(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
        static int[,] Input(int[,] matrix)
        {
            int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"matrix[{i}][{j}] = ");
                    int t = int.Parse(Console.ReadLine());
                    result[i, j] = t;
                }
                Console.WriteLine();
            }
            return result;
        }
        static void Verify(int[,] matrix)
        {
            bool isMagical = false;
            int rowSum = 0;
            int colSum = 0;
            int diagonal1Sum = 0;
            int diagonal2Sum = 0;

            int firstRow = 0;
            int firstCol = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == 0)
                    {
                        firstRow += matrix[i, j];
                        firstCol += matrix[j,i];
                        rowSum += matrix[i,j];
                        colSum += matrix[j, i];
                    }
                    else
                    {
                        rowSum += matrix[i, j];
                        colSum += matrix[j, i];
                    }
                    if (i == j)
                    {
                        diagonal2Sum += matrix[i, j];
                    }
                }
                diagonal1Sum += matrix[i,i];
            }
            
            //Console.WriteLine(rowSum + "---" + firstRow);
            //Console.WriteLine(colSum + "---" + firstCol);
            //Console.WriteLine(diagonal1Sum);
            //Console.WriteLine(diagonal2Sum);

            if (rowSum / matrix.GetLength(0) == colSum / matrix.GetLength(0) && rowSum / matrix.GetLength(0) == diagonal1Sum && rowSum / matrix.GetLength(0) == diagonal2Sum &&
                colSum / matrix.GetLength(0) == diagonal1Sum && colSum / matrix.GetLength(0) == diagonal2Sum && diagonal1Sum == diagonal2Sum)
            {
                isMagical = true;
            }
            Console.WriteLine($"Is the square magical: {isMagical}");
        }
        static void Main(string[] args)
        {
            Console.Write("Enter square dimension(1-20): ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n,n];
            matrix = Input(matrix);
            print(matrix);
            Verify(matrix);
        }
    }
}
