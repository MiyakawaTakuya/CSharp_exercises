using System;
using System.Linq;
//C014:ボールが入る箱

namespace paiza_C
{
    public class C014
    {
        internal static void test()
        {
            string[] ArrayData = Console.ReadLine().Trim().Split(' ');
            int n = int.Parse(ArrayData[0]);
            int r = int.Parse(ArrayData[1]);
            int min = 0; //各行の最小値を代入する
            int[] boxarray =new int[3];
            //int x, y, z;

            for (int i = 1; i <= n; i++)
            {
                string[] ArrayData_line = Console.ReadLine().Trim().Split(' ');
                boxarray[0] = int.Parse(ArrayData_line[0]);
                boxarray[1] = int.Parse(ArrayData_line[1]);
                boxarray[2] = int.Parse(ArrayData_line[2]);
                min = boxarray.Min();
                if(2 * r <= min)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

//n r　　　#箱の数n, ボールの半径r 表す整数
//h_1 w_1 d_1　　　#1個目の箱の高さ、幅、奥行きを表す整数
//h_2 w_2 d_2　　　#2個目の箱の高さ、幅、奥行きを表す整数
//...
//h_n w_n d_n　　　#n個目の箱の高さ、幅、奥行きを表す整数

//すべてのテストケースで以下の条件を満たします。

//・ 1 ≦ n ≦ 100
//・ 1 ≦ r ≦ 100
//・ 1 ≦ h_i, w_i, d_i ≦ 200

//4 2
//6 6 6
//4 6 4
//6 1 1
//4 4 4

//受験結果 受験言語： C# 解答時間： 17分50秒 バイト数： 832 Byte スコア： 100点  211208