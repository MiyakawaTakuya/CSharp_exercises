// using System.Collections.Generic;
using System.Linq;
using System;
//C061:繰り上がりのない足し算

namespace paiza_C
{
    public class C061
    {
		//フィールド
		private static int Akurai_1, Akurai_10, Akurai_100, Bkurai_1, Bkurai_10, Bkurai_100;
		//クラス
		private class Number
		{
			internal Number(string a,string b)  //コンストラクタ
			{
				A = a;
				B = b;
			}
			internal string A { get; set; }
			internal string B { get; set; }
			//それぞれの文字列が何桁かを把握する
			//各桁の文字列を１文字ずつ足して行って計算した結果の文字列をえる
			//最後にがっちゃんする
			internal static void Calculate(Number num)
			{
				int a_Length = num.A.Length;
				int b_Length = num.B.Length;
                if (a_Length ==1)
                {
					Akurai_1 = int.Parse(num.A);
				}
				else if (a_Length == 2)
				{
					Akurai_1 = int.Parse(num.A.Substring(1, 1));
					Akurai_10 = int.Parse(num.A.Substring(0, 1));
				}
				else if (a_Length == 3)
				{
					Akurai_1 = int.Parse(num.A.Substring(2, 1));
					Akurai_10 = int.Parse(num.A.Substring(1, 1));
					Akurai_100 = int.Parse(num.A.Substring(0, 1));
				}

				if (b_Length == 1)
				{
					Bkurai_1 = int.Parse(num.B);
				}
				else if (b_Length == 2)
				{
					Bkurai_1 = int.Parse(num.B.Substring(1, 1));
					Bkurai_10 = int.Parse(num.B.Substring(0, 1));
				}
				else if (b_Length == 3)
				{
					Bkurai_1 = int.Parse(num.B.Substring(2, 1));
					Bkurai_10 = int.Parse(num.B.Substring(1, 1));
					Bkurai_100 = int.Parse(num.B.Substring(0, 1));
				}
			}
			//各位の１文字を受け取って一時的に数値に置き換えて足して、一の位だけをstringで返す関数
			internal static string kakuKurai_cal(int a,int b)
			{
				int sum = a + b;
				if(sum >= 10)
                {
					return sum.ToString().Substring(1, 1);  //一の位だけ返す
				}
				else
                {
					return sum.ToString();  //足しても一桁だったらそのまま返す
                }
			}

		}

		internal static void main()
		{
			//入力
			string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
			Number number = new Number(strArray[0], strArray[1]);
			//計算
			Number.Calculate(number);  //角くらいごとに分解してフィールドの変数に代入
			string ichi = Number.kakuKurai_cal(Akurai_1, Bkurai_1);
			string ju = Number.kakuKurai_cal(Akurai_10, Bkurai_10);
			string hyaku = Number.kakuKurai_cal(Akurai_100, Bkurai_100);

			//出力
			if(Akurai_100 == 0 && Bkurai_100 == 0 && (Akurai_10 !=0 || Bkurai_10 != 0))
			{
				Console.WriteLine(ju + ichi);
			}
			else if (Akurai_100 == 0 && Bkurai_100 == 0 && Akurai_10 == 0 && Bkurai_10 == 0)
			{
				Console.WriteLine(ichi);
			}
			else
            {
				Console.WriteLine(hyaku + ju + ichi);
			}

		}
	}
}

//受験結果 受験言語： C# 解答時間： 58分36秒 バイト数： 2422 Byte スコア： 48点  220111 正答率９割　１問間違え
//受験結果 受験言語： C# 獲得ランク： Cランク スコア： 100点  出力の時の条件式を少しミスってた
