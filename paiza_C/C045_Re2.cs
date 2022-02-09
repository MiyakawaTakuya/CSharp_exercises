using System.Collections.Generic;
using System.Linq;
using System;
//C045:ページネーション リベンジ
//受験結果 受験言語： C# 獲得ランク： Cランク スコア： 100点  220208  

namespace paiza_C
{
	public class C045_Re2
	{
		//フィールド
		private static int n, s, p,firstNum, lastNum;
		private static double p_last;
		private static List<int> P_ans = new List<int>();

		internal static void main()
		{
			//入力
			string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
			int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
			n = intArray[0];
			s = intArray[1];
			p = intArray[2];

			p_last = Math.Ceiling((double)n / s);  //切り上げで最終ページを算出
			firstNum = (p - 1) * s + 1;
            if (p > p_last)
            {
				Console.WriteLine("none");
			}
			else if (p== p_last && n%s !=0)
            {
				lastNum = (p - 1) * s + (n % s);
				output();
			}
            else
            {
				lastNum = p * s;
				output();
			}
		}

        internal static void output()
        {
			for (int i = firstNum; i <= lastNum; i++)
			{
				P_ans.Add(i);
			}
			Console.WriteLine(String.Join(" ", P_ans));
		}
    }
}

