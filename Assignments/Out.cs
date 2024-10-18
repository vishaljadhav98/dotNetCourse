using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Out
    {
        public static void Main(string[] args)
        {
            int mainValue = 10;
            string mainName = "CSharp";
            InitializeValues(out mainValue, mainName);
            Console.WriteLine(mainValue + " " + mainName);
        }
        public static void InitializeValues(out int funValue, string funName)
        {
            funValue = 0;
            funValue += 20;
            funName = "";
            funName += "Java";
        }
    }
}
