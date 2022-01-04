// using System.Collections.Generic;
using System.Linq;
using System;
//C019: 完全数とほぼ完全数
namespace paiza_C
{
    public class C019
    {
		//フィールド
		private static int n;

		internal static void main()
		{
			//読み込み
			int Q = int.Parse(Console.ReadLine());
			for (int i = 0; i < Q; i++)
			{
				int n = int.Parse(Console.ReadLine());
				Console.WriteLine(judge(sum(n), n));
			}
		}

		internal static int sum(int a)
		{
			int sum = 0;
			for (int j = 1; j <=a ; j++)
			{
				if (a % j == 0) sum += j;
			}
			return sum - a;
		}

		internal static string judge(int a,int b)
		{
            if (a == b)
            {
				return "perfect";
			}
			else if (a == b - 1 || a == b + 1)
			{
				return "nearly";
			}
            else
            {
				return "neither";
			}
		}
	}
}

//受験結果 受験言語： C# 解答時間： 28分15秒 バイト数： 646 Byte スコア： 90点  220104

//・N = S となるような N を完全数
//・|N-S| = 1 となるような N をほぼ完全数
//Q
//N_1
//...
//N_Q
//1行目には判定したい整数の個数 Q が入力されます。続く Q 行には整数 N_1, ..., N_Q が入力されます。
//・N_i が完全数であれば "perfect"
//・N_i がほぼ完全数であれば "nearly"
//・どちらでもなければ "neither"