// using System.Collections.Generic;
using System.Linq;
using System;
//C067:【ハッカー入門コラボ問題】数字の調査

namespace paiza_C
{
    public class C067
    {
		//フィールド
		private static int N,X;
		private static char[] array;

		internal static void main()
		{
			string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
			int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
			N = intArray[0];
			X = intArray[1];

			string n = Convert.ToString((X), 2);
			array = n.ToArray();
			Array.Reverse(array);  //二進数を逆にする

			for (int i = 0; i < N; i++)
			{
				int pos = int.Parse(Console.ReadLine());
				Console.WriteLine(array[pos - 1]);
			}
			
		}
	}
}

//受験結果 受験言語： C# 解答時間： 23分42秒 バイト数： 566 Byte スコア： 96点  220107
//N X
//k_1
//k_2
//...
//k_N
//・1 行目にそれぞれ知りたい数字を表す整数 N, X がこの順で半角スペース区切りで与えられます。
//・続く N 行のうちの i 行目 (1 ≦ i ≦ N) には知りたい桁が右から何番目であるかを表す整数 k_i が与えられます。
//・入力は合計で N + 1 行となり、入力値最終行の末尾に改行が 1 つ入ります。