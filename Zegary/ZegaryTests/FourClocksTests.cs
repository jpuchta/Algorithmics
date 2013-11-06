using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zegary;
using System.Collections.Generic;

namespace ZegaryTests
{
    [TestClass]
    public class FourClocksTests
    {
        [TestMethod]
        public void FourClocks()
        {
            int i, j, k, l;
            int actual;
            for (i = 0; i < 720; i++)
            {
                for (j = 0; j < 120; j++)
                {
                    for (k = 0; k < 24; k++)
                    {
                        for (l = 0; l < 6; l++)
                        {
                            actual=Solve(i, j, k, l);
                            Assert.AreEqual<int>(6, actual);
                        }
                    }
                }
            }
        }
        
        private int Solve(int i, int j, int k, int l)
        {
            int[][] A=new int[4][];
            A[0]=Get6Clock(i);
            A[1]=Get6Clock(j);
            A[2]=Get6Clock(k);
            A[3]=Get6Clock(l);
            
            return Solution.Solve(A,6);
        }

//        private int[] Get6Clock(int i)
  //      {
    //        return Permutation(i).
      //  }

        private int[] Get6Clock(int n)
        {
            int[] dividors = { 720, 120, 24, 6, 2, 1, 1 };
            List<int> numbers = new List<int>(new int[] {1,2,3,4,5,6});
            int[] result = new int[5];
            int index;

            for (int i = 0; i < 5; i++)
            {
                index = (n%dividors[i])/dividors[i+1];
                result[i] = numbers[index];
                numbers.RemoveAt(index);
            }
            return result;
        }
    }
}
