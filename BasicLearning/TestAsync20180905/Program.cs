using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TestAsync20180905
{
    class Program
    {
        static string[] urlArray = new string[] {
                "http://www.baidu.com",
                "http://www.zhihu.com",
                "http://www.taobao.com",
                "http://www.jd.com",
                "http://www.douyu.com"
            };
        static void Main(string[] args)
        {
            //#region 同步顺序获取网页内容
            //GetWebInfo gwi = new GetWebInfo();
            //gwi.sw.Start();
            //foreach (var i in urlArray)
            //{
            //    gwi.GetStringContent(i);
            //}
            //gwi.sw.Stop();
            //#endregion

            //Console.WriteLine();

            //#region 异步顺序获取网页内容
            GetWebInfoAsync gwia = new GetWebInfoAsync();
            gwia.sw.Start();
            foreach (var i in urlArray)
            {
                Task<string> temp = gwia.GetStringContentAsync(i);
            }
            gwia.sw.Stop();
            Console.ReadKey();
            //#endregion


            //GetWebInfoAsync gwia = new GetWebInfoAsync();
            //gwia.sw.Start();
            //gwia.DoWorkAsync();
            //gwia.sw.Stop();
            //Console.ReadKey();
        }
    }
    class GetWebInfo
    {
        public Stopwatch sw = null;
        public GetWebInfo()
        {
            sw = new Stopwatch();
        }
        public string GetStringContent(string url)
        {
            //貌似HttpClient只有异步的方法
            //HttpClient hc = new HttpClient();
            WebClient wc1 = new WebClient();
            Console.WriteLine("start downloading {0} Time:{1,4}", url, sw.Elapsed.TotalMilliseconds);
            string content = wc1.DownloadString(url);
            Console.WriteLine("finish downloading {0} Time:{1,4}", url, sw.Elapsed.TotalMilliseconds);
            return content;
        }
    }
    class GetWebInfoAsync
    {
        public Stopwatch sw = null;
        public async void DoWorkAsync()
        {
            string[] urlArrayNew = new string[] {
                "http://www.baidu.com",
                "http://www.zhihu.com",
                "http://www.taobao.com",
                "http://www.jd.com",
                "http://www.douyu.com"
            };
            foreach (string s in urlArrayNew)
            {
                Task<int> result = GetContentNumberAsync(s);
                int tempResult = await result;
                Console.WriteLine("the number of the content of {0} is {1}", s, result);
            }
        }
        public GetWebInfoAsync()
        {
            sw = new Stopwatch();
        }
        public async Task<string> GetStringContentAsync(string url)
        {
            HttpClient hc = new HttpClient();
            Console.WriteLine("start downloading {0} Time:{1,4}", url, sw.Elapsed.TotalMilliseconds);
            string content = await hc.GetStringAsync(url);
            Console.WriteLine("finish downloading {0} Time:{1,4}", url, sw.Elapsed.TotalMilliseconds);
            int count = content.Count() + 1;
            return content;
        }
        public async Task ExecuteGetStringContentAsync(string url)
        {
            HttpClient hc = new HttpClient();
            Console.WriteLine("start downloading {0} Time:{1,4}", url, sw.Elapsed.TotalMilliseconds);
            string content = await hc.GetStringAsync(url);
            Console.WriteLine("finish downloading {0} Time:{1,4}", url, sw.Elapsed.TotalMilliseconds);
        }
        public async Task<int> GetContentNumberAsync(string url)
        {
            HttpClient hc = new HttpClient();
            Console.WriteLine("start downloading {0} Time:{1,4}", url, sw.Elapsed.TotalMilliseconds);
            string content = await hc.GetStringAsync(url);
            Console.WriteLine("finish downloading {0} Time:{1,4}", url, sw.Elapsed.TotalMilliseconds);
            return content.Length;
        }
    }
    static class BasicMethod
    {
        static public void UseTaskRun()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }


}
