using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Ref
    {
        public static void Main(string[] str)
        {
            int mainValue = 1;
            IncrementValue(ref mainValue);
            Console.Out.WriteLine(mainValue);
        }
        public static void IncrementValue(ref int functionValue)
        {
            {
                functionValue += 1;
            }
        }
    }
}
