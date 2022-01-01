using System;
using System.Collections.Generic;
using System.Linq;
//C022:ローソク足

namespace paiza_C
{
    public class C022
    {
		private static List<int> starts = new List<int>();
		private static List<int> ends = new List<int>();
		private static List<int> highs = new List<int>();
		private static List<int> lows = new List<int>();

		internal static void main()
		{
			int N = int.Parse(Console.ReadLine());

			for (int i = 0; i < N; i++)
			{
				string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
				int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
				starts.Add(intArray[0]);
				ends.Add(intArray[1]);
				highs.Add(intArray[2]);
				lows.Add(intArray[3]);
			}

			Console.WriteLine(starts[0]+ " " + ends[N-1]+ " "+ highs.Max()+ " " + lows.Min());

		}
	}
}

//受験結果 受験言語： C# 解答時間： 15分4秒 バイト数： 754 Byte スコア： 100点

//入力は以下のフォーマットで与えられます。
//n
//s_1 e_1 h_1 l_1
//...
//s_n e_n h_n l_n
//1 行目には、日数 n が与えられます。
//続く n 行の各行では、1 日間の 4 種類の株価のデータが与えられます。
//s_i は始値、e_i は終値、h_i は高値、l_i は安値を表しています
