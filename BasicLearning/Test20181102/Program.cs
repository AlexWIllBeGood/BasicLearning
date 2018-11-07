using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test20181102
{
    class Program
    {

        public delegate void Action();
        //public static int copy;
        static void Main(string[] args)
        {
            int copy;
            List<Action> action_list = new List<Action>();
            for (int counter = 0; counter < 10; counter++)
            {
                copy = counter;
                action_list.Add(()=> { Console.WriteLine(copy); });
            }
            foreach (Action action in action_list) action();

            Console.ReadKey();
        }
        
    }
}
