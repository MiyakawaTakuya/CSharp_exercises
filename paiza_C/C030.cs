using System.Collections.Generic;
using System.Linq;
using System;
//C030: 白にするか黒にするか
namespace paiza_C
{
    public class C030
    {
		//フィールド
		private static int H,W;

		internal static void main()
		{
			//初期化
			string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
			int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
			H = intArray[0];
			W = intArray[1];
			int[,] screen = new int[H,W];
			//入力  この際に２値化する関数を挟んで変換
			for (int i = 0; i < H; i++)
			{
				string[] strArray2 = Console.ReadLine().Trim().Split(' ');  
				int[] intArray2 = strArray2.Select(int.Parse).ToArray();
				for (int j = 0; j < W; j++)
				{
					screen[i, j] = binarization(intArray2[j]);
				}
			}
            ////出力 その1
            //for (int i = 0; i < H; i++)
            //{
            //	for (int j = 0; j < W; j++)
            //	{
            //		if (j != W - 1) { Console.Write(screen[i, j] + " "); }
            //		else if (j == W - 1) { Console.Write(screen[i, j]); }
            //	}
            //	Console.WriteLine("");

            //}
            //出力 その2
    //        for (int i = 0; i < H; i++)
    //        {
				//for (int j = 0; j < W; j++)
    //            {
				//	var seg = new ArraySegment<int>(screen[i], i, W);
				//	screen[i].WriteLine(string.Join(", ", seg));
				//}
    //            Console.WriteLine("");

    //        }

        }

		internal static int binarization(int a)
		{
			if (a >= 128){ return 1; }
			else { return 0; }
		}
	}
}

//受験結果 受験言語： C# 解答時間： 18分32秒 バイト数： 972 Byte スコア： 100点  220104  

//問題集計
//難易度： 1539 ±3
//受験者数： 18,524人
//正解率： 39.7％
//平均解答時間： 18分59秒
//平均スコア： 70.36点

//今回は単に表示するだけなので、単純に以下の条件を用いて二値画像に変換します。
//・画素値が 128 以上: 1(白)
//・画素値が 127 以下: 0(黒)

//H W
//P_{1, 1} P_
//{ 1, 2}
//... P_
//{ 1, W}
//P_
//{ 2, 1}
//P_
//{ 2, 2}
//... P_
//{ 2, W}
//...
//P_
//{ H, 1}
//P_
//{ H, 2}
//... P_
//{ H, W}

//・1行目に画像の縦横のサイズ H, W が空白区切りで与えられます。
//・続く H 行のうち、 i 行目 (1 ≦ i ≦ H) には W 個の整数値が半角スペース区切りで与えられます。
//　　i 行目の j 番目 (1 ≦ i ≦ W) の整数値 P_ { i, j }
//は画像の i 行 j 列目 の画素値を表します。
//・入力は合計で H + 1 行であり、入力値最終行の末尾に改行が1つ入ります。