using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml.Style;
using OfficeOpenXml;
using OfficeOpenXml.Drawing.Chart;
using OfficeOpenXml.Drawing;
using System.Reflection;

namespace TestEPPlus
{
    class TableFactory<T> : ITableFacotry<T>
    {
        public void GetTable(List<T> TableDatas)
        {
            var type = typeof(T);
            object obj = Activator.CreateInstance(type);
            PropertyInfo[] props = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            List<string> headerList = new List<string>();
            for (int i = 0; i < props.Count(); i++)
            {
                PropertyInfo pi = props[i];
                headerList.Add(pi.Name);
            }

            using (ExcelPackage package = new ExcelPackage())
            {
                var workSheet = package.Workbook.Worksheets.Add(type.Name);
                for (int i = 0; i < headerList.Count(); i++)
                {
                    workSheet.SetValue(1, i, headerList[i]);
                }
                foreach (T item in TableDatas)
                {
                    Dictionary<string, string> propertyDict = new Dictionary<string, string>();
                    foreach (var pi in props)
                    {
                        string propertyName = pi.Name;
                        string propertyValue = pi.GetValue(item, null).ToString();
                        propertyDict.Add(propertyName, propertyValue);
                    }
                    foreach (string key in propertyDict.Keys)
                    {
                        for (int i = 0; i < headerList.Count; i++)
                        {
                            if (headerList[i] == key)
                            {
                                workSheet
                            }
                        }
                    }
                }
            }
        }
    }
}
