using System.Collections.Generic;
using System.Linq;
using System;
//C070:簡易カードゲーム
namespace paiza_C
{
    public class C070
    {
		//フィールド
		private static char[] chaArray;

		//クラス
		private class Card
		{
			public Card(char a, char b, char c, char d)  //コンストラクタ
			{
				A = a;
				B = b;
				C = c;
				D = d;
			}
			public char A { get; set; }
			public char B { get; set; }
			public char C { get; set; }
			public char D { get; set; }

			public string WhatsRole(Card ca)
            {
				if(A==B && B==C && C==D) //four
                {
					return "Four Card";
				}
				else if (A == B && B == C && C != D) //three
				{
					return "Three Card";
				}
				else if (A != B && B == C && C == D) //three
				{
					return "Three Card";
				}
				else if (A == B && C == D && B != C) //two pair
				{
					return "Two Pair";
				}
				else if (A == B && B != C && C!=D) //one pair
				{
					return "One Pair";
				}
				else if (A != B && B == C && C != D) //one pair
				{
					return "One Pair";
				}
				else if (A != B && B  != C && C == D) //one pair
				{
					return "One Pair";
				}
				else
                {
					return "No Pair";
				}
            }
		}

		internal static void main()
		{
			//入力
			int N = int.Parse(Console.ReadLine());
			for (int i = 0; i < N; i++)
			{
				chaArray = Console.ReadLine().ToCharArray();
				Card card = new Card(chaArray[0], chaArray[1], chaArray[2], chaArray[3]);
				//出力
				Console.WriteLine(card.WhatsRole(card));
			}
		}
	}
}

//受験結果 受験言語： C# 解答時間： 26分25秒 バイト数： 1392 Byte スコア： 92点  220111