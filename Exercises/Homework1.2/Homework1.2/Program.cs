using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1._2
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
        static int[] Combine(int[] arr1, int[] arr2, int[] arr3)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < arr1.Length; i++)
            {
                list.Add(arr1[i]);
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                list.Add(arr2[i]);
            }
            list.Sort();

            for (int i = 0; i < list.Count; i++)
            {
                arr3[i] = list[i];
            }
            return arr3;
        }
        static void Main(string[] args)
        {
            Console.Write("N1 = ");
            int n1 = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n1];

            arr1 = Input(arr1, n1);

            Console.Write("N2 = ");
            int n2 = int.Parse(Console.ReadLine());
            int[] arr2 = new int[n2];

            arr2 = Input(arr2, n2);

            int[] arr3 = new int[n1 + n2];

            arr3 = Combine(arr1, arr2, arr3);

            for (int i = 0; i < arr3.Length; i++)
            {
                Console.WriteLine(arr3[i]);
            }
        }
    }
}
