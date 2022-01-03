using System.Collections.Generic;
using System.Linq;
using System;
//C036: 犬ぞりトーナメント

namespace paiza_C
{
    public class C036
    {
		//フィールド
		private static int n;

		internal static void main()
		{
			//入力
			string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
			int[] member_1 = strArray.Select(int.Parse).ToArray();  //intへ変換
			string[] strArray2 = Console.ReadLine().Trim().Split(' ');  //読み取り
			int[] member_2 = strArray2.Select(int.Parse).ToArray();  //intへ変換
			//それぞれのタイムをDictionaryで記録
			string[] strArray3 = Console.ReadLine().Trim().Split(' ');  
			int[] first = strArray3.Select(int.Parse).ToArray();  
			var firstResult = new Dictionary<int, int>()
			{{1,first[0]}, {2,first[1]},{3,first[2]},{4,first[3]}};

			//レースの勝者を算出する関数を使って配列に組み込む
			int[] secondMember = new int[] {race(member_1,firstResult),race(member_2, firstResult)};
			Array.Sort(secondMember); //数が小さ順に並び替え

			//それぞれのタイムをDictionaryで記録
			string[] strArray4 = Console.ReadLine().Trim().Split(' ');  //読み取り
			int[] second = strArray4.Select(int.Parse).ToArray();  //intへ変換
			var secondResult = new Dictionary<int, int>()
			{{secondMember[0],second[0]}, {secondMember[1],second[1]}};
			Console.WriteLine();
		}

		internal static int race(int[] member, Dictionary<int, int> dic)
		{
			int time = Math.Min(dic[member[0]], dic[member[1]]);
			return dic.FirstOrDefault(x => x.Value.Equals(time)).Key;
		}
	}
}

//入力は以下のフォーマットで与えられます。
//p_1 p_2
//p_3 p_4
//e_1 e_2 e_3 e_4
//f_1 f_2
//・1 行目に参加者のエントリーナンバーを表す整数 p_1, p_2 が、2 行目に同様の整数 p_3, p_4 が半角スペース区切りで与えられます。このとき 1 回戦の組み分けが p_1 vs p_2, p_3 vs p_4 となります。
//・次の行には各参加者の 1 回戦のタイムを表す 4 つの整数がエントリーナンバーの小さい順に半角スペース区切りで与えられます。これらの整数を e_1, e_2, e_3, e_4 で表します。
//・次の行には 2 回戦進出者の 2 回戦のタイムを表す 2 つの整数がエントリーナンバーの小さい順に半角スペース区切りで与えられます。これらの整数を f_1, f_2 で表します。
//・入力は合計で 4 行となり、入力値最終行の末尾に改行が１つ入ります。
