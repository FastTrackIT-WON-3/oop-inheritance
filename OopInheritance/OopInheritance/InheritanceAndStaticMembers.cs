using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopInheritance
{
    public class BaseClassWithStaticMember
    {
        public static void Test()
        {
            Console.WriteLine("Running Test method from BaseClassWithStaticMember");
        }
    }

    public class ChildClass : BaseClassWithStaticMember
    {
    }
}
