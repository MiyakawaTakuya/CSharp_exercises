// using System.Collections.Generic;
using System.Linq;
using System;
//B026:自動販売機

namespace paiza_C
{
    public class B026
    {
		private static int n;

		private class Aa
		{
			internal Aa(int a)
			{
				A = a;
			}
			internal int A { get; set; }
			internal static void Do()
			{

			}
		}

		internal static void main()
		{
			int N = int.Parse(Console.ReadLine());
			string[] strArray = Console.ReadLine().Trim().Split(' ');
			int[] intArray = strArray.Select(int.Parse).ToArray();
			for (int i = 0; i < N; i++)
			{
			}

			Console.WriteLine();
		}
	}
}
