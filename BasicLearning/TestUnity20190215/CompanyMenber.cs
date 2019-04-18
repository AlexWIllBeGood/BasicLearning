using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Attributes;

namespace TestUnity20190215
{
    public class CompanyMenber : ICompanyMenber
    {
        //属性依赖注入
        [Dependency]
        public IHumanResource ihr { get; set; }
        [Dependency]
        public IEngineer ie { get; set; }
        //构造器依赖注入
        [InjectionConstructor]
        public CompanyMenber(IHumanResource ihr,IEngineer ie)
        {
            this.ihr = ihr;
            this.ie = ie;
        }
        //方法依赖注入
        [InjectionMethod]
        public void Init(IHumanResource ihr, IEngineer ie)
        {
            this.ihr = ihr;
            this.ie = ie;
        }
    }
}
