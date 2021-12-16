using System;
//C098: 多重パス回し

namespace paiza_C
{
    public class C098
    {
        internal static void test()
        {
            int from = 0;
            int to = 0;
            int howmany = 0;

            int N = int.Parse(Console.ReadLine());
            int[] firsttime = new int[N];
            for (int i = 0; i < N; i++)
            {
                firsttime[i]= int.Parse(Console.ReadLine());
            }
            int M = int.Parse(Console.ReadLine());
            for (int i = 0; i < M; i++)
            {
                string[] ArrayData = Console.ReadLine().Trim().Split(' ');
                from = int.Parse(ArrayData[0]);
                to = int.Parse(ArrayData[1]);
                howmany = int.Parse(ArrayData[2]);

                //たまを持っている個数以上渡そうとしているのか、範囲内なのかによって分岐
                if(firsttime[from - 1] >= howmany)
                {
                    firsttime[from - 1] -= howmany;
                    firsttime[to - 1] += howmany;
                }
                else if(firsttime[from - 1] < howmany)
                {
                    firsttime[to - 1] += firsttime[from - 1];
                    firsttime[from - 1] = 0;
                }
            }

            //投げ合った後に最後に順にもち玉数を掃き出す
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(firsttime[i]);
            }
        }
    }
}

//受験結果 受験言語： C# 解答時間： 27分49秒 バイト数： 1304 Byte スコア： 100点  211217

//N
//s_1
//...
//s_N
//M
//a_1 b_1 x_1
//...
//a_M b_M x_M
//・1 行目には、人数を表す整数 N が与えられます。
//・続く N 行のうちの i 行目 (1 ≦ i ≦ N) には、 人 i が最初に持っているボールの個数を表す整数 s_i が与えられます。
//・N+2 行目には、パス回しの情報の数を表す整数 M が与えられます。
//・続く M 行のうちの i 行目 (1 ≦ i ≦ M) には、 i 番目のパス回しの情報を表す 3 つの整数 a_i, b_i, x_i がこの順に半角スペース区切りで与えられます。これは、人 a_i が相手として人 b_i を、そしてボールの個数 x_i を宣言したことを表します。

//t_1...
//t_N
//・出力は N 行からなります。
//・i 行目 (1 ≦ i ≦ N) には、人 i が最終的に持っているボールの個数を表す整数 t_i を出力してください。
//・出力最終行の末尾に改行を入れ、余計な文字、空行を含んではいけません。
