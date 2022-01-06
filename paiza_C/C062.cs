﻿ using System.Collections.Generic;
using System.Linq;
using System;
//C062: 回転寿司のメロン
namespace paiza_C
{
    public class C062
    {
		//フィールド
		private static int T,count;
		private static List<string> food = new List<string>();

		internal static void main()
		{
			//入力
			T = int.Parse(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
				food.Add(Console.ReadLine());
			}
            //melonが出たらカウント
            for (int i = 0; i < T; i++)
            {
                if (food[i] == "melon")
                {
                    i += 10;
                    count++;
                }
            }

            Console.WriteLine(count);
		}
	}
}
//受験結果 受験言語： C# 解答時間： 33分40秒 バイト数： 610 Byte スコア： 83点  220106
//T
//n_1
//...
//n_T
//・1行目に流れてくる皿の数を示す整数 T が入力されます。
//・続く T 行に流れてくるネタを示す文字列 n_i (1 ≦ i ≦ T) が入力されます。
//・入力は合計で T + 1 行となり、入力値最終行の末尾に改行が 1 つ入ります。
