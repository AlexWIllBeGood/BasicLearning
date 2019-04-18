using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Test20181026
{
    //测试使用插件进行序列化以及反序列化
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Alex",25);
            Console.WriteLine(employee.GetJsonString());
            List<Employee> employee_list = new List<Employee>();
            for (int i = 0; i < 5; i++)
            {
                Employee emp = new Employee($"employee{i}", i + 20);
                employee_list.Add(emp);
            }
            Console.WriteLine(JsonConvert.SerializeObject(employee_list));

            string jsonString1 = "[{\"name\":\"Alex\",\"age\":\"24\"}]";
            List<Employee> emp_list = JsonConvert.DeserializeObject<List<Employee>>(jsonString1);
            Console.ReadKey();
        }
    }
    class Employee
    {
        public string name { get; set; }
        public int age { get; set; }
        public Employee(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public string GetJsonString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
