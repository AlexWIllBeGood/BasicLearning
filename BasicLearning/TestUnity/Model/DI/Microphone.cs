using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUnity.Model.DI
{
    public class Microphone:IMicrophone
    {
        public Microphone()
        {
            Console.WriteLine("Microphone被构造");
        }
    }
}
