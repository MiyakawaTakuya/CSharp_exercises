using System.Collections.Generic;
using System.Linq;
using System;
//B009:カンファレンスのタイムテーブル作成

namespace paiza_C
{
    public class B009
    {
		//フィールド
		private static int lunchDone;
		private static List<Presenter> table_elm = new List<Presenter>();
		private static DateTime StartPoint =new DateTime(2022, 1, 17, 10, 0, 0);
		private static DateTime LunchPoint = new DateTime(2022, 1, 17, 12, 1, 0);

		//クラス
		private class Presenter
		{
			internal Presenter(string name,int min)  //コンストラクタ
			{
				Name = name;
				Min = min;
				Start = StartPoint;
				End = StartPoint.AddMinutes((double)Min);
			}

			internal string Name { get; set; }
			internal int Min { get; set; }
			internal DateTime Start { get; set; }
			internal DateTime End { get; set; }

			//10時から順番に予定を埋めていく
			//start時刻を与えられて、終了時刻を算出していく
			//途中昼休憩を挟むべきところで予定を入れてしまわないように例外処理をする

			internal static void makeSchedule(Presenter a,int No_)
			{
				a.Start = StartPoint;
				//ラストの登壇者で次がいない場合、次の人も発表したら12:01以降になる場合、ならない場合
				if (No_ + 1 == table_elm.Count)
                {
					StartPoint = StartPoint.AddMinutes((double)a.Min + 10);
					a.End = a.Start.AddMinutes((double)a.Min);
				}
				else if (a.Start.AddMinutes((double)a.Min + 10 + table_elm[No_ + 1].Min) >= LunchPoint && lunchDone == 0)
                {
					StartPoint =StartPoint.AddMinutes((double)a.Min + 60);
					a.End = a.Start.AddMinutes((double)a.Min);
					lunchDone = 1;
				}
				else
                {
					StartPoint = StartPoint.AddMinutes((double)a.Min + 10);
					a.End = a.Start.AddMinutes((double)a.Min);
				}
				
			}
		}

		internal static void main()
		{
			//入力
			int N = int.Parse(Console.ReadLine());
			for (int i = 0; i < N; i++)
			{
				string[] strArray = Console.ReadLine().Trim().Split(' ');
				table_elm.Add(new Presenter(strArray[0], int.Parse(strArray[1])));
			}
			for (int i = 0; i < N; i++)
			{
				Presenter.makeSchedule(table_elm[i], i);
			}
			//出力			
			foreach (Presenter one in table_elm)
			{
				Console.WriteLine("{0} - {1} {2}", one.Start.ToString("HH:mm"), one.End.ToString("HH:mm"), one.Name);
			}
		}

	}
}

//受験結果 受験言語： C# 解答時間： 84分2秒 バイト数： 2199 Byte スコア： 73点  220117  正答率は100%
//フィールドのStartPointの時刻を書き換えらておらず、少し時間取られた。
//どのタイミングでどの時刻をどういじるべきか、を考えてて頭の中ごっちゃになった。

//1. 10:00に1人目のトークを始めます。
//2.現在のトークが終了し10分休憩の後、次のトークを始めます。
//3.すべての発表者のトークが終了するまで2.を繰り返します。
//	発表予定者のトーク終了予定時刻（現在の発表者の終了時刻 + 10分休憩 + 次の発表者の持ち時間）が12: 01 以降になる場合においては、
//	現在のトークが終了後、10分休憩の代わりに1時間のお昼休憩を一度だけとります。

//１行目は発表者数が入力されます。
//２行目からN + 1行目まで各発表者の名前と発表時間がスペースで区切で入力されます。
//N(発表者数)
//s_1(一人目の発表者名) a_1(一人目の発表時間)
//s_2(二人目の発表者名) a_2(二人目の発表時間)...
//s_N(N人目の発表者名) a_N(N人目の発表時間)
//1 ≦ a_i(発表時間) ≦ 60
