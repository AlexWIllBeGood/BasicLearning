using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUnity.Model
{
    /// <summary>
    /// 基础的数据库CRUD接口
    /// </summary>
    public interface IDbInterface
    {
        string Insert();
        string Update();
        string Delete();
        string Query();
    }
}
