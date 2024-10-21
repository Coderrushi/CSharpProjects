using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShallowCopyAndDeepCopy
{
    internal class Address
    {
        public string address {  get; set; }

        // for deep copy
        //public Address getClone()
        //{
        //    return (Address)this.MemberwiseClone();
        //}
    }
}
