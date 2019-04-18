using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test20181115
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a = (decimal)(3.3 - 3.1);
            decimal b = (decimal)(4.4 - 4.2);
            double c = 3.2 - 3.1;
            double d = 3.3 - 3.2;
            Console.WriteLine(a == b);
            Console.WriteLine(c == d);

            Console.ReadLine();
        }
    }
}
