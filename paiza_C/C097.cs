using System;
//C097:プレゼント応募企画の実施

namespace paiza_C
{
    public class C097
    {
        internal static void test()
        {
            string[] ArrayData = Console.ReadLine().Trim().Split(' ');
            int N = int.Parse(ArrayData[0]);
            int X = int.Parse(ArrayData[1]);
            int Y = int.Parse(ArrayData[2]);

            for (int i = 1; i <= N; i++)  
            {
                if(i % X == 0 && i % Y != 0)
                {
                    Console.WriteLine("A");
                }
                else if(i % Y == 0 && i % X != 0)
                {
                    Console.WriteLine("B");
                }else if(i % X == 0 && i % Y == 0)
                {
                    Console.WriteLine("AB");
                }
                else
                {
                    Console.WriteLine("N");
                }

            }

        }
    }
}

//N X Y
//・1 行目にはそれぞれ整数 N, X, Y がこの順で半角スペース区切りで与えられます。これらは応募者が N 人であることを示し、X の倍数番目の応募者がプレゼント A の当選者となり、Y の倍数番目の応募者がプレゼント B の当選者となることを示します。
//・入力は 1 行となり、末尾に改行が 1 つ入ります。

//a_1
//a_2
//...
//a_N
//・期待する出力は N 行からなります。
//・i 行目 (1 ≦ i ≦ N) にはそれぞれ i 番目の応募者の当選情報を出力してください。
//・プレゼント A に当選しているとき、大文字アルファベットの A を、プレゼント B に当選しているとき、大文字アルファベットの B を、プレゼント A、Bの両方当選しているとき、大文字アルファベットの AB を出力し、当選していないとき、大文字アルファベットの N を出力してください。
//・出力最終行の末尾に改行を入れ、余計な文字、空行を含んではいけません。
//・1 ≦ N ≦ 1,000
//・1 ≦ X, Y ≦ N


//受験結果 受験言語： C# 解答時間： 10分12秒 バイト数： 849 Byte スコア： 100点  211208