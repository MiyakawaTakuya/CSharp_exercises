// using System.Collections.Generic;
using System.Linq;
using System;

namespace paiza_C.PrimeNumber
{
    public class Grothendieck
    {
        internal static void main()
        {
            int grothandieck = 57;
            int count = 0;
            for(int i = 2; i < grothandieck; i++)
            {
                if (grothandieck % i == 0) count++;
            }
            if(count!=0) Console.WriteLine("NO");
            else Console.WriteLine("YES");
        }
    }
}
