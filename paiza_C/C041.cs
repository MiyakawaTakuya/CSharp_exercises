using System.Collections.Generic;
using System.Linq;
using System;
//C041: メダルランキングの作成
//二次元配列でチャレンジした....けど入りが違う気がしたのでやり直し

namespace paiza_C
{
	public class C041
	{
		//フィールド
		private static int N;
		private static int[,] results;
		private static int[,] ranking;
		//各賞をそのまま格納する用
		private static List<int> Gold = new List<int>();
		private static List<int> Silver = new List<int>();
		private static List<int> Bronze = new List<int>();
		//各賞を高順に格納する用
		private static List<int> Gold_CtoA = new List<int>();

		internal static void main()
		{
			//入力
			N = int.Parse(Console.ReadLine());
			results = new int[N, 3];
			for (int i = 0; i < N; i++)
			{
				string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
				int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
				results[i, 0] = intArray[0];  //金
				results[i, 1] = intArray[1];  //銀
				results[i, 2] = intArray[2];  //銅
			}
			ranking = new int[N, 3];

			//各賞ごとに降順の配列を算出する
			GoldToList(Gold, 0);
			//値が重複していないかチェック
			//重複してなかったら,そのまま銀の値のチェックに入る
			int[] rank_Gold = Gold.Distinct().ToArray();
			if (rank_Gold.Length == Gold.Count) //重複していない場合
			{
				GoldToSilver();
			}
			else  //金で重複しているところで銀の値を比べて入れていく
			{

			}
			//出力
			Console.WriteLine();
		}

		//各賞のListを作成する → 金メダルだけ先に格納する
		internal static void GoldToList(List<int> medal, int whitch)
		{
			for (int i = 0; i < N; i++)
			{
				medal.Add(results[i, whitch]);
			}
			//降順に並び替えて格納していく
			foreach (int val in medal.OrderByDescending(val => val))
			{
				Gold_CtoA.Add(val);
			}
			//金の順位をランキングに入れていく
			for (int i = 0; i < N; i++)
			{
				ranking[i, whitch] = Gold_CtoA[i];
			}
		}
		//
		internal static void GoldToSilver()
		{
			for (int j = 0; j < N; j++)
			{
				ranking[j, 1] = results[Gold.IndexOf(ranking[j, 0]),1]; 
			}
		}

		//重複しているところだけをListにして吐き出す関数
		internal static List<int> FindDuplication(List<int> list)
		{
			// 要素名でGroupByした後、グループ内の件数が2以上（※重複あり）に絞り込み、
			// 最後にIGrouping.Keyからグループ化に使ったキーを抽出している。
			var duplicates = list.GroupBy(name => name).Where(name => name.Count() > 1)
				.Select(group => group.Key).ToList();
			return duplicates;
		}

		//金が重複しているところで銀の数を比較する関数

	}
}

//N
//g_1 s_1 b_1
//g_2 s_2 b_2
//...
//g_N s_N b_N
//・1 行目にはランキング対象となる国の総数を表す整数 N が与えられます。
//・続く N 行のうち i 行目 (1 ≦ i ≦ N) には i 番目の国の金メダル、銀メダル、銅メダルの獲得数をそれぞれ表す整数 g_i, s_i, b_i がこの順に半角スペース区切りで与えられます。
//・入力は合計で N + 1 行であり、入力最終行の末尾に改行が１つ入ります。

//List中の重複する要素を抽出する方法
//public static List<string> FindDuplication(List<string> list)
//{
//	// 要素名でGroupByした後、グループ内の件数が2以上（※重複あり）に絞り込み、
//	// 最後にIGrouping.Keyからグループ化に使ったキーを抽出している。
//	var duplicates = list.GroupBy(name => name).Where(name => name.Count() > 1)
//		.Select(group => group.Key).ToList();

//	return duplicates;
//}