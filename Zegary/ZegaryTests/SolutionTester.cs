using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zegary;

namespace ZegaryTests
{
    class SolutionTester
    {
        private static Random R = new Random();
        private static int MaxP=1000000000;

        public int SingleRandomClockForP(int P)
        {
            int[][] A =new int[1][];
            A[0]=new int[1];
            A[0][0]=R.Next(1,P);

            return Solution.Solve(A,P);
        }

        public int TwoRandomClocksForP(int P)
        {
            int[][] A = new int[2][];
            A[0] = new int[1]; A[1] = new int[1];
            A[0][0] = R.Next(1, P);
            A[1][0] = R.Next(1, P);

            return Solution.Solve(A, P);
        }

        static public int[][] InitEmpyArray(int N, int M)
        {
            int[][] A = new int[N][];
            for (int i = 0; i < N; i++)
                A[i] = new int[M];
            return A;
        }

        public int RandomClocks(int N, int M)
        {
            int[][] A = new int[N][];
            for (int i = 0; i < N; i++)
                A[i] = GenerateRandomClock(M, MaxP);
            return Solution.Solve(A,MaxP);
        }

        private int[] GenerateRandomClock(int M, int P)
        {
            int[] c = new int[M];
            for (int i = 0; i < M; i++)
                c[i] = R.Next(1, P);
            return c;
        }


    }
}
