using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Employee
    {
        public int EmpId;
        public string EmpName;
        public float Salary;
        public Employee(int eid, string ename, float sal)
        {

            EmpId = eid;
            EmpName = ename;
            Salary = sal;

        }
        public void Display()
        {
            Console.WriteLine("Employee id is  " + EmpId + " , Employee name is  " + EmpName + " , Employee salary is " + Salary);
        }
    }

    class partTimeEmployee : Employee
    {
        int Wages;
        public partTimeEmployee(int eid, string ename, float sal) : base(eid, ename, sal)
        {

        }
        public static void Main()
        {
            Console.WriteLine("Enter employee id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter salary of employee");
            float salary = (float)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Employee Details : ");
            Employee e1 = new Employee(id, name, salary);
            e1.Display();
            Console.WriteLine("======================");
            Console.WriteLine("Part Time Employee Details : ");
            partTimeEmployee p1 = new partTimeEmployee(id, name, salary);
            p1.Display();
            Console.Read();




        }
    }
}
