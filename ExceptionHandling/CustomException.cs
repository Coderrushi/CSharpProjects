using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class CustomException : Exception
    {
        public CustomException() { }
        public CustomException(string message) : base(message) { }
        public CustomException(string message, Exception inner) : base(message, inner) { }
        public override string Message 
        {
            get
            {
                return "Number is not completely divisible by 3";
            }
        }
        public override string HelpLink
        {
            get
            {
                return "Get more information here : " +
                    "https://learn.microsoft.com/en-us/dotnet/standard/exceptions/how-to-create-user-defined-exceptions";
            }
        } 
    }
}
