using System;
namespace paiza_C
{
    public class D196
    {
        internal static void test()
        {
            int n = int.Parse(Console.ReadLine());  //1行目読み込み
            int p_i = 0;  
            int Sum = 0;
            for (int m = 0; m < n; m++)  //3行目移行を読み込み
            {
                p_i = int.Parse(Console.ReadLine());
                Sum += p_i;
            }
            Console.WriteLine(Sum);
        }
    }
}
//受験結果 受験言語： C# 解答時間： 6分12秒 バイト数： 406 Byte スコア： 100点