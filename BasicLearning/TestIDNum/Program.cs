using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIDNum
{
    class Program
    {
        static void Main(string[] args)
        {
//            652221198602240010
//362422199503253013
//612726197110282125
//640122199409123019

            bool result1 = CheckIDCard("652221198602240010");
            bool result2 = CheckIDCard("362422199503253013");
            bool result3 = CheckIDCard("612726197110282125");
            bool result4 = CheckIDCard("640122199409123019");
        }
        public static bool CheckIDCard(string idCard)
        {
            string[] arrVarifyCode = ("1,0,X,9,8,7,6,5,4,3,2").Split(',');
            string[] Wi = ("7,9,10,5,8,4,2,1,6,3,7,9,10,5,8,4,2").Split(',');
            string[] Checker = ("1,9,8,7,6,5,4,3,2,1,1").Split(',');
            string strVerifyCode = string.Empty, Ai = string.Empty, birthday = string.Empty;
            int i = 0, totalmulAiWi = 0, modValue = 0, year = 0, month = 0, day = 0;

            if ((idCard.Length != 18) && (idCard.Length != 15))
            {
                return false;  //身份证位数不对:必须是15位或者18位
            }

            if (idCard.Length == 15)
            {
                Ai = idCard.Substring(0, 6) + "19" + idCard.Substring(6, 9);
            }
            else
            {
                Ai = idCard.Substring(0, 17);
            }
            double tempNum;
            if (!double.TryParse(Ai, out tempNum))
            {
                return false;   //身上证号除最后一位外，其他位不能有非数字字符
            }

            year = Convert.ToInt32(Ai.Substring(6, 4));
            month = Convert.ToInt32(Ai.Substring(10, 2));
            day = Convert.ToInt32(Ai.Substring(12, 2));

            if (month > 12)
            {
                return false;//月份不对，不能大于12  
            }
            if (day > 31)
            {
                return false;  //日期不对，不能大于31
            }

            birthday = year.ToString() + "-" + month.ToString() + "-" + day.ToString();
            DateTime tempDate;
            if (DateTime.TryParse(birthday, out tempDate))
            {
                DateTime DateBirthDay = DateTime.Parse(birthday);
                if (DateBirthDay > DateTime.Now)
                {
                    return false;//年份不对,出生日期不能比当前日期晚
                }
                int intYearLength = DateBirthDay.Year - DateTime.Now.Year;
                if (intYearLength < -140)
                {
                    return false; //身份证输入错误（年份输入错误）！1900+140,即2040年还在用第一代身份证的人这里不认
                }
            }
            else
            {
                return false;   //其中的日期部分转换错误(主要是润月问题)
            }

            //核对校验位
            for (i = 0; i < 17; i++)
            {
                totalmulAiWi = totalmulAiWi + (Convert.ToInt32(Ai.Substring(i, 1)) * Convert.ToInt32(Wi[i].ToString())); //加权
            }
            modValue = totalmulAiWi % 11;  //取模

            strVerifyCode = arrVarifyCode[modValue].ToString(); //校验位
            Ai = Ai + strVerifyCode;
            if (idCard.Length == 18 && idCard != Ai)  //对十八位身份证核对校验位
            {
                return false;//校验位不对
            }
            return true;
        }
    }
}
