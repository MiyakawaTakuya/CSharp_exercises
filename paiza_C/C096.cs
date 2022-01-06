// using System.Collections.Generic;
 using System.Linq;
using System;
//C096:夏休み

namespace paiza_C
{
    public class C096
    {
		//フィールド
		private static int[] schedule = new int[31];
		private static int a,b;

		internal static void main()
		{
			//入力
			int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
                int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
				a = intArray[0] - 1;
				b = intArray[1] - 1;
                for (int j = a; j <= b; j++)
                {
                    schedule[j] += 1;
                }
            }
			//計算量が多くてランタイムエラーに見舞われたケース
			//for (int i = 0; i < N; i++)
			//{
			//	string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
			//	int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
			//	for (int j = intArray[0]-1 ; j <= intArray[1]-1; j++)
			//	{
			//		schedule[j] += 1;
			//	}
			//}

			if (schedule.Max() == N)
            {
				Console.WriteLine("OK");
			}
            else if((schedule.Max() != N))
            {
				Console.WriteLine("NG");
			}
		}



	}
}

//受験結果 受験言語： C# 解答時間： 18分42秒 バイト数： 606 Byte スコア： 40点  220107
//ランタイムエラーで正答率4割  ...なぜ？！
//→forのindexに配列を値を入れていて計算量が増えてしまっていた模様
//受験結果 受験言語： C# 獲得ランク： Cランク スコア： 100点

//問題集計
//難易度： 1495 ±10
//受験者数： 1,702人
//正解率： 40.46％
//平均解答時間： 30分30秒
//平均スコア： 77.54点

//N
//s_1 e_1
//s_2 e_2
//...
//s_N e_N
//・1 行目に子供を除いた (休みを合わせないといけない) お出かけに行くメンバーの人数を表す整数 N が与えられます。
//・続く N 行のうち i 行目 (1 ≦ i ≦ N) に i 番目のメンバーの休みを取れる期間のうち最初と最後の日付を表す整数 s_i, e_i がこの順に半角スペース区切りで与えられます。
//・入力は合計で N + 1 行となり、入力の最後に改行が 1 つ入ります。
