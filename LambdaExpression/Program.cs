using System.Collections.Generic;
namespace LambdaExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BuiltInDataTypes.LambdaExpOnInt();

            List<UserDefinedClass> studentList = new List<UserDefinedClass>()
            {
                new UserDefinedClass {rollno = 1, name = "Aryan"},
                new UserDefinedClass{rollno = 2,name = "Liza"},
                new UserDefinedClass{rollno = 3, name = "Stefani"},
                new UserDefinedClass{rollno = 4, name = "Trish"}
            };
            var studentDetails = studentList.OrderBy(x => x.name);
            foreach(var detail in studentDetails)
            {
                Console.WriteLine(detail.rollno + " " + detail.name);
            }

        }
    }
}
