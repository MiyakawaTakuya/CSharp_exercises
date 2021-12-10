using System;
using System.Text.RegularExpressions;
//C016:Leet文字列

namespace paiza_C
{
    public class C016
    {
        internal static void test()
        {
            string S = Console.ReadLine();
            Regex reg1 = new Regex("[A]");//正規表現
            Regex reg2 = new Regex("[E]");//正規表現
            Regex reg3 = new Regex("[G]");//正規表現
            Regex reg4 = new Regex("[I]");//正規表現
            Regex reg5 = new Regex("[O]");//正規表現
            Regex reg6 = new Regex("[S]");//正規表現
            Regex reg7 = new Regex("[Z]");//正規表現 
            //Console.WriteLine(reg1.Replace(S, "4"));
            S = reg1.Replace(S, "4");
            S = reg2.Replace(S, "3");
            S = reg3.Replace(S, "6");
            S = reg4.Replace(S, "1");
            S = reg5.Replace(S, "0");
            S = reg6.Replace(S, "5");
            S = reg7.Replace(S, "2");
            Console.WriteLine(S);

        }

        //public string Replace(char 置換前の文字, char 置換後の文字)
        //Replaceメソッドの引数がchar型の場合、指定した1文字を別の1文字に全て置き換えます。
        internal static void test2()
        {
            string S = Console.ReadLine();
            S = S.Replace("A", "4");
            S = S.Replace("E", "3");
            S = S.Replace("G", "6");
            S = S.Replace("I", "1");
            S = S.Replace("O", "0");
            S = S.Replace("S", "5");
            S = S.Replace("Z", "2");
            Console.WriteLine(S);
        }

        internal static void test3()
        {
            string S = Console.ReadLine();
            Console.WriteLine(S.Replace("A", "4").Replace("E", "3").Replace("G", "6").Replace("I", "1").Replace("O", "0").Replace("S", "5").Replace("Z", "2"));
            //S = S.Replace("E", "3");
            //S = S.Replace("G", "6");
            //S = S.Replace("I", "1");
            //S = S.Replace("O", "0");
            //S = S.Replace("S", "5");
            //S = S.Replace("Z", "2");
            //Console.WriteLine(S);
        }

    }
}
//受験結果 受験言語： C# 解答時間： 10分27秒 バイト数： 792 Byte スコア： 100点   211211

//A 4
//E 3
//G 6
//I 1
//O 0
//S 5
//Z 2
