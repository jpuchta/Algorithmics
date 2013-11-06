using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zegary
{
    class Clock
    {
        private int[] wskazowki;
        int M;
        private int P;

        public Clock(int[] a, int P)
        {
            this.wskazowki = a;
            this.M = wskazowki.Length;
            Array.Sort<int>(this.wskazowki);
            this.P = P;
            this.Reset();
        }

        private void Reset()
        {
            StartFinder F= new StartFinder(this.GetDeltas());
            this.Rotate(F.GetIndex());
        }

        private int[] GetDeltas()
        {
            int sum=0;
            int[] deltas = new int[M];
            for (int i = 0; i < M - 1; i++)
            {
                deltas[i] = wskazowki[i + 1] - wskazowki[i];
                sum += deltas[i];
            }
            deltas[M - 1] = P - sum;
            return deltas;
        }

        private void Rotate(int index)
        {
            int delta = this.wskazowki[index];
            for (int i = 0; i < M; i++)
                wskazowki[i] = (this.P + wskazowki[i] - delta) % this.P;
        }

        public long GetInv()
        {
            long inv = 0;
            foreach (int x in wskazowki)
                inv += (x * x);
            return inv;
        }
    }
}
