using System;
using System.Linq;
//C083:売上の発表

namespace paiza_C
{
    public class C083
    {
		internal static int N,R;

		internal static void main()
		{
			string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
			int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
			N = intArray[0];
			R = intArray[1];
			int[] data = new int[N];
			for (int i = 0; i < N; i++)
			{
				data[i] = int.Parse(Console.ReadLine());
			}
			int maxParame = data.Max() / R;
			for (int j = 0; j < N; j++)
			{
				string graph = new string(createGraph(data[j], maxParame));
				Console.WriteLine(j + ":" + graph);
			}
		}

		internal static char[] createGraph(int a,int m)
		{
			char[] line = new char[m];
			for (int k = 0; k < m; k++)
			{
				line[k] = '.';
			}
			for (int k = 0; k < a; k++)
            {
				line[k] = '*';
			}
			return line;
        }

	}
}

//受験結果 受験言語： C# 解答時間： 50分56秒 バイト数： 836 Byte スコア： 62点  211231  正解率100%
//入力は以下のフォーマットで与えられます。
//N R
//a_1
//a_2
//...
//a_N
//・1 行目に売上データの個数を表す整数 N と、データの表示単位を表す整数 R がこの順で半角スペース区切りで与えられます。
//・続く N 行のうちの i 行目 (1 ≦ i ≦ N) には、第 i 期の売上を表す整数 a_i がこの順で与えられます。
//・入力は合計で N + 1 行となり、入力値最終行の末尾に改行が 1 つ入ります。