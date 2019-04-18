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
            //Counter c = Counter.GetCounter();
            //Console.WriteLine(c.getIncreasedCount());
            //Console.WriteLine(c.getIncreasedCount());
            //Counter c1 = Counter.GetCounter();
            ////能够确保获取到的确实是一个counter()
            //Console.WriteLine(c1.getIncreasedCount());
            //Console.WriteLine(c1.getIncreasedCount());

            Task t1 = new Task(()=> {
                while (true)
                {
                    Counter c = Counter.GetCounter();
                    Console.WriteLine("counter1:"+c.getIncreasedCount());
                    Thread.Sleep(500);
                }
            });
            Task t2 = new Task(() => {
                while (true)
                {
                    Counter c = Counter.GetCounter();
                    Console.WriteLine("counter2:" + c.getIncreasedCount());
                    Thread.Sleep(100);
                }
            });
            t1.Start();
            t2.Start();
            Console.ReadKey();

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
                if (uniqueInstance == null)
                {
                    lock (locker)
                    {
                        if (uniqueInstance == null)
                        {
                            uniqueInstance = new Singleton_MutiThread();
                        }
                    }
                }
                return uniqueInstance;
            }
        }
        #endregion

        #region 单例模式的实例
        public class Counter
        {
            private int count;
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
                lock (locker)
                {
                    return count;
                }
            }
            public int getIncreasedCount()
            {
                lock (locker)
                {
                    return count++;
                }
            }
        }
        #endregion
    }
}
