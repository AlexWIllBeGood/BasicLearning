using System;
using System.Collections.Generic;
using System.Text;

namespace Test20190225_1
{
    public class Cat
    {
        public static int count=0;
        public Cat()
        {
            count++;
        }
        static Cat()
        {
            count++;
        }
    }
}
