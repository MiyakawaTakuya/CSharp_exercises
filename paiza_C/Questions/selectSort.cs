// using System.Collections.Generic;
using System.Linq;
using System;
//選択ソート  220306 スコア100 ランクB

//選択ソート(昇順) は、データ列を「整列済み」と「未整列」の2つに分け、「未整列な配列」の最小値を取り出し、
//「整列済み配列」の末尾に付け加えることを繰り返す手法です。
//「未整列な配列」の要素数が 1 になるまで処理を繰り返すと、1つの「整列済み配列」が得られます。
//選択ソート(昇順) は以下のようなアルゴリズムです。初期状態では配列全体 A[0] ~ A[n-1] を「未整列」とします。

//selection_sort(A: 配列, n: Aの要素数)
//    for i = 0 to n - 2
//        // A[i] ~ A[n-1] の最小値を見つけ、A[i]と交換する
//        // つまり、整列済みとなっている A[0] ~ A[i-1] の末尾に、A[i] ~ A[n-1] の最小値を付け加える

//        // A[i] ~ A[n-1] の最小値の位置を保存する変数 min_index を用意
//        // 暫定的に A[i] を最小値とする
//        min_index < -i

//        // 最小値を探す
//    for j = i + 1 to n - 1
//            if A[j] < A[min_index] then
//                min_index = j
//        // A[i] と A[min_index]を交換
//swap(A[i], A[min_index])
//        // A[0] ~ A[i] が整列済みになった


namespace paiza_C.Questions
{
    public class selectSort
    {

		internal static void main()
		{
			int n = int.Parse(Console.ReadLine());
			string[] strArray = Console.ReadLine().Trim().Split(' ');
			int[] intArray = strArray.Select(int.Parse).ToArray();
			select_Sort(intArray, n);
		}

		internal static void select_Sort(int[] arr,int n)
        {
			for (int i = 0; i <= n - 2; i++)
			{
				int min_index = i;  //暫定的に最長値のインデックスとしてi番目を入れておく
				//最小値を探す
				for(int j=i+1;j <= n - 1; j++)
                {
                    if (arr[j]<arr[min_index])
                    {
						min_index = j;
                    }
                }
				int tmp = arr[min_index];
				arr[min_index] = arr[i];
				arr[i] = tmp;
			}
			Console.WriteLine(string.Join(" ", arr));
		}
	}
}
