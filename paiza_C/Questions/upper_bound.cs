// using System.Collections.Generic;
using System.Linq;
using System;
//220222 スコア30　ランタイムエラーと間違いが半々  ...なぜ？
//二分探索の条件式 if (A[mid] < k)をif (A[mid] <= k) に変えたらスコア100になった

//解答より
//k より大きい = k+1 以上 であることから、前問にて書いた lower_bound の3つめの引数に k+1 を与えることによっても問題を解くことができます。

//学び
//参照する配列はソートかかっていることが大前提。
//2分探索で範囲を絞る過程で、mid,lesf,rightの値の取り方をしっかり設計してあげないといけない。特に不等号。
//今回の場合では、if (A[mid] <= k)left=mid+1 ;で処理していき、最終的に返す値(right)にkと一致した値を返さないような工夫が必要
//２分探索を続けて行った末、left,mid,rightが３つ並んだ状態になり、ラストの１個が決まるようになっている。

namespace paiza_C.Questions
{
    public class upper_bound
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
				Console.WriteLine(n - upperBound(A, n, int.Parse(Console.ReadLine())));  //出力
			}
		}

		//A_i > k を満たす最小の i を返す
		//A_i > k を満たす i が存在しない場合は n を返す(最後nから引き算した時に0になるように)
		internal static int upperBound(int[] A, int n, int k)
		{
			// 探索範囲 [left, right]
			left = 0;
			right = n; 
		    // 探索範囲を狭めていく  最後がleft == rightとなったら抜ける(1つに絞られるまで)ループ
			while (left < right)
			{
				// 探索範囲の中央のインデックス
				mid = (left + right) / 2;
				if (A[mid] <= k)   //kがmid含め右半分だったら(lower_bound.csとの違いはここだけ)
				{
					left = mid + 1;
				}
				else   //midより左だったら
				{
					right = mid;
				}
			}
			return right;

			////このやり方だとランタイムエラーと間違いがたくさん出てしまった
			////kと一致していたらright自身は含まないので　→結論最後の１こに絞られた状態のrightに+1してもダメで、絞る途中過程でleft=mid+1して行かないとうまく精査できてないことになる
            ///leftは常にmid+1になっているので
			//if (A[right] == k) 
			//         {
			//	return right + 1;
			//         }
			//         else
			//         {
			//	return right;
			//}

		}
	}
}

//n 人の生徒が受けた、10^9 点満点のテストの採点結果 A_1, A_2, ..., A_n があります。あなたは合格点を自由に設定することができます。
//合格点が k 点のとき、k 点より"大きい"点数を取った生徒が合格で、k 点"以下"の点数を取った生徒が不合格です。
//q 個の整数 k_1, k_2, ..., k_q が与えられます。各 k_i について、合格点が k_i のときに合格する生徒の数を答えてください。