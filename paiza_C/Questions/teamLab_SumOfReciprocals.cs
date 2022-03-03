using System.Collections.Generic;
 using System.Linq;
using System;
namespace paiza_C.Questions
{
    public class teamLab_SumOfReciprocals
	{
		//private static int n;
		private static List<int> numbers = new List<int>();

		internal static void main()
		{
			double sum = 0;
			for (int i = 1; i < 100000; i++)
			{
				if (sum > 10) break;
                sum += 1/(double)i;
				Console.WriteLine(i+" : " + sum);
			}
			//出力
			//Console.WriteLine(sum);
		}
	}
}
