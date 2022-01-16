using System.Collections.Generic;
using System.Linq;
using System;
using System.Globalization;

namespace paiza_C
{
    public class Datetime
    {
		//フィールド
		private static int y,m,d;

		//クラス
		private class Medal
		{
			internal Medal(int a)  //コンストラクタ
			{
				A = a;
			}
			internal int A { get; set; }
			internal static void Do()
			{

			}
		}

		internal static void main()
		{
			//入力
			int N = int.Parse(Console.ReadLine());
			string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
			int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
			for (int i = 0; i < N; i++)
			{
			}

			//出力
			Console.WriteLine();
		}

		internal static void LeapYear()
		{
			int N = int.Parse(Console.ReadLine());
			if (DateTime.IsLeapYear(N))
            {
				Console.WriteLine("Yes");
			}
			else
            {
				Console.WriteLine("No");
			}
            ////今年が閏年かどうかを確かめる
            //if (DateTime.IsLeapYear(DateTime.Now.Year))
            //{
            //}
        }

		internal static void Wareki()
		{
			string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
			int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
			y = intArray[0];
			m = intArray[1];
			d = intArray[2];

			CultureInfo culture = new CultureInfo("ja-JP", true);
			culture.DateTimeFormat.Calendar = new JapaneseCalendar();
			var then = new DateTime(y, m, d);
			string result = then.ToString("ggyy年M月d日", culture);  //令和5年５月1日
			//string result = then.ToString("gg年M月d日", culture);  //令和年５月1日
			Console.WriteLine(result);
			//書式指定内の「gg」は元号名「yy」は年
			//https://atmarkit.itmedia.co.jp/ait/articles/0306/06/news004.html

		}

		internal static void eto()
		{
			string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
			int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
			y = intArray[0];
			m = intArray[1];
			d = intArray[2];
			//干支をとる
			var now = new DateTime(y, m, d);
			JapaneseLunisolarCalendar a = new JapaneseLunisolarCalendar();
			//六十干支を取得する
			int sexagenaryYear = a.GetSexagenaryYear(now);
			//十二支を取得する
			int eto = a.GetTerrestrialBranch(sexagenaryYear);
		}
		//https://dobon.net/vb/dotnet/system/geteto.html




	}
}
