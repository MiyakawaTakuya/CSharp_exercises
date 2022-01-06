 //using System.Collections.Generic;
using System.Linq;
using System;
//C074:【クロニクルコラボ問題】文章サイズ変更

namespace paiza_C
{
    public class C074
    {
		//フィールド
		private static int H,W,X;
		private static string sum;

		internal static void main()
		{
			//入力  一つの１次元配列にする
			string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
			int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
			H = intArray[0];
			W = intArray[1];
			X = intArray[2];
			for (int i = 0; i < H; i++)
			{
				sum += Console.ReadLine();
			}
			part_Write(sum);
		}

		//文字列の一部を書き出す関数
		internal static void part_Write(string str)
		{
			for(int j = 0; j < H * W / X; j++)
			{
				string c = str.Substring(j * X , X);
				Console.WriteLine(c);
			}
			//余が発生する時の最後の行  ピッタリ割れる時はLengthに0が入って処理されない
			string d = str.Substring((H * W) - (H * W) % X, (H * W) % X);  
			Console.WriteLine(d);
		}
	}
}

//受験結果 受験言語： C# 解答時間： 47分58秒 バイト数： 834 Byte スコア： 71点  正答率 100%
//問題集計 受験者数： 9,984人 正解率： 86.75％ 平均解答時間： 22分18秒 平均スコア： 73.16点
//難易度:1505

//H W X
//s_1
//s_2
//...
//s_H
//・1 行目にそれぞれ変更前の文章表示部分の高さ、横幅を表す整数 H, W と、変更後の文章表示部分の横幅を表す整数 X がこの順で半角スペース区切りで与えられます。
//・続く H 行のうちの i 行目 (1 ≦ i ≦ H) には 小文字英字、大文字英字、及び "#", "." からなる長さ W の文字列 s_i が与えられます。
//・入力は合計で H + 1 行となり、入力値最終行の末尾に改行が １ つ入ります。