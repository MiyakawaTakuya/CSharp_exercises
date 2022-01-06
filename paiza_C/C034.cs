// using System.Collections.Generic;
using System.Linq;
using System;
//C034:先生の宿題

namespace paiza_C
{
    public class C034
    {
		//フィールド
		private static int n;

		internal static void main()
		{
			//入力
			string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
            //出力 xの位置によって場合分けして計算処理をしていく
            if (strArray[0]=="x")
			{
				Console.WriteLine(Calculate1(int.Parse(strArray[2]), strArray[1], int.Parse(strArray[4])));
			}
			else if (strArray[2] == "x")
			{
				Console.WriteLine(Calculate2(int.Parse(strArray[0]), strArray[1], int.Parse(strArray[4])));
			}
			else if (strArray[4] == "x")
			{
				Console.WriteLine(Calculate3(int.Parse(strArray[0]), strArray[1], int.Parse(strArray[2])));
			}
		}

		internal static int Calculate1(int a, string op, int b)
		{
			if (op == "+")
			{
				return  b - a;
			}
			else
			{
				return  b + a;
			}
		}

		internal static int Calculate2(int a, string op, int b)
		{
			if (op == "+")
			{
				return b - a;
			}
			else
			{
				return a - b;
			}
		}

		internal static int Calculate3(int a,string op,int b)
		{
			if(op=="+")
            {
				return a + b;
			}
			else
			{
				return a - b;
			}
		}


	}
}

//受験結果 受験言語： C# 解答時間： 18分52秒 バイト数： 1093 Byte スコア： 100点  220107

//a op b = c
//・文字 a, op, b, "=" (半角等号), c がこの順に半角スペース区切りで与えられ、これらの並びが 1 つの問題を表します。
//　・op には足し算あるいは引き算を表す記号が入ります。
//　・a, b, c は "x" (英字小文字), "0", "1",..., "9" のうちいずれかで、"x" は空欄を表します。
//入力値最終行の末尾に改行が１つ入ります。
