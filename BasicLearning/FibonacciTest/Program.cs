using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciTest
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 20; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }
            Console.ReadKey();
        }
        public static int Fibonacci(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n-1) + Fibonacci(n - 2);
            }
        }
    }
}
