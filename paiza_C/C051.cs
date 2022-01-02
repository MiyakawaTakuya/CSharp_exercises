using System.Collections.Generic;
using System.Linq;
using System;
//C051:カード並べ

namespace paiza_C
{
    public class C051
    {
		internal static void main()
		{
			string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
			int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
			Array.Sort(intArray);
			Console.WriteLine((intArray[2]+ intArray[3]) * 10 + intArray[0]+ intArray[1]);
		}

	}
}
//受験結果 受験言語： C# 解答時間： 16分43秒 バイト数： 330 Byte スコア： 100点  220103

//入力は以下のフォーマットで与えられます。
//a b c d
//・a, b, c, d はそれぞれ 4 枚のカードに書かれた数を表し、半角スペース区切りで与えられます。
//・入力は 1 行となり、入力値最終行の末尾に改行が 1 つ入ります。
