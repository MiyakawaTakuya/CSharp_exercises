// using System.Collections.Generic;
using System.Linq;
using System;
//B019:グレースケール画像の縮小


namespace paiza_C
{
    public class B019
    {
		private static int N,K, sellBol;
		private static int[,] reducedArr;

		internal static void main()
		{
			string[] strArray = Console.ReadLine().Trim().Split(' ');
			int[] intArray = strArray.Select(int.Parse).ToArray();
			N = intArray[0];
			K = intArray[1];
			reducedArr = new int[N/K,N/K];
			sellBol = N * N / ((N / K) * (N / K));
			for (int i = 0; i < N; i++)
			{
				string[] strArray2 = Console.ReadLine().Trim().Split(' ');
				int[] intArray2 = strArray2.Select(int.Parse).ToArray();
				addToArr(intArray2,i);
			}
			output2D(reducedArr);
		}

		//分割した後の各セルの個数ごとに拾って、reducedArrに+していく
		internal static void addToArr(int[] intArr,int i_y)
		{
            for (int j = 0 ;j < N ; j++)
            {
				int indexX = j/K;
				int indexY =  i_y/K;
				reducedArr[indexY, indexX] += intArr[j];
			}
		}

		//出力
		internal static void output2D(int[,] Arr)
		{
			//各セルの要素数sellBol
			for (int i = 0; i < N/K; i++)
			{
				for (int p = 0; p < N/K; p++)
				{
					if (p != N / K - 1) Console.Write(Arr[i, p]/ sellBol + " ");
					else Console.Write(Arr[i, p] / sellBol);
				}
				Console.WriteLine("");  //改行
			}
		}
	}
}

//受験結果 受験言語： C# 解答時間： 46分33秒 バイト数： 1185 Byte スコア： 96点  220312

//あなたの手元には N × N ピクセルのグレースケール画像があります。 各ピクセルの画素値は 0 から 255 までの整数で指定されています。
//あなたは上司から、この画像を縦横それぞれ K 分の 1 (K は N の約数) の大きさに縮小してほしいと頼まれました。 縮小の手順を正確に述べると、次のようになります。
//1.元の画像を K × K ピクセルのブロックに区切る。その結果、N/K × N/K 個のブロックができる。(図左)
//2.各ブロックに対して、ブロックに含まれるピクセルの画素値の平均値(小数点以下切り捨て) を計算する。(図中央)
//3.各ブロックを新しい一つのピクセルと見なし、N / K × N / K ピクセルの画像を作る。
//　ここで、新しいピクセルの画素値は 2.で計算した平均値とする。(図右)