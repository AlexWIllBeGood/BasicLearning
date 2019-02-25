using System;

namespace Test20190225_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat c1 = new Cat();
            Cat c2 = new Cat();
            Console.WriteLine(Cat.count);
            Console.ReadKey();
        }
    }
}
