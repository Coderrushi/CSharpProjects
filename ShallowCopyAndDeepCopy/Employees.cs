using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShallowCopyAndDeepCopy
{
    internal class Employees
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public Address EmpAddress { get; set; }

        // for shallow copy
        public Employees GetClone()
        {
            return (Employees)this.MemberwiseClone();
        }

        // for deep copy
        //public Employees GetClone()
        //{
        //    Employees employee  = (Employees)this.MemberwiseClone();
        //    employee.EmpAddress = EmpAddress.getClone();
        //    return employee;
        //}

    }
}
