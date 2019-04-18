using System;
using System.Collections.Generic;
using System.Text;

namespace Test20190225
{
    public class Animal
    {
        static Animal()
        {
            Console.WriteLine("A_Static");
        }
        public Animal()
        {
            Console.WriteLine("A_Constructor");
        }
    }
}
