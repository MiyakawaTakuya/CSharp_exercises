// using System.Collections.Generic;
using System.Linq;
using System;
//C052:ゲームの画面

namespace paiza_C
{
    public class C052
    {
		//フィールド
		private static int H,W,dy,dx,sum;

		internal static void main()
		{
			//入力
			string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
			int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
			H = intArray[0];
			W = intArray[1];

			string[] strArray2 = Console.ReadLine().Trim().Split(' ');  //読み取り
			int[] intArray2 = strArray2.Select(int.Parse).ToArray();  //intへ変換
			dy = Math.Abs(intArray2[0]);
			dx = Math.Abs(intArray2[1]);
			sum = dy * W + dx * H - (dy * dx); 

			Console.WriteLine(sum);
		}
	}
}

//受験結果 受験言語： C# 解答時間： 13分57秒 バイト数： 587 Byte スコア： 100点

//H W
//dy dx
//・1 行目には、画面の縦方向の解像度 H、 横方向の解像度 W が整数でこの順に半角スペース区切りで与えられます。
//・2 行目には、 y 軸方向にスクロールする距離 dy、 x 軸方向にスクロールする距離 dx が整数でこの順に半角スペース区切りで与えられます。
//・入力は合計で 2 行となり、入力値最終行の末尾に改行が １ つ入ります。