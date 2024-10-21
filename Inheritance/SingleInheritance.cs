using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class BaseClass
    {
        public void display1()
        {
            Console.WriteLine("display1() method from BaseClass");
        }
    }
    public class DerivedClass : BaseClass
    {
        public void display2()
        {
            display1();
            Console.WriteLine("display2() method from DerivedClass");
        }
    }
}
