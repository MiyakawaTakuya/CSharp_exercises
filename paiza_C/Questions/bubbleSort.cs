// using System.Collections.Generic;
using System.Linq;
using System;
//220306 スコア  スコア100 ランクB
//バブルソートは、データ列の隣り合う要素を比較し交換することを繰り返すことによりデータ列をソートする手法です。
//バブルとは「泡」の意味で、ソートの過程でデータが移動する様子が、水中で泡が浮かんでいくように見えることからこの名前がついています。
//バブルソート(昇順) は以下のようなアルゴリズムです。

//bubble_sort(A: 配列, n: Aの要素数)
//	for i = 0 to n - 2
//		for j = n - 1 down to i + 1
//			if a[j - 1] > a[j] then
//				swap(a[j - 1], a[j])

//データ列を左から右へ昇順ソートすることを考えます。バブルソートの基本方針は、左の要素と比較し、左の方が大きければ交換するです。
//これを右から左まで1回行うと、最小の要素が一番左に移動します。
// (首を左に傾けてこの処理を眺めると、泡が水面へと上がっていく様子に見えてきませんか？)
//次に、一番左の要素を除いて、同じ処理を繰り返します。すると、2番目に小さい要素が左から2番目に移動します。
//これを最後まで繰り返せば、ソート完了です。

//バブルソートの計算量を考えます。最も多くの計算ステップがかかるのは、二重 for ループ中にて値を比較する処理です。
//よって、この処理が何回行われるかに注目し、計算量を導きます。この処理は、各 i について n - i - 1 回行われます。
//つまり、この処理は全体で n - 1 + ... +1 = (n - 1) * n / 2 = (n ^ 2 - n) / 2 回行われます。
//よって、バブルソートは O(n ^ 2) のアルゴリズムとなります。


namespace paiza_C.Questions
{
    public class bubbleSort
    {
		internal static void main()
		{
			int n = int.Parse(Console.ReadLine());
			string[] strArray = Console.ReadLine().Trim().Split(' ');
			int[] intArray = strArray.Select(int.Parse).ToArray();
			bubble_Sort(intArray, n);
		}

		internal static void bubble_Sort(int[] arr, int n)
		{
			for (int i = 0; i <= n - 2; i++)  //左側から詰めていきたいのでi=0スタート
			{						
				for (int j = n-1; j >= i+1; j--)
				{
					if (arr[j-1] > arr[j])
					{
						int tmp = arr[j];
						arr[j] = arr[j-1];
						arr[j-1] = tmp;
					}
				}
				Console.WriteLine(string.Join(" ", arr));
			}
			
		}
	}
}
