// using System.Collections.Generic;
using System.Linq;
using System;
//C094:国民の税金

namespace paiza_C
{
    public class C094
    {
		//フィールド
		private static double taxSum;

		internal static void main()
		{
			int N = int.Parse(Console.ReadLine());
			for (int i = 0; i < N; i++)
			{
				int a = int.Parse(Console.ReadLine());
				taxSum += calculateTax(a);
			}

			Console.WriteLine(taxSum);
		}

		internal static double calculateTax(int x)
		{
			double sum = 0;
            //xがどこの金額帯に位置するかで条件分岐
            if (x <= 100000)
            {
				return sum;
			}
			else if (100001 <= x && x <= 750000)
			{
				sum += Math.Floor((x - 100000) * 0.1);
				return sum;
			}
			else if (750001 <= x && x <= 1500000)
			{
				sum += 65000;  //650000 * 0.1
				sum += Math.Floor((x - 750000) * 0.2);
				return sum;
			}
			else if (1500001 <= x)
			{
				sum += 65000;  //650000 * 0.1
				sum += 150000;  //750000*0.2
				sum += Math.Floor((x - 1500000) * 0.4);
				return sum;
			}
			return 0;
		}
	}
}

//受験結果 受験言語： C# 解答時間： 20分44秒 バイト数： 901 Byte スコア： 100点  220107

//N
//x_1
//x_2
//...
//x_N
//・ 行目に PAIZA 国民の人数を表す整数 N が与えられます。
//・続く N 行のうちの i 行目 (1 ≦ i ≦ N) には、i 番目の人の所得を表す整数 x_i が与えられます。
//・入力は合計で N + 1 行となり、入力値最終行の末尾に改行が 1 つ入ります。