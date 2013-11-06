using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zegary;

namespace ZegaryTests
{
    [TestClass]
    public class SanityTests
    {
        private SolutionTester ST=new SolutionTester();
        [TestMethod]
        public void AAA_TimeConsumerPseudoTest()
        {
            int[] c = { 1 };
            int[][] A = { c };
            int P = 1;
            int result = Solution.Solve(A, P);
            Assert.AreEqual<int>(0, result);
        }
        [TestMethod]
        public void Sanity_SingleClock()
        {
            for (int P = 1; P < 100; P++)
            {
                Assert.AreEqual<int>(0, ST.SingleRandomClockForP(P));
            }
        }
        [TestMethod]
        public void Sanity_TwoClocks()
        {
            for (int P = 1; P < 100; P++)
            {
                Assert.AreEqual<int>(1, ST.TwoRandomClocksForP(P));
            }
        }


        [TestMethod]
        public void Sanity_Example()
        {
            int P = 4;
            int [][] A={new int[] {1,2},new int[] {2,4}, new int[] {2,3},new int[] {1,4},new int[]{3,1}};

            Assert.AreEqual<int>(4, Solution.Solve(A, P));
        }
        [TestMethod]
        public void Sanity_SeveralSimpleExamples()
        {
            Example[] ExSet = GenerateExamples();
            foreach (Example e in ExSet)
                Assert.AreEqual<int>(e.result, Solution.Solve(e.A, e.P));
        }

        private Example[] GenerateExamples()
        {
 	        Example[] przyklady = new Example[1];//docelowo 10
            int result, P;
            int[][] A;

            //Przyklad 0
            P = 6;
            A=new int[][] {new int[] {1,3,6}, new int[] {1,2,5}, new int[] {3,1,6}, new int[] {1,4,5}, new int[] {5,4,2}};
            result = 4;
            przyklady[0] = new Example(result,P,A);
            return przyklady;
        }

        [TestMethod]
        public void FourClocksExample()
        {
            int[][] A = new int[][] { new int[] { 2, 3, 1, 4, 5 }, new int[] { 6, 3, 5, 4, 1 }, new int[] { 4, 2, 5, 6, 1 }, new int[] { 2, 4, 5, 3, 6 } };
            int P = 6;
            int result = 6;
            Assert.AreEqual<int>(result, Solution.Solve(A, P));
        }

    }
}
