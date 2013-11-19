using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolejki
{
    //Na razie będzie to int_LIFO
    public class LIFO
    {
        private bool czy_null;
        private int head;
        private LIFO tail;

        static public LIFO NullLIFO = new LIFO();

        public int Head() { return this.head; }
        public LIFO Tail()
        {
            if (czy_null)
                throw Pusta_Kolejka;
            else
                return this.tail;
        }
        public bool CzyPusta() { return czy_null; }

        public LIFO()
        {
            this.czy_null = true;
            this.tail = null;
            this.head = 0;
        }
        public LIFO(int h, LIFO t)
        {
            this.czy_null = false;
            this.head = h;
            this.tail = t;
        }
        public LIFO(int x) { this.czy_null = false; this.head = x; this.tail = NullLIFO; }

        public LIFO Add(int h) { return new LIFO(h, this); }
//        public static LIFO Add(int h, LIFO t) {return new LIFO(h,t);}


        //bardzo nieoptymalne, ale działające:

        public override string ToString()
        {
            if (this.czy_null)
                return "";
            else
                return this.head.ToString() + "; " + tail.ToString();
        }

        Exception Pusta_Kolejka;
    }
}
