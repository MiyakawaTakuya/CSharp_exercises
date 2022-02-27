// using System.Collections.Generic;
using System.Linq;
using System;
//B016:ここはどこ？

namespace paiza_C
{
    public class B016
    {
        private static int w,h,n;
        private static int[] nowPos;

		internal static void main()
		{
            ////入力
            string[] strArray = Console.ReadLine().Trim().Split(' ');
            int[] intArray = strArray.Select(int.Parse).ToArray();
            w = intArray[0];
            h = intArray[1];
            n = intArray[2];
            string[] strArray2 = Console.ReadLine().Trim().Split(' ');
            nowPos = strArray2.Select(int.Parse).ToArray();

            for (int i = 0; i < n; i++)
            {
                string[] strArray3 = Console.ReadLine().Trim().Split(' ');
                string dir = strArray3[0];
                int m = int.Parse(strArray3[1]);
                move(dir, m);
            }

            Console.WriteLine(nowPos[0] + " " + nowPos[1]);
            //Console.WriteLine((-2)%7);
        }

		internal static void move(string dir,int mov)
		{
            if (dir == "U")
            {
                nowPos[1] = (nowPos[1]+ mov) % h;
            }
            else if (dir == "D")
            {
                if ((nowPos[1] - mov) % h >= 0) nowPos[1] = (nowPos[1] - mov) % h;
                else nowPos[1] = h + (nowPos[1] - mov) % h;
            }
            else if (dir == "R")
            {
                nowPos[0] = (nowPos[0] + mov) % w;
            }
            else if (dir == "L")
            {
                if ((nowPos[0] - mov) % w >= 0) nowPos[0] = (nowPos[0] - mov) % w;
                else nowPos[0] = w + (nowPos[0] - mov) % w;
            }

        }



	}
}

//w h n
//x y
//dir_1 m_1
//dir_2 m_2
//・・・
//dir_n m_n
//1 行目には、マップの横幅 w 、縦幅 h 、移動ログの個数 n が与えられます。
//2 行目には、初期位置 x, yが与えられます。
//3 行目から n+2 行目までは、移動ログが与えられます。 dir_i は移動した向き、 m_i は移動した距離を表します。
//dir_i は "U", "D", "R", "L" のいずれかで与えられ、 それぞれ、上、下、右、左への移動を表します。