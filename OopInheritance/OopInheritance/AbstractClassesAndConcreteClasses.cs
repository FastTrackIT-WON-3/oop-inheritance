using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopInheritance
{
    public abstract class AbstractClass
    {
        public abstract void ChildSpecificFunctionality();

        public void GeneralFunctionality()
        {
            Console.WriteLine("Executing GeneralFunctionality");
            ChildSpecificFunctionality();
        }
    }

    public class ConcreteClass : AbstractClass
    {
        public override void ChildSpecificFunctionality()
        {
            Console.WriteLine("Executing ConcreteClass.ChildSpecificFunctionality");
        }
    }
}
