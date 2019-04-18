using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestUnity.Model;
using TestUnity.Model.DI;
using Unity;

namespace TestUnity
{
    class Program
    {
        static void Main(string[] args)
        {
            //IOC思想：
            //上层模块不依赖于下层模块 两者都依赖于抽象
            //抽象不依赖于细节 细节依赖于抽象


            //上层模块是依赖于抽象 但是这里抽象依赖于细节了
            //IDbInterface db = new MSSQL();

            //Unity相当于是一个类的容器 工厂
            //IUnityContainer container = new UnityContainer();
            ////注册类型
            ////container.RegisterType<IMSSQL,MSSQL>();
            //container.RegisterType<IOracle, Oracle>();
            ////注册实例
            //container.RegisterInstance<IMSSQL>(new MSSQL());
            //var mssql= container.Resolve<IMSSQL>();
            //Console.WriteLine(mssql.Insert());



            //实现IOC
            IUnityContainer container = new UnityContainer();
            container.RegisterType<IHeadphone, Headphone>();
            container.RegisterType<IMicrophone, Microphone>();
            container.RegisterType<IPower, Power>();
            container.RegisterType<Iphone, ApplePhone>();

            Iphone applePhone = container.Resolve<Iphone>();
            Console.WriteLine($"Phone.headphone==null?{applePhone.iHeadphone == null}");
            Console.WriteLine($"Phone.microphone==null?{applePhone.iMicrophone == null}");
            Console.WriteLine($"Phone.power==null?{applePhone.iPower == null}");
            Console.ReadKey();
        }
    }
}
