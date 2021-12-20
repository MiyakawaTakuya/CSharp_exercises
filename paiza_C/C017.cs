using System;
//C017:ハイアンドロー・カードゲーム

namespace paiza_C
{
    public class C017
    {
        internal static void test()
        {
            string[] ArrayData = Console.ReadLine().Trim().Split(' ');
            int a = int.Parse(ArrayData[0]);
            int b = int.Parse(ArrayData[1]);
            int n = int.Parse(Console.ReadLine());
            int A_ = 0;
            int B_ = 0;

            for (int i = 0; i < n; i++)
            {
                string[] ArrayData2 = Console.ReadLine().Trim().Split(' ');
                A_ = int.Parse(ArrayData2[0]);
                B_ = int.Parse(ArrayData2[1]);
                //ここから勝負判定の条件分岐
                if (a > A_)
                {
                    Console.WriteLine("High");
                }
                else if (a < A_)
                {
                    Console.WriteLine("Low");
                }
                else if (a == A_)
                {
                    if (b > B_)
                    {
                        Console.WriteLine("Low");
                    }
                    else if (b < B_)
                    {
                        Console.WriteLine("High");
                    }
                }
            }
        }

        //internal static void test2()
        //{
        //    int[,] BossData = new int[1, 2] {Console.ReadLine().Trim().Split(' '),3 };
        //    string[,] ArrayData = Console.ReadLine().Trim().Split(' ');
        //    //int a = int.Parse(ArrayData[0]);
        //    //int b = int.Parse(ArrayData[1]);
        //    //int n = int.Parse(Console.ReadLine());
        //    //int A_ = 0;
        //    //int B_ = 0;

        //    for (int i = 0; i < n; i++)
        //    {
        //        string[] ArrayData2 = Console.ReadLine().Trim().Split(' ');
        //        A_ = int.Parse(ArrayData2[0]);
        //        B_ = int.Parse(ArrayData2[1]);
        //        //ここから勝負判定の条件分岐
        //        if (a > A_)
        //        {
        //            Console.WriteLine("High");
        //        }
        //        else if (a < A_)
        //        {
        //            Console.WriteLine("Low");
        //        }
        //        else if (a == A_)
        //        {
        //            if (b > B_)
        //            {
        //                Console.WriteLine("Low");
        //            }
        //            else if (b < B_)
        //            {
        //                Console.WriteLine("High");
        //            }
        //        }
        //    }
        //}
    }
}

//a b
//n
//A_1 B_1
//…
//A_n B_n
//1行目では親カードの情報が与えられます。親カードの1つ目の番号は a、2つ目の番号は b で表されます。
//2行目では整数 n が与えられます。
//3行目から n 行の入力が続き、各行では、子カード i (1 ≦ i ≦ n)の情報が与えられます。
//子カード i の1つ目の番号は A_i、2つ目の番号は B_i で表されます。

//期待する出力
//出力の i 行目では、親カードと子カード i の強弱関係を調べたときに
//親カードの方が強いならば "High"、そうでなければ "Low" と出力してください。
//各行では、"High" または "Low" 以外の余分な文字、空白を含んではいけません。

//最後は改行し、余計な文字、空行を含んではいけません。
//条件
//すべてのテストケースで以下の条件を満たします。

//・1 ≦ a, A_i ≦ 10
//・1 ≦ b, B_i ≦ 4
//・1 ≦ n < 40

//※入力データの中で同じカードが現れることはありません。