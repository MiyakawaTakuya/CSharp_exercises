// using System.Collections.Generic;
using System.Linq;
using System;
//五目並べ

namespace paiza_C.Questions
{
    public class toB_gomoku
    {
		//フィールド
		private static string winner;
        private static string[,] grid = new string[5 , 5];

        internal static void main()
		{
            //入力
            for (int i = 0; i < 5; i++)
            {
                string line = Console.ReadLine();
                for (int j = 0; j < 5; j++)
                {
                    grid[i, j] = line.Substring(j, 1);
                }
            }

            //判定
            judgeW(grid);
            judgeH(grid);
            judgeCross(grid);

            //出力
            if (winner != null)
            {
                Console.WriteLine(winner);
            }
            else if (winner == null)
            {
                Console.WriteLine("D");
            }
        }

        //斜め方向が揃っているかどうかを判定する関数
        internal static void judgeCross(string[,] str)
        {
            if (str[0, 0] == str[1, 1] && str[1, 1] == str[2, 2] && str[2, 2] == str[3, 3] && str[3, 3] == str[4, 4] && str[0, 0] != ".")
            {
                winner = str[0, 0];
            }
            else if (str[0, 4] == str[1, 3] && str[1, 3] == str[2, 2] && str[2, 2] == str[3, 1] && str[3, 1] == str[4, 0] && str[0, 4] != ".")
            {
                winner = str[0, 0];
            }
        }
        //縦方向が揃っているかどうかの判定する関数
        internal static void judgeH(string[,] str)
        {
            for (int i = 0; i < 5; i++)
            {
                if (str[0,i] == str[1, i] && str[1, i] == str[2, i] && str[2, i] == str[3, i] && str[3, i] == str[4, i] && str[0, i] != ".")
                {
                    winner = str[0, i];
                }
            }
        }

        //横方向が揃っているかどうかの判定する関数
        internal static void judgeW(string[,] str)
        {
            for (int i = 0; i < 5; i++)
            {
                if (str[i, 0] == str[i, 1] && str[i, 1] == str[i, 2] && str[i, 2] == str[i, 3] && str[i, 3] == str[i, 4] && str[i, 0] != ".")
                {
                    winner = str[i, 0];
                }
            }

        }

	}
}
