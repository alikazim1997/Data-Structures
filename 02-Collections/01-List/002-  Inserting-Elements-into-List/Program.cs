using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace _002___Inserting_Elements_into_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> {1,4,5,6,7,8,9,10 };
            list.Add(11);
            Console.WriteLine("After adding 11 : "+ string.Join(", ",list));
            list.Insert(0, 0);
            Console.WriteLine("After inserting 0 at the beginning  " + string.Join(", ", list));
            list.InsertRange(2, new List<int> { 2, 3 });

            Console.WriteLine("After adding 11 : " + string.Join(", ", list));
        }
    }
}
