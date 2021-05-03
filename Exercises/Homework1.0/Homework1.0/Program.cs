using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1._0
{
    class Program
    {
        static int[] Input(int[] arr, int n)
        {
            
            int input = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"arr[{i}] = ");
                input = int.Parse(Console.ReadLine());
                arr[i] = input;
                Console.WriteLine();
            }
            return arr;
        }
        static void Sum(int[] arr, int num)
        {
            int sum = 0;
            for (int i = 0; i < num; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine($"Sum of the first {num} elements is: {sum}"); 
        }
        static void Main(string[] args)
        {
            int n = 0;
            Console.Write("Array size(N < 20): ");
            n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            arr = Input(arr, n);
            Console.Write($"Enter the number of elements you want to find the sum of: ");
            int num = int.Parse(Console.ReadLine());
            if (num <= n)
            {
                Sum(arr, num);
            }
            else
            {
                Console.WriteLine("Incorect input!");
            }
        }
    }
}
