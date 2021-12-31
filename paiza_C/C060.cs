using System;
using System.Linq;
//C060:辞書の作成

namespace paiza_C
{
    public class C060
    {
		//フィールド
		private static int N,K,P;
		private static string[,] dic;

		internal static void main()
		{
			string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
			int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
			N = intArray[0];
			K = intArray[1];
			P = intArray[2];
			string[] strArray2 = Console.ReadLine().Trim().Split(' ');  //読み取り
			Array.Sort(strArray2);  //戻り値はvoidになっている. 引数そのものを書き換える関数
			double all = Math.Ceiling((double)N / K); 
			dic = new string[(int)all, K];  //ページ数, 最大単語数
			for (int i = 0; i < (int)all; i++)
			{
				for (int j = 0; j < K; j++)
				{
					if (j + (i * K) < N) dic[i, j] = strArray2[j + (i * K)];  //string[]で値が入っていないところはnullになっている
				}
			}
			for (int k = 0; k < K; k++)
			{
				if (dic[P - 1, k] != null)
					Console.WriteLine(dic[P - 1, k]);
			}
		}
	}
}

//受験結果 受験言語： C# 解答時間： 54分6秒 バイト数： 838 Byte スコア： 58点  211231  正答率は100%
//入力は以下のフォーマットで与えられます。

//N K P
//s_1 s_2 ... s_N
//・1 行目に辞書に載せる単語の数を表す整数 N、1 ページに掲載する単語の数 K、調べたいページの番号 P が与えられます。
//・2 行目に N 個の文字列が半角スペース区切りで与えられます。i 番目 (1 ≦ i ≦ N) の文字列 s_i は辞書に載る i 番目の単語を表します。
//・入力は合計で 2 行となり、入力値最終行の末尾に改行が １ つ入ります。
