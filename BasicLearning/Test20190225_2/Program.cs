using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace Test20190225_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Add1();
            Add2();

            Console.ReadKey();
        }
        /// <summary>
        /// 不使用泛型的列表添加操作
        /// </summary>
        public static void Add1()
        {
            ArrayList al = new ArrayList();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 10000000; i++)
            {
                al.Add(i);
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
        }
        /// <summary>
        /// 使用泛型的列表添加操作
        /// </summary>
        public static void Add2()
        {
            List<int> al = new List<int>();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 10000000; i++)
            {
                al.Add(i);
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
        }
    }
}
