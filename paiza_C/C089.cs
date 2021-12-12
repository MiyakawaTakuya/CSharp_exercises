using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
//C089:ストラックアウト

namespace paiza_C
{
    public class C089
    {
        internal static void test()
        {
            string[] ArrayData = Console.ReadLine().Trim().Split(' ');
            int H = int.Parse(ArrayData[0]);
            int W = int.Parse(ArrayData[1]);
            int[,] array_01 = new int[H, W];
            int[,] array_point = new int[H, W];
            int[,] array_x = new int[H, W];
            int h, w;
            int Sum = 0;

            //丸バツの代わりに1と0を代入して行って、後から各行列の値をかけて行って、合計値を出す方針(罰の場合は*0で0点になる)
            for (h = 0; h < H; h++)   //１行目、２行目、３行目...と順に処理していく
            {
                string S = Console.ReadLine();
                //string[] Array_h = Console.ReadLine().Trim().Split(' ');
                for (w = 0; w < W; w++)  //１列目、２列目、３列目...と順に処理していく
                {
                    if (S[w] == '○')
                    {
                        array_01[h, w] = 1;
                    }
                    else if(S[w] == '×')
                    {
                        array_01[h, w] = 0;
                    }
                }
            }

            //それぞれの座標に値を代入していく
            for (h = 0; h < H; h++)   //１行目、２行目、３行目...と順に処理していく
            {
                string[] Array_point = Console.ReadLine().Trim().Split(' ');
                for (w = 0; w < W; w++)  //１列目、２列目、３列目...と順に処理していく
                {
                    array_point[h,w] = int.Parse(Array_point[w]);
                }
            }

            //それぞれの座標に値をかけていく
            for (h = 0; h < H; h++)   //１行目、２行目、３行目...と順に処理していく
            {
                for (w = 0; w < W; w++)  //１列目、２列目、３列目...と順に処理していく
                {
                    array_x[h, w] = array_01[h, w] * array_point[h, w];
                    Sum += array_x[h, w];
                }
            }
            Console.WriteLine(Sum);
            //Console.WriteLine(array_x.Sum());
        }
    }
}

//まずは法則性をつかむ
//for (h = 0; h < H; h++)   //１行目、２行目、３行目...と順に処理していく
//{
//    for (w = 0; w < W; w++)  //１列目、２列目、３列目...と順に処理していく
//    {
//        array[0, w] = w + 1 + 0 * W;
//        array[2, w] = w + 1 + 1 * W;
//        array[3, w] = w + 1 + 2 * W;
//        array[4, w] = w + 1 + 3 * W;

//        array[W, w] = w + 1 + H * W;
//    }
//}