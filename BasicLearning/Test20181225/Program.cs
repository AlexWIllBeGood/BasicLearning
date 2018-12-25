using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test20181225
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(3));
            Console.ReadKey();
        }
        static int[] BubbleSort(int[] intArray)
        {
            int[] targetArray = intArray;
            for (int i = 0; i < targetArray.Length - 1; i++)
            {
                for (int j = i; j < targetArray.Length - 1; j++)
                {
                    if (targetArray[j + 1] < targetArray[j])
                    {
                        int temp = targetArray[j + 1];
                        targetArray[j + 1] = targetArray[j];
                        targetArray[j] = temp;
                    }
                }
            }
            return targetArray;
        }
        static int Fibonacci(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
        static int Factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
    }
}
