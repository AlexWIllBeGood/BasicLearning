using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Counter counter = Counter.GetCounter();
            //Console.WriteLine(counter.getIncreasedCount());
            //Console.WriteLine(counter.getIncreasedCount());
            //Console.WriteLine(counter.getIncreasedCount());
            //Console.WriteLine(counter.getCurrentCount());

            //测试异步异步执行中的单例模型
            Task t1 = new Task(count1);
            Task t2 = new Task(count2);
            t1.Start();
            t2.Start();
            Console.ReadKey();
        }
        public static void showCount()
        {
            Counter c = Counter.GetCounter();
            c.getIncreasedCount();
            Console.WriteLine(string.Format("current counter:{0}",c.getCurrentCount()));
            Thread.Sleep(200);
        }
        public static void count1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("count1:" + i);
            }
        }
        public static void count2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("count2:" + i);
            }
        }
        #region 单例模式标准写法
        //单线程的单例模式
        class Singleton
        {
            private static Singleton uniqueInstance;
            private Singleton()
            {
            }
            public static Singleton GetInstance()
            {
                if (uniqueInstance == null)
                {
                    uniqueInstance = new Singleton();
                }
                return uniqueInstance;
            }
        }
        //多线程中的单例模式
        class Singleton_MutiThread
        {
            private static Singleton_MutiThread uniqueInstance;
            private static readonly object locker;
            private Singleton_MutiThread()
            {

            }
            public static Singleton_MutiThread GetInstance()
            {
                lock (locker)
                {
                    if (uniqueInstance == null)
                    {
                        uniqueInstance = new Singleton_MutiThread();
                    }
                    return uniqueInstance;
                }
            }
        }
        #endregion

        #region 单例模式的实例
        public class Counter
        {
            private static int count;
            private readonly static object locker = new object();
            private static Counter counter;
            private Counter()
            { }
            public static Counter GetCounter()
            {
                lock (locker)
                {
                    if (counter == null)
                    {
                        counter = new Counter();
                    }
                }
                return counter;
            }
            public int getCurrentCount()
            {
                return count;
            }
            public int getIncreasedCount()
            {
                return count++;
            }
        }
        #endregion
    }
}
