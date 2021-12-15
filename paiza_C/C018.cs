using System;
//C018:何人前作れる？

namespace paiza_C
{
    public class C018
    {
        internal static void test()
        {
            int n = int.Parse(Console.ReadLine());
            string[,] recipes  = new string[n,2];  
            double howmany = 0;
            double howmanyPeple = 100;
            int match = 0;

            //必要な食材と数を２次元配列に格納していく
            for (int i = 0; i < n; i++)
            {
                string[] ArrayData = Console.ReadLine().Trim().Split(' ');
                recipes[i, 0] = ArrayData[0];
                recipes[i, 1] = ArrayData[1];
            }

            //手元にある食材と数を２次元配列に格納していく
            int m = int.Parse(Console.ReadLine());
            string[,] shokuzai = new string[m,2];
            for (int i = 0; i < m; i++)
            {
                string[] ArrayData2 = Console.ReadLine().Trim().Split(' ');
                shokuzai[i, 0] = ArrayData2[0];
                shokuzai[i, 1] = ArrayData2[1];
            }

            //まず必要な食材が一致した場合にその個数を把握する
            for (int p = 0; p < n; p++)  //必要な食材を軸に回すのでn
            {
                for (int q = 0; q < m; q++)  //食材の数だけまわすのでm
                {
                    if (recipes[p, 0] == shokuzai[q, 0])
                    {
                        //仮にこの食材だけで生成できる人数を算出しておく
                        howmany = int.Parse(shokuzai[q, 1]) / int.Parse(recipes[p, 1]);
                        howmany = Math.Floor(howmany);  //小数点切り捨て
                        match += 1;  
                        if (howmanyPeple > howmany)  //比較演算子 型の問題はなし？
                        {
                            howmanyPeple = howmany;
                        }
                    }
                }
            }

            if(match == n)  
            {
                Console.WriteLine(howmanyPeple);
            }else
            {
                Console.WriteLine(0);
            }
            //Console.WriteLine(howmanyPeple);
        }
    }
}

//受験結果 受験言語： C# 解答時間： 51分20秒 バイト数： 1923 Byte スコア： 55点  211215
//正答率は9割５部

//入力は以下のフォーマットで与えられます。

//n　　　　　#レシピに書かれている食材の数を表す整数 n
//a_1 b_1　　#レシピに書かれている食材の名前 a_1, 数 b_1
//a_2 b_2　　#レシピに書かれている食材の名前 a_2, 数 b_2
//...
//a_n b_n　　#レシピに書かれている食材の名前 a_n, 数 b_n
//m　　　　　#あなたが所持している食材の数を表す整数 m
//c_1 d_1　　#所持している食材の名前 c_1, 数 d_1
//c_2 d_2　　#所持している食材の名前 c_2, 数 d_2
//...
//c_m d_m　　#所持している食材の名前 c_m, 数 d_m
//ここで、n はレシピに書かれている食材の数を表す整数
//文字列 a_i と整数 b_i (1 ≦ i ≦ n) は、1人前あたりの食材 a_i が b_i だけ必要であることを表します。

//同様に、m はあなたが所持している食材の数を表す整数
//文字列 c_i と整数 d_i (1 ≦i ≦ m) は、食材 c_i を d_i だけ所持していることを表します。

//すべてのテストケースで以下の条件を満たします。

//・1 ≦ n ≦ 100
//・0 ≦ m ≦ 100
//・1 ≦ a_i の長さ, c_i の長さ ≦ 10
//・1 ≦ b_i ≦ 100
//・1 ≦ d_i ≦ 10,000
//・i ≠ j のとき a_i ≠ a_j
//・i ≠ j のとき c_i ≠ c_j