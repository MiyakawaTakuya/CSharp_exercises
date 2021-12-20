using System;
using System.Collections.Generic;
//C090:【40万人記念問題】黒電話

namespace paiza_C
{
    public class C090
    {
        internal static void test()
        {
            string S = Console.ReadLine().Replace("-", "");
            var dial = new Dictionary<string, int>()
            {{"0",12},{"1",3},{"2",4},{"3",5},{"4",6},{"5",7},{"6",8},{"7",9},{"8",10},{"9",11}};
            int sum = 0;
            foreach(char c in S)
            {
                sum += dial[c.ToString()];
            }
            Console.WriteLine(sum * 2);
        }
    }
}

//受験結果 受験言語： C# 解答時間： 19分30秒 バイト数： 482 Byte スコア： 100点  211220