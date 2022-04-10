using System.Collections.Generic;
using System.Linq;
using System;
//B025:うさぎジャンプ
//受験結果 受験言語： C# 解答時間： 64分50秒 バイト数： 1210 Byte スコア： 85点   220410  正答率100%
//完全に取り組む場所が悪かった....

// 出力は M 行からなります。
// i行目には、K セットのジャンプが終わったあとに i 番目のうさぎがいるしげみの番号を出力してください。(i = 1, 2, ..., M)

namespace paiza_C
{
    public class B025
    {
		internal static int N;
		internal static Dictionary<int, int> usaPos = new Dictionary<int, int>();
		internal static int[] fillOrNot;

		internal static void main()
		{
			string[] ArrayData = Console.ReadLine().Trim().Split(' ');
			N = int.Parse(ArrayData[0]);  
			int M = int.Parse(ArrayData[1]);  
			int K = int.Parse(ArrayData[2]);
			fillOrNot = new int[N];
			for (int i = 0; i < M; i++)
			{
				int pos = int.Parse(Console.ReadLine());
				usaPos.Add(pos,pos);
				fillOrNot[pos - 1] = 1;  //1は充填
			}

			List<int> posList = usaPos.Keys.ToList();
			for (int i = 0; i < K; i++)
			{
				foreach (int p in posList)
				{
					usaPos[p] = changePos(usaPos[p]);
				}
			}

			//出力
			foreach (int p in posList)
			{
				Console.WriteLine(usaPos[p]);
			}
		}

		internal static int changePos(int p)
		{
			fillOrNot[p - 1] = 0; //現在のポジションを空き(=0)にする
			int j = p;
			int afterPos;
			while (true)
            {
				if (j == N) j = 0;  //もし最終インデックスだったら0番目にカーソル移動させる
				if (fillOrNot[j] == 0)
				{
					fillOrNot[j] = 1;
					afterPos = j;
					break;
				}
				j++;
			}
			return afterPos+1;
		}
	}
}
