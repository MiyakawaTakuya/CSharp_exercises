using System;
namespace paiza_C
{
    //C013:嫌いな数字
    public class C013
    {
        internal static void test()
        {
            int n = int.Parse(Console.ReadLine()); //嫌いな数字
            int m = int.Parse(Console.ReadLine());
            int r_i = 0 ;
            string M;  //一度文字列化する時に利用
            int m_left = 0;
            int m_center = 0;
            int m_right = 0;
            //int okRoomNo = 0 ;


            for (int i = 0; i < m; i++)
            {
                r_i = int.Parse(Console.ReadLine());
                if (r_i != 0)
                {
                    //r_iが１桁の時
                    if(r_i < 10 )
                    {
                        if(n != r_i)
                        {
                            Console.WriteLine(r_i);
                        }
                    }
                    //r_iが2桁の時
                    if (10 <= r_i  && r_i < 100)
                    {
                        M = r_i.ToString();
                        //一の位と一致する
                        m_left = int.Parse(M.Substring(0, 1));
                        //十の位と一致する
                        m_right = int.Parse(M.Substring(1, 1));
                        if (n == m_left || n == m_right)
                        {
                        }
                        else
                        {
                            Console.WriteLine(r_i);
                        }
                    }

                    //r_iが3桁の時
                    if (100 <= r_i && r_i < 1000)
                    {
                        M = r_i.ToString();
                        //一の位と一致する
                        m_left = int.Parse(M.Substring(0, 1));
                        //十の位と一致する
                        m_center = int.Parse(M.Substring(1, 1));
                        //十の位と一致する
                        m_right = int.Parse(M.Substring(2, 1));

                        if (n == m_left || n == m_center || n == m_right)
                        {
                        }
                        else
                        {
                            Console.WriteLine(r_i);
                        }
                    }
                    //r_iが4桁の時 つまり1000
                    if (r_i == 1000)
                    {
                        if (n == 0 || n == 1)
                        {
                        }
                        else
                        {
                            Console.WriteLine(r_i);
                        }
                    }

                }
                else
                {
                    Console.WriteLine("none");
                }
            }
        }
    }
}
