using System;

namespace Boxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Value Type
            int valType = 10;

            // Boxing: Convert Value Type to Object
            object objType = valType;

            Console.WriteLine($"Value Type : {valType}");
            Console.WriteLine($"Object Type: {objType}");

            Console.WriteLine($"Value Type Data Type : {valType.GetType()}");
            Console.WriteLine($"Object Type Data Type: {objType.GetType()}");
            Console.ReadLine(); 
        }
    }
}