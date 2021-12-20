using System;
//C084:【キャンペーン問題】枠で囲む

namespace paiza_C
{
    public class C084
    {
        internal static string S;

        internal static void test()
        {
            string S = Console.ReadLine();
            for(int i=0 ; i < S.Length + 2 ; i++)
            {
                Console.Write("+");
            }
            Console.WriteLine(""); //改行
            Console.WriteLine("+" + S + "+");
            for (int i = 0; i < S.Length + 2 ; i++)
            {
                Console.Write("+");
            }
            Console.WriteLine(""); //改行
        }

        //繰り返す使うものを関数化する
        internal static void outline()
        {
            for (int i = 0; i < S.Length + 2; i++)
            {
                Console.Write("+");
            }
            Console.WriteLine(""); //改行
        }

        internal static void test2()
        {
            S = Console.ReadLine();
            outline();
            Console.WriteLine("+" + S + "+");
            outline();
        }

    }
}
//受験結果 受験言語： C# 解答時間： 9分13秒 バイト数： 466 Byte スコア： 100点  211220
