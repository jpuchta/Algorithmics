using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kolejki;

namespace ASDe1
{
    class Program
    {
        static void Main(string[] args)
        {
            LIFO l = new LIFO();
            int i;
            for (i = 0; i < 10; i++)
                l.Add(i);
            Console.WriteLine(l.ToString());
            Console.ReadLine();
            int h = l.Head();
            LIFO t = l.Tail();
            Console.WriteLine("Head:\t" + h);
            Console.WriteLine("Tail:\t" + t);
            Console.ReadLine();
        }
    }
 }


