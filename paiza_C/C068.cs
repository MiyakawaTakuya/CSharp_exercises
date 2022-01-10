// using System.Collections.Generic;
using System.Linq;
using System;
//C068:秘密の手紙

namespace paiza_C
{
    public class C068
    {
		//フィールド
		private static char[] ABC = new char[]
		{'A', 'B', 'C', 'D', 'E', 'F','G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R','S', 'T', 'U', 'V', 'W', 'X','Y', 'Z'};
		private static char[] charsS;
		private static int[] charsPos;
		private static int N;

		internal static void main()
		{
			//入力
			N = int.Parse(Console.ReadLine());
			string S = Console.ReadLine();
			charsS = S.ToCharArray();
			int length = charsS.Length;
			//一文字ずつそれぞれabcの何番目かを把握する
			charsPos = new int[length];
			for(int i = 0;i < length; i++)
            {
                charsPos[i] = Array.IndexOf(ABC ,charsS[i]);
            }

			//奇数番目の文字は-N番目の文字に置き換える関数
			//偶数番目の文字は+N番目の文字に置き換える関数
			//にそれぞれ降っていき変換していく
			char[] cenvertedArr = new char[length];
			for (int j = 0; j < length; j++)
			{
				if((j+1) % 2 != 0)  //奇数だったら
                {
					cenvertedArr[j] = odd(charsPos[j]);
				}
				if ((j + 1) % 2 == 0)  //偶数だったら
				{
					cenvertedArr[j] = even(charsPos[j]);
				}

			}

			//出力
			foreach(char ch in cenvertedArr)
			{ 
			    Console.Write(ch);
			}
			Console.WriteLine("");
		}

		//奇数番目の文字
		internal static char odd(int od)
		{
			if(od - N >= 0)
            {
				return ABC[od - N];
			}
            else
            {
				return ABC[26 + (od - N) ];
			}
		}

		//偶数番目の文字
		internal static char even(int ev)
		{
			if (ev + N < 26)
			{
				return ABC[ev + N];
			}
			else
			{
				return ABC[(ev + N) -26];
			}
		}

	}
}
//受験結果 受験言語： C# 解答時間： 76分56秒 バイト数： 1471 Byte スコア： 0点  220111 正答率は100
//要件定義で時間かかってる。
//変換の関数のところで+26-26のところで混乱していた
