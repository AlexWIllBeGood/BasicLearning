using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//使用递归算法计算阶乘
namespace FactorialTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(factorial(3));
            Console.WriteLine(fibonacci(5));
            Console.ReadKey();
        }
        static private int factorial(int n)
        {
            if (n < 1)
            {
                throw new Exception("参数错误");
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * factorial(n - 1);
            }
        }
        static private int fibonacci(int n)
        {
            if (n <= 0)
            {
                throw new Exception("参数错误");
            }
            else if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                return fibonacci(n - 1) + fibonacci(n - 2);
            }
        }
    }
}
