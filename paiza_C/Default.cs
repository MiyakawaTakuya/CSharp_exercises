using System;
using System.Linq;

namespace paiza_C
{
	public class Default
	{
		//フィールド
		private static int n;

		internal static void main()
		{
			input();
			
			output();
		}

		internal static void input()
		{
			int N = int.Parse(Console.ReadLine());
			string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
			int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
			for (int i = 0; i < N; i++)
			{
			}
	    }

		internal static void Do()
		{
			
		}


		internal static void output()
		{
			Console.WriteLine();
		}

	}
}
