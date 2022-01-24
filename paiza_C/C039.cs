using System;
using System.Linq;
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
                sum += 10 * CountChar(S, '<');
                sum += 1 * CountChar(S, '/');
            }
            Console.WriteLine(sum);
        }


        static void test2()
        {
            string line = Console.ReadLine();
            int result = 0;
            string[] numbers = line.Split('+');
            foreach (var i in numbers)
            {
                //int firsrt_count = i.Where(c => c == '/').Count();
                int firsrt_count = i.Count(f => f == '/');  //Linqを利用してラムダ式でコンパクトに！
                int second_count = i.Count(f => f == '<');
                result = result + firsrt_count + 10 * second_count;
            }
            Console.WriteLine(result);
        }
        //Paiza会にて
        //ただし、StringクラスのReplaceメソッドを利用した処理の方が数倍ほど速いので、カウントする処理を繰り返す場合には注意してほしい。
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