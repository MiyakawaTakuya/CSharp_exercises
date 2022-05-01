// using System.Collections.Generic;
using System.Linq;
using System;
//B030:氷のダンジョン
//受験結果 受験言語： C# 解答時間： 69分22秒 バイト数： 2312 Byte スコア： 82点  220501 正答率100

namespace paiza_C
{
    public class B030
    {
		private static int H,W;
		private static string[,] map;
		private static Position nowPos;
		private class Position
		{
			internal Position(int x,int y)
			{
				X = x;
				Y = y;
			}
			internal int X { get; set; }
			internal int Y { get; set; }
			internal static void Move(string dir)
			{
				if (dir == "U" )
				{
					if(nowPos.Y == 1) //上が壁だったら
                    {
						//何も移動しない
                    }
					else if (map[nowPos.Y - 2, nowPos.X - 1] == "#") //氷だったら
					{
						nowPos.Y--;
						Move(dir);
					}
					else //土だったら
					{
						nowPos.Y--; //移動して終わり
					}
				}
				else if (dir == "R")
				{
					if (nowPos.X == W) //壁だったら
					{
						//何も移動しない
					}
					else if (map[nowPos.Y - 1, nowPos.X] == "#") //氷だったら
					{
						nowPos.X++;
						Move(dir);
					}
					else //土だったら
					{
						nowPos.X++; //移動して終わり
					}
				}
				else if (dir == "D")
				{
					if (nowPos.Y == H) //壁だったら
					{
						//何も移動しない
					}
					else if (map[nowPos.Y, nowPos.X - 1] == "#") //氷だったら
					{
						nowPos.Y++;
						Move(dir);
					}
					else //土だったら
					{
						nowPos.Y++; //移動して終わり
					}
				}
				else if (dir == "L")
				{
					if (nowPos.X == 1) //壁だったら
					{
						//何も移動しない
					}
					else if (map[nowPos.Y - 1, nowPos.X - 2] == "#") //氷だったら
					{
						nowPos.X--;
						Move(dir);
					}
					else //土だったら
					{
						nowPos.X--; //移動して終わり
					}
				}
			}
		}

		internal static void main()
		{
			//input
			string[] strArray = Console.ReadLine().Trim().Split(' ');
			int[] intArray = strArray.Select(int.Parse).ToArray();
			H = intArray[0];
			W = intArray[1];
			map = new string[H,W]; //H(y),W(x)
			for (int i = 0; i < H; i++)
			{
				string str = Console.ReadLine();
				for (int j = 0; j < W; j++)
				{
					map[i, j] = str[j].ToString();
				}
			}
			strArray = Console.ReadLine().Trim().Split(' ');
			intArray = strArray.Select(int.Parse).ToArray();
			nowPos = new Position(intArray[0], intArray[1]);

			//move
			int N = int.Parse(Console.ReadLine());
			for (int i = 0; i < N; i++)
			{
				Position.Move(Console.ReadLine());
			}

			//output
			Console.WriteLine(nowPos.X + " " + nowPos.Y);
		}

	 //   static void addXArr(string str,int y,int W)
		//{
  //          for (int j=0;j<W;j++)
  //          {
		//		map[y,j]= str[j].ToString();
		//	}
		//}
	}
}

//入力値
//5 5
//.###.
//#.#.#
//##..#
//..##.
//##..#
//3 3
//5
//U
//R
//D
//L
//U

//”#” であれば氷の床、”.” であれば土の床

//各添字の範囲は 1 ≦ i ≦ H, 1 ≦ j ≦ W, 1 ≦ k ≦ N とする。
//・H, W, s_x, s_y, N は整数
//・g_i は半角記号 ”#” および ”.” で構成される文字列
//・d_k は英字大文字で ”U”, ”R”, ”D”, ”L” のいずれか
//・3 ≦ H, W ≦ 100
//・(g_i の長さ) = W
//・1 ≦ s_x ≦ W
//・1 ≦ s_y ≦ H
//・g_s_y の s_x 番目の文字は必ず ”.” である (最初にいるマスは必ず土の床である)
//・1 ≦ N ≦ 100
