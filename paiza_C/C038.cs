 using System.Collections.Generic;
using System.Linq;
using System;
//C038:お菓子の分配

namespace paiza_C
{
    public class C038
    {
		private static int M,N, package,surplus;

		internal static void main()
		{
			string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
			int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
			M = intArray[0];
			N = intArray[1];
			int[] packageNum = new int[M];
			int[] surplusNum = new int[M];
			for (int i = 0; i < M; i++)
			{
				int a = int.Parse(Console.ReadLine());
				packageNum[i] = N / a;
				surplusNum[i] = N % a;
			}
			//余りが最小値の機械は、何番目の機械なのかを配列に入れる
			List<int> minSurplusPos = new List<int>();
			for (int i = 0; i < M; i++)
			{
                if (surplusNum.Min() == surplusNum[i])
                {
					minSurplusPos.Add(i);
				}
			}

			//条件分岐で何番目の機械なのかを出力
			if(minSurplusPos.Count == 1)
            {
				Console.WriteLine(minSurplusPos[0]+1);
			}
            else if(minSurplusPos.Count == 2)
			{
				//該当する機械が複数あった場合はpackageNumが大きい方を選択
				int b = Math.Max(packageNum[minSurplusPos[0]], packageNum[minSurplusPos[1]]);
				for (int i = 0; i < M; i++)
				{
					if(b == packageNum[i])
                    {
						Console.WriteLine(i + 1);
					}
				}
			}

		}

		internal static void Do()
		{

		}
	}
}
//受験結果 受験言語： C# 解答時間： 30分27秒 バイト数： 1185 Byte スコア： 53点  220103  正解率6.5割くらい

//M N
//m_1
//m_2
//...
//m_M
//・1 行目には、機械の数を表す整数 M と、詰め込むお菓子の数を表す整数 N が、空白区切りで与えられます。
//・続く M 行のうち i (1 ≦ i ≦ M) 行目には、 i 番目の機械によって、お菓子が分配される容器の数を表す整数 m_i が与えられます。
//・入力は合計で N + 1 行となり、入力値最終行の末尾に改行が１つ入ります。

//排出される余りが最も少ない機械の番号を 1 行に出力してください。ただしそのような機械が複数ある場合は、その中で分配される容器の総数が多い機械の番号を出力してください。
//最後は改行し、余計な文字、空行を含んではいけません。
