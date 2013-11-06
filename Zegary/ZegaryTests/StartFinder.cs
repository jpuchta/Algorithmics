using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zegary
{
    class StartFinder
    {
        private int[] steps;
        private int[] values;
        List<int> candidates;
        int N;
        int counter;
        int iteration;

        public StartFinder(int[] deltas)
        {
            this.steps = deltas;
            this.N = steps.Length;
            this.counter = N;
            this.values = new int[N];
            this.candidates = ListOfInts(counter);
            this.iteration = 0;
        }

        private List<int> ListOfInts(int n)    // To potencjalnie moze generowac zla zlozonosc
        {
            List<int> result = new List<int>(n);
            for (int i = 0; i < n; i++)
                result.Add(i);
            return result;
        }

        public int GetIndex()
        {
            while (this.counter > 1)
            {
                this.Iterate();
            }
            return this.candidates[0];
        }

        private void Iterate()
        {
            this.iteration++;
            this.SetNewValues();
            this.RemoveNonMinValues();
            this.RemoveNeighbourCandidates();
            this.SetNewCandidates();
        }

        private void SetNewValues()
        {
            foreach (int i in candidates)
                values[i] = steps[(i + iteration)%N];
        }

        private void RemoveNonMinValues()
        {
            int m = MinValue();
            foreach (int i in candidates)
                if (values[i] > m)
                    Drop(i);
        }
        private void Drop(int i)
        {
            if (counter > 1&& IsCandidate(i))
            {
                values[i] = -1;
                counter--;
            }
        }

        private int MinValue()
        {
            int m = int.MaxValue;
            foreach (int i in candidates)
                if (values[i] < m && IsCandidate(i))
                    m = values[i];
            return m;
        }

        private void RemoveNeighbourCandidates()
        {
            foreach (int i in candidates)
                if (IsCandidate(Prev(i)))
                    Drop(i);
        }

        private bool IsCandidate(int i)
        {
            return values[i]!=-1;
        }

        private int Prev(int i)
        {
            int Wynik = (N+i - iteration) % N;
            return Wynik;
        }


        private void SetNewCandidates()
        {
            List<int> newCandidates = new List<int>();
            foreach (int i in candidates)
                if (IsCandidate(i))
                    newCandidates.Add(i);
            this.candidates=newCandidates;
        }



    }
}
