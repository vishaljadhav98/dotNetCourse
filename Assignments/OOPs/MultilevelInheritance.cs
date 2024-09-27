using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.OOPs
{
    public class Person3
    {
        public string name;
        public string address;
    }
    public class Teacher : Person3
    {
        public int id;
        public int salary;
    }
    public class Principle : Teacher
    {
        public Principle(int id, string name, int salary, string address)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.address = address;
        }
        public void Display()
        {
            Console.WriteLine("ID : " + id);
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Salary : " + salary);
            Console.WriteLine("Address : " + address);
        }
    }
    internal class MultilevelInheritance
    {
        static void Main(string[] args)
        {
                Principle principle = new Principle(111, "Vishal", 100000, "Pune");
                principle.Display();
        }
    }
}
