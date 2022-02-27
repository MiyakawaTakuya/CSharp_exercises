// using System.Collections.Generic;
using System.Linq;
using System;
//3 つ以上の整数の最大公約数 (paizaランク C 相当)
//220226 スコア
namespace paiza_C.Questions
{
    public class greatestCommonDivisor
    {
		internal static void main()
		{
			string[] strArray = Console.ReadLine().Trim().Split(' ');
			int[] intArray = strArray.Select(int.Parse).ToArray();
			int A = intArray[0];
			int B = intArray[1];

			Console.WriteLine();
        }

		internal static int euclidsMethod(int a, int b, int fla)  //
		{
			if (a == 0) return b;
			else if (b == 0) return a;

			if (fla == 0)
			{
				return euclidsMethod(a % b, b, 1);
			}
			else
			{
				return euclidsMethod(a, b % a, 0);
			}
		}
	}
}
