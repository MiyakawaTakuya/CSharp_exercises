// using System.Collections.Generic;
using System.Linq;
//C100:選曲の方法

using System;
namespace paiza_C
{
    public class C100
    {
		//フィールド
		private static int N,M,S,count,amoutSec;

		internal static void main()
		{
			//入力
			string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
			int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
			N = intArray[0];
			M = intArray[1];
			S = intArray[2];
			amoutSec = M * 60 + S;
			int[] dtArray = new int[N];

			for (int i = 0; i < N; i++)
			{
				string[] strArray2 = Console.ReadLine().Trim().Split(' ');  //読み取り
				int[] intArray2 = strArray2.Select(int.Parse).ToArray();  //intへ変換
				dtArray[i] = intArray2[0]*60 + intArray2[1];  //秒に変換して格納していく
			}
			Array.Sort(dtArray); //小さいものから順に並び替え

			for (int j = 0; j < N; j++)
			{
				if(amoutSec - dtArray[j] >= 0)
                {
					count++;
					amoutSec -= dtArray[j];
				}
			}
			Console.WriteLine(count);
		}

		//ランタイムエラーでアウトだったやつ
		//internal static void main2()
		//{
		//	//入力
		//	string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
		//	int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
		//	N = intArray[0];
		//	M = intArray[1];
		//	S = intArray[2];
		//	//標準時を宣言
		//	DateTime amountTime = new DateTime(2022, 1, 8, 0, M, S);  //日程はいつでも大丈夫

		//	DateTime[] dtArray = new DateTime[N];

		//	for (int i = 0; i < N; i++)
		//	{
		//		string[] strArray2 = Console.ReadLine().Trim().Split(' ');  //読み取り
		//		int[] intArray2 = strArray2.Select(int.Parse).ToArray();  //intへ変換
		//		DateTime a = new DateTime(2022, 1, 8, 0, intArray2[0], intArray2[1]);
		//		dtArray[i] = a;
		//	}
		//	Array.Sort(dtArray); //小さいものから順に並び替え

		//	DateTime zeroTime = new DateTime(2022, 1, 8, 0, 0, 0);
		//	for (int j = 0; j < N; j++)
		//	{
		//		int min = (amountTime - dtArray[j]).Minutes;
		//		int sec = (amountTime - dtArray[j]).Seconds + min * 60;
		//		if (sec >= 0)
		//		{
		//			count++;
		//			amountTime = amountTime.AddMinutes(-dtArray[j].Minute);
		//			amountTime = amountTime.AddSeconds(-dtArray[j].Second);
		//		}
		//		else break;
		//	}
		//	Console.WriteLine(count);
		//}
	}
}

//受験結果 受験言語： C# 解答時間： 59分13秒 バイト数： 1189 Byte スコア： 20点  ８割以上ランタイムエラー 例題は正解してる
//DateTimeだとfor文で回すには情報量多すぎると考えた

//受験結果 受験言語： C# 獲得ランク： Cランク スコア： 100点 DateTime使わずやり直しでいけた

//N M S
//x_1 y_1
//x_2 y_2
//...
//x_N y_N
//・1 行目には、それぞれ流したい曲数を表す整数 N、持ち時間を表す整数 M, S がこの順で半角スペース区切りで与えられます。これは、持ち時間が M 分 S 秒であることを示します。
//・続く N 行のうちの i 行目 (1 ≦ i ≦ N) には、それぞれ i 番目の流したい曲の時間を表す整数 x_i, y_i がこの順で半角スペース区切りで与えられます。これは x_i 分 y_i 秒を示します。
//・入力は合計で N + 1 行となり、入力値最終行の末尾に改行が 1 つ入ります。