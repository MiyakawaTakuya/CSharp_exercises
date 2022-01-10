using System.Collections.Generic;
using System.Linq;
using System;
//C073:うさぎとかめ
namespace paiza_C
{
    public class C073
    {
		//フィールド
		private static int L,u,a,b,v;
		private static double goalK_t;

		internal static void main()
		{
			//入力
			L = int.Parse(Console.ReadLine());
			string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
			int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
			u = intArray[0];
			a = intArray[1];
			b = intArray[2];
			v = int.Parse(Console.ReadLine());

			//カメのゴールタイム
			goalK_t = L * v;
			//うさぎのゴール時間を求める
			int shou = L / u;
			int amari = L % u;
			double usagiPos = 0;
			double usagiTime = 0;
		    for (int i = 0; i < shou; i++)  //割り切れる分だけ先に時間を計算
		    {
		    	usagiPos += a / u;
		    	usagiTime += a * u;
		    	if (usagiPos < L)
		    	{
		    		usagiTime += b;
		    	}
		    }
			if(amari != 0)
            {
				usagiTime += (L- usagiPos) * u;
			}

			//出力
			if (usagiTime < goalK_t)
            {
				Console.WriteLine("USAGI");
			}
			else if(usagiTime > goalK_t)
            {
				Console.WriteLine("KAME");
			}
			else if (usagiTime == goalK_t)
			{
				Console.WriteLine("DRAW");
			}
		}
	}
}
//受験結果 受験言語： C# 解答時間： 58分24秒 バイト数： 1103 Byte スコア： 6点 正答率３割くらい...涙


//L
//u a b
//v
//・1 行目に、2 匹が走る距離を表す整数 L が与えられます。
//・2 行目に、うさぎの 1 km を走る時間を表す整数 u、問題文中のハンデを表す整数 a, b がこの順で半角スペース区切りで与えられます。
//・3 行目に、かめの 1 km を走る時間を表す整数 v が与えられます。
//・入力は合計で 3 行となり、入力値最終行の末尾に改行が 1 つ入ります。
//・うさぎは 1 km を u 分、という一定の速さで走るが、a km 走るごとに b 分の休憩を取らなければならない
//・かめは 1 km を v 分、という一定の速さで走り続ける
