using System;
//C024:ミニ・コンピュータ

namespace paiza_C
{
    public class C024
    {
        internal static void test()
        {
            int _1 = 0;
            int _2 = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り

                if(strArray[0] == "SET" && strArray[1] == "1")
                {
                    _1 = int.Parse(strArray[2]);
                }
                else if (strArray[0] == "SET" && strArray[1] == "2")
                {
                    _2 = int.Parse(strArray[2]);
                }
                else if(strArray[0] == "ADD")
                {
                    _2 = _1 + int.Parse(strArray[1]);
                }
                else if (strArray[0] == "SUB")
                {
                    _2 = _1 - int.Parse(strArray[1]);
                }

            }
            Console.WriteLine( _1 +" "+ _2);
        }
    }
}

//受験結果 受験言語： C# 解答時間： 15分17秒 バイト数： 938 Byte スコア： 100点

//入力は以下のフォーマットで与えられます。
//n
//s_1
//s_2
//...
//s_n

//1 行目には命令の個数 n が与えられます。
//続く n 行には、n 個の命令が実行される順番どおりに与えられます。

//s_i は次の 3 種類の文字列のうちのいずれかです。
//・SET i a
//・ADD a
//・SUB a
