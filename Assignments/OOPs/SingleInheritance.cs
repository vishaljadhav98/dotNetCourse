using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.OOPs
{
    public class Person2
    {
        public int rollNo;
        public string name;
    }
    public class Student : Person2
    {
        public Student(int rollNo, string name)
        {
            this.rollNo = rollNo;
            this.name = name;
        }
        public void Display()
        {
            Console.WriteLine("Roll No. : " + rollNo);
            Console.WriteLine("Name : " + name);
        }
    }
    internal class SingleInheritance
    {
        public static void Main(string[] arg)
        {
            Student emp = new Student(101, "Vishal");
            emp.Display();
        }
    }
}
