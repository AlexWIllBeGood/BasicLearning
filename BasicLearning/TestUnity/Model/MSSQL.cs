using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUnity.Model
{
    public class MSSQL : IMSSQL
    {
        public string Delete()
        {
            return "实现MSSQL删除";
        }

        public string Insert()
        {
            return "实现MSSQL插入";
        }

        public string Query()
        {
            return "实现MSSQL查询";
        }

        public string Update()
        {
            return "实现MSSQL更新";
        }
    }
}
