using System;
using System.Collections.Generic;
using System.Linq;
//C063:ガーデニング

namespace paiza_C
{
    public class C063
    {
		//フィールド
		private static int maxDate=0;
		private static int sumDay,sum;
		private static List<int> days = new List<int>();
		private static int[] bloom;

		internal static void main()
		{
			int N = int.Parse(Console.ReadLine());
			//読み取り　最大の日数を算出し配列の大きさを把握する 配列化
			for (int i = 0; i < N; i++)
			{
				string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
				int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
				sumDay = intArray[0] + intArray[1];
                if (sumDay > maxDate)
                {
					maxDate = sumDay;
                }
				days.Add(sumDay);
			}
			bloom = new int[maxDate]; //日数分の箱を用意する　
			for (int i = 0; i < N; i++)
			{
				bloom[days[i]-1]++; 
			}
			for (int i = 0; i < N; i++)
			{
				if (bloom[i] == bloom.Max())
				{
					Console.WriteLine(i+1);
					break;
				}
			}

			
		}

		internal static void Do()
		{

		}
	}
}

//受験結果 受験言語： C# 解答時間： 33分51秒 バイト数： 936 Byte スコア： 42点 正答率50%くらい...

//入力は以下のフォーマットで与えられます。
//N
//a_1 b_1
//a_2 b_2
//...
//a_N b_N
//・1 行目に、花の種類数を表す整数 N が与えられます。
//・続く N 行のうちの i 行目 (1 ≦ i ≦ N) には、i 番目の花の種が花を咲かせるまでの日数を表す整数 a_i、i 番目の花の種を庭にまく日を表す整数 b_i がこの順で半角スペース区切りで与えられます。
//・入力は合計で N + 1 行となり、入力値最終行の末尾に改行が 1 つ入ります。