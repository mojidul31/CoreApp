using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApp.com.test
{
    public  class DataInfo
    {
        public DataInfo() { }
        public List<Employee> GetEmployeeRecord()
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee { empid = 1, empname = "Employee1", salary = 10000 });
            empList.Add(new Employee { empid = 2, empname = "Employee2", salary = 8500 });
            empList.Add(new Employee { empid = 3, empname = "Employee3", salary = 14200 });
            empList.Add(new Employee { empid = 4, empname = "Employee4", salary = 15000 });
            empList.Add(new Employee { empid = 5, empname = "Employee5", salary = 10000 });
            empList.Add(new Employee { empid = 6, empname = "Employee6", salary = 6000 });
            empList.Add(new Employee { empid = 7, empname = "Employee7", salary = 20000 });
            empList.Add(new Employee { empid = 8, empname = "Employee8", salary = 15000 });
            empList.Add(new Employee { empid = 9, empname = "Employee9", salary = 7000 });
            empList.Add(new Employee { empid = 10, empname = "Employee10", salary = 7000 });
            return empList;
        }
    }

    public class Employee
    {
        public int empid { get; set; }
        public string empname { get; set; }
        public double salary { get; set; }

    }
}
