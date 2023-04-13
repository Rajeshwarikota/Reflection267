using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection267Batch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("....REFLECTION....");
            int n = 17;
            int closest = Reflection.GetClosestEvenNumber(n);
            Console.WriteLine($"The closest number to {n} with all even digits is {closest}");

            int m = -33;
            int closestM = Reflection.GetClosestEvenNumber(m);
            Console.WriteLine($"The closest number to {m} with all even digits is {closestM}");
            Console.ReadLine(); 
        }
    }
}
