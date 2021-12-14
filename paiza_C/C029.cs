using System;
using System.Collections.Generic;
using System.Linq;
//C029:旅行の計画

namespace paiza_C
{
    public class C029
    {
        internal static void test()
        {
            string[] ArrayData = Console.ReadLine().Trim().Split(' ');
            int M = int.Parse(ArrayData[0]);
            int N = int.Parse(ArrayData[1]);
            int s = 0;
            int e = 0;
            //int[,] array;  //日付と降水確率がセットになった２次元配列を用意してみる
            int[] array_s;  //日付の配列を用意してみる
            int[] array_e;  //降水確率の配列を用意してみる
            var list_s = new List<int>();
            var list_e = new List<int>();

            for (int i = 1; i <= M; i++)
            {
                string[] ArrayData2 = Console.ReadLine().Trim().Split(' ');
                s = int.Parse(ArrayData2[0]);
                e = int.Parse(ArrayData2[1]);
                list_s.Add(s);  //日付を代入
                list_e.Add(e);  //降水確率を代入
            }
            array_s = list_s.ToArray();  //最後に配列として整える
            array_e = list_e.ToArray();  //最後に配列として整える
            double ave = 0;  //降水確率の平均値を用意
            int sum = 0; //降水確率の平均値を出すときの合計値
            double minAve = 100;  //降水確率の平均値の最小値
            //int[] aveArray;  //降水確率の平均配列
            var listAve = new List<double>();
            double[] arrayAve;

            for (int m = 1; m <= M - N + 1; m++)  //日程のパターンは(M - N + 1)回までしかない
            {
                for (int n = 0; n < N; n++)
                {
                    sum += array_e[n];
                }
                ave = sum / N;
                listAve.Add(ave);  //降水確率を代入
                if (minAve > ave)  //一番小さい降水確率の平均値を更新していく
                {
                    minAve = ave;
                }
                sum = 0; //リセット
                ave = 0;  //リセット
            }
            arrayAve = listAve.ToArray();  //最後に配列として整える

            for (int l = 0 ; l <= arrayAve.Length; l++)
            {
                if (minAve == arrayAve[l])
                {
                    Console.WriteLine(array_s[l] + " "+ arrayAve[l]);  //最小値の降水確率と一致したときに掃き出す
                }
            }
        }
    }
}


//あなたは連休に N 日間の旅行にいく計画を立てています。降水確率の予報を見て、 N 日間の降水確率の平均が最も低くなる日程を選びます。
//このような形で連休の日数、旅行の日数および各日付の降水確率が与えられたとき、 降水確率の平均が最も低くなる日程を求めてください。

//なおこのような日程が複数あった場合はそのうち最も早いものを出力してください。

//M N
//d_1 r_1
//d_2 r_2
//...
//d_M r_M

//・1 行目には連休の日数を表す整数 M、旅行の日数を表す整数 N が与えられます。
//・続く M 行のうち i 行目 (1 ≦ i ≦ M) には連休の各日の日付を表す整数 d_i、降水確率を表す整数 r_i がこの順に半角スペース区切りで与えられます。
//・入力は合計で M + 1 行となり、入力値最終行の末尾に改行が１つ入ります。
//N 日間の降水確率の平均が最も低くなる日程の最初の日付 s と最後の日付 e を
//s e
//のように半角スペース区切りで出力してください。このような日程が複数あった場合はそのうち最も早いものを出力してください。

//受験結果 受験言語： C# 解答時間： 61分36秒 バイト数： 2202 Byte スコア： 0点  211208 タイムアウト...！