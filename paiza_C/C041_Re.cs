using System.Collections.Generic;
using System.Linq;
using System;
namespace paiza_C
{
    public class C041_Re
    {
		//フィールド
		private static int N;
		private static List<Medal> medals = new List<Medal>();
		
		private class Medal //クラス
		{
			//コンストラクターで初期化をする
			public Medal(int gold,int silver,int bronze)
			{
				Gold = gold;
				Silver = silver;
				Bronze = bronze;
			}
			public int Gold { get; set; }
			public int Silver { get; set; }
			public int Bronze { get; set; }
		}

		internal static void main()
		{
			//入力
			N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
                int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
				medals.Add(new Medal(intArray[0], intArray[1], intArray[2]));  //金銀銅の順に格納
            }
			foreach (Medal val in medals.OrderByDescending(val => val.Bronze).OrderByDescending(a => a.Silver).OrderByDescending(val => val.Gold))
			{
				Console.WriteLine("{0} {1} {2}", val.Gold, val.Silver,val.Bronze);
			}
		}
	}
}
