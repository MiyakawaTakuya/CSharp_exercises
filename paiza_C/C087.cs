using System.Collections.Generic;
using System.Linq;
using System;
//C087:数字の規則

namespace paiza_C
{
    public class C087
    {
		//フィールド
		private static int N;
		private static string strN,fromFirst,fromLast;

		internal static void main()
		{
			strN = Console.ReadLine();
			N = int.Parse(strN);
			while (!isPalindrome(strN)) reverseAdd(strN);

			Console.WriteLine(strN);
		}
		//数字を反転して足し算する関数  int
		internal static string reverseAdd(string n)
		{
			var rev = string.Join("", n.Reverse());
			N = int.Parse(n) + int.Parse(rev);
			strN = N.ToString();
			return strN;
		}
		//値が回文かどうかを判定する関数 bool
		//stringのLengthが奇数か偶数かで条件分岐か？ 不要
		internal static bool isPalindrome(string b)
		{
			int count = 0;
			if (b.Substring(0, 1) == b.Substring(b.Length - 1)) count++;
            if (b.Length >= 4)
            {
			    for (int i = 2; i <= b.Length / 2; i++)
			    {
					if (b.Substring(i - 1, i) == b.Substring(b.Length - i - 1, b.Length - i)) count++;
				}
			}
			if (count == b.Length / 2)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}

//受験結果 受験言語： C# 解答時間： 56分14秒 バイト数： 987 Byte スコア： 51点  １問間違い  難易度に対して成績わるめ

//問題集計 受験者数： 4,944人 正解率： 87.31％ 平均解答時間： 22分59秒 平均スコア： 70.56点 
//難易度： 1600 ±6

//入力は以下のフォーマットで与えられます。
//N
//・ある整数 N が与えられます。入力は 1 行となり、末尾に改行が 1 つ入ります。
//すべてのテストケースにおいて、以下の条件をみたします。
//・1 ≦ N ≦ 1000
//・N は回文数ではない。
//・答えが 10 進数で 9 桁以内に収まる入力が与えられます。

//https://dobon.net/vb/dotnet/string/substring.html