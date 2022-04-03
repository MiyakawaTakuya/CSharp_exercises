 using System.Collections.Generic;
using System.Linq;
using System;
//B024:格子を円で切り取る
//・1 ≦ r ≦ 1000
//r は0.00001 刻みで与えられる
//受験結果 受験言語： C# 解答時間： 117分49秒 バイト数： 970 Byte スコア： 52点  正答率100% 220403 



namespace paiza_C
{
    public class B024
    {
		private static Dictionary<int, int> pixels = new Dictionary<int, int>();
		private static List<int[]> filled = new List<int[]>();

		internal static void main()
		{
			////全体の1/4の円形で考える. xもyも正で扱える第一象限で考える。個数を出して最後に４倍して終わり。
			//円周が乗っかっているピクセルを算出していく x^2 + y^2 = r^2
			//x=1,x=2...x=int(r),x=r.でみていき接する点の左右のピクセルをListに格納していく. 最後にそれぞれの
			double R = double.Parse(Console.ReadLine());
			double R_R = R * R;
			int R_ceil = (int)Math.Ceiling(R);
			for (int x = 0; x < R_ceil; x++)
			{
				double y = Math.Sqrt(R_R - x * x);
				pixels[x+1] = (int)Math.Ceiling(y);
			}
			
			//円周上のピクセルを元に充填していく
			for (int x = 1; x <= R_ceil; x++) fill(x, pixels[x]);

			//最後に合計値を４倍
			Console.WriteLine(filled.Count()*4);
		}

		internal static void fill(int x,int Y)
		{
			for (int i = 1; i <= Y; i++) filled.Add(new int[2] { x, i });
		}
	}
}


