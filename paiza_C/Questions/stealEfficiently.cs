 using System.Collections.Generic;
using System.Linq;
using System;
//効率よく盗もう (paizaランク A 相当)
//paiza 博物館に、n 個の財宝が展示されています。各財宝の価値は V_1, V_2, ..., V_n であり、
//重さは W_1, W_2, ..., W_n です。怪盗であるあなたは、paiza 博物館からちょうど k 個の財宝を盗み出そうとしています。
//k 個の財宝の平均価値を、(k 個の財宝の価値の和) ÷ (k 個の財宝の重さの和) で定義します。
//盗み出す財宝を適切に選んだ結果、平均価値が最大でいくつになるかを答えてください。


//解説  (歯が立たなかった)  下のコードはC++から翻訳してスコア100
//この問題には、k 個の財宝の平均価値を x 以上になるように財宝を選べるなら、y ≦ x を満たすすべての y について、
//k 個の財宝の平均価値を y 以上になるように財宝を選ぶことができるという単調性があります。
//従って、二分探索により達成できる平均価値の境界を求めれば良いです。
//重さ w_1, ..., w_k 、価値 v_1, ..., v_k からなる k 個の財宝の平均価値は、(v_1 + v_2 + ... + v_k) / (w_1 + w_2 + ... + w_k) で求めることができます。
//平均価値が x 以上になるためには、
//(v_1 + v_2 + ... + v_k) / (w_1 + w_2 + ... + w_k) ≧ x
//(v_1 + v_2 + ... + v_k) -x * (w_1 + w_2 + ... + w_k) ≧ 0
//(v_1 - x * w_1) + (v_2 - x * w_2) + ... +(v_k - x * w_k) ≧ 0
//を満たしていなければいけません。
//つまり、(v_i - x*w_i) を大きい方から k 個選んで足し合わせたときに和が 0 以上 であれば、n 個の財宝から k 個選んで平均価値を x 以上とすることができます。

//探索範囲が [left, right) のとき、平均価値が mid = (left+right)/2 以上となるように 財宝を k 個選ぶことができるかどうかをチェックします。
//これは、各財宝について v_i - mid*w_i を計算する処理に O(n) 、それらの値をソートする処理に O(n log n) 、ソートした値を大きい方から
//k 個選んで足す処理に O(k) かかるため、全体で O(n log n) で処理することができます。
//平均価値が mid 以上となるように財宝を選べるなら、探索範囲の左端を left から mid にします。逆に選べないならば、探索範囲の右端を right から mid にします。
//このように探索範囲を狭めていくことを、探索範囲が十分小さくなるまで行えばよいです。1 回狭めるごとに探索範囲は半分になるため、(本問の制約において) この処理は 50 回もすれば十分です。
//C++コード
//int main() {
//int n, k;
//cin >> n >> k;

//double w[n], v[n];
//for (int i = 0; i < n; i++)
//{
//	cin >> w[i];
//}

//for (int i = 0; i < n; i++)
//{
//	cin >> v[i];
//}

//double l = 0, r = 5001.0;
//for (int loop = 0; loop < 100; loop++)
//{
//	double mid = (l + r) / 2;

//	vector<double> tmp;
//	for (int i = 0; i < n; i++)
//	{
//		tmp.push_back(v[i] - w[i] * mid);
//	}
//	sort(tmp.rbegin(), tmp.rend());

//	if (accumulate(tmp.begin(), tmp.begin() + k, 0.0) >= 0)
//	{
//		l = mid;
//	}
//	else
//	{
//		r = mid;
//	}
//}

//cout << fixed << setprecision(10) << l << endl;

//return 0;
//}

namespace paiza_C.Questions
{
    public class stealEfficiently
    {
		private static int n, k;
		private static double[] W,V;
		private static double left, right, mid;

		internal static void main()
		{
			string[] strArray = Console.ReadLine().Trim().Split(' ');
			int[] intArray = strArray.Select(int.Parse).ToArray();
			n = intArray[0];
			k = intArray[1];
			string[] strArray2 = Console.ReadLine().Trim().Split(' ');
			W = strArray2.Select(double.Parse).ToArray();
			string[] strArray3 = Console.ReadLine().Trim().Split(' ');
			V = strArray3.Select(double.Parse).ToArray();

            left = 0.0;
            right = 5001.0;  //平均の値としてとりうる範囲のうち最大のものに+1したもの (部分的にここは正解！！)
            for (int loop = 0; loop < 100; loop++)
            {
                mid = (left + right) / 2;

				List<double> tmp = new List<double>();
				for (int i = 0; i < n; i++)
				{
					tmp.Add(V[i] - W[i] * mid);
				}
				//sort(tmp.rbegin(), tmp.rend());
				//tmp.Sort((a, b) => b - a); doubleはこの方法で降順にできない？？
				//var tmp_ = tmp.OrderBy(a => -a);  //tmp_の型が変わってしまってCopyTo出来なくなった
				tmp.Sort();
				tmp.Reverse();  //降順にする

				double[] d = new double[k];
				tmp.CopyTo(0, d, 0, k);  //List tmpのはじめ（0）から配列のコピーを、dのはじめ（0）からk分配置する。
				double d_sum = d.Sum();

				if (d_sum >= 0)
				{
					left = mid;
				}
				else
				{
					right = mid;
				}
			}
            Console.WriteLine(left.ToString("0.0000000000"));

        }

		//先に個別で割ってしまって価値を出したものの、合計した平均価値と答えに結構ずれが生じてしまう
        //結論、先に割ってしまってはダメ
		//internal static void main()
		//{
		//	string[] strArray = Console.ReadLine().Trim().Split(' ');
		//	int[] intArray = strArray.Select(int.Parse).ToArray();
		//	n = intArray[0];
		//	k = intArray[1];
		//	string[] strArray2 = Console.ReadLine().Trim().Split(' ');
		//	W = strArray2.Select(double.Parse).ToArray();
		//	string[] strArray3 = Console.ReadLine().Trim().Split(' ');
		//	V = strArray3.Select(double.Parse).ToArray();
		//	double[] Ave = new double[n];
		//	for (int i = 0; i < n; i++)
		//	{
		//		Ave[i] = V[i] / W[i];
		//	}

		//	Array.Sort(Ave);
		//	aveSum = (Ave[n - 1] + Ave[n - 2] + Ave[n - 3]) / 3;
		//	Console.WriteLine(aveSum.ToString("0.0000000000"));
		//}
	}
}
