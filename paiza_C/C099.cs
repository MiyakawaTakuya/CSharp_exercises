using System;
//C099:折り紙の貼り合わせ

namespace paiza_C
{
    public class C099
    {
        internal static void test()
        {
            string[] ArrayData = Console.ReadLine().Trim().Split(' ');
            int N = int.Parse(ArrayData[0]);  //折り紙の枚数を表す整数
            int D = int.Parse(ArrayData[1]);
            int x = D;  //x軸の長さの初期値

            for (int i = 1; i < N; i++)  //1枚目はすでに加算されているのでforで回すカウント数はN-1
            {
                int addX = D - (int.Parse(Console.ReadLine())); //各行のみかんの重さ
                x += addX; 
            }
            Console.WriteLine(D * x);  //面積
        }
    }
}

//N D
//d_2
//...
//d_N
//・1 行目には、折り紙の枚数を表す整数 N および折り紙の 1 辺の長さを表す整数 D が半角スペース区切りで与えられます。
//・1 + i 行目 (1 ≦ i ≦ N - 1) には整数 d_ { i + 1}
//が与えられます。これは、 i + 1 枚目の折り紙が i 枚目の折り紙に d_{i + 1} cm 重なっていることを表します。

//・2 ≦ N ≦ 100
//・2 ≦ D ≦ 10
//・1 ≦ d_i ≦ D / 2(2 ≦ i ≦ N)
//入力例
//4 10
//3
//4
//5

//受験結果 受験言語： C# 解答時間： 10分31秒 バイト数： 496 Byte スコア： 100点  2111207

