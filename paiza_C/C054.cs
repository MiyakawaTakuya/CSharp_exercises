// using System.Collections.Generic;
using System.Linq;
using System;
//C054:【ぱいじょ！コラボ問題】スピード違反の取り締まり

namespace paiza_C
{
    public class C054
    {
		//フィールド
		private static int N,V;

		internal static void main()
		{
			//入力
			string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
			int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
			N = intArray[0];
			V = intArray[1];
			int[] times = new int[N];
			int[] poss = new int[N];
			for (int i = 0; i < N; i++)
			{
				string[] strArray2 = Console.ReadLine().Trim().Split(' ');
				int[] intArray2 = strArray2.Select(int.Parse).ToArray();
				times[i] = intArray2[0];
				poss[i] = intArray2[1];
			}
			Console.WriteLine(judge(times,poss));
		}

		internal static string judge(int[] t,int[] x)
		{
			int count = 0;
			for (int i = 0; i < N -1; i++)
			{
				if((x[i + 1]-x[i])/(t[i + 1] - t[i]) > V)
                {
					count++;
				}
			}

			if(count > 0)
            {
				return "YES";
            }
			else
            {
				return "NO";
			}
		}
	}
}

//受験結果 受験言語： C# 解答時間： 19分44秒 バイト数： 933 Byte スコア： 100点

//N V
//t_1 p_1
//t_2 p_2
//...
//t_N p_N
//・1 行目に観測地点の数 N と 制限速度 V が整数でスペース区切りで与えられます。
//・続く N 行のうちの i 行目 (1 ≦ i ≦ N) には、i 番目の観測データにおける時刻 t_i と、位置 p_i がこの順に整数で半角スペース区切りで与えられます。
//・入力は N + 1 行で終わり、最後に改行が入ります。
//区間の平均速度が制限速度を越えている場合は "YES"、そうでない場合は "NO" を出力してください。