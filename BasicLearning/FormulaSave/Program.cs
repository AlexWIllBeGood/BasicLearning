using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  MSScriptControl;

namespace FormulaSave
{
    class Program
    {
        public static void Main(string[] args)
        {
            //string f1 = "";
            //A:基本工资
            //B:绩效系数
            MSScriptControl.ScriptControl sc = new MSScriptControl.ScriptControlClass();
            sc.Language = "JavaScript";
            string formulate2 = string.Format("if({0}==1)({2});else if({0}==2)({3});else if({0}==3)({4})", 3,2,3,4,5);
            //string formulate1 = string.Format("if({0}==2)((({0}*{1})-{3}+({1}*{2}))+{4}/{0});else(1+2*3)", 2, 3, 4, 5, 6);
            object objResult = sc.Eval(formulate2);
            if (objResult != null)
            {
                Console.WriteLine(objResult);
            }
            Console.ReadKey();
        }
    }
}
