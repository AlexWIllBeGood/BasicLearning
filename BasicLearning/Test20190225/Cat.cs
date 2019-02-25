using System;
using System.Collections.Generic;
using System.Text;

namespace Test20190225
{
    public class Cat:Animal
    {
        static Cat()
        {
            Console.WriteLine("C_Static");
        }
        public Cat()
        {
            Console.WriteLine("C_Constructor");
        }
    }
}
