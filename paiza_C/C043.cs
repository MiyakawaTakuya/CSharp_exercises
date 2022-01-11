using System.Collections.Generic;
using System.Linq;
using System;
//C043:使用回数の調査

namespace paiza_C
{
    public class C043
    {
		//フィールド
		private static List<int> Access;

		internal static void main()
		{
			//入力
			int N = int.Parse(Console.ReadLine());
			string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
			int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
			Access = new List<int>(intArray);
			Access.Sort();  //このタイミングで昇順に並べておく

			//重複しているやつを削って、要素を並べる
			int[] classification = Access.Distinct().ToArray();
			var clas = new Dictionary<int, int>();
			int len = classification.Length;
			for (int i = 0; i < len; i++)
			{
				int a = classification[i];
				clas.Add(a, Access.Count(n => n == a));
			}

			//並べ替え
			IOrderedEnumerable<KeyValuePair<int,int>> abc =clas.OrderByDescending(p => p.Value);
			int maxValue = clas.Values.Max();
			int Count = clas.Values.Count(n => n == maxValue);
			int count = 0;

			//出力
			foreach (KeyValuePair<int,int> v in abc)
			{
				if (v.Value == maxValue && count != Count - 1)
				{
					count++;
					Console.Write("{0} ", v.Key);
				}
				else if (v.Value == maxValue && count == Count - 1)
				{
					count++;
					Console.Write("{0}", v.Key);
				}
			}
			Console.WriteLine();
		}
	}
}

//受験結果 受験言語： C# 解答時間： 41分18秒 バイト数： 1242 Byte スコア： 74点  220111  正解率１００　　途中トイレ退席あり...w
//問題集計 受験者数： 12,511人 正解率： 19.43％ 平均解答時間： 26分13秒 平均スコア： 30.02点 
//難易度： 2019 ±6

//N
//a_1 a_2 ... a_N
//・1 行目に、公開されている課金アイテムが使用された回数を表す整数 N が与えられます。
//・2 行目に、N 個の整数が半角スペース区切りで与えられます。i 列目 (1 ≦ i ≦ N) の整数 a_i は、i 番目に課金アイテムを使用したプレイヤー ID を表します。
//・入力は合計 2 行であり、最終行の末尾に改行が 1 つ入ります。