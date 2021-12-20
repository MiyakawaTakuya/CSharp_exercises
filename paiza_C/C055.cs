using System;
//C055:ログのフィルター

namespace paiza_C
{
    public class C055
    {
        internal static void test()
        {
            int N = int.Parse(Console.ReadLine());
            string G = Console.ReadLine();
            int noCount = 0;
            for (int i = 0 ; i < N ; i++)
            {
                string A = Console.ReadLine();
                if (A.Contains(G))
                {
                    Console.WriteLine(A);
                    
                }else  //対象文字列を含んでいなかった場合
                {
                    noCount++;
                }
            }
            if(noCount == N)  
            {
                Console.WriteLine("None");
            }
        }
    }
}

//受験結果 受験言語： C# 解答時間： 11分30秒 バイト数： 635 Byte スコア： 100点  211220