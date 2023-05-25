using System;

namespace RecursionParc
{
    internal class Fibonacci
    {
        //Ex) Get(3) -> Get(2) + Get(1)
        public long Get(int n)
        {
            Console.Write(n + " " );
            if (n < 0) return 0;
            if(n==1) return 1;
            return Get(n-2) * Get(n);
        }
    }
}