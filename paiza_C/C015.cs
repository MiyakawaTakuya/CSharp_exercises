using System;
//C015:ポイントカードの計算

namespace paiza_C
{
    public class C015
    {
        internal static void test()
        {
            int N = int.Parse(Console.ReadLine());
            double sum = 0;  //合計金額

            for (int i = 0; i < N; i++)
            {
                string[] ArrayData = Console.ReadLine().Trim().Split(' ');
                string d_i = ArrayData[0];
                int p_i = int.Parse(ArrayData[1]);

                if (d_i.Contains("3"))
                {
                    sum += Math.Floor(p_i * 0.03);  //小数点切り捨て
                }
                else if (d_i.Contains("5"))
                {
                    sum += Math.Floor(p_i * 0.05);
                }
                else
                {
                    sum += Math.Floor(p_i * 0.01);
                }
            }
            Console.WriteLine(sum);
        }
    }
}

//受験結果 受験言語： C# 解答時間： 31分58秒 バイト数： 900 Byte スコア： 86点  211214

//N # 各レシートの数
//d_1 p_1　#1枚目のレシートの日付 d_1 日, 購入金額 p_1 円
//d_2 p_2　#2枚目のレシートの日付 d_2 日, 購入金額 p_2 円
//...
//d_N p_N　#N枚目のレシートの日付 d_N 日, 購入金額 p_N 円
//1行目には今月分のレシートの枚数を表す整数 N が入力されます。続く N 行には各レシートの情報が入力されます。
//すなわち、d_i p_i は i 枚目のレシートが発行された日付が d_i 日であり、このときの購入金額が p_i 円であることを表します。
//すべてのテストケースで以下の条件を満たします。

//・ 1 ≦ N ≦ 1000(レシートの数)
//・ 1 ≦ d_i ≦ 31(i番目のレシートが発行された日付)
//・ 1 ≦ p_i ≦ 10000(i番目のレシートの購入金額)
