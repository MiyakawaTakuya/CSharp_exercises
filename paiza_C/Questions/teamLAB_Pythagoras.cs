using System.Collections.Generic;
using System.Linq;
using System;
//20220303 teamLABコーディングテスト4問目 時間切れで回答できず

//三辺の長さが3，4，5である三角形は直角三角形です。これは「ピタゴラスの定理」から示されます。

//【ピタゴラスの定理】 直角三角形について、直角をはさむ2辺の長さがaとbで斜辺の長さがcであるとき a2 + b2 = c2 が成り立つ。
//つまり、32 + 42 = 52（ = 25）が成立するので直角三角形といえるのです。

//三辺の長さが整数で面積が8000以下である直角三角形は何種類あるかを求めてください。

//※合同なもの（例えば“3，4，5”と“5，4，3”）は区別せず1種類として数えます。

namespace paiza_C.Questions
{
    public class teamLAB_Pythagoras
    {
		private static int n;
		private static List<int> numbers = new List<int>();
		//private static List<List<int>> patarn = new List<List<int>>();
		private static List<Num> patarn = new List<Num>();

		private class Num
		{
			internal Num(int a, int b, int c)  //コンストラクタ
			{
				A = a;
				B = b;
				C = c;
			}
			internal int A { get; set; }
			internal int B { get; set; }
			internal int C { get; set; }
		}

		internal static void main()
		{
			n = 8000;
			int sum = 0;
			for (int i = 1; i < 16001; i++)
			{
				for (int j = 1; j < i + j; j++)
				{
					if (i * j > 16000) break;  //底辺*高さ/2が8000を超えたらbreak
					double c = Math.Sqrt(j * j + i * i);
					if(c == (int)c)
                    {
						List<int> numbers = new List<int>() { i,j,(int)c};
						numbers.Sort();
						//patarn.Add(numbers);
						patarn.Add(new Num(numbers[0], numbers[1], numbers[2]));
					}
				}
			}

			//出力

			//Console.WriteLine(patarn);
			//IEnumerable<List<int>> result1 = patarn.Distinct();
			//IEnumerable<Num> result1 = patarn.Distinct();
			IEnumerable<Num> result1 = patarn.GroupBy(x => new { x.A, x.B, x.C }).Select(x => x.First());

			foreach (Num a in result1)
            {
                Console.Write(a.A + " " + a.B + " "+ a.C);
                Console.WriteLine();
            }

            Console.WriteLine(result1.Count());  //145が正解かな...？
		}
	}
}
