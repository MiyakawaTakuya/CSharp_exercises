using System.Collections.Generic;
using System.Linq;
using System;
//B013:最遅出社時刻


namespace paiza_C
{
    public class B013
    {
		//フィールド
		private static int a,b,c,N;
		private static List<DateTime> timetable = new List<DateTime>();
		private static DateTime limit = new DateTime(2022, 2, 5, 8, 59, 0);
		private static DateTime boardTime;  //乗車時刻

		internal static void main()
		{
			//入力
			string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
			int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
			a = intArray[0];
			b = intArray[1];
			c = intArray[2];
			N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                string[] strArray2 = Console.ReadLine().Trim().Split(' ');  //読み取り
                int[] intArray2 = strArray2.Select(int.Parse).ToArray();  //intへ変換
                DateTime dep = new DateTime(2022, 2, 5, intArray2[0], intArray2[1], 0);
                timetable.Add(dep);
            }

			//8:59分までに到着できる乗車時刻を算出する
			DateTime X = selectBoradTime();

			//出力 a分ひいて出発時刻を算出
			Console.WriteLine(X.AddMinutes(-a).ToString("HH:mm"));
		}

		internal static DateTime selectBoradTime()
		{
			boardTime = limit.AddMinutes(-c-b);
			//timetableの中から、8:59-c-b >= X を満たす 最遅の時刻を算出する
			for (int i = timetable.Count-1 ; i >= 0 ; i--)
			{
                if (boardTime >= timetable[i])
                {
					boardTime = timetable[i];
					break;
                }
			}
			return boardTime;
        }
	}
}

//受験結果 受験言語： C# 解答時間： 57分15秒 バイト数： 1451 Byte スコア： 90点  220205  正答率100%
//あなたの会社では 8:59 までに出社すれば遅刻扱いにはなりません。

//a b c　　#配座駅へまで時間 a 分, 配座駅から儀野駅の乗車時間 b 分, 儀野駅から会社までの時間 c 分
//N　　　　#配座駅から出る電車の本数を表す整数 N
//h_1 m_1　#1本目の電車の発車時刻 h_1 時 m_1 分
//h_2 m_2　#2本目の電車の発車時刻 h_2 時 m_2 分
//...
//h_N m_N　#N本目の電車の発車時刻 h_N 時 m_N 分
//1 行目には 3 つの整数 a, b, c が入力されます。これらは通勤ルートの各ステップにかかる時間（単位は分）を表します。

//2 行目には配座駅から出る電車の本数を表す整数 N が入力されます。
//続く N 行は各電車の発車時刻を表しています。 すなわち、i = 1, 2, ..., N に対し、h_i 時 m_i 分に配座駅を発車する電車があることを表します。

//自宅を出発する最も遅い時刻を h 時 m 分とするとき
//h, m が 1 桁の数のときは、2 桁になるように先頭を 0 で埋め以下の様な形式で出力してください。
//hh:mm　　　#自宅を出発する最も遅い時間 hh(0埋め二桁) 時 mm(0埋め二桁) 分

