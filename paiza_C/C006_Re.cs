 using System.Collections.Generic;
using System.Linq;
using System;
//C006:ハイスコアランキング

namespace paiza_C
{
    public class C006_Re
    {
		//フィールド
		private static int N,M,K;
		private static double[] ranking;

		internal static void main()
		{
			//入力
			string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
			int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
			N = intArray[0];
			M = intArray[1];
			K = intArray[2];
			ranking = new double[M];
			string[] strArray2 = Console.ReadLine().Trim().Split(' ');
			double[] coefficientArray = strArray2.Select(double.Parse).ToArray(); 
			for (int i = 0; i < M; i++)
			{
				string[] strArray3 = Console.ReadLine().Trim().Split(' ');
				int[] array = strArray3.Select(int.Parse).ToArray();
				calculate(array, coefficientArray,i);
			}
			//出力
			Array.Sort(ranking);
			Array.Reverse(ranking);
			for (int n = 0; n < K; n++)  //１番からK番目までのランキング表示
			{
				Console.WriteLine(ranking[n]);
			}
		}

		internal static void calculate(int[] itemNum, double[] coe,int a)
		{
			double sum = 0;
			for (int j = 0; j < N; j++)
			{
				sum += itemNum[j] * coe[j];
			}
			sum = Math.Round(sum, MidpointRounding.AwayFromZero);
			ranking[a] = sum;
		}
	}
}

//受験結果 受験言語： C# 解答時間： 33分28秒 バイト数： 1191 Byte スコア： 84点 全問正解
//１ヶ月前にちょうど同じ問題を解いていたが１時間以上かかっていてタイムオーバーで０点だった。少し成長