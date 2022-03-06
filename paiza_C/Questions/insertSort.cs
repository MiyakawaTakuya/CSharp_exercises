 //using System.Collections.Generic;
using System.Linq;
using System;
//insert sort  220306  スコア100 B相当
//挿入ソートは、データ列を「整列済み」と「未整列」の2つに分け、「未整列な配列」からデータを1つ取り出し、
//「整列済み配列」の適切な位置に挿入することを繰り返す手法です。「未整列な配列」が空になるまで処理を繰り返すと、1つの「整列済み配列」が得られます。
//この手法は、手持ちのトランプを並び替える際などによく用いられる、自然で比較的直感的なものです。
//挿入ソート(昇順) は以下のようなアルゴリズムです。初期状態では A[0] ~ A[0] を「整列済み」、A[1] ~A[n - 1] を「未整列」とします。

//insertion_sort(A: 配列, n: Aの要素数)

//	for i = 1 to n - 1
//		// A[i] を、整列済みの A[0] ~ A[i-1] の適切な位置に挿入する
//		// 実装の都合上、A[i] の値が上書きされてしまうことがあるので、予め A[i] の値をコピーしておく        
//		x < -A[i]
//		// A[i] の適切な挿入位置を表す変数 j を用意
//		j < -i - 1
//		// A[i] の適切な挿入位置が見つかるまで、A[i] より大きい要素を1つずつ後ろにずらしていく
//	while j >= 0 AND A[j] > x
//			A[j + 1] = A[j]
//			j--
//		// A[i] を挿入
//A[j + 1] < -x
//		// A[0] ~ A[i] が整列済みになった


namespace paiza_C.Questions
{
    public class insertSort  //昇順に並び替える
    {
		internal static void main()
		{
			int n = int.Parse(Console.ReadLine());
			string[] strArray = Console.ReadLine().Trim().Split(' ');
			int[] setArray = strArray.Select(int.Parse).ToArray();

            for (int i =1; i<= n-1; i++)
            {
				int x = setArray[i];  //コピーを用意する
				int j = i - 1;    // A[i] の適切な挿入位置を表す変数 j を用意、カーソル的な役割
				//A[i] の適切な挿入位置が見つかるまで、A[i] より大きい要素を1つずつ後ろにずらしていく
				while (j >= 0 && setArray[j] > x)
				{
					setArray[j + 1] = setArray[j];
					j--;
				}
				setArray[j + 1] = x;
				Console.WriteLine(string.Join(" ", setArray));
			}

		}
	}
}
