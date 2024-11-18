using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpCity { get; set; }
        public double EmpSalary { get; set; }

        public static List<Employee> GetEmployees()
        {
            List<Employee> EmpList = new List<Employee>()
            {
                new Employee{EmpId=101, EmpName="Hari", EmpCity="PENUGONDA", EmpSalary=30000},
                new Employee{EmpId=102, EmpName="Vasu", EmpCity="KPHB", EmpSalary=32000},
                new Employee{EmpId=103, EmpName="Mani", EmpCity="SHAPUR", EmpSalary=28000},
                new Employee{EmpId=104, EmpName="Anji", EmpCity="PENUGONDA", EmpSalary=22000},
                new Employee{EmpId=104, EmpName="Asha", EmpCity="ACHANTA", EmpSalary=15800}
            };
            return EmpList;
        }
    }

    class Details
    {
        static void Main()
        {
            Console.WriteLine("==================ALL EMPLOYEES DETAILS==================");

            IEnumerable<Employee> name = from emp in Employee.GetEmployees()                                        
                                         select emp;
            foreach (var n in name)
            {
                Console.WriteLine($"EmpId : {n.EmpId}, EmpName : {n.EmpName}, EmpCity : {n.EmpCity}, EmpSalary : {n.EmpSalary}");
            }
            Console.WriteLine();
            Console.WriteLine("=================WHOSE SALARY IS GREATER THAN 30000==================");

            IEnumerable<Employee> greater = from emp in Employee.GetEmployees()
                                            where emp.EmpSalary>30000
                                            select emp;
            foreach (var n in greater)
            {
                Console.WriteLine($"EmpId : {n.EmpId}, EmpName : {n.EmpName}, EmpCity : {n.EmpCity}, EmpSalary : {n.EmpSalary}");
            }

            Console.WriteLine();
            Console.WriteLine("=================WHO BELONGS TO 'PENUGONDA' REGION==================");

            IEnumerable<Employee> compare = from emp in Employee.GetEmployees()
                                            where emp.EmpCity == "PENUGONDA"
                                            select emp;
            foreach (var n in compare)
            {
                Console.WriteLine($"EmpId : {n.EmpId}, EmpName : {n.EmpName}, EmpCity : {n.EmpCity}, EmpSalary : {n.EmpSalary}");
            }

            Console.WriteLine();
            Console.WriteLine("=================ASCENDING ORDER==================");

            IEnumerable<Employee> order = from emp in Employee.GetEmployees()
                                            orderby emp.EmpName ascending 
                                            select emp;
            foreach (var n in order)
            {
                Console.WriteLine($"EmpId : {n.EmpId}, EmpName : {n.EmpName}, EmpCity : {n.EmpCity}, EmpSalary : {n.EmpSalary}");
            }
            Console.Read();
        }

    }
}
