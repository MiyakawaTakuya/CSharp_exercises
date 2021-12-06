using System;
//C020:残り物の量

namespace paiza_C
{
    public class C020
    {
        internal static void test()
        {
            string[] ArrayData = Console.ReadLine().Trim().Split(' ');  //1行目読み込み・・
            double m = double.Parse(ArrayData[0]);
            double p = double.Parse(ArrayData[1]);
            double q = double.Parse(ArrayData[2]);
            double _P = (100 - p) / 100;
            double _Q = (100 - q) / 100;
            double leave = m* _P * _Q;

            Console.WriteLine(leave);
        }
    }
}

//1 ≦ m ≦ 1000
//0 ≦ p, q ≦ 100
//p = 100 のとき、q = 0
//入力例
//1 80 40

//受験結果 受験言語： C# 解答時間： 14分12秒 バイト数： 464 Byte スコア： 100点 211206