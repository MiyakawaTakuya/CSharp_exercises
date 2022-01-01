using System;
using System.Collections.Generic;
using System.Linq;
//C064:paizaでお食事

namespace paiza_C
{
    public class C064
    {
		//フィールド
		private static int M,N;

		internal static void main()
		{
			string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
			int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
			M = intArray[0];
			N = intArray[1];
			int[] calories = new int[M];
			//入力 食品の種類
			for (int i = 0; i < M; i++)
			{
				calories[i] = int.Parse(Console.ReadLine());
			}
			//入力&出力 生徒の摂取したg
			for (int i = 0; i < N; i++)
			{
				string[] strArray2 = Console.ReadLine().Trim().Split(' ');  //読み取り
				int[] intArray2 = strArray2.Select(int.Parse).ToArray();  //intへ変換
				Console.WriteLine(caloriesSum(calories, intArray2)); 
			}
		}

		internal static double caloriesSum(int[] cal ,int[] eat)
		{
			double sum = 0;  //リセットの意味も込めてここで0で初期化
			for (int i = 0; i < M; i++)
			{
				sum += Math.Floor((double)cal[i] * eat[i] / 100); //切り捨てして足す
			}
			return sum;
		}
	}
}

//受験結果 受験言語： C# 解答時間： 28分56秒 バイト数： 928 Byte スコア： 89点  正答率100%

//M N  
//c_1  
//c_2  
//...  
//c_M
//a_{1,1} a_
//{ 1,2}
//... a_
//{ 1,M}
//a_
//{ 2,1}
//a_
//{ 2,2}
//... a_
//{ 2,M}
//...  
//a_
//{ N,1}
//a_
//{ N,2}
//... a_
//{ N,M}
//・1 行目にそれぞれ料理の品数、就活生の人数を表す整数 M, N がこの順で半角スペース区切りで与えられます。
//・続く M 行のうちの i 行目 (1 ≦ i ≦ M) には、100 g あたりのカロリーを表す整数 c_i がこの順で半角スペース区切りで与えられます。
//・さらに続く N 行のうちの i 行目 (1 ≦ i ≦ N) には M 個の整数が半角スペース区切りで与えられます。i 行目の j 番目 (1 ≦ j ≦ M) の整数 a_ { i, j }
//は i 番目の就活生が食べた、j 番目の料理の量を表します。
//・入力は合計で M + N + 1 行となり、入力値最終行の末尾に改行が 1 つ入ります。