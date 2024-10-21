namespace ShallowCopyAndDeepCopy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employees emp1 = new Employees
            {
                Name = "Rajesh",
                Department = "IT",
                EmpAddress = new Address { address = "Pune" }
            };
            Employees emp2 = emp1.GetClone();
            emp2.Name = "Rakesh";
            emp2.EmpAddress.address = "Mumbai";

            Console.WriteLine("Employee 1: ");
            Console.WriteLine("Name: "+ emp1.Name+", Address: "+ emp1.EmpAddress.address+", Dept: "+ emp1.Department);
            Console.WriteLine("Employee 2: ");
            Console.WriteLine("Name: " + emp2.Name + ", Address: " + emp2.EmpAddress.address + ", Dept: " + emp2.Department);
        }
    }
}
