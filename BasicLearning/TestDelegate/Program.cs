using System;
namespace TestDelegate
{
    class Program
    {
        public delegate void MyDelegate(string str);
        static void Main(string[] args)
        {
            MyDelegate d1 = Method1;
            MyDelegate d2 = Method2;
            MyDelegate d3 = Method3;
            MyDelegate d4 = Method4;

            d1("1");
            d2("2");
            d3("3");
            d4("4");

            Console.WriteLine("***********");

            MyDelegate d=Method1;
            d += Method2;
            d += Method3;
            d += Method4;
            d("1");
            
            Console.ReadKey();
        }
        public static void Method1(string str)
        {
            Console.WriteLine("this is the first method1,string value is {0}", str);
        }
        public static void Method2(string str)
        {
            Console.WriteLine("this is the first method2,string value is {0}", str);
        }
        public static void Method3(string str)
        {
            Console.WriteLine("this is the first method3,string value is {0}", str);
        }
        public static void Method4(string str)
        {
            Console.WriteLine("this is the first method4,string value is {0}", str);
        }
    }
}
