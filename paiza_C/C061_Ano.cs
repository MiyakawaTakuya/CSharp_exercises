// using System.Collections.Generic;
// using System.Linq;
using System;
//C061:繰り上がりのない足し算

//１次元配列でやり直し
//こちらの方がコードはスリム
//Substring()を使いたいがために、場合わけをしていたのが冗長になる原因でした。
//文字列の大きさを予め000で固定してしまって、配列にするとスリムになった。

namespace paiza_C
{
    public class C061_Ano
    {
		//フィールド
		private static string[] A = new string[] { "0", "0", "0" };
		private static string[] B = new string[] { "0", "0", "0" };
		//クラス
		private class Number
		{
			internal Number(string a, string b)  //コンストラクタ
			{
				A = a;
				B = b;
			}
			internal string A { get; set; }
			internal string B { get; set; }
			//当てられた文字列を3桁の配列に組み込む関数
			internal static void dainyu(string a,string[] aa)
			{
				string aaa = ("000" + a);
				int len = aaa.Length;
				aaa = aaa.Substring(len - 3);  //056 みたいな文字列になっている
				for(int i = 0 ;i < 3; i++)
                {
					aa[i] = aaa.Substring(i,1);
                }
			}
			//各位の１文字を受け取って一時的に数値に置き換えて足して、一の位だけをstringで返す関数
			internal static string kakuKurai_cal(int a,int b)
			{
				int sum = a + b;
				if (sum >= 10)
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
			Number.dainyu(number.A, A);  //各くらいごとに分解してフィールドの配列に代入
			Number.dainyu(number.B, B);
			string ichi = Number.kakuKurai_cal(int.Parse(A[2]), int.Parse(B[2]));
			string ju = Number.kakuKurai_cal(int.Parse(A[1]), int.Parse(B[1]));
			string hyaku = Number.kakuKurai_cal(int.Parse(A[0]), int.Parse(B[0]));

			//出力
			if (number.A.Length <= 2 && number.B.Length <= 2)
			{
				Console.WriteLine(ju + ichi);
			}
			else if (number.A.Length <= 1 && number.B.Length <= 1)
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
//受験結果 受験言語： C# 獲得ランク： Cランク スコア： 100点
//フィールドのAとクラスの中のAがごっちゃになってしまっていた。