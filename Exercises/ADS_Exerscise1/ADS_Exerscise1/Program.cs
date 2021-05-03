using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS_Exerscise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N = ");
            int n = int.Parse(Console.ReadLine());
            int x;
            for (int j = 2; j <= n; j++)
            {
                x = 0;

                for (int i = 2; i <= j / 2; i++)
                {
                    if (j % i == 0)
                    {
                        x++;
                        break;
                    }
                }

                if (x == 0 && j != 1)
                    Console.Write("{0} ", j);
            }
            Console.WriteLine();
        }
    }
}
