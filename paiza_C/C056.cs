using System;
//C056:テストの採点

namespace paiza_C
{
    public class C056
    {
        internal static void test()
        {
            string[] ArrayData = Console.ReadLine().Trim().Split(' ');
            int N = int.Parse(ArrayData[0]);
            int M = int.Parse(ArrayData[1]);

            for (int i = 1; i <= N; i++)  //iを学籍番号と揃える
            {
                string[] ArrayData2 = Console.ReadLine().Trim().Split(' ');
                int a_i = int.Parse(ArrayData2[0]);
                int b_i = int.Parse(ArrayData2[1]);

                if(a_i - 5 * b_i >= M)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}


//あなたは PAIZA 大学の講義を受講した学生の評価をしています。
//学生の成績はテストの点数から 欠席回数 × 5 点 を引いた点数とすることにしました。
//成績がマイナスとなった場合は 0 とします。

//学生のテストと欠席回数のデータが学籍番号順に与えられたとき、成績が合格点以上になっている学生の学籍番号を順に出力するプログラムを作成してください。
//学籍番号は 1 から順に与えられます。

//例えば、入力例 1 の場合では以下のようになります。
//N M
//a_1 b_1
//a_2 b_2
//...
//a_N b_N
//・1 行目に学生の人数を表す整数 N と合格点を表す整数 M が半角スペース区切りで与えられます。
//・続く N 行のうち i 行目 (1 ≦ i ≦ N ) には学籍番号 i の学生のテストの点数を表す整数 a_i、欠席回数を表す整数 b_i が半角スペース区切りで与えられます。
//・入力は合計で N + 1 行であり、入力値最終行の末尾に改行が 1 つ入ります。


//受験結果 受験言語： C# 解答時間： 12分7秒 バイト数： 739 Byte スコア： 100点  211207