using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.OOPs
{
    internal class HashTableAssignment
    {
        public static void Main(string[] args)
        {
            //Creating a Hashtable
            Hashtable myHashtable = new Hashtable();

            //Adding five key value pairs
            myHashtable.Add(1, "Hi");
            myHashtable.Add(2, "Lion");
            myHashtable.Add(3, "Dog");
            myHashtable.Add(4, "Cat");
            myHashtable.Add(5, "Horse");

            //Remove an key value pair
            //myHashtable.Remove(1);

            foreach (int key in myHashtable.Keys)
            {
                Console.WriteLine(key + " : " + myHashtable[key] + "   " + myHashtable.GetHashCode());
            }
        }
    }
}
