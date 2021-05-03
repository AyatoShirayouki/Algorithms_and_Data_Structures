using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2._1
{
    class Program
    {
        static int check(int[] arr, int n)
        {
            if (n == 1 || n == 0)
                return 1;

            if (arr[n - 1] < arr[n - 2])
                return 0;

            return check(arr, n - 1);
        }
        static void Main(string[] args)
        {
            int[] arr = new int[9];
            int n = arr.Length;
            Console.WriteLine("Enter 9 lements: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"arr[{i}] = ");
                arr[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            if (check(arr, n) == 1)
            {
                Console.WriteLine("Numbers are monotonically increasing!");
            }
            else
            {
                Console.WriteLine("Numbers are NOT monotonically increasing!");
            }
        }
    }
}
