using System;
using System.Collections.Generic;

//C040:【ロジサマコラボ問題】背比べ

namespace paiza_C
{
    public class C040
    {
        internal static void test()
        {
            int N = int.Parse(Console.ReadLine());
            double lowest = 100.0;
            double highest = 200.0;

            //まずは階数の配列を生成
            for (int i = 0; i < N; i++)
            {
                string[] ArrayData = Console.ReadLine().Trim().Split(' ');
                string c_i = ArrayData[0];
                double h_i = double.Parse(ArrayData[1]);

                //大きい時小さい時で代入していく先を切り替えていく
                if(c_i =="le" && highest > h_i)  //表示されている身長以下の時
                {
                    highest = h_i;
                }
                else if(c_i == "ge" && lowest < h_i)  //表示されている身長以上の時
                {
                    lowest = h_i;
                }
            }
            string low = string.Format("{0:F1}", lowest);  //小数点以下の表示桁数を指定するときはstringにしてFのあとの桁数を指定する。F0は0桁。F1は少数第一までとなる。
            string high = string.Format("{0:F1}", highest);

            Console.WriteLine(low + " " + high);  //小数点第一が表示されないことがある
        }
    }
}

//受験結果 受験言語： C# 解答時間： 44分10秒 バイト数： 968 Byte スコア： 70点  211213  正答率は100%


//入力は以下のフォーマットで与えられます。

//N
//c_1 h_1
//c_2 h_2
//...
//c_N h_N
//・1 行目には身長がわかっている子供の総数を表す整数 N が与えられます。
//・続く N 行のうち i 行目 (1 ≦ i ≦ N) には身長がわからない子供と i 番目の子供の身長比較結果を表す文字 c_i と i 番目の子供の身長 (cm) を表す小数 hi がこの順に半角スペース区切りで与えられます。
//　・身長がわからない子供の身長が h_i 以下のとき c_i は "le"、h_i 以上のとき "ge" となります。ただし h_i と同じ時は "le" となります。("le", "ge" はそれぞれ "less than or equal to", "greater than or equal to" の略で「〜以下」「〜以上」の意味)。
//・入力は合計で N + 1 行となり、入力最終行の末尾に改行が１つ入ります。

//すべてのテストケースにおいて、以下の条件をみたします。

//・2 ≦ N ≦ 100
//・各 i(1 ≦ i ≦ N) について
//・c_i は英字小文字で構成される文字列で、 "le", "ge" のいずれか
//・h_i は小数第 1 位までを含む小数
//・100 ≦ h_i ≦ 200
//・c1, c2, ..., c_N の中に "le" と "ge" は必ず 1 つ以上ずつ含まれる
//・c_i = "le" , c_j = "ge" である各 i, j (1 ≦ i, j ≦ N) について h_i ≧ h_j が成り立つ。すなわち、身長の大小関係について矛盾する条件は与えられない
