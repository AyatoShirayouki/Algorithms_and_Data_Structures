using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2._3
{
    class Program
    {
        static int Calculate(int n)
        {
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n = n / 10;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Calculate(n));
        }
    }
}
