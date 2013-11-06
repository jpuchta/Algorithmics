using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ZegaryTests
{
    [TestClass]
    public class TimeComplexTests
    {
        SolutionTester ST = new SolutionTester();
        private static int Krotnosc = 20;

        private void TestRandomClocks(int N, int M)
        {
            for (int i=0; i<Krotnosc; i++)
                Assert.AreEqual<int>(0, ST.RandomClocks(N, M));
        }

        //M=16
        [TestMethod]
        public void TC_RandomN_016_M_016()
        { TestRandomClocks(16, 16); }
        [TestMethod]
        public void TC_RandomN_032_M_016()
        { TestRandomClocks(32, 16); }
        [TestMethod]
        public void TC_RandomN_064_M_016()
        { TestRandomClocks(64, 16); }
        [TestMethod]
        public void TC_RandomN_128_M_016()
        { TestRandomClocks(128, 16); }
        [TestMethod]
        public void TC_RandomN_256_M_016()
        { TestRandomClocks(256, 16); }
        [TestMethod]
        public void TC_RandomN_500_M_016()
        { TestRandomClocks(500, 16); }

        //M=32
        [TestMethod]
        public void TC_RandomN_016_M_032()
        { TestRandomClocks(16, 32); }
        [TestMethod]
        public void TC_RandomN_032_M_032()
        { TestRandomClocks(32, 32); }
        [TestMethod]
        public void TC_RandomN_064_M_032()
        { TestRandomClocks(64, 32); }
        [TestMethod]
        public void TC_RandomN_128_M_032()
        { TestRandomClocks(128, 32); }
        [TestMethod]
        public void TC_RandomN_256_M_032()
        { TestRandomClocks(256, 32); }
        [TestMethod]
        public void TC_RandomN_500_M_032()
        { TestRandomClocks(500, 32); }

        //M=64
        [TestMethod]
        public void TC_RandomN_016_M_064()
        { TestRandomClocks(16, 64); }
        [TestMethod]
        public void TC_RandomN_032_M_064()
        { TestRandomClocks(32, 64); }
        [TestMethod]
        public void TC_RandomN_064_M_064()
        { TestRandomClocks(64, 64); }
        [TestMethod]
        public void TC_RandomN_128_M_064()
        { TestRandomClocks(128, 64); }
        [TestMethod]
        public void TC_RandomN_256_M_064()
        { TestRandomClocks(256, 64); }
        [TestMethod]
        public void TC_RandomN_500_M_064()
        { TestRandomClocks(500, 64); }

        //M=128
        [TestMethod]
        public void TC_RandomN_016_M_128()
        { TestRandomClocks(16, 128); }
        [TestMethod]
        public void TC_RandomN_032_M_128()
        { TestRandomClocks(32, 128); }
        [TestMethod]
        public void TC_RandomN_064_M_128()
        { TestRandomClocks(64, 128); }
        [TestMethod]
        public void TC_RandomN_128_M_128()
        { TestRandomClocks(128, 128); }
        [TestMethod]
        public void TC_RandomN_256_M_128()
        { TestRandomClocks(256, 128); }
        [TestMethod]
        public void TC_RandomN_500_M_128()
        { TestRandomClocks(500, 128); }

        //M=256
        [TestMethod]
        public void TC_RandomN_016_M_256()
        { TestRandomClocks(16, 256); }
        [TestMethod]
        public void TC_RandomN_032_M_256()
        { TestRandomClocks(32, 256); }
        [TestMethod]
        public void TC_RandomN_064_M_256()
        { TestRandomClocks(64, 256); }
        [TestMethod]
        public void TC_RandomN_128_M_256()
        { TestRandomClocks(128, 256); }
        [TestMethod]
        public void TC_RandomN_256_M_256()
        { TestRandomClocks(256, 256); }
        [TestMethod]
        public void TC_RandomN_500_M_256()
        { TestRandomClocks(500, 256); }

        //M=500
        [TestMethod]
        public void TC_RandomN_016_M_500()
        { TestRandomClocks(16, 500); }
        [TestMethod]
        public void TC_RandomN_032_M_500()
        { TestRandomClocks(32, 500); }
        [TestMethod]
        public void TC_RandomN_064_M_500()
        { TestRandomClocks(64, 500); }
        [TestMethod]
        public void TC_RandomN_128_M_500()
        { TestRandomClocks(128, 500); }
        [TestMethod]
        public void TC_RandomN_256_M_500()
        { TestRandomClocks(256, 500); }
        [TestMethod]
        public void TC_RandomN_500_M_500()
        { TestRandomClocks(500, 500); }

    }
}
