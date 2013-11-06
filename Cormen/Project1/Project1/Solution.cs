using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Solution
    {
        public int BR_Root(int N)
        {
            int SP = StopienParzystosci(N);
            int P = DwaDoX(SP);
            int M = N / P;
            int k = Log(M) / 2;
            int A_Min = DwaDoX(k) + 1;
            int A_Max = 2 * (A_Min - 1);

            int A = A_Min;
            int B = A_Min;
            while (A < A_Max)
            {
                if (A * B == M)
                    return (A * P);
                else
                {
                    A += 2;
                    B = BR_Incr(B,A_Max);
                }
            }
            return -1;
        }

        private int StopienParzystosci(int N)
        {
            int SP=0;
            while (N % 2 == 0)
            {
                SP++;
                N /= 2;
            }
            return SP;
        }
        private int DwaDoX(int x)
        {
            int Out = 1;
            while (x-- > 0)
            {
                Out *= 2;
            }
            return Out;
        }
        private int Log(int N)
        {
            int Out = 0;
            while (N/2>0)
            {
                Out++;
                N/=2;
            }
            return Out;
        }
        private int BR_Incr(int B, int Min)
        {
            int step = Min/2;
            while (B + step > 2 * Min)
            {
                step /= 2;
            }
            return B + step;
        }
    }
}
