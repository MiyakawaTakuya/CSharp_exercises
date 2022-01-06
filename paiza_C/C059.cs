// using System.Collections.Generic;
using System.Linq;
using System;
//C059:パリティチェック

namespace paiza_C
{
    public class C059
    {
		//フィールド
		private static string line;
		private static int pos0Sum, pos1Sum, pos2Sum, pos3Sum;


		internal static void main()
		{
			//入力
			int N = int.Parse(Console.ReadLine());
			for (int i = 0; i < N; i++)
			{
				line = Console.ReadLine();
				pos0Sum += int.Parse(line.Substring(0, 1));
				pos1Sum += int.Parse(line.Substring(1, 2));
				pos2Sum += int.Parse(line.Substring(2, 3));
				pos3Sum += int.Parse(line.Substring(3));
			}
	        //出力
			Console.WriteLine(toZeroOne(pos0Sum) + toZeroOne(pos1Sum) + toZeroOne(pos2Sum) + toZeroOne(pos3Sum));
		}

		internal static string toZeroOne(int a)
		{
			if(a % 2 == 0|| a == 0)
            {
				return "0";
			}
			else if (a % 2 == 1 || a == 1)
            {
				return "1";
			}
			return "";
		}
	}
}
//受験結果 受験言語： C# 解答時間： 21分47秒 バイト数： 809 Byte スコア： 98点  220104
//public string Substring (int startIndex, int length);
//この部分文字列は、指定した文字位置から開始し、指定した文字数の文字列です

//N
//b_1
//b_2
//...
//b_N
//・1 行目には、与えられる 2 進数の数 N が整数で与えられます。
//・続く N 行の i 行目 (1 ≦ i ≦ N) には、4 桁の 2 進数を示す文字列 b_i が与えられます。
//・入力は合計で N + 1 行となり、入力値最終行の末尾に改行が１つ入ります。