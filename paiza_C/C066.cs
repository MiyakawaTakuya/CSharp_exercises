// using System.Collections.Generic;
using System.Linq;
using System;
//C066:金魚すくい
namespace paiza_C
{
    public class C066
    {
		//フィールド
		private static int M,N,x,count;
		private static int[] kingyoArray;

		internal static void main()
		{
			//入力
			string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
			int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
			M = intArray[0]; //金魚の数
			N = intArray[1]; //ポイの数
			x = intArray[2]; //耐久
			kingyoArray = new int[M];
			for (int i = 0; i < M; i++)
			{
				kingyoArray[i] = int.Parse(Console.ReadLine());
			}
			//集計
			catchKingyo();
			//出力
			Console.WriteLine(count);
		}

		internal static void catchKingyo()
		{
			int X = x;
			for (int i = 0; i < M; i++)
			{
				int g = kingyoArray[i];
				if (N == 0) break;
				if(x-g > 0)  //耐えられたら
                {
					count++;
					x -= g;
                }
				else if (x - g <= 0)
                {
					x = X;
					N--;
					i--;  //クリアできなかったらポイを取り替えてもう一度チャレンジ
                }
			}
		}

		//internal static void main2()
		//{
		//	//入力
		//	string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
		//	int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
		//	M = intArray[0]; //金魚の数
		//	N = intArray[1]; //ポイの数
		//	x = intArray[2]; //耐久
		//					 //集計
		//	catchKingyo();
		//	//出力
		//	Console.WriteLine(count);
		//}

		//internal static void catchKingyo()
		//{
		//	int X = x;
		//	for (int i = 0; i < M; i++)
		//	{
		//		int g = int.Parse(Console.ReadLine());
		//		if (N == 0) break;
		//		if (x - g > 0)  //耐えられたら
		//		{
		//			count++;
		//			x -= g;
		//		}
		//		else if (x - g <= 0)
		//		{
		//			x = X;
		//			N--;
		//		}
		//	}
		//}
	}
}

//受験結果 受験言語： C# 解答時間： 25分55秒 バイト数： 944 Byte スコア： 100点  220109

//M N x
//w_1
//w_2
//...
//w_M
//・1 行目に金魚の数を表す整数 M、ポイの数を表す整数 N、ポイの耐久値を表す整数 x がこの順に半角スペース区切りで与えられます。
//・続く M 行のうちの i 行目 (1 ≦ i ≦ M) には金魚の重量を表す整数 w_i が与えられます。
//・入力は合計で M + 1 行となり、入力値最終行の末尾に改行が 1 つ入ります。
