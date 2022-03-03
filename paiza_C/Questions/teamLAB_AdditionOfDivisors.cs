using System.Collections.Generic;
using System.Linq;
using System;
//1234567890の正の約数のうち、20000000以下のものを全て足し合わせたときの和を求めてください。

namespace paiza_C.Questions
{
    public class teamLAB_AdditionOfDivisors
	{
		private static int n;
		private static List<int> numbers=new List<int>();

		internal static void main()
		{
			n = 1234567890;
			for (int i = 1; i*i < n; i++)
			{
				if (n % i != 0) continue;
				numbers.Add(i);
				if(i != n / i)
                {
					numbers.Add(n/i);
				}
			}
			numbers.Sort();
			int len = numbers.Count();
			int sum = 0;
			for (int i = 0; i < len; i++)
			{
				if (numbers[i]> 20000000) break;
				sum += numbers[i];
			}
			//出力
			Console.WriteLine(sum);
		}
	}
}
