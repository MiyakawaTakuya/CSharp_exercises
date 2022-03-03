using System.Collections.Generic;
 using System.Linq;
using System;

//以下のような規則で整数を並べます。

//最初の3つの数は「1, 0, 5」である。
//それ以降は、直前の3つの整数の和を並べる。つまり、
//4番目の整数は 1 + 0 + 5 = 6
//5番目の整数は 0 + 5 + 6 = 11
//6番目の整数は 5 + 6 + 11 = 22
//この規則により、次のような列ができます。

//1, 0, 5, 6, 11, 22, 39, 72, ⋯

//この列の29番目の整数を求めてください。

namespace paiza_C.Questions
{
    public class teamLab_Tribonacci
    {
		//private static int n;
		//private static List<int> numbers = new List<int>();

		internal static void main()
		{
            int number = 30;
            for (int i = 0; i <= number; i++)
            {
                //tribonacci(i);
                Console.WriteLine(i+" : "+tribonacci(i));
            }
           
        }
        public static long tribonacci(int num)
        {
            // トリボナッチ数の最初の3項(0, 0, 1)を用いて，再起呼び出し
            return tri2(1, 0, 5, num);
        }

        public static long tri2(long a, long b, long c, long d)
        {
            if (d <= 1)
            {
                return 0;
            }
            // 再起の深さがd
            if (d == 2)
            {
                return c;
            }
            // 再起呼び出し
            return tri2(b, c, a + b + c, d - 1);
        }



        //public static long tribonacci(int num)
        //{
        //    // トリボナッチ数の最初の3項(0, 0, 1)を用いて，再起呼び出し
        //    return tri2(1, 0, 5, num);
        //}

        //public static long tri2(long a, long b, long c, long d)
        //{
        //    // 再起の深さがd
        //    if (d < 2)
        //    {
        //        return a;
        //    }
        //    // 再起呼び出し
        //    return tri2(a + b + c, a, b, d - 1);
        //}
    }
}

