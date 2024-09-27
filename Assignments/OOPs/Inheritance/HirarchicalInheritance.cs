using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.OOPs.Inheritance
{
    public class Shape
    {
        public string color;
        public void DisplayDetails()
        {
            Console.WriteLine(color);
        }
    }
    public class Circle2 : Shape
    {
        public Circle2(string color)
        {
            this.color = color;
        }
    }
    public class Rectangle2 : Shape
    {
        public Rectangle2(string color)
        {
            this.color = color;
        }
    }
    internal class HirarchicalInheritance
    {
        public static void Main(string[] args)
        {
            Circle2 circle = new Circle2("White");
            Console.Write("Circle color : ");
            circle.DisplayDetails();
            Rectangle2 rectangle2 = new Rectangle2("Black");
            Console.Write("Rectangle color : ");
            rectangle2.DisplayDetails();
        }
    }
}
