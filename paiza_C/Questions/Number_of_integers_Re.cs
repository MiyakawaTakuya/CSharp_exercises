// using System.Collections.Generic;
using System.Linq;
using System;
//ある範囲に含まれている整数の個数
//220222 スコア100  再チャレンジ 解説を読んで
//「数列をソートし、l_i 以上の値が最初に現れる位置 lpos と r_i より大きい値が最初に現れる位置 rpos をそれぞれ
//lower_bound と upper_bound で求め、rpos - lpos を出力すればよいです。」

namespace paiza_C.Questions
{
    public class Number_of_integers_Re
    {
		private static int n, q, left, right, mid;

		internal static void main()
		{
			//入力
			n = int.Parse(Console.ReadLine());
			string[] strArray = Console.ReadLine().Trim().Split(' ');
			int[] A = strArray.Select(int.Parse).ToArray();
			Array.Sort(A);  //ソートされてないと２分探索が有効にならないのでソートから
			q = int.Parse(Console.ReadLine());

			for (int i = 0; i < q; i++)
			{
				string[] strArray2 = Console.ReadLine().Trim().Split(' ');
				int[] arr = strArray2.Select(int.Parse).ToArray();

				Console.WriteLine(upper_bound.upperBound(A, n, arr[1]) - lower_bound.lowerBound(A, n, arr[0])); 
			}
		}
    }
}
//10
//-45 62 -11 81 75 -90 13 2 97 -32
//1
//-90 -90
//l=0 r=1 →0を返して間違い

//10
//- 45 62 - 11 81 75 - 90 13 2 97 - 32
//1
//- 50 50
//解消ずみ

//例題にはないけど
//10
//- 45 62 - 11 81 75 - 90 13 2 97 - 32
//1
//97  97
//はエラーになって回答出来ない。
//nは元々配列外で途中にmid[n]を返してしまうからかな...