using System;
using System.Linq;
//C078:株の売買

namespace paiza_C
{
    public class C078
    {
		//フィールド
		private static int profit_loss = 0;
		private static int shares = 0;

		internal static void main()
		{
			string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
			int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
			int N = intArray[0];
			int buyLine = intArray[1];
			int sellLine = intArray[2];

			for (int i = 0; i < N; i++)
			{
				int p = int.Parse(Console.ReadLine());
				if (p <= buyLine && i != N - 1)
				{
					profit_loss -= p;
					shares++;
				}
				else if (p >= sellLine && i != N - 1)
				{
					profit_loss += p * shares;
					shares = 0;
				}
				else if (i == N - 1)
				{
					profit_loss += p * shares;
					shares = 0;
				}
		    }

			Console.WriteLine(profit_loss);
		}


	}
}

//受験結果 受験言語： C# 解答時間： 19分58秒 バイト数： 783 Byte スコア： 100点  211231
//入力は以下のフォーマットで与えられます。

//N c_1 c_2
//p_1
//p_2
//...
//p_N
//・1 行目には、株を売買する日数を表す整数 N、株の売買条件を表す整数 c_1, c_2 がこの順で半角スペース区切りで与えられます。
//・続く N 行のうちの i 行目 (1 ≦ i ≦ N) には、i 日目の株価を表す整数 p_i が与えられます。
//・入力は合計で N + 1 行となり、入力値最終行の末尾に改行が 1 つ入ります。