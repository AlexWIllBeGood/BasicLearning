using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<temp> temp_list = new List<temp>() {
                new temp(){ amount=100,month=1,year=2018},
                new temp(){ amount=100,month=2,year=2018},
                new temp(){ amount=100,month=3,year=2018},
                new temp(){ amount=100,month=4,year=2018},
                new temp(){ amount=100,month=5,year=2018}
            };
            List<temp> selectedList = temp_list.Where(e => e.month <= 0).ToList();
            var result1 = selectedList.Sum(e => e.amount);
            Console.ReadKey();
        }
        public class temp
        {
            public int month { get; set; }
            public decimal amount { get; set; }
            public decimal year { get; set; }
        }
    }
}
