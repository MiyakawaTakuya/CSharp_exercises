 using System.Collections.Generic;
 using System.Linq;
using System;
//C035 試験の合否判定

namespace paiza_C
{
    public class C035
    {
		private static int countQualified;

		internal static void main()
		{
			int N = int.Parse(Console.ReadLine());
			for (int i = 0; i < N; i++)
			{
				string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
				List<string> results_5 = new List<string>(strArray); //リストに変換
				judge_ls_350(results_5);
			}
			Console.WriteLine(countQualified);
		}

		//lかsを判定して文理判定　そのあとすぐに合計350点以上かをジャッジする関数
		internal static void judge_ls_350(List<string> list)
		{
            if (list[0] == "l")
            {
				list.Remove("l");
				List<int> intCard = list.ConvertAll(int.Parse);
				if (intCard.Sum() >= 350) judge_l(intCard);
			}
			else if (list[0] == "s")
			{
				list.Remove("s");
				List<int> intCard = list.ConvertAll(int.Parse);
				if (intCard.Sum() >= 350) judge_s(intCard);
			}

		}

		//理系, 文系ごとに点数をジャッジする関数
		internal static void judge_l(List<int> l)
		{
			if (l[3]+ l[4] >= 160) countQualified++;
		}
		internal static void judge_s(List<int> s)
		{
			if (s[1] + s[2] >= 160) countQualified++;
		}

	}
}

//受験結果 受験言語： C# 解答時間： 25分0秒 バイト数： 1129 Byte スコア： 94点  220102

//入力は以下のフォーマットで与えられます。
//N
//t_1 e_1 m_1 s_1 j_1 g_1 
//t_2 e_2 m_2 s_2 j_2 g_2
//...
//t_N e_N m_N s_N j_N g_N
//・1 行目には受験者の人数を表す整数 N が与えられます。
//・続く N 行のうち i 行目 (1 ≦ i ≦ N) には受験者の文理の区分を表す文字 t_i と、英語、数学、理科、国語、地理歴史の点数を表す整数 e_i, m_i, s_i, j_i, g_i がこの順に半角スペース区切りで与えられます。
//・t_i について文系は "l" ("L" の小文字)、理系は "s" で表されます。
//・入力は合計で N + 1 行となり、入力値最終行の末尾に改行が１つ入ります。
