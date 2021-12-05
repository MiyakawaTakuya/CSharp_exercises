using System;
using System.Linq;

namespace paiza_C
{
    public class D103
    {
        internal static void test()
        {
            string S = Console.ReadLine();
            // var rev = string.Join("", S.Reverse());
            var rev = new string(S.Reverse().ToArray());
            Console.WriteLine(rev);
        }
    }
}

