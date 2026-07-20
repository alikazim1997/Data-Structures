using System;


namespace Unboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valType = 10;
            object objType = valType; // Boxing

            // Fixed: unbox from 'objType' instead of 'valType'
            int unboxedValType = (int)objType;

            Console.WriteLine("Unboxed Value: " + unboxedValType);
            Console.ReadLine();    
        
        }
    }
}