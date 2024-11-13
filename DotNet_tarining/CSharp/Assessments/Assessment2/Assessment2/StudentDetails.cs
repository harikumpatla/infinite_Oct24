
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2
{
    public abstract class Student
    {
        public string Name { get; set; }
        public int StudentId { get; set; }
        public double Grade { get; set; }
        protected Student(string name, int studentId, double grade)
        {
            Name = name;
            StudentId = studentId;
            Grade = grade;
        }

        abstract public bool IsPassed(double grade);
    }

    class Undergraduate : Student
    {
        public Undergraduate(string studentName, int studentId , double grade):base(studentName, studentId, grade)
        {

        }

        public override bool IsPassed(double grade)
        {
        
                return Grade > 70;
            
        }
    }

    class Graduate:Student
    {
        public Graduate(string studentName, int studentId, double grade) : base(studentName, studentId, grade)
        {

        }

        public override bool IsPassed(double grade)
        {

            return Grade > 70;

        }
    }
    class StudentDetails
    { 
        static void Main(string[] args)
        {
            Student UndergradStudent = new Undergraduate("HARI", 0032, 70.5);
            Console.WriteLine($"Undergraduate {UndergradStudent.Name} passed: {UndergradStudent.IsPassed(UndergradStudent.Grade)}");

            Student gradStudent = new Graduate("vasu", 0012, 92);
            Console.WriteLine($"Graduate {gradStudent.Name} passed: {gradStudent.IsPassed(gradStudent.Grade)}");

            Console.Read();
        }
    }
}
