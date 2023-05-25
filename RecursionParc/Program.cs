using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecursionParc
{
    internal static class Program
    {
        static void Main(String []args)
        {
            Fibonacci fibo = new Fibonacci();
            Console.Write(fibo.Get(50));

            FibonacciAdv fiboAdv = new FibonacciAdv();
            Console.Write(fiboAdv.Get(50));
        }
    }
}
