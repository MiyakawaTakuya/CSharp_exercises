using System;
//C045:ページネーション

namespace paiza_C
{
    public class C045
    {
        internal static void test()
        {
            string[] strArray = Console.ReadLine().Trim().Split(' ');
            int n = int.Parse(strArray[0]);
            int s = int.Parse(strArray[1]);
            int p = int.Parse(strArray[2]);

            //全ての数字を二次元配列で格納していく
            if(n % s != 0)  //ページ数でピッタリ割り切れない時
            {
                int[,] allPage = new int[n / s + 1, s] ;
                if (p < n / s + 1)
                {
                    //代入 p毎にs個ちゃんと充填されるページ
                    for (int a = 0; a < n / s; a++)
                    {
                        for (int b = 0; b < s; b++)
                        {
                            allPage[a, b] = a * s + b + 1;
                        }
                    }
                    //書き出し
                    for (int b = 0; b < s; b++)
                    {
                        if (b < s - 1)
                        {
                            Console.Write(allPage[p - 1, b] + " ");
                        }
                        else if (b == s - 1)
                        {
                            Console.WriteLine(allPage[p - 1, b]);
                        }
                    }
                }
                else if (p == n / s + 1)
                {
                    //代入と書き出し 最後のあまりのページ
                    for (int b = 0; b < n % s; b++)
                    {
                        allPage[n / s, b] = (n / s + 1) * s + b + 1;
                        if (b < n % s - 1)
                        {
                            Console.Write(allPage[p - 1, b] + " ");
                        }
                        else if (b == n % s- 1)
                        {
                            Console.WriteLine(allPage[p - 1, b]);
                        }
                    }
                }
                else if (p > n / s + 1)  //存在しないページ
                {
                    Console.WriteLine("none");
                }
            }
            else if(n % s == 0)  //ページ数でピッタリ割り切れる時
            {
                int[,] allPage = new int[n / s , s];
                //値を代入
                for (int a = 0; a < n / s ; a++)
                {
                    for (int b = 0; b < s; b++)
                    {
                        allPage[a, b] = a * s + b + 1;
                    }
                }
                //pで条件分岐して吐き出し
                if (p <= n / s)  //存在するページ
                {
                    for (int b = 0; b < s; b++)  //pを書き出していく
                    {
                        if (b < s - 1)
                        {
                            Console.Write(allPage[p - 1, b] + " ");
                        }
                        else if (b == s - 1)
                        {
                            Console.WriteLine(allPage[p - 1, b]);
                        }
                    }
                }
                else if (p > n / s )  //存在しないページ
                {
                    Console.WriteLine("none");
                }
            }
        }
    }
}

//受験結果 受験言語： C# 解答時間： 117分3秒 バイト数： 3017 Byte スコア： 0点  211222
//出力結果間違いが４つ

//入力は以下のフォーマットで与えられます。
//n s p
//・1 行目には、検索結果の件数を表す整数 n、ページサイズを表す整数 s および表示したいページ番号を表す整数 p がこの順で半角スペース区切りで入力されます。
//・入力は 1 行となり、末尾に改行が 1 つ入ります。