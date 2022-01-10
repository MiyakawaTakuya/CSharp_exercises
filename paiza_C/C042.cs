using System.Collections.Generic;
using System.Linq;
using System;
//C042:リーグ表の作成
namespace paiza_C
{
    public class C042
    {
		//フィールド
		private static int N;
		private static string[,] league;

		internal static void main()
		{
			//入力
			N = int.Parse(Console.ReadLine());
			int M = N * (N - 1) / 2;
			league = new string[N,N];
			for (int i = 0; i < N; i++)
			{
				league[i, i] = "-";
			}

			for (int i = 0; i < M; i++)
			{
				string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
				int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
				league[intArray[0] - 1, intArray[1] - 1] = "W";
				league[intArray[1] - 1, intArray[0] - 1] = "L";
			}

			//出力
			for (int i = 0; i < N; i++)
			{
				for (int j = 0; j < N; j++)
				{
                    if (j != N-1)
                    {
						Console.Write(league[i, j] + " ");
					}
					else
                    {
						Console.Write(league[i, j]);
					}
				}
				Console.WriteLine("");
			}
			
		}
	}
}

//受験結果 受験言語： C# 解答時間： 23分25秒 バイト数： 915 Byte スコア： 96点  220111  全問正解

//N
//f_1 s_1
//f_2 s_2
//...
//f_M s_M  
//・1 行目には大会の参加者の総数を表す整数 N が与えられます。
//・続く M 行 (M = N × (N-1) / 2) のうち i 行目 (1 ≦ i ≦ M) には i 番目の試合結果の勝者の番号を表す整数 f_i、敗者の番号を表す整数 s_i がこの順に半角スペース区切りで与えられます。
//・入力は合計で M + 1 行となり、入力最値終行の末尾に改行が 1 つ入ります。

//・期待する出力は N 行からなります。
//・出力の i 行目 (1 ≦ i ≦ N) に N 個の文字を半角スペース区切りで出力してください。この j 番目 (1 ≦ j ≦ N) の文字 r_ { i, j }
//は参加者 i から見た参加者 j との試合の結果を表します。
//　・i ≠ j のとき、r_{i, j} は試合結果が勝利である場合 "W" 、敗北である場合は "L" となります。
//　・i = j のとき、r_
//{ i, j}
//は存在しない試合に対応するので "-" となります。
//・出力の N 行目の最後に改行を 1 つ入れ、余計な文字、空行を含んではいけません。