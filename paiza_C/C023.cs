using System;
using System.Collections.Generic;
//C023:クジの当選番号

namespace paiza_C
{
    public class C023
    {
        internal static void test()
        {
            int count = 0;
            string[] ArrayData = Console.ReadLine().Trim().Split(' ');
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                string[] ArrayData2 = Console.ReadLine().Trim().Split(' ');
                for (int p = 0; p < 6; p++)
                {
                    if (((IList<string>)ArrayData2).Contains(ArrayData[p]))
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                count = 0;  //リセット
            }
        }
    }
}

//受験結果 受験言語： C# 解答時間： 19分49秒 バイト数： 692 Byte スコア： 100点  211220