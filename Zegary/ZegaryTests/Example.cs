using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZegaryTests
{
    struct Example
    {
        public int result;
        public int P;
        public int[][] A;

        public Example(int result, int P, int[][] A)
        {
            this.result=result;
            this.P = P;
            this.A = A;
        }
    }
}
