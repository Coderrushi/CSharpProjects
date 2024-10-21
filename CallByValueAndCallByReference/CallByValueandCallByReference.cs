namespace CallByValueAndCallByReference
{
    internal class CallByValueandCallByReference
    {
        public static void ModifyValue(int num)
        {
            num = 20;
        }
        public static void ModifyReference(ref int num)
        {
            num = 20;
        }
        public static void ModifyArray(int[] arr)
        {
            arr[0] = 100;
        }
        static void Main(string[] args)
        {
            int a = 10;
            ModifyValue(a);
            Console.WriteLine("Call by Value: {0}", a); //call by value

            int b = 10;
            ModifyReference(ref b);
            Console.WriteLine("Call by Reference: {0}", b); //call by reference

            int[] arr = { 1, 2, 3 };
            ModifyArray(arr);
            Console.WriteLine("Referenece Type: {0}", arr[0]); //Reference Type
            // Even when passed by value, modifications to the object's contents are visible outside the method.
        }
    }
}
