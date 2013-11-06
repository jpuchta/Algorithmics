using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zegary
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] c = { 1 };
            int[][] A = { c,c };
            int P = 1;
            Console.WriteLine(Solution.Solve(A, P));
            Console.ReadLine();

        }
    }
}
