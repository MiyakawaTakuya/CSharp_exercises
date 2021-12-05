using System;
using System.Net;
using System.Text.RegularExpressions;
namespace paiza_C
{
    public class C086
    {
        internal static void test()
        {
            string S = Console.ReadLine();
            Regex re1 = new Regex("[aiueoAIUEO]", RegexOptions.Singleline); //aiueo...の母音を取り除く
            S = re1.Replace(S, "");
            Console.WriteLine(S);
        }

        internal static void test2()
        {
            string S = Console.ReadLine();  //リードライン
            string n = Console.ReadLine();  //取り除きたいワード
            Regex re1 = new Regex(n, RegexOptions.Singleline); //aiueo...の母音を取り除く
            S = re1.Replace(S, "");
            Console.WriteLine(S);
        }
    }
}

//受験結果 受験言語： C# 解答時間： 23分40秒 バイト数： 338 Byte スコア： 96点 211205
