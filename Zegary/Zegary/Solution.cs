using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zegary
{
    class Solution
    {
        public static int Solve(int[][] A, int P)
        {
            int N = A.Length;
            long[] Invs = new long[N];
            Clock C;
            for (int i = 0; i < N; i++)
            {
                C=new Clock(A[i],P);
                Invs[i] = C.GetInv();
            }

            return GetResult(GetBlocks(Invs));
        }

        private static int GetResult(List<int> list)
        {
            int result = 0;
            foreach (int x in list)
                result += (x * (x - 1)) / 2;
            return result;
        }

        private static List<int> GetBlocks(long[] Invs)
        {
            Array.Sort<long>(Invs); //O(N*log(N))
            int N = Invs.Length;
            List<int> blocks = new List<int>();
            int buffor=1;
            for (int i = 1; i < N; i++)
            {
                if (Invs[i] == Invs[i - 1])
                    buffor++;
                else
                {
                    blocks.Add(buffor);
                    buffor = 1;
                }
            }
            blocks.Add(buffor);
            return blocks;
        }

    }
}
