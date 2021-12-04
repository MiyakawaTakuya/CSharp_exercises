using System;
namespace paiza_C
{
    public class C101
    {
        internal static void test()
        {
            int N = int.Parse(Console.ReadLine());  //1行目読み込み(1~364)
            int n = N;  //1 ~ 364  →置き換える必要なかった！！！   
            int count = 0;  //ラッキーな日にちをカウントして足していく
            string M;  //抜き出し用に一度文字列化する時に利用
            int m_left = 0;
            int m_center = 0;
            int m_right = 0;

            //nが1桁
            if (n >= 1 && 9 >= n)
            {
                //Mが１桁の時
                for (int m = 1; m <= 9; m++)
                {
                    if (n == m)
                    {
                        count += 1;
                        // Console.WriteLine(m);
                    }

                }
                //Console.WriteLine(count);

                //Mが２桁の時
                for (int m = 10; m <= 99; m++)
                {
                    M = m.ToString();
                    //一の位と一致する
                    m_left = int.Parse(M.Substring(0, 1));
                    //十の位と一致する
                    m_right = int.Parse(M.Substring(1, 1));
                    if (n == m_left || n == m_right)
                    {
                        count += 1;
                        // Console.WriteLine(m);
                    }
                }
                //Console.WriteLine(count);

                ////Mが３桁の時
                for (int m = 100; m <= 364; m++)
                {
                    M = m.ToString();
                    //一の位と一致する
                    m_left = int.Parse(M.Substring(0, 1));
                    //十の位と一致する
                    m_center = int.Parse(M.Substring(1, 1));
                    //十の位と一致する
                    m_right = int.Parse(M.Substring(2, 1));

                    if (n == m_left || n == m_center || n == m_right)
                    {
                        count += 1;
                        // Console.WriteLine(m);
                    }

                }
                //Console.WriteLine(count);
            }


            //nが2桁
            if (n >= 10 && 99 >= n)
            {

                for (int m = 10; m <= 99; m++)
                {
                    if (n == m)
                    {
                        count += 1;
                    }
                }

                for (int m = 100; m <= 364; m++)
                {
                    M = m.ToString();
                    //頭２つの数字と一致する
                    m_left = int.Parse(M.Substring(0, 2));
                    if (n == m_left)
                    {
                        count += 1;
                    }

                    //けつ２つの数字と一致する
                    m_right = int.Parse(M.Substring(1, 2));
                    if (n == m_right)
                    {
                        count += 1;
                    }

                }
                //Console.WriteLine(count);
            }

            //nが３桁
            if (n >= 100 && 364 >= n)
            {
                for (int m = 100; m <= 364; m++)
                {
                    if (n == m)
                    {
                        count += 1;
                    }
                }
                //Console.WriteLine(count);
            }
            Console.WriteLine(count);
        }
    }
}

//受験結果 受験言語： C# 解答時間： 78分21秒 バイト数： 3227 Byte スコア： 90点
//受験者数： 522人 正解率： 77.78％ 平均解答時間： 17分23秒 平均スコア： 93.07点 211205