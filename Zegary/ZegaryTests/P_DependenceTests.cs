using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zegary;

namespace ZegaryTests
{
    [TestClass]
    public class P_DependenceTests
    {
        SolutionTester ST = new SolutionTester();
        
        [TestMethod]
        public void PD_SingleClockPEqual1000()
        {
            for (int P = 1; P < 1000; P++)
            {
                Assert.AreEqual<int>(0, ST.SingleRandomClockForP(P));
            }
        }
        [TestMethod]
        public void PD_SingleClockPEqual10000()
        {
            for (int P = 1; P < 10000; P++)
            {
                Assert.AreEqual<int>(0, ST.SingleRandomClockForP(P));
            }
        }
        [TestMethod]
        public void PD_SingleClockPEqual100000()
        {
            for (int P = 1; P < 100000; P++)
            {
                Assert.AreEqual<int>(0, ST.SingleRandomClockForP(P));
            }
        }
        [TestMethod]
        public void PD_SingleClockPEqual1000000()
        {
            for (int P = 1; P < 1000000; P++)
            {
                Assert.AreEqual<int>(0, ST.SingleRandomClockForP(P));
            }
        }


        [TestMethod]
        public void PD_TwoClocksPEqual1000()
        {
            for (int P = 1; P < 1000; P++)
            {
                Assert.AreEqual<int>(1, ST.TwoRandomClocksForP(P));
            }
        }
        [TestMethod]
        public void PD_TwoClocksPEqual10000()
        {
            for (int P = 1; P < 10000; P++)
            {
                Assert.AreEqual<int>(1, ST.TwoRandomClocksForP(P));
            }
        }
        [TestMethod]
        public void PD_TwoClocksPEqual100000()
        {
            for (int P = 1; P < 100000; P++)
            {
                Assert.AreEqual<int>(1, ST.TwoRandomClocksForP(P));
            }
        }
        [TestMethod]
        public void PD_TwoClocksPEqual1000000()
        {
            for (int P = 1; P < 1000000; P++)
            {
                Assert.AreEqual<int>(1, ST.TwoRandomClocksForP(P));
            }
        }

    }
}
