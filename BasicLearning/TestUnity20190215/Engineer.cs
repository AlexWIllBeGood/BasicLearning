using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUnity20190215
{
    public class Engineer : IEngineer
    {
        public string Talk()
        {
            return "Engineer Talk!";
        }

        public string Walk()
        {
            return "Engineer Walk!";
        }
    }
}
