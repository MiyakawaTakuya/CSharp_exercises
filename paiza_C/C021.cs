using System;
using System.Linq;

//C021:暴風域にいますか？
namespace paiza_C
{
    public class C021
    {
		private static int xc,yc,r_1,r_2,n,x,y,inside,outside;

		internal static void main()
		{
			string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
			int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
			xc = intArray[0];
			yc = intArray[1];
			r_1 = intArray[2];
			r_2 = intArray[3];
			inside = r_1 * r_1;
			outside = r_2 * r_2;
			n = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				string[] strArray2 = Console.ReadLine().Trim().Split(' ');
				int[] intArray2 = strArray2.Select(int.Parse).ToArray();
				x = intArray2[0];
				y = intArray2[1];
				if (judge(x, y))
				{
					Console.WriteLine("yes");
				}
				else
				{
					Console.WriteLine("no");
				}
			}
		}

		internal static bool judge(int a,int b)
		{
			if (inside <= (a - xc) * (a - xc) + (b - yc) * (b - yc) && (a - xc) * (a - xc) + (b - yc) * (b - yc) <= outside)
			{ return true; }
			else
			{ return false; }
		}
	}
}

//受験結果 受験言語： C# 獲得ランク： Cランク スコア： 100点
//if文を省略式で書いていたらpaizaエラーで最初０点とってしまった.

//入力は以下のフォーマットで与えられます。
//xc yc r_1 r_2
//n
//x_1 y_1
//x_2 y_2
//...
//x_n y_n
//ここで、xc, yc, r_1, r_2 問題文で説明された変数で、すべて整数です。
//n は与えられる人の数を表す整数で、x_i, y_i は i (1 ≦ i ≦ n) 番目の人の座標を表す整数です。