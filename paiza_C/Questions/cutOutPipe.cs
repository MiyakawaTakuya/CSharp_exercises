// using System.Collections.Generic;
using System.Linq;
using System;
// パイプを切り出そう(paizaランク A 相当)
// 問題とけず断念 解答をみた
// この問題には、長さ x のパイプを k 本切り出せるなら、y ≦ x を満たすすべての y について長さ y のパイプを k 本切り出すことができるという単調性があります。
// 従って、二分探索により 切り出せる/切り出せない 長さの境界を求めれば良いです。
// 探索範囲が[left, right) のとき、長さ mid = (left + right) / 2 のパイプを k 本切り出すことができるかどうかをチェックします(これは O(n) で実行可能です)。
// 切り出すことができるなら、y ≦ mid を満たすすべての y について長さ y のパイプを k 本切り出せることがわかるため、探索範囲の左端を left から mid にします。
// 逆に切り出すことができないならば、y >= mid を満たすすべての y について長さ y のパイプを k 本切り出せないことがわかるため、探索範囲の右端を right から mid にします。
//このように探索範囲を狭めていくことを、探索範囲が十分小さくなるまで行えばよいです。1回狭めるごとに探索範囲は半分になるため、(本問の制約において) この処理は 50 回もすれば十分です。

//時間の計測
//https://qiita.com/Kosen-amai/items/81efaf815b48ab9ffbb6

namespace paiza_C.Questions
{
    public class cutOutPipe
    {
		private static int n, k;
		private static int[] a;
		private static double left, right, mid;

		internal static void main()
		{
			string[] strArray = Console.ReadLine().Trim().Split(' ');
			int[] intArray = strArray.Select(int.Parse).ToArray();
			n = intArray[0];
			k = intArray[1];
			string[] strArray2 = Console.ReadLine().Trim().Split(' ');
			a = strArray2.Select(int.Parse).ToArray();
			var sw = new System.Diagnostics.Stopwatch();  //計測
			sw.Start();

			left = 0.0;
			right = 10001.0;  //模範解答これだったけどここからスタートする必要ないなと思ったので修正した、が時間計測したらこっちの方がsortより100倍早かった)汗
			//right = a.Max() + 1;  //.Max()はおそらくソートしてるので、こっちの方が計算量が多くなっている模様...
			for (int i = 0; i < 100; i++)
			{
				mid = (left + right) / 2;
				int num_of_pipes = 0;
				foreach (int x in a)
				{
					num_of_pipes += (int)(x / mid);
				}

				if (num_of_pipes < k)
				{
					right = mid;
				}
				else
				{
					left = mid;
				}
			}
			sw.Stop();
			TimeSpan ts = sw.Elapsed;
			//Console.WriteLine("計算にかかった時間は、" + $"　{ts.Seconds}" + "."+ $"　{ts.Milliseconds}"+"秒です");
			Console.WriteLine("計算にかかった時間は、" + $"{ts.ToString(@"ss\.ffffff")}" + "です");
			Console.WriteLine(left.ToString("0.0000000000"));

		}
	}
}

//n 本のパイプがあり、長さはそれぞれ A_1, A_2, ..., A_n です。今、n 本のパイプから k 本の同じ長さのパイプを切り出すことを考えます。
//パイプを切って分割することはできますが、つなげることはできません。
//パイプの切り方を工夫した結果、切り出すことができるパイプの長さの最大値を答えてください。
//答えは整数になるとは限りません。相対誤差または絶対誤差が 10^-6 (0.000001) 以下であれば正解とみなされます。
//入力される値
//n k
//A_1 A_2 ... A_n
//n 本のパイプから k 本のパイプを適切に切り出した結果、切り出すことができるパイプの長さの最大値を出力してください。
//相対誤差または絶対誤差が 10^-6 (0.000001) 以下であれば正解とみなされます。
//条件
//すべてのテストケースにおいて、以下の条件をみたします。
//・ 入力はすべて整数
//・ 1 ≦ n ≦ 200,000
//・ 1 ≦ k ≦ 500,000
//・ 1 ≦ A_i ≦ 10,000 (1 ≦ i ≦ n)