using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUnity.Model.DI
{
    public class Power:IPower
    {
        public Power()
        {
            Console.WriteLine("Power被构造");
        }
    }
}
