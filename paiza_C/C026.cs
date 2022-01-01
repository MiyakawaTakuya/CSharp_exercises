using System;
using System.Collections.Generic;
using System.Linq;

//C026: ウサギと人参
namespace paiza_C
{
    public class C026
    {
		//フィールド
		private static int N,S,p;
		private static List<int> carrotWay = new List<int>();
		private static List<int> okCarrot = new List<int>();
		private static List<int> okCarrotNum = new List<int>();

		internal static void main()
		{
			string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
			int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
			N = intArray[0];
			S = intArray[1];
			p = intArray[2];
			//入力
			for (int i = 0; i < N; i++)
			{
				string[] strArray2 = Console.ReadLine().Trim().Split(' ');  //読み取り
				int[] intArray2 = strArray2.Select(int.Parse).ToArray();  //intへ変換
				carrotWay.Add(intArray2[0]);
				if (okSugarContent(intArray2[1]))
				{
					okCarrotNum.Add(i);
					okCarrot.Add(intArray2[0]);
				}
			}
			//出力 糖質がOKなニンジンが１つでもある場合とそうでない場合
			if (okCarrot.Count != 0)
			{
				getCarrotNum(okCarrot.Max());
			}
			else if (okCarrot.Count == 0)
			{
				Console.WriteLine("not found");
			}
		}

		internal static bool okSugarContent(int ca)
		{
			if (S - p <= ca && ca <= S + p) { return true; }
			else { return false; }
		}

		internal static void getCarrotNum(int max)
		{
			for (int i = 0; i < okCarrot.Count ; i++)
            {
				if(max == okCarrot[i])
                {
					Console.WriteLine(okCarrotNum[i]);
					break;
				}
            }
		}
	}
}

//受験結果 受験言語： C# 解答時間： 54分48秒 バイト数： 1432 Byte スコア： 57点  正答率100%

//入力は以下のフォーマットで与えられます。
//N S p
//m_1 s_1
//...
//m_N s_N
//1行目には3つの整数 N, S, p が入力されます。 それぞれ、人参のデータの数、目安となる糖分、許容誤差を表します。

//続く N 行には N 個の人参のデータが与えられます。
//ここで、人参には 1 から N の番号が付いているものとし、 m_i、s_i はそれぞれ番号 i の人参の質量、糖分を表す整数です。