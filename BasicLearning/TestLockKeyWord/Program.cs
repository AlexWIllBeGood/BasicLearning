using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestLockKeyWord
{
    class Program
    {
        //使用lock之后能够避免多线程访问时候出错
        private readonly static object obj = new object();
        static void Main(string[] args)
        {
            Library l = new Library();
            l.SetBookNum(20);
            Task t = new Task(()=> {
                while (l.GetBook())
                {
                    Thread.Sleep(20);
                }
            });
            Task t1 = new Task(() => {
                while (l.GetBook())
                {
                    Thread.Sleep(20);
                }
            });
            t.Start();
            t1.Start();
            Console.ReadKey();
        }
        class Library
        {
            private int bookNum =0;
            public void SetBookNum(int num)
            {
                bookNum = num;
            }
            public int GetBookNum()
            {
                return bookNum;
            }
            public bool GetBook()
            {
                lock (obj)
                {
                    if (bookNum > 0)
                    {
                        bookNum--;
                        Console.WriteLine(string.Format("{0} books left", bookNum));
                        return true;
                    }
                    else
                    {
                        Console.WriteLine(string.Format("no book left!"));
                        return false;
                    }
                }
            }
        }
    }
}
