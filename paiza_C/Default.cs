using System;
using System.Linq;

namespace paiza_C
{
	public class Default
	{
		//フィールド
		private static int n;
		//クラス
		private class Aa 
		{
			internal Aa(int a)  //コンストラクタ
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
			//入力
			int N = int.Parse(Console.ReadLine());
			string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
			int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
			for (int i = 0; i < N; i++)
			{
			}

			//出力
			Console.WriteLine();
		}


	}
}
