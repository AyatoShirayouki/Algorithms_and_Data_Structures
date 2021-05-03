using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace durvetaMutveta
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree<int> tree = new Tree<int>(20, new Tree<int>(22), new Tree<int>(8, new Tree<int>(4), new Tree<int>(12, new Tree<int>(10), new Tree<int>(14))));
            tree.DFS();
        }
    }
}
