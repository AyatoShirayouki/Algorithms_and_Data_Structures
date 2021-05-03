using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1._1
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
        static void MostOften(int[] arr, int n)
        {
            int mOften = int.MinValue;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!dict.ContainsKey(arr[i]))
                {
                    dict.Add(arr[i], 1);
                }
                else
                {
                    dict[arr[i]]++;
                }
            }
            mOften = dict.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
            Console.WriteLine($"Most common element is: {mOften}");
        }
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            arr = Input(arr, n);
            MostOften(arr, n);
        }
    }
}
