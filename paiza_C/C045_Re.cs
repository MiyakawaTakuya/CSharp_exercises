using System.Collections.Generic;
using System.Linq;
using System;
//C045:ページネーション リベンジ
//受験結果 受験言語： C# 獲得ランク： Cランク スコア： 100点  220208  

namespace paiza_C
{
    public class C045_Re
    {
		//フィールド
		private static int n,s,p,p_last;

		internal static void main()
		{
			//入力
			string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
			int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
			n = intArray[0];
			s = intArray[1];
			p = intArray[2];

			if(n%s == 0) //キリがよかったら
            {
				p_last = n / s;
                if (p > p_last)
                {
					Console.WriteLine("none");
				}
                else
                {
					output_1();
				}
            }
            else
            {
				p_last = n / s + 1;
				if (p > p_last)
				{
					Console.WriteLine("none");
				}
				else
				{
					output_2();
				}
			}
		}

		internal static void output_1()
		{
			int firstNum = (p-1) * s +1;
			int lastNum = p * s;
			for (int i = firstNum; i <= lastNum; i++)
			{
                if (i != lastNum)
                {
					Console.Write(i + " ");
				}
                else if (i == lastNum)
                {
					Console.WriteLine(i);
				}
			}
		}

		internal static void output_2()
		{
			int firstNum = (p - 1) * s + 1;
			int lastNum = p * s;
            if (p != p_last)
            {
				for (int i = firstNum; i <= lastNum; i++)
				{
					if (i != lastNum)
					{
						Console.Write(i + " ");
					}
					else if (i == lastNum)
					{
						Console.WriteLine(i);
					}
				}
            }
            else
            {
				lastNum = (p - 1) * s + (n % s);
				for (int i = firstNum; i <= lastNum; i++)
				{
					if (i != lastNum)
					{
						Console.Write(i + " ");
					}
					else if (i == lastNum)
					{
						Console.WriteLine(i);
					}
				}
			}

		}
	}
}
