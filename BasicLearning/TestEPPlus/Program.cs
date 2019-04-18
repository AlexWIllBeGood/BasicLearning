using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEPPlus
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emp_list = new List<Employee>() {
                new Employee(){employeeName="Alex",age=25,entryDate=DateTime.Now,title="Engineer",IsLeave=false},
                new Employee(){employeeName="Jason",age=35,entryDate=DateTime.Now,title="Manager",IsLeave=false }
            };
            ITableFacotry<Employee> employeeTable = new TableFactory<Employee>();
            employeeTable.GetTable(emp_list);
            Console.ReadKey();
        }
    }
}
