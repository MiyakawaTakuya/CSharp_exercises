// using System.Collections.Generic;
// using System.Linq;
using System;
namespace paiza_C.PrimeNumber
{
    public class Prime
    {
        //1 ≦ N ≦ 1,000,000,000,000
        //実は N を割り切れるかどうかを 2 〜 N-1 の全ての整数について調べなくても、 2 〜 ルート N の整数について調べるだけで N の素数判定ができます。
        //具体的な証明は省略しますが、これは N に 1 と N 以外の約数があると仮定した場合、少なくとも 1 つは N の 0.5 乗（ルート N ）
        //以下の約数があるという約数の性質に基づくものです。

        internal static void main()
        {
            long N = long.Parse(Console.ReadLine());
            if(N != 1)
            {
                int count = 0;
                for (int i = 2; i * i < N; i++)
                {
                    if (N % i == 0)
                    {
                        count++;
                        break;
                    }
                }
                if (count != 0) Console.WriteLine("NO");
                else Console.WriteLine("YES");
            }
            else Console.WriteLine("NO");

        }
    }
}
