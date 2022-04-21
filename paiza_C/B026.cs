using System.Collections.Generic;
using System.Linq;
using System;
//B026:自動販売機  20220421
//問題集計 難易度： 2183 ±11 受験者数： 4,940人 正解率： 33.04％ 解答時間中央値： 49分45秒 平均スコア： 27.26点
//受験結果 受験言語： C# 解答時間： 97分42秒 バイト数： 2321 Byte スコア： 64点 正答率100%

namespace paiza_C
{
    public class B026
    {
		private static VendingMachine VM;

		private class VendingMachine
		{
			internal VendingMachine(int a, int b, int c, int d)
			{
				c_500 = a;
				c_100 = b;
				c_50 = c;
				c_10 = d;
			}
			internal int c_500 { get; set; }
			internal int c_100 { get; set; }
			internal int c_50 { get; set; }
			internal int c_10 { get; set; }

			public static string returnChange(int price,int a, int b, int c, int d)
			{
				int change = a * 500 + b * 100 + c * 50 + d * 10 - price; //500-130=370
				int tmp=0,r_500=0,r_100=0,r_50=0,r_10=0;
				if (change >= 500 && VM.c_500 != 0) {
					change -= 500;
					r_500 += 1;
				}
				if (change >= 100 && VM.c_100 != 0)
                {
					tmp = change / 100;//370 →3
					if(VM.c_100 >= tmp)
                    {
						change -= tmp*100;
						r_100 += tmp;
					}
					else
					{
						change -= VM.c_100 * 100;
						r_100 += VM.c_100;
					}
				}
				if (change >= 50 && VM.c_50 != 0)
				{
					tmp = change / 50;//70 →1
					if (VM.c_50 >= tmp)
					{
						change -= tmp * 50;
						r_50 += tmp;
					}
					else
					{
						change -= VM.c_50 * 50;
						r_50 += VM.c_50;
					}
				}
				if (change >= 10 && VM.c_10 != 0)
				{
					tmp = change / 10;//20 →2
					if (VM.c_10 >= tmp)
					{
						change -= tmp * 10;
						r_10 += tmp;
					}
					else
					{
						change -= VM.c_10 * 10;
						r_10 += VM.c_10;
					}
				}
				if (r_50 * 50 + r_10 * 10 >= 100 || change != 0)
				{
					return "impossible";
				}
				else
				{
					VM.c_500 = VM.c_500 - r_500+a;
					VM.c_100 = VM.c_100 - r_100+b;
					VM.c_50 = VM.c_50 - r_50+c;
					VM.c_10 = VM.c_10 - r_10+d;
					return r_500 + " " + r_100 + " " + r_50 + " " + r_10;
				}
			}
		}

		internal static void main()
		{
			string[] strArray = Console.ReadLine().Trim().Split(' ');
			int[] intArray = strArray.Select(int.Parse).ToArray();
			VM = new VendingMachine(intArray[0], intArray[1], intArray[2], intArray[3]);
			int N = int.Parse(Console.ReadLine());
			for (int i = 0; i < N; i++)
			{
				string[] strArray_ = Console.ReadLine().Trim().Split(' ');
				int[] intArray_ = strArray_.Select(int.Parse).ToArray();
				Console.WriteLine(VendingMachine.returnChange(intArray_[0], intArray_[1], intArray_[2], intArray_[3], intArray_[4]));
			}
		}
	}
}

//入力値
//v_500 v_100 v_50 v_10
//N
//b_1 x_{1, 500} x_{1, 100} x_{1, 50} x_{1, 10}
//b_2 x_{2, 500} x_{2, 100} x_{2, 50} x_{2, 10}
//...
//b_N x_{N, 500} x_{N, 100} x_{N, 50} x_{N, 10}
//入力例
//1 4 1 20
//3
//130 1 0 0 0
//150 0 2 0 0
//100 1 0 0 0
//出力例
//0 3 1 2
//0 0 0 5
//impossible

//これらの機能は、以下のルールに従って動作します。
//・おつりは「投入金額 - 購入金額」で計算されます。
//・おつりは自動販売機の内部にある硬貨から、枚数が最も少なくなるように選んだ硬貨の組合せで返却します。
//・ただし、50円硬貨、10円硬貨を組み合わせる、もしくはどちらか一方のみを使うことによって、おつりの内の100円分以上を返却することは許されません。
//・また、おつりを返却することができない場合は購入不可能となり、それを知らせた上で投入された硬貨を全て返却します。
//・自動販売機の内部では、まずおつりとして返却された硬貨がなくなり、その後に投入された硬貨が貯まります。
