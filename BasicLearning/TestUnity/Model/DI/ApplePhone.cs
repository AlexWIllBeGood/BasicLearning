using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Attributes;

namespace TestUnity.Model.DI
{
    //https://www.cnblogs.com/dotnet261010/p/9054201.html
    public class ApplePhone : Iphone
    {
        //属性注入
        [Dependency]
        public IMicrophone iMicrophone { get; set; }
        public IHeadphone iHeadphone { get; set; }
        public IPower iPower { get; set; }
        //构造器注入
        [InjectionConstructor]
        public ApplePhone(IHeadphone headphone, IMicrophone microphone, IPower power)
        {
            this.iHeadphone = headphone;
            this.iMicrophone = microphone;
            this.iPower = power;
            Console.WriteLine("{0}带参数构造函数", this.GetType().Name);
        }
        public void Call()
        {
            Console.WriteLine("{0}打电话", this.GetType().Name);
        }
        //方法注入
        [InjectionMethod]
        public void Init(IHeadphone headphone, IMicrophone microphone, IPower power)
        {
            this.iHeadphone = headphone;
            this.iMicrophone = microphone;
            this.iPower = power;
        }
    }
}
