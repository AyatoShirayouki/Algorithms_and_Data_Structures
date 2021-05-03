using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {3,40,21,5,8,2,99,90,34,1,7,9 };
            //int temp = 0;
            //for (int i = arr.Length - 1; i > 0; i--)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        if (arr[j] > arr[j + 1])
            //        {
            //            temp = arr[j];
            //            arr[j] = arr[j + 1];
            //            arr[j + 1] = temp;
            //        }
            //    }
            //}

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
