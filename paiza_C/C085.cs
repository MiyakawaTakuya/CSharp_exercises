 using System.Collections.Generic;
using System.Linq;
using System;
//C085:壊れかけのキーボード

namespace paiza_C
{
    public class C085
    {
		//フィールド
		private static int i = 0;

		internal static void main()
		{
			//入力
			var dic = new Dictionary<string, int>()
			{ {"a",0},{"b",0},{"c",0},{"d",0},{"e",0},{"f",0},{"g",0},{"h",0},{"i",0},{"j",0},{"k",0},{"l",0},{"m",0},{"n",0},{"o",0},{"p",0},{"q",0},{"r",0},{"s",0},{"t",0},{"u",0},{"v",0},{"w",0},{"x",0},{"y",0},{"z",0} };
			List<string> keyList = new List<string>(dic.Keys);
			string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
			int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
            foreach (string key in keyList)
            {
                dic[key] = intArray[i];
				i++;
            }
            string str = Console.ReadLine();

			for(int j = 0 ; j < str.Length; j++)
			{
                if (dic[str.Substring(j, 1)] != 0)
                {
					Console.Write(str.Substring(j, 1));
					dic[str.Substring(j, 1)]--;
				}
				//else if (dic[str.Substring(j, 1)] == 0)
				//{
				//}
			}
			Console.WriteLine("");
		}

		internal static void Do()
		{

		}
	}
}
//受験結果 受験言語： C# 解答時間： 38分16秒 バイト数： 1047 Byte スコア： 78点  220108 正答率は１００

//t_1 t_2 ... t_26
//S
//・1 行目にキーの耐久度を表す整数 t_i (1 ≦ i ≦ 26) が空白区切りで与えられます。
//　i 番目の数字は、アルファベットの i 番目の文字のキーの耐久度を表します。
//・続く 2 行目に入力される文字列 S が与えられます。
