using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPrime = true;
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            //int closest = 0;

            for (int i = 2; i <= 2*n; i++)
            {
                for (int j = 2; j <= 2*n; j++)
                {

                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }
                if (isPrime && i >= n + 1)
                {
                    Console.WriteLine(i);
                    break;
                }
                isPrime = true;
            }
            //Console.WriteLine();
        }
    }
}
