using System;
using System.Collections.Generic;
using System.Linq;
//C046:書籍購入費ランキング

namespace paiza_C
{
    public class C046
    {
        internal static void test()
        {
            int N = int.Parse(Console.ReadLine());
            string[] ArrayData = Console.ReadLine().Trim().Split(' ');
            var member = new Dictionary<string, int>();  //名前と金額の合計を入れる箱
            for (int i = 0; i < N; i++)
            {
                member.Add(ArrayData[i], 0);
            }
            int M = int.Parse(Console.ReadLine());
            for (int i = 0; i < M; i++)
            {
                string[] ArrayData2 = Console.ReadLine().Trim().Split(' ');
                member[ArrayData2[0]] += int.Parse(ArrayData2[1]);  //該当する名前のところに金額をたす
            }

            IOrderedEnumerable<KeyValuePair<string, int>> sorted = member.OrderBy(pair => pair.Value); //値の小さいものから順
            foreach (var pair in sorted.Reverse())  //値の大きいものから順に並んだDictionaryを上から順番に書き出していく
            {
                Console.WriteLine(pair.Key);  
            }
        }
    }
}

//受験結果 受験言語： C# 解答時間： 62分6秒 バイト数： 970 Byte スコア： 0点  211217

//N
//s_1 s_2 ... s_N
//M
//o_1 p_1
//o_2 p_2
//...
//o_M p_M
//・1 行目に、エンジニアの人数 N が整数で与えられます。
//・2 行目に、半角英小文字で構成される文字列が N 個スペース区切りで与えられます。
//・i 番目 (1 ≦ i ≦ N) の文字列 s_i は、i 番目のエンジニアの名前です。
//・3 行目に、エンジニアたちが購入した本の数 M が整数で与えられます。
//・4 行目から続く M 行には、購入した人の名前を表す半角英小文字で構成される文字列 oj と
//　その本の金額を表す整数 pj がこの順にスペース区切りで与えられます。
//・入力は合計で M + 3 行となり、入力値最終行の末尾に改行が１つ入ります。

//t_1
//t_2
//...
//t_N
//・1 行目からつづく N 行に、書籍購入費が高い人順に並べた時の i 番目の人の名前 t_i を出力して下さい。
//・N 行目の出力の最後に改行を入れ、余計な文字、空行を含んではいけません。