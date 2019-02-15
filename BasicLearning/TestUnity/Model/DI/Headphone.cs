using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUnity.Model.DI
{
    public class Headphone:IHeadphone
    {
        public Headphone()
        {
            Console.WriteLine("Headphone被构造");
        }
    }
}
