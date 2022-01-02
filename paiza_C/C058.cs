// using System.Collections.Generic;
using System.Linq;
using System;
//C058: 模様そろえ
namespace paiza_C
{
    public class C058
    {
		//フィールド
		private static int N,countR,countL;
		private static string t,s;
		private static char[] charArrayR, charArrayL;

		internal static void main()
		{
			string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
			N = int.Parse(strArray[0]);
			t = strArray[1];
			s = strArray[2];

			if(t != s)
            {
				charArrayR = s.ToCharArray();
				charArrayL = charArrayR;
				Console.WriteLine(countMinRotate(charArrayR, charArrayL));
			}
			else if (t == s)
            {
				Console.WriteLine(0);
			}
		}

		internal static int countMinRotate(char[] chR, char[] chL)
		{
			roopUntilMatchR(chR);
			roopUntilMatchL(chL);
			return Math.Min(countR, countL);
		}
		internal static void roopUntilMatchR(char[] ch)
		{
			while (!match(rotateR(ch)))
			{
				roopUntilMatchR(ch);
			}
		}
		internal static void roopUntilMatchL(char[] ch)
		{
			while (!match(rotateL(ch)))
			{
				roopUntilMatchL(ch);
			}
		}


		internal static char[] rotateR(char[] ch)
		{
			char last = ch[N - 1]; //最初の値を最後の箱に先に入れ替えておく
			for (int i = N- 1; i > 0; i--)
			{
				ch[i] = ch[i - 1];
			}
			ch[0] = last;
			countR++;
			//string afterR = new string(ch);
			return ch;
		}

		internal static char[] rotateL(char[] ch)
		{
			char fast = ch[0]; //最初の値を最後の箱に先に入れ替えておく
			for (int i = 0; i < N - 1; i++)
			{
				ch[i] = ch[i + 1];
			}
			ch[N - 1] = fast;
			countL++;
			//string afterL = new string(ch);
			return ch;

		}

		internal static bool match(char[] ch)
		{
			string moji = new string(ch);
			if (t == moji) { return true; }
            else { return false; }
		}
	}
}

//受験結果 受験言語： C# 解答時間： 58分25秒 バイト数： 1579 Byte スコア： 6点  220102  ランタイムエラーが９割

//おそらくここのロジックが重たすぎた
//internal static int countMinRotate(char[] chR, char[] chL)
//{
//	//string mojiR = new string(rotateR(ch));
//	while (!match(rotateR(chR)))
//	{
//		countMinRotate(chR, chL);
//	}
//	while (!match(rotateL(chL)))
//	{
//		countMinRotate(chR, chL);
//	}

//	return Math.Min(countR, countL);
//}

//入力は以下のフォーマットで与えられます。
//N t s
//・1 行目には箱の側面の数を表す N、そろえる向きを表す文字列 t、最初の箱の向きを表す文字列 s がこの順に半角スペース区切りで与えられます。
//・入力は 1 行となり、末尾に改行が 1 つ入ります。