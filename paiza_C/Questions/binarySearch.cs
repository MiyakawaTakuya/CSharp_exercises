using System.Collections.Generic;
using System.Linq;
using System;

namespace paiza_C.Questions
{
    public class binarySearch
    {
		private static int n,q,left,right,mid;

		internal static void main()
		{
			//入力
			n = int.Parse(Console.ReadLine());
			string[] strArray = Console.ReadLine().Trim().Split(' ');
			int[] A = strArray.Select(int.Parse).ToArray();
			q = int.Parse(Console.ReadLine());
            for (int i = 0; i < q; i++)
            {
				Console.WriteLine(binary_search(A, n, int.Parse(Console.ReadLine())));  //出力
			}
		}

		//ソート済みの数列 A に 値 k が含まれているなら "Yes" を、含まれいなければ"No"を返す
		internal static string binary_search(int[] A,int n,int k)
        {
			// 探索範囲 [left, right]
			left = 0;
			right = n - 1;
			// 探索範囲を狭めていく  最後がleft == rightとなるまで(1つに絞られるまで)ループ
			while (left <= right)
            {
				// 探索範囲の中央のインデックス
				mid = (left + right) / 2;
				if (A[mid] == k)
                {
					return "Yes";
				}
				else if (A[mid] < k)  //半分より右側だったら
				{
					left = mid + 1;
				}
				else   //半分より左側だったら
				{
					right = mid - 1;
				}
			}
			return "No";
		}

		//ソート済みの数列 A に 値 k が含まれているなら true を、含まれていないなら no を返す
		//(A : 数列, n : 数列のサイズ, k : 探索する値)
		//internal static bool binary_search(int[] A, int n, int k)
		//{
		//	// 探索範囲 [left, right]
		//	left = 0;
		//	right = n - 1;
		//	// 探索範囲を狭めていく
		//	while (left <= right)
		//	{
		//		// 探索範囲の中央のインデックス
		//		mid = (left + right) / 2;
		//		if (A[mid] == k)
		//		{
		//			return true;
		//		}
		//		else if (A[mid] < k)  //半分より右側だったら
		//		{
		//			left = mid + 1;
		//		}
		//		else   //半分より左側だったら
		//		{
		//			right = mid - 1;
		//		}
		//	}
		//	return false;
		//}
	}
}

//220221 スコア100 

//ソートされた数列 A = (A_1, A_2, ..., A_n) と、q 個の整数 k_1, k_2, ..., k_q が与えられます。各 k_i について、数列 A に含まれているなら Yes と、含まれていないなら No と出力してください。
//なお、n, q の最大値はいずれも 200,000 です。
//探索範囲の始点と終点を変数として持ち、探索範囲を半分にする処理を探索範囲が十分小さくなるまで繰り返す
//(1, 5)... 1 < x < 5 を満たす x からなる区間 開区間
//[1,5] ... 1 ≦ x ≦ 5 を満たす x からなる区間 閉区間
//半開区間を(a, b] や[a, b) と表記します


//条件
//・ 入力はすべて整数
//・ 1 ≦ n ≦ 200,000
//・ -10 ^ 9 ≦ A_i ≦ 10 ^ 9(1 ≦ i ≦ n)
//・ A_1 ≦ A_2 ≦ ... ≦ A_n
//・ 1 ≦ q ≦ 200,000
//・ -10 ^ 9 ≦ k_i ≦ 10 ^ 9(1 ≦ i ≦ q)