using System.Collections.Generic;
using System.Linq;
using System;
using System.Globalization;

namespace paiza_C.Questions
{
	public class Datetime
	{
		//フィールド
		private static int y, m, d;

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

		//西暦から和暦を算出する
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
			string result_gannnen = then.ToString("ggyy'年'M月d日", culture);  //令和元年５月1日
																			//string result = then.ToString("gg年M月d日", culture);  //令和年５月1日
			Console.WriteLine(result);
			//書式指定内の「gg」は元号名「yy」は年
			//https://atmarkit.itmedia.co.jp/ait/articles/0306/06/news004.html
		}

		//干支を算出する
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
			//https://dobon.net/vb/dotnet/system/geteto.html
		}

		//その月の日数を取得
		internal static void lastDay()
		{
			string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
			int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
			y = intArray[0];
			m = intArray[1];
			var theDay = new DateTime(y, m, 1);
			//int days = DateTime.DaysInMonth(theDay.Year, theDay.Month); // その月の日数
			int days = DateTime.DaysInMonth(y, m); // その月の日数
			Console.WriteLine(days);
			// DateTime構造体の場合
			//var lastDayOfMonth1 = new DateTime(theDay.Year, theDay.Month, days);
			//Console.WriteLine("{0}年{1}月の最後の日は {2}",
			//				  theDay.Year, theDay.Month, lastDayOfMonth1.ToString());
			// 出力結果：
			// 2016年2月の最後の日は 2016/02/29 0:00:00

			// DateTimeOffset構造体の場合
			//var lastDayOfMonth2 = new DateTimeOffset(theDay.Year, theDay.Month, days,
			//										 0, 0, 0, TimeSpan.FromHours(9.0));
			//Console.WriteLine("{0}年{1}月の最後の日は {2}",
			//				  theDay.Year, theDay.Month, lastDayOfMonth2.ToString());
			//https://atmarkit.itmedia.co.jp/ait/articles/1505/27/news018.html
		}

		//次の日を算出する
		internal static void nextDay()
		{
			string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
			int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
			y = intArray[0];
			m = intArray[1];
			d = intArray[2];

			//var theDay = new DateTime(y, m, d + 1 );  //2019 2 28に対してエラーが出てしまうのでNG
			var theDay = new DateTime(y, m, d);
			var nextDay = theDay.AddDays(1);
			Console.WriteLine("{0} {1} {2}", nextDay.Year, nextDay.Month, nextDay.Day);
			//https://itsakura.com/csharp-datecalc
		}

		//その日の曜日を算出する
		internal static void dayOfWeek()
		{
			string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
			int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
			y = intArray[0];
			m = intArray[1];
			d = intArray[2];
			var theDay = new DateTime(y, m, d);
			// DateTime構造体のToStringメソッドを使う
			string 長い曜日 = theDay.ToString("dddd");
			string 短い曜日 = theDay.ToString("ddd");
			Console.WriteLine($"長い曜日={長い曜日}、短い曜日={短い曜日}");
			// 出力：長い曜日=木曜日、短い曜日=木

			//日本語表記にするならcultureを引数に渡す
			var culture = CultureInfo.GetCultureInfo("ja-JP");
			// DateTime構造体のToStringメソッドを使う
			string dayOf = theDay.ToString("dddd", culture);
			Console.WriteLine(dayOf);
			//https://atmarkit.itmedia.co.jp/ait/articles/1710/04/news017.html


		}

		//その日の曜日を算出する 1000000000年先も取るためには??　　TODO 精度が出ていない状態。解けていない
		internal static void dayOfWeek_Large()
		{
			//9999999992 2 29
			//Int32 は、負の 2147483648 (定数で表されます) から正の 2147483647 (定数で表される) までの値を持つ符号付き整数を表す
			//100000000000にはどのように対処する？
			//Int64 は、負の 9223372036854775808 (定数で表されます Int64.MinValue ) から正の 9223372036854775807 (定数で表されます) までの値を持つ符号付き整数を表す、変更できない値型です
			//int型ではなくlong型だと-9,223,372,036,854,775,808 から 9,223,372,036,854,775,807
			//1800年1月1日は水曜日です。

			string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
			long Y = long.Parse(strArray[0]);
			int m = int.Parse(strArray[1]);
			int d = int.Parse(strArray[2]);
			//与えられた年数をdaysに変換して1800/1/1水曜日からのみて何番目かを把握して算出

			long largeYearsUnit_Num = Y / (long)2000; //400で割り切れる年は閏年を考慮して400で割れる数で捌いていく
			long largeYearsUnit_Amari = Y % (long)2000;

			//まずは2000000000を区切りに刻んでいく
			var theDay = new DateTime(2001, 1, 1);
			var firstDay = new DateTime(1, 1, 1);
			TimeSpan large_unit = theDay - firstDay;
			long unit_days = large_unit.Days;

			long SumDays = unit_days * largeYearsUnit_Num;   //一旦大きい部分の合計日数を出す

			var amariDay = new DateTime((int)largeYearsUnit_Amari + 1, m, d);
			TimeSpan nokorYears_days = amariDay - firstDay;
			SumDays += nokorYears_days.Days;

			var thatDay = new DateTime(1800, 1, 1);
			TimeSpan until1800 = thatDay - firstDay;
			long until1800_days = until1800.Days;

			SumDays -= until1800_days;  //これが欲しい差分の日数

			//ここまでで日数の計算おしまい。曜日算出のためのあまりを出す。
			long youbi_amari = SumDays % 7 + 2;

			string[] youbi = new string[] { "水曜日", "木曜日", "金曜日", "土曜日", "日曜日", "月曜日", "火曜日" };
			Console.WriteLine(youbi[(int)youbi_amari]);
		}

		//"YYYY/MM/DD"の形式の10文字からなるフォーマットに従っているかどうかを判定する
		internal static bool isDateTimeFormat()
		{
			//文字数チェック
			string S = Console.ReadLine();
			if (S.Length != 10) return false;
			string[] strArray = S.Trim().Split('/');
			string Y = strArray[0];
			string M = strArray[1];
			string D = strArray[2];
			if (Y.Length != 4 || M.Length != 2 || D.Length != 2) return false;
			//全てint型であるかをチェック
			int y, m, d;
			if (!int.TryParse(Y, out y)) return false;
			if (!int.TryParse(M, out m)) return false;
			if (!int.TryParse(D, out d)) return false;
			//数値が規定以内であるかを判定
			if (m <= 0 || m > 12) return false;
			if (d <= 0 || d > 31) return false;
			return true;
		}

		internal static void test()
		{
			Console.WriteLine(int.Parse("01"));  //1 →ok
		}
		//baseTime.AddHours(HH.Value - BaseHour).ToString("HH:mm")
		//DateTime.ToString("HH:mm")で２４時間表記で算出
		//AddHours(int a)で追加


	}
}
