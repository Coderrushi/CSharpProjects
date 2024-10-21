using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class FatherClass
    {
        public string FatherName()
        {
            return "Rajuprasad";
        }
    }
    public class FirstChildClass : FatherClass
    {
        public string FirstChildName()
        {
            return "Bunty";
        }
    }
    public class SecondChildClass : FatherClass
    {
        public string SecondChildName()
        {
            return "Bubli";
        }
    }
}
