using System;
using System.Collections.Generic;
using System.Linq;

/// B101:【2021年Xmas問題】キャンディのプレゼント
namespace paiza_C
{
    public class B101
    {
        internal static void test()
        {
            int N = int.Parse(Console.ReadLine());
            string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
            int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
            Array.Sort(intArray);  //intArray[]を昇順に並び替える  この時点で配列の大きさは2*N
            int[] sum = new int[N]; //合計値の箱 N
            
            //ArrayData[]から最大値・最小値(端と端)を取り出しその和をSum配列に入れていく
            for(int i = 0 ; i < N ; i++)
            {
                sum[i] = intArray[i] + intArray[2 * N - i - 1];
            }

            //Sum配列の最大値を最小値の差分を求める
            int delta = sum.Max()- sum.Min();
            Console.WriteLine(delta);
        }
    }
}

//受験結果 受験言語： C# 解答時間： 128分23秒 バイト数： 738 Byte スコア： 99点  211220
//全問正解 時間減点