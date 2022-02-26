using System.Collections.Generic;
using System.Linq;
using System;
//220226 ユークリッドの互除法 スコア100

namespace paiza_C.Questions
{
    public class EuclidsMethod
    {

		internal static void main()
		{
			string[] strArray = Console.ReadLine().Trim().Split(' ');
			int[] intArray = strArray.Select(int.Parse).ToArray();
			int A = intArray[0];
			int B = intArray[1];
			if (A > B) Console.WriteLine(euclidsMethod(A, B, 0));
            else if (A < B) Console.WriteLine(euclidsMethod(A, B, 1));
            else if (A == B) Console.WriteLine(A);
			//Console.WriteLine(gcd(A,B));  //解説より。これ一撃でいける。
		}

		internal static int euclidsMethod(int a,int b,int fla)  //flaでa,bの値が大きい方を判別。aなら0,bなら1
		{
			if (a == 0) return b;
			else if (b == 0) return a;

			if (fla == 0)
            {
				return euclidsMethod(a % b, b, 1);
			}
            else
            {
				return euclidsMethod(a, b % a, 0);
			}
		}

		//解説より...b,b%aはユークリッド互除法とはまた違う値になってしまっている気がするが、正解になる。。。
		internal static int gcd(int a, int b)
		{
			if (b == 0) return a;

			return gcd(b, b % a);
		}
	}
}

//1.A , B のうち、いずれかが 0 の場合 手順 3 に進む
//2. A , B のうち小さい方で大きい方をわり、大きい方をその余りで置き換え、手順 1 に戻る
//3. このとき、0 でない方の数が求めたい最大公約数になっている。

//解説
//問題文中のユークリッドの互除法の手順通りの処理を行うプログラムを作成しましょう。
//手順の 2 にある「A , B のうち小さいほうで大きいほうを割る」という操作では、
//条件分岐で A , B のうち大きいほうを調べる必要があるように思えますが、
//「A , B の大きいほうで小さいほうをわり、大きいほうをその余りで置き換える」操作をした時、
//大きいほうの値と小さいほうの値がそのまま入れ替わるだけなので、A , B の大小の判定は行わなくても大丈夫です。
//この操作は最初のループ処理でのみ起こりうるので全体の計算量に影響を及ぼしません。
//int gcd(int a, int b)
//{
//	if (b == 0)
//	{
//		return a;
//	}
//	return gcd(b, a % b);
//}

//int main()
//{
//	int a, b;
//	cin >> a >> b;
//	cout << gcd(a, b) << endl;
//}