using System.Collections.Generic;
using System.Linq;
using System;

namespace paiza_C.Questions
{
    public class lower_bound
    {
		private static int n,q,left,right,mid;

		internal static void main()
		{
			//入力
			n = int.Parse(Console.ReadLine());
			string[] strArray = Console.ReadLine().Trim().Split(' ');
			int[] A = strArray.Select(int.Parse).ToArray();
			//ソート
			Array.Sort(A);
			q = int.Parse(Console.ReadLine());

			for (int i = 0; i < q; i++)
			{
				Console.WriteLine(n - lowerBound(A, n, int.Parse(Console.ReadLine())));  //出力
			}

			//出力
			Console.WriteLine();
		}

		//A_i >= k を満たす最小の i を返す
		//A_i >= k を満たす i が存在しない場合は n を返す
		internal static int lowerBound(int[] A, int n, int k)
		{
			// 探索範囲 [left, right]
			left = 0;
			right = n ; //開で扱う
			// 探索範囲を狭めていく  最後がleft == rightとなるまで(1つに絞られるまで)ループ
			while (left < right)
			{
				// 探索範囲の中央のインデックス
				mid = (left + right) / 2;
				if (A[mid] < k)   //kが半分より右側だったら
				{
					left = mid + 1;
				}
				else   //半分より左側だったら
				{
					right = mid;
				}
			}
			return right;
		}
	}
}

//220221 スコア100 B相当

//n 人の生徒が受けた、10^9 点満点のテストの採点結果 A_1, A_2, ..., A_n があります。あなたは合格点を自由に設定することができます。合格点が k 点のとき、k 点以上を取った生徒が合格で、k 点未満を取った生徒が不合格です。
//q 個の整数 k_1, k_2, ..., k_q が与えられます。各 k_i について、合格点が k_i のときに合格する生徒の人数を答えてください。
//なお、n, q の最大値はいずれも 200,000 です。

//入力値
//n
//A_1 A_2 ... A_n
//q
//k_1
//k_2
//...
//k_q

