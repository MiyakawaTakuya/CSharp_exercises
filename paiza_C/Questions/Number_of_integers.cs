// using System.Collections.Generic;
using System.Linq;
using System;
//ある範囲に含まれている整数の個数
//220222 スコア30
//ランタイムエラー2問、間違い５問

namespace paiza_C.Questions
{
    public class Number_of_integers
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
                if (arr[0]== arr[1] && A.Contains(arr[0])) //値が同じだった場合エラーの原因になるので事前に個別処理する
                {
					Console.WriteLine(A.Count(a => a == arr[0]));
                }
                else
                {
					Console.WriteLine(r_binary_search(A, n, arr[1]) - l_binary_search(A, n, arr[0]) - 1); 
				}
				
			}
		}

		// l_i 以上 r_i 以下という条件に対して、Aの内からr_iより大きい値のうち最小の値を求める
		internal static int r_binary_search(int[] A, int n, int k)
		{
			// 探索範囲 [left, right]
			left = 0;
			right = n; //開で扱う
			// 探索範囲を狭めていく  最後がleft == rightとなるまで(1つに絞られるまで)ループ
			while (left < right)
			{
				// 探索範囲の中央のインデックス
				mid = (left + right) / 2;
				if (A[mid] <= k)   //kが半分より右側だったら
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

		// l_i 以上 r_i 以下という条件に対して、Aの内からl_iより小さい値の中から最大の値を求める
		internal static int l_binary_search(int[] A, int n, int k)
		{
			left = 0;
			right = n; //開で扱う
			// 探索範囲を狭めていく  最後がleft == rightとなるまで(1つに絞られるまで)ループ
			while (left < right)
			{
				// 探索範囲の中央のインデックス  //midよりも小さい値を求めていく時にint変換の小数点以下切り捨て進めていくと、
				// 途中left=0とright=1,mid=0で無限ループしてしまう現象に陥った
				// 切り上げ、で処理をしていけば「left=0とright=1,mid=0」の状態に陥ることはなく、
				// 「left=0とright=1,mid=1」になり次「left=0とright=0,mid=1」となってクリアできる

				double mid_ = Math.Ceiling((left + (double)right) / 2);  
				mid = (int)mid_; 
				if (A[mid] >= k)   //kが半分より左側だったら
				{
					right = mid - 1;
				}
				else   //半分より右側だったら
				{
					left = mid;
				}
			}
			return left;
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