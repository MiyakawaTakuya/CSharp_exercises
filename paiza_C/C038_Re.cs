using System.Collections.Generic;
using System.Linq;
using System;
namespace paiza_C
{
	public class C038_Re
	{
		//フィールド
		private static int N, M;
		private static List<Pack> machines = new List<Pack>();

		//クラス
		private class Pack
		{
			internal Pack(int a, int b)  //コンストラクタ
			{
				packageNum = a;
				amari = N % a;
				machineNo_ = b + 1;
			}
			internal int packageNum { get; set; }
			internal int amari { get; set; }
			internal int machineNo_ { get; set; }
		}

		internal static void main()
		{
			//入力
			string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
			int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
			M = intArray[0];
			N = intArray[1];
			for (int i = 0; i < M; i++)
			{
				int a = int.Parse(Console.ReadLine());
				machines.Add(new Pack(a, i));
			}

			//出力  リストmachinesを容器の数が大きい順に入れ替える→あまりが小さい順に入れ替える、で一番最初にきたものが答え。
			List<Pack> No1machine = new List<Pack>(machines.OrderByDescending(val => val.packageNum).OrderBy(val => val.amari));
			Console.WriteLine(No1machine[0].machineNo_);

			//foreach (Pack val in mashines.OrderByDescending(val => val.packageNum).OrderBy(val => val.amari))
			//{
			//	Console.WriteLine("{0} あまりは{1} 容器は{2}", val.mashineNo_, val.amari, val.packageNum);
			//}

		}


	}
}
