using System.Collections.Generic;
using System.Linq;
using System;
//B014:3Dプリンタ
//受験結果 受験言語： C# 解答時間： 52分32秒 バイト数： 1193 Byte スコア： 93点  正答率100%  220212

namespace paiza_C
{
    public class B014
    {
		private static int X,Y,Z;
		private static int[,] vertical_X;

		internal static void main()
		{
			//入力
			string[] strArray = Console.ReadLine().Trim().Split(' '); 
			int[] intArray = strArray.Select(int.Parse).ToArray();
			X = intArray[0];
			Y = intArray[1];
			Z = intArray[2];
			vertical_X = new int[Z,Y];  //縦方向がZ, 横方向がYになるので

			for (int z = 0; z < Z; z++)
			{
				for (int x = 0; x < X; x++)
				{
					string str = Console.ReadLine();
					count_sharp(str, z);
				}
				string _ = Console.ReadLine();  //--を受け取る
			}
			out_2DArr();
		}

		internal static void count_sharp(string str,int z)
		{
			char[] chararray = str.ToCharArray();
			int now_z = Z - z - 1;
			for (int y = 0; y < Y; y++)
			{
                if (chararray[y]=='#')
                {
					vertical_X[now_z, y] += 1; 
				}
			}
		}

		internal static void out_2DArr()
		{
			for (int z = 0; z < Z; z++)
			{
				for (int y = 0; y < Y; y++)
				{
					if(vertical_X[z, y] > 0)
                    {
						Console.Write("#");
					}
                    else
                    {
						Console.Write(".");
					}
				}
				Console.WriteLine("");
			}
			
		}

	}
}



//入力は以下のフォーマットで与えられます。
//X Y Z #奥行き X, 横幅 Y, 高さ Z
//(1,1,1) (1, 2, 1)... (1, Y, 1) #奥行き1,高さ1の横幅1からYまでのセルの状態
//(2, 1, 1)(2, 2, 1)... (2, Y, 1) #奥行き2,高さ1の横幅1からYまでのセルの状態
//...
//(X, 1, 1)(X, 2, 1)... (X, Y, 1) #奥行きX,高さ1の横幅1からYまでのセルの状態
//-- #区切り記号 区切り記号ごとに高さZが増えていく
//(1, 1, 2)(1, 2, 2)... (1, Y, 2) #奥行き1,高さ2の横幅1からYまでのセルの状態
//(2, 1, 2)(2, 2, 2)... (2, Y, 2) #奥行き2,高さ2の横幅1からYまでのセルの状態
//...
//(X, 1, 2)(X, 2, 2)... (X, Y, 2) #奥行きX,高さ2の横幅1からYまでのセルの状態
//--...
//--
//(1, 1, Z)(1, 2, Z)... (1, Y, Z)
//  (2, 1, Z)(2, 2, Z)... (2, Y, Z)...
//(X, 1, Z)(X, 2, Z)... (X, Y, Z)
//  --
//ここで、X は立体の奥行きを、Y は立体の横幅を、Z は立体の高さを表す整数です。 入力の 2 行目以降は、ある立体のデータを表しています。
//各 (x, y, z) は '#' または '.' からなる一文字で、この文字が '#' のときはセル(x, y, z) が立体に含まれることを、'.' のときはセル(x, y, z) が立体に含まれないことを意味します。(1 ≦ x ≦ X, 1 ≦ y ≦ Y, 1 ≦ z ≦ Z)

//入力には、X 行ごとに区切り記号 "--" が入ることに注意してください。また、二つのセル (x, y, z) と(x, y + 1, z) の間には、実際には空白文字は入っていないことに注意してください。(以下の入力例を参照)

//出力例1
//##.
//##.
//###