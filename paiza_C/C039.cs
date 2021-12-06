using System;
//C039:古代の数式

namespace paiza_C
{
    public class C039
    {
        // 文字の出現回数をカウントする関数
        static int CountChar(string s, char c)
        {
            return s.Length - s.Replace(c.ToString(), "").Length;
        }

        internal static void test()
        {
            string[] ArrayDataE = Console.ReadLine().Trim().Split('+');  //1行目読み込み +の数は決まってない
            int sum = 0;

            for (int i = 0;i < ArrayDataE.Length; i++)
            {
                string S = ArrayDataE[i];
                sum += 10*CountChar(S, '<');
                sum += 1 * CountChar(S, '/');
            }
            Console.WriteLine(sum);
        }
    }
}

//・数式はすべて 2 個以上の整数の足し算となっている
//・使用する整数は 1 から 99 までで、10 進法を用いる
//・連続する "<" の数が整数の 10 の位を表し、それに続く連続する "/"(スラッシュ) の数が整数の 1 の位を表す
//・"+" が足し算の記号を表す
// <///////+<<</+////
// → 17 + 31 + 4 = 52
//
//・E は半角記号 "<", "/", "+" で構成される
//・3 ≦ (E の長さ) ≦ 100

//受験結果 受験言語： C# 解答時間： 26分1秒 バイト数： 835 Byte スコア： 93点  211207