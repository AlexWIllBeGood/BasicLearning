using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test20190102
{
    class Program
    {
        static void Main(string[] args)
        {
            string originalCode = "BPO180001";
            var a = getNewCode("BPO180021");
            var b = getNewCode("BPO190001");
            var c = getNewCode("BPO190023");
        }
        /// <summary>
        /// 获取新的code
        /// </summary>
        static string getNewCode(string orginalCode)
        {
            string currentYear =DateTime.Now.Year.ToString().Substring(2, 2);
            string year = orginalCode.Substring(3, 2);
            if (currentYear == year)
            {
                int newIndex = Convert.ToInt32(orginalCode.Substring(5, 4)) + 1;
                if (newIndex <= 9)
                {
                    return "BPO" + year + "000" + newIndex;
                }
                else if (newIndex <= 99)
                {
                    return "BPO" + year + "00" + newIndex;
                }
                else if (newIndex <= 999)
                {
                    return "BPO" + year + "0" + newIndex;
                }
                else if (newIndex <= 9999)
                {
                    return "BPO" + year + newIndex.ToString();
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return "BPO" + currentYear + "0001";
            }
        }
    }
}
