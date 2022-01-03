 using System.Collections.Generic;
 using System.Linq;
using System;
//C093:【キャンペーン問題】下桁ルール
namespace paiza_C
{
	public static class C093
	{
		private static int Bob_p, Alice_p;

		internal static void main()
		{
			string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
			Bob_p = calculateNum(strArray[0]);
			Alice_p = calculateNum(strArray[1]);
			if(Math.Max(Bob_p, Alice_p) == Bob_p)
            {
				Console.WriteLine("Bob");
			}
			else if (Math.Max(Bob_p, Alice_p) == Alice_p)
			{
				Console.WriteLine("Alice"); 
			}
		}

		internal static int calculateNum(string a)
		{
			//2文字だったら分割してintに変換してたす
			if (a.Length == 1)
			{
				return int.Parse(a);
			}
			else if (a.Length == 2)
			{
				int[] sumsum = MySplit(a);
				int number = sumsum[0] + sumsum[1];
				if (number.ToString().Length == 1)
                {
					return number;
                }
				else if (number.ToString().Length == 2)
                {
					int[] arr2 = MySplit(number.ToString());
					return arr2[1];
				}		
			}
			else if (a.Length == 3) //100
			{
				return 1;
			}
			return 0;
		}

		internal static int[] MySplit(string str)
		{
			char[] charArr = str.ToCharArray();
			int[] arry = { int.Parse(charArr[0].ToString()), int.Parse(charArr[1].ToString()) };
			return arry;
		}
	}
}

//受験結果 受験言語： C# 解答時間： 59分48秒 バイト数： 1327 Byte スコア： 51点  正解率100%
//型変換のオンパレード

//入力は以下のフォーマットで与えられます。
//X Y
//・ボブの期末テストの点数を表す整数 X とアリスの期末テストの点数を表す整数 Y がこの順で入力されます。
//・入力は 1 行となり、末尾に改行を１つ含みます。
//0 ≦ X, Y ≦ 100
