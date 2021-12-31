using System;
using System.Linq;
//C079:カードを集める

namespace paiza_C
{
    public class C079
    {
		//フィールド
		private static int count = 0;

		internal static void main()
		{
			string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
			int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
			int N = intArray[0];
			int M = intArray[1];
			int[] allCards = new int[M];

			for (int i = 0; i < N; i++)
			{
				int draw = int.Parse(Console.ReadLine());
				if (allCards[draw - 1] == 0)
				{
					allCards[draw - 1] = 1;
					count++;
				}
				if (count == M)
				{
					Console.WriteLine(i + 1);
					break;
				}
			}
			if (count != M) Console.WriteLine("unlucky");

		}
	}
}

//受験結果 受験言語： C# 解答時間： 15分48秒 バイト数： 632 Byte スコア： 100点
//入力は以下のフォーマットで与えられます。
//N M
//c_1
//...
//c_N
//・1 行目に買ったカードの枚数 N とカードの種類数を示す整数 M が入力されます。
//・続く N 行に開けたカードのカード番号 c_i (1 ≦ i ≦ N) が入力されます。
//・最終行の末尾に改行が 1 つ入ります