using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUnity.Model
{
    public class Oracle : IOracle
    {
        public string Delete()
        {
            return "实现Oracle删除";
        }

        public string Insert()
        {
            return "实现Oracle插入";
        }

        public string Query()
        {
            return "实现Oracle查询";
        }

        public string Update()
        {
            return "实现Oracle更新";
        }
    }
}
