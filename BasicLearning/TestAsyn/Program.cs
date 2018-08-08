using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TestAsync
{
    /// <summary>
    /// 测试异步操作
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //StartAsync();

            //MyDownLoadingString my = new MyDownLoadingString();
            //my.DoRun();

            //MyDownloadingStringAsync myAsync = new MyDownloadingStringAsync();
            //myAsync.DoRun();

            Console.ReadKey();
        }
        //使用async关键字来修饰方法
        //在异步方法中使用await关键字（不使用编译器会给出警告但不报错），否则异步方法会以同步方式执行
        //尽量不使用void作为返回类型，若希望异步方法返回void类型，请使用Task
        //异步方法名称以Async结尾
        //异步方法中不能声明使用ref或out关键字修饰的变量
        //static async Task<int> StartAsync()
        //{
        //    HttpClient client = new HttpClient();
        //    var str = await client.GetStringAsync("https://www.visualstudio.com/");
        //    return str.Count();
        //}
        
    }
    class MyDownLoadingString
    {
        Stopwatch sw = new Stopwatch();
        public void DoRun()
        {
            const int largeNumber = 600000;
            sw.Start();
            int t1 = CountCharacters(1, "http://www.baidu.com");
            int t2 = CountCharacters(2, "https://www.jd.com");
            CountToAlrgeNumnber(1, largeNumber);
            CountToAlrgeNumnber(2, largeNumber);
            CountToAlrgeNumnber(3, largeNumber);
            CountToAlrgeNumnber(4, largeNumber);
            Console.WriteLine("Chars in http://www.baidu.com        :{0}", t1);
            Console.WriteLine("Chars in https://www.jd.com            :{0}", t2);
        }
        private int CountCharacters(int id, string uristring)
        {
            WebClient wc1 = new WebClient();
            Console.WriteLine("String call {0}      ：   {1, 4} ms", id, sw.Elapsed.TotalMilliseconds);
            string result = wc1.DownloadString(new Uri(uristring));
            Console.WriteLine("call {0} complete：   {1, 4} ms", id, sw.Elapsed.TotalMilliseconds);
            return result.Length;
        }
        private void CountToAlrgeNumnber(int id,int largeNumber)
        {
            for (int i = 0; i < largeNumber; i++)
            { }
            Console.WriteLine("  End Counting{0}:   {1,4} ms", id, sw.Elapsed.TotalMilliseconds);
        }
    }
    class MyDownloadingStringAsync
    {
        Stopwatch sw = new Stopwatch();
        public void DoRun()
        {
            const int largeNumber = 600000;
            sw.Start();
            Task<int> t1 = CountCharacters(1, "http://www.baidu.com");
            Task<int> t2 = CountCharacters(2, "https://www.jd.com");

            CountToAlrgeNumnber(1, largeNumber);
            CountToAlrgeNumnber(2, largeNumber);
            CountToAlrgeNumnber(3, largeNumber);
            CountToAlrgeNumnber(4, largeNumber);
            Console.WriteLine("Chars in http://www.baidu.com        :{0}", t1.Result);
            Console.WriteLine("Chars in https://www.jd.com            :{0}", t2.Result);
        }
        private async Task<int> CountCharacters(int id, string uristring)
        {
            WebClient wc1 = new WebClient();
            Console.WriteLine("String call {0}    :     {1, 4} ms",id,sw.Elapsed.TotalMilliseconds);
            string result = await wc1.DownloadStringTaskAsync(new Uri(uristring));
            Console.WriteLine("call {0} complete：   {1, 4} ms", id, sw.Elapsed.TotalMilliseconds);
            return result.Count();
        }
        private void CountToAlrgeNumnber(int id, int largeNumber)
        {
            for (int i = 0; i < largeNumber; i++)
            { }
            Console.WriteLine("  End Counting{0}:   {1,4} ms", id, sw.Elapsed.TotalMilliseconds);
        }
    }
    class GetHttpContentSync
    {
        public GetContentByUri
    }
}
