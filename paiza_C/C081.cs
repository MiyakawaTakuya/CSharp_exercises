using System;
using System.Collections.Generic;
using System.Linq;
//C081:靴下の整理

namespace paiza_C
{
    public class C081
    {
		//フィールド
		private static int pairSum = 0;
		private static Dictionary<string, string> socks = new Dictionary<string, string>();
		private static int countR = 0;
		private static int countL = 0;
		private static int countPair = 0;
		private static int[] countRL = new int[2];

		internal static void main()
		{
			int N = int.Parse(Console.ReadLine());

			//Dictionaryに格納する
			for (int i = 0; i < N; i++)
			{
				string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
                if (!socks.ContainsKey(strArray[0]))
                {
					socks.Add(strArray[0], strArray[1]);
				}
				else if (socks.ContainsKey(strArray[0]))
                {
					socks[strArray[0]] += strArray[1];
				}
			}
			//Dictionaryのそれぞれのキーに対して、何ペア成立しているかをカウントする
			foreach(string Key in socks.Keys)
            {
				pairSum += pairCount(socks[Key]);
			}
			//出力
			Console.WriteLine(pairSum);
		}

		internal static int pairCount(string value)
		{
			char[] chars = value.ToCharArray();  //一文字ずつchar配列として分解する
			foreach (char one in chars)
			{
				switch (one)  //左回りして一つ進む
				{
					case 'R': countR += 1; break;
					case 'L': countL += 1; break;
				}
			}
			countRL[0] = countR; countRL[1] = countL;
			countPair = countRL.Min();
			countR = 0; countL = 0;
			return countPair;
		}

	}
}
//入力は以下のフォーマットで与えられます。

//N
//t_1 d_1
//t_2 d_2
//...
//t_N d_N
//・1 行目には、与えられる靴下の数を表す整数 N が与えられます。
//・続く N 行目のうち i 行目 (1 ≦ i ≦ N) には、i 番目の靴下の種類を表す文字 t_i, および左右を表す文字 d_i が与えられます。
//・入力は合計で N + 1 行となり、入力値最終行の末尾に改行が 1 つ入ります。