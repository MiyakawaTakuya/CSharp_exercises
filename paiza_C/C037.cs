// using System.Collections.Generic;
using System.Linq;
using System;
//C037:アニメの日時

namespace paiza_C
{
    public class C037
    {
		internal static void main()
		{
			//入力
			string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
			string[] month_day = strArray[0].Trim().Split('/');
			string month = month_day[0];
			string day_Str = month_day[1];
			string[] hhmmStr = strArray[1].Trim().Split(':');
			string hh_Str = hhmmStr[0];
			string mm_Str = hhmmStr[1];

			int day_int = int.Parse(day_Str);
			int hh_int = int.Parse(hh_Str);

			//出力

			if (hh_int < 24)//そのまま書き出す
            {
				Console.WriteLine(strArray[0]+ " " + strArray[1]);
			}
			else if (hh_int == 24 && int.Parse(mm_Str) > 0)
            {
				day_int += 1; 
				if(day_int < 10)  //day 頭に０がつく二桁表記にする
				{
					Console.WriteLine(month + "/0" + day_int + " " + "00:" + mm_Str);
				}
                else
                {
					Console.WriteLine(month + "/" + day_int + " " + "00:" + mm_Str);
				}	
			}
			else if (hh_int >= 25)
			{
				hh_int = hh_int % 24;
				day_int += hh_int / 24;
				if (day_int < 10  && hh_int !=0)  //day 頭に０がつく二桁表記にする
				{
					Console.WriteLine(month + "/0" + day_int + " " + hh_int + ":" + mm_Str);
				}
				else if (day_int < 10 && hh_int == 0)
				{
					Console.WriteLine(month + "/0" + day_int + " " + "00:" + mm_Str);
				}
				else if (day_int >= 10 && hh_int != 0)
				{
					Console.WriteLine(month + "/" + day_int + " " + hh_int + ":" + mm_Str);
				}
				else if (day_int >= 10 && hh_int == 0)
				{
					Console.WriteLine(month + "/" + day_int + " " + "00:" + mm_Str);
				}
			}
		}
	}
}

//受験結果 受験言語： C# 解答時間： 45分57秒 バイト数： 1871 Byte スコア： 61点  一問間違えている
//非現実的な現象を相手にするためDateTime関数を使えず苦戦...二桁表記に対して何か良いやり方があるのだろうか

//・0 ≦ (入力される日時の時) ≦ 99
//t
//・ここで、t は日時を表す "MM/dd hh:mm" 形式に従った文字列です。MM, dd, hh, mm はそれぞれ月、日、時、分の 0 埋め 2 桁表記を意味します。
//・入力値最終行の末尾に改行が１つ入ります。


