// using System.Collections.Generic;
// using System.Linq;
using System;
namespace paiza_C
{
    public class zokuzoku
    {
        internal static void main()
        {
            string zokuzoku = "ʕ•̫͡•ʕ•̫͡•ʔ•̫͡•ʔ•̫͡•ʕ•̫͡•ʔ•̫͡•ʕ•̫͡•ʕ•̫͡•ʔ•̫͡•ʔ•̫͡•ʕ•̫͡•ʔ•̫͡•ʔ";
            char[] barabara = zokuzoku.ToCharArray();
            Console.WriteLine(String.Join(" ", barabara));
            //ʕ • ̫ ͡ • ʕ • ̫ ͡ • ʔ • ̫ ͡ • ʔ • ̫ ͡ • ʕ • ̫ ͡ • ʔ • ̫ ͡ • ʕ • ̫ ͡ • ʕ • ̫ ͡ • ʔ • ̫ ͡ • ʔ • ̫ ͡ •

            for(int i=1;i <= barabara.Length;i++)
            {
                //if(i != barabara.Length) Console.Write(i + " = " + barabara[i - 1] + ", ");
                //else Console.Write(i + " = " + barabara[i - 1]);
                Console.WriteLine(i + "=" + barabara[i - 1]);
            }
            //1 = ʕ, 2 = •, 3 = ̫, 4 = ͡, 5 = •, 6 = ʕ, 7 = •, 8 = ̫, 9 = ͡, 10 = •, 11 = ʔ, 12 = •, 13 = ̫, 14 = ͡, 15 = •, 16 = ʔ, 17 = •, 18 = ̫,
            //19 = ͡, 20 = •, 21 = ʕ, 22 = •, 23 = ̫, 24= ͡, 25 = •, 26 = ʔ, 27 = •, 28 = ̫, 29 = ͡, 30 = •, 31 = ʕ, 32 = •, 33 = ̫, 34 = ͡, 35 = •,
            //36 = ʕ, 37 = •, 38 = ̫, 39 = ͡, 40 = •, 41 = ʔ, 42 = •, 43 = ̫, 44 = ͡, 45 = •, 46 = ʔ, 47 = •, 48 = ̫, 49 = ͡, 50 = •, 51 = ʕ, 52 = •,
            //53 = ̫, 54 = ͡, 55 = •, 56 = ʔ, 57 = •, 58 = ̫, 59 = ͡, 60 = •, 61 = ʔ
        }
    }
}
