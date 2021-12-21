using System;
using System.Collections.Generic;
using System.Linq;
//C025:ファックスの用紙回収

namespace paiza_C
{
    public class C025
    {
        internal static void test()
        {
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            var hourly = new Dictionary<int, int>()  //時間ごとの合計枚数を格納する配列
            {{0,0},{1,0},{2,0},{3,0},{4,0},{5,0},{6,0},{7,0},{8,0},{9,0},{10,0},{11,0},{12,0},{13,0},{14,0},{15,0},{16,0},{17,0},{18,0},{19,0},{20,0},{21,0},{22,0},{23,0}};
            int getSum = 0;  //取りに行く回数をカウントする

            //一通り、時間ごとの箱に枚数を代入していく
            for (int i = 0; i < N; i++)
            {
                string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
                int[] intArray = strArray.Select(int.Parse).ToArray();
                hourly[intArray[0]] += intArray[2];  
            }

            //時間ごとに取りに行かないといけない回数をカウントする
            for (int i = 0; i <= 23; i++)
            {
                if(hourly[i] != 0 && hourly[i] % M !=0 )
                {
                    getSum += hourly[i] / M + 1;
                }
                else if (hourly[i] != 0 && hourly[i] % M == 0)
                {
                    getSum += hourly[i] / M ;
                }
            }
            Console.WriteLine(getSum);

        }
    }
}

//受験結果 受験言語： C# 解答時間： 30分33秒 バイト数： 1262 Byte スコア： 87点  211221  全問正解

//あなたが 1 回で運べる紙の最大枚数 M、 今日 1 日にファックスが届く回数 N、 また、その N 回それぞれについて、いつ何枚の紙が届くのかという情報が与えられます。
//この情報を使って、 今日、ファックス機に何回紙を取りに行く必要があるのかを求めて下さい。
//・1 ≦ M ≦ 100
//・1 ≦ N ≦ 100
//・0 ≦ x_i ≦ 23(1 ≦ i ≦ N)
//・0 ≦ y_i ≦ 59(1 ≦ i ≦ N)
//・0 ≦ c_i ≦ 100(1 ≦ i ≦ N)
