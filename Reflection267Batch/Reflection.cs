using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection267Batch
{
    public class Reflection
    {
        public static int GetClosestEvenNumber(int n)
        {
            int absN = Math.Abs(n);
            int closest = int.MaxValue;
            // Iterate over even numbers less than or equal to absN
            for (int i = 0; i <= absN; i += 2)
            {
                int temp = i;
                bool allEven = true;
                // Iterate over digits of i and check if they are all even
                while (temp > 0)
                {
                    int digit = temp % 10;
                    if (digit % 2 != 0)
                    {
                        allEven = false;
                        break;
                    }
                    temp /= 10;
                }
                // Update closest if i has all even digits and is closer to absN
                if (allEven && Math.Abs(absN - i) < Math.Abs(absN - closest))
                {
                    closest = i;
                }
            }
            // Negate closest if n is negative
            if (n < 0)
            {
                closest = -closest;
            }
            return closest;
        }
    }
}
