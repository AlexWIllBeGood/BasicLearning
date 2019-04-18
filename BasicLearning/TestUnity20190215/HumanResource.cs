using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUnity20190215
{
    public class HumanResource : IHumanResource
    {
        public string Talk()
        {
            return "Human Resource Talk!";
        }

        public string Walk()
        {
            return "Human Resource Walk!";
        }
    }
}
