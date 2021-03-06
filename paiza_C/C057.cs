using System;
//C057:シャボン玉飛ばし

namespace paiza_C
{
    public class C057
    {
        //リファクタリング 220401
        internal static void main()
        {
            string[] ArrayData = Console.ReadLine().Trim().Split(' ');
            int T = int.Parse(ArrayData[0]);  //T秒間風がふく
            int x = int.Parse(ArrayData[1]);  //最初のx座標
            int y = int.Parse(ArrayData[2]);  //最初のx座標
            int maxX = x; //最大値用の変数
            for (int i = 1; i <= T; i++)
            {
                string[] ArrayData_xy = Console.ReadLine().Trim().Split(' ');
                x += int.Parse(ArrayData_xy[0]);
                if (maxX < x) maxX = x;   //最大値を適宜書き換え
                y += int.Parse(ArrayData_xy[1]);
                if (y <= 0) break;
            }
            Console.WriteLine(maxX);
        }

        //internal static void test()
        //{
        //    string[] ArrayData = Console.ReadLine().Trim().Split(' ');
        //    int T = int.Parse(ArrayData[0]);  //T秒間風がふく
        //    int x = int.Parse(ArrayData[1]);  //最初のx座標
        //    int y = int.Parse(ArrayData[2]);  //最初のx座標
        //    int maxX = x; //最大値用の変数
        //    while (y > 0)
        //    {
        //        for (int i = 1; i <= T; i++)
        //        {
        //            string[] ArrayData_xy = Console.ReadLine().Trim().Split(' ');
        //            x += int.Parse(ArrayData_xy[0]);
        //            y += int.Parse(ArrayData_xy[1]);
        //            if (maxX < x)  //最大値を適宜書き換え
        //            {
        //                maxX = x;
        //            }
        //            if (y <= 0) //地面に着地したらbreakで抜け出す
        //            {
        //                break;
        //            }
        //        }
        //        break; //風が吹き終わったらbreakで抜け出す
        //    }
        //    Console.WriteLine(maxX);
        //}
    }
}

//あなたは友達とシャボン玉を飛ばして遊んでいました。ふと、あなたは、自分が作ったシャボン玉がどこまで飛んで行くのかが気になりました。
//あなたは、時刻 0 のときに座標(x, y) にシャボン玉を作ります。このシャボン玉は、時刻 i - 1 と時刻 i の間 (1 ≦ i ≦ T) に風を受けます。この風により、まずシャボン玉の x 座標が a_i 増えます。その次に、シャボン玉の y 座標が b_i 増えます。
//シャボン玉は、y 座標が 0 以下になると、地面に接触し割れてなくなってしまいます。
//時刻 T までに吹く風の情報が与えられるので、シャボン玉が通った x 座標の最大値を求めるプログラムを作成してください。

//例)
//入力例 1 の状況を考えます。シャボン玉が最初(1, 1) にあるとします。時刻 4 までに次のように風が吹くとします。
//・時刻 0 から時刻 1: x 座標 +4, y 座標 +2
//・時刻 1 から時刻 2: x 座標 -5, y 座標 -4
//・時刻 2 から時刻 3: x 座標 +3, y 座標 +3
//・時刻 3 から時刻 4: x 座標 +3, y 座標 +3

//T x y
//a_1 b_1
//a_2 b_2
//...
//a_T b_T
//・1 行目に、風が吹く時刻の長さを表す整数 T、シャボン玉の最初の x 座標を表す整数 x、シャボン玉の最初の y 座標を表す整数 y がこの順で半角スペース区切りで与えられます。
//・続く T 行のうちの i 行目 (1 ≦ i ≦ T) には、時刻 i - 1 と時刻 i の間に吹く風の情報を表す整数 a_i, b_i がこの順で半角スペース区切りで与えられます。
//・入力は合計で T + 1 行となり、入力値最終行の末尾に改行が 1 つ入ります。
//・1 ≦ T ≦ 100
//・-1,000 ≦ x ≦ 1,000
//・1 ≦ y ≦ 1,000
//・-1,000 ≦ a_i, b_i ≦ 1,000(1 ≦ i ≦ T)

//受験結果 受験言語： C# 解答時間： 27分31秒 バイト数： 977 Byte スコア： 100点  211207