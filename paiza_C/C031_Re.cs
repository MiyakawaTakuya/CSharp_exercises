 using System.Collections.Generic;
 using System.Linq;
using System;
namespace paiza_C
{
    public class C031_Re
    {
		//フィールド
		private static int n;
		private static Dictionary<string, int> city = new Dictionary<string, int>();

		internal static void main()
		{
			//入力
			int N = int.Parse(Console.ReadLine());
			for (int i = 0; i < N; i++)
			{
				string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
				city.Add(strArray[0], int.Parse(strArray[1]));
			}
			string[] baseCity = Console.ReadLine().Trim().Split(' ');  //基準都市+時刻
			string[] baseCity_time = baseCity[1].Trim().Split(':');  //時刻について　[0]にh, [1]にmin
			int baseHour = int.Parse(baseCity_time[0]);
			int baseMin = int.Parse(baseCity_time[1]);
			//int deltaBase = baseHour - city[baseCity[0]];
			int BaseHour = city[baseCity[0]];
			//標準時を宣言
			DateTime baseTime = new DateTime(2022, 1, 7, baseHour, baseMin, 0);

			//出力
			//forで回して各都市の時間を足し引きして書き出す
			foreach (KeyValuePair<string, int> HH in city)
			{
				Console.WriteLine(baseTime.AddHours(HH.Value - BaseHour).ToString("HH:mm"));
			}
		}
	}
}
//受験結果 受験言語： C# 獲得ランク： Cランク スコア： 100点  220107
