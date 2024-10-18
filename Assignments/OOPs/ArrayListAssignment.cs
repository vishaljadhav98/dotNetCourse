using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.OOPs
{
    internal class ArrayListAssignment
    {
        public static void Main(string[] args)
        {
            //Creating an ArrayList
            ArrayList list = new ArrayList();

            //Adding elements to the list
            Console.Write("The added list : ");
            for (int i = 1; i <= 10; i++)
            {
                list.Add(i);
                Console.Write(i + " ");
            }

            //Removing an element from the list which occurs first
            list.Remove(5);
            Console.Write("\nThe removed list : ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }

            //Remove an element from the list at a given specific index
            list.RemoveAt(0);
            Console.Write("\nThe removedAt list : ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }

            //Clear the entire List
            list.Clear();
            Console.Write("\nThe Cleared list : ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
        }
    }
}
