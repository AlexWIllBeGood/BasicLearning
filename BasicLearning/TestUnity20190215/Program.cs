using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace TestUnity20190215
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<IHumanResource, HumanResource>();
            container.RegisterType<IEngineer, Engineer>();
            container.RegisterType<ICompanyMenber,CompanyMenber>();

            var cm = container.Resolve<CompanyMenber>();
            Console.WriteLine($"cm.ihr==null?{cm.ihr == null}");
            Console.WriteLine($"cm.ie==null?{cm.ie == null}");
            Console.WriteLine(cm.ihr.Talk());
            Console.WriteLine(cm.ihr.Walk());
            Console.WriteLine(cm.ie.Talk());
            Console.WriteLine(cm.ie.Walk());
            Console.ReadKey();
        }
    }
}
