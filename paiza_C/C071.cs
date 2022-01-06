// using System.Collections.Generic;
using System.Linq;
using System;
//C071: 直角三角形

namespace paiza_C
{
    public class C071
    {
		//フィールド
		private static int M,N,count;
		private static double underDeci;

		internal static void main()
		{
			//入力
			string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
			int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
			M = intArray[0];
			N = intArray[1];

			for (int i = 1; i < M; i++)
			{
				for (int j = 1; j < N; j++)
				{
					double root = Math.Sqrt(i * i + j * j);
					underDeci = root % 1;  //小数点以下の値を拾う
					if (underDeci == 0)
                    {
						count++;
                    }
				}
			}

			Console.WriteLine(count);
		}
	}
}

//受験結果 受験言語： C# 解答時間： 19分51秒 バイト数： 639 Byte スコア： 100点  220107

//M N
//・2 つの整数 M, N がこの中に半角スペース区切りで与えられます。
//・入力は 1 行となり、末尾に改行が 1 つ入ります。
//斜辺も整数である直角三角形の個数を整数で出力してください。

//・調べる直角三角形は直角が右下にある。
//・全ての辺は整数である。
//・ある与えられた二つの整数 M, N が与えられ、M より長さが小さい底辺、N より長さが小さい高さをもつ。