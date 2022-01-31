using System.Collections.Generic;
using System.Linq;
using System;
//B011: 名刺バインダー管理

namespace paiza_C
{
    public class B011
    {
		private static int n,m,l,amari,uraNum;

		internal static void main()
		{
			//入力
			string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
			int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
			n = intArray[0];
			m = intArray[1];

			//商と余りを出して、バインダーのどの位置にいるかを把握する
			//l = m / (2 * n);     
			amari = m % (2 * n);    //あまりが０だったらそのバインダーの最終に位置する  あまりの数が何番目に位置するかを示す
			//int firstNum = l * 2 * n + 1;
			//int lastNum = firstNum + 2 * n - 1;
            if (amari == 0)  //mがバインダーの最後の数
            {
				uraNum = m - 2 * n + 1;  //そのバインダーの最初の数  
			}
            else if(amari <= n && amari != 0)  //mがバインダーの前半の時(amariがn以下の時)
			{
				uraNum = m + 2 * (n - (amari - 1)) - 1;
            }
            else  //mがバインダーの後半にいる時
            {
				uraNum = m - 2 * (n - (2 * n -amari)) + 1;
			}
			//出力
			Console.WriteLine(uraNum);
		}
	}
}
//受験結果 受験言語： C# 解答時間： 76分23秒 バイト数： 936 Byte スコア： 78点  220131  全問正解
//1つのポケットには、2枚の名刺が背中合わせに入っており、１枚のファイルで表と裏の両面から名刺を眺めることができます。
//名刺の番号mが与えられるので、その名刺の裏側の名刺の番号を表示するプログラムを作成してください
