 using System.Collections.Generic;
using System.Linq;
using System;
//C053: カードの合計

namespace paiza_C
{
    public class C053
    {
		//フィールド
		private static int x10 = 1; 

		internal static void main()
		{
			int N = int.Parse(Console.ReadLine());
			string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
			List<string> card = new List<string>(strArray); //リストに変換

			//x10を含んでいるかチェック 含んでいたら削除 x10に10代入
			check10(card);
			//0を含んでいるかチェック 含んでいたらmaxを0に
			List<int> intCard = card.ConvertAll(int.Parse);
			check0(intCard);
			//合計を算出
			Console.WriteLine(intCard.Sum() * x10);
		}

		internal static List<string> check10(List<string> ca)
		{
			if(ca.Contains("x10"))
            {
				ca.Remove("x10");
				x10 = 10;
			}
			return ca;
		}
		internal static List<int> check0(List<int> ca)
		{
			if (ca.Contains(0))
			{
				ca.Remove(ca.Max());
			}
			return ca;
		}
	}
}
//受験結果 受験言語： C# 解答時間： 40分58秒 バイト数： 855 Byte スコア： 74点  220101  正答率100%