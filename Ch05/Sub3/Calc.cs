using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub3
{
    internal class Calc
    {
        static Calc instance = new Calc();
        public static Calc Instance { get => instance; }
        public Calc() { }

        public int Plus(int x, int y) { return x + y; }
        public int Minus(int x, int y) { return x - y; }
        public int Multy(int x, int y) { return x * y; }
        public int Div(int x, int y) { return x / y; }


    }
}
