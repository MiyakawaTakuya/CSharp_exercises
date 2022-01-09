using System.Collections.Generic;
using System.Linq;
using System;
//【2021年paizaの日問題】C095:バスの時間

namespace paiza_C
{
    public class C095_bus_time
    {
		//フィールド
		private static int N,K;

		internal static void main()
		{
			//入力
			string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
			int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
			N = intArray[0];
			K = intArray[1];
			List<int> bus = new List<int>();  //Listに格納していく
			for (int i = 0; i < N; i++)
			{
				bus.Add(int.Parse(Console.ReadLine()));
			}
			bus.Sort();

			//出発したい時間と時刻表の時間差を取っていき、配列に入れる
			List<int> delta = new List<int>();
			for (int i = 0; i < N; i++)
			{
				delta.Add(Math.Abs(K - bus[i]));
			}
			int min = delta.Min();

			//出力
			for (int i = 0; i < N; i++)
			{
                if (min == delta[i]) Console.WriteLine(bus[i]);
			}
			
		}
	}
}
//受験結果 受験言語： C# 解答時間： 14分57秒 バイト数： 791 Byte スコア： 100点  220109

//N K
//t_1
//t_2
//...
//t_N
//・1 行目には、整数 N, K が半角スペース区切りで与えられます。N はバスの時間の種類数を表し、K は K 分後にバスに乗りたいことを表します。
//・続く N 行のうちの i 行目 (1 ≦ i ≦ N) には、i 番目のバスの時間を表す整数 t_i がこの順で半角スペース区切りで与えられます。t_i 分後にバスが来ることを表します。
//・入力は合計で N + 1 行となり、入力値最終行の末尾に改行が 1 つ入ります。

//K 分後に最も近いバスの時間が 1 種類のみ場合、K 分後に一番近いバスの時間を整数で出力してください。末尾に改行を入れ、余計な文字、空行を含んではいけません。
//K 分後に最も近いバスの時間が 2 種類存在する場合、以下の形式で出力してください。
//a_1
//a_2
//・K 分後に最も近いバスの時間を表す a_1, a_2 を 2 行で出力してください。
//・a_1 < a_2
//・すべて整数で出力してください。