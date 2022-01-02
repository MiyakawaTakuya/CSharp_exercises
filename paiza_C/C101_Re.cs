using System.Collections.Generic;
using System.Linq;
using System;
//C101:【2021年Xmas問題】ラッキーデイ

namespace paiza_C
{
    public class C101_Re
    {
		private static int judgeXcount;
		private static string[] year = new string[365];

		internal static void main()
		{
			string X = Console.ReadLine();
			//0〜364までが格納されたstring[]を用意する
			for (int i = 0; i < 365; i++)
			{
				if (i.ToString().Contains(X)) judgeXcount++;
			}

			Console.WriteLine(judgeXcount);
		}
	}
}

//受験結果 受験言語： C# 解答時間： 21分4秒 バイト数： 359 Byte スコア： 100点