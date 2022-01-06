// using System.Collections.Generic;
using System.Linq;
using System;
using System.Net;
//C005: アドレス調査

namespace paiza_C
{
    public class C005_Re
    {
		//フィールド
		private static string str;
        //受験結果 受験言語： C# 獲得ランク： Cランク スコア： 70点  再再再チャレンジ ずっとランタイムエラー３つ
        internal static void main3()
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                str = Console.ReadLine();
                if (CountChar(str, '.') != 3) { Console.WriteLine("False"); continue; }
                string[] strArray = str.Trim().Split('.');
                if (strArray.Length != 4 || strArray.Contains("")) { Console.WriteLine("False"); continue; }
                int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
                int count = 0;
                int _1 = intArray[0]; int _2 = intArray[1]; int _3 = intArray[2]; int _4 = intArray[3];
                if (_1 >= 0 && _1 <= 255 && _2 >= 0 && _2 <= 255 && _3 >= 0 && _3 <= 255 && _4 >= 0 && _4 <= 255)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
        }

        public static int CountChar(string s, char c)
        {
            return s.Length - s.Replace(c.ToString(), "").Length;
        }

        //internal static void main3()
        //{
        //    int N = int.Parse(Console.ReadLine());

        //    for (int i = 0; i < N; i++)
        //    {
        //        str = Console.ReadLine();
        //        if (CountChar(str, '.') != 3) { Console.WriteLine("False"); continue; }
        //        string[] strArray = str.Trim().Split('.');
        //        if (strArray.Length != 4 || strArray.Contains("")) { Console.WriteLine("False"); continue; }
        //        int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
        //        int count = 0;
        //        int _1 = intArray[0];
        //        if (_1 >= 0 && _1 <= 255) { count++; }
        //        int _2 = intArray[1];
        //        if (_2 >= 0 && _2 <= 255) { count++; }
        //        int _3 = intArray[2];
        //        if (_3 >= 0 && _3 <= 255) { count++; }
        //        int _4 = intArray[3];
        //        if (_4 >= 0 && _4 <= 255) { count++; }
        //        if (count == 4)
        //        {
        //            Console.WriteLine("True");
        //        }
        //        else
        //        {
        //            Console.WriteLine("False");
        //        }

        //    }
        //}

        //受験結果 受験言語： C# 獲得ランク： Cランク スコア： 70点  再再チャレンジ 同じくランタイムエラー３つ
        //internal static void main2()
        //{
        //    int N = int.Parse(Console.ReadLine());

        //    for (int i = 0; i < N; i++)
        //    {
        //        str = Console.ReadLine();
        //        if (CountChar(str, '.') != 3) { Console.WriteLine("False");continue; }
        //        string[] strArray = str.Trim().Split('.');
        //        if (strArray.Length != 4 || strArray.Contains("")) { Console.WriteLine("False"); continue; }
        //        int _1 = int.Parse(strArray[0]);
        //        if (_1 < 0 && _1 > 255) { Console.WriteLine("False"); continue; }
        //        int _2 = int.Parse(strArray[1]);
        //        if (_2 < 0 && _2 > 255) { Console.WriteLine("False"); continue; }
        //        int _3 = int.Parse(strArray[2]);
        //        if (_3 < 0 && _3 > 255) { Console.WriteLine("False"); continue; }
        //        int _4 = int.Parse(strArray[3]);
        //        if (_4 < 0 && _4 > 255) { Console.WriteLine("False"); continue; }
        //        Console.WriteLine("True");
        //    }
        //}

        //public static int CountChar(string s, char c)
        //{
        //    return s.Length - s.Replace(c.ToString(), "").Length;
        //}



        //受験結果 受験言語： C# 獲得ランク： Cランク スコア： 70点　再チャレンジ 正答率はUP ランタイムエラーが３つ
        //internal static void main()
        //{
        //    int N = int.Parse(Console.ReadLine());
        //    for (int i = 0; i < N; i++)
        //    {
        //        str = Console.ReadLine();

        //        if (!isIP(str))
        //        {
        //            Console.WriteLine("False"); 
        //        }
        //        else
        //        {
        //            Console.WriteLine("True");
        //        }
        //    }
        //}

        //internal static bool isIP(string ip)
        //{
        //    string[] strArray = ip.Trim().Split('.');
        //    if(CountChar(ip, '.') !=3) { return false; }
        //    if (strArray.Length !=4 || strArray.Contains("")) { return false; }
        //    int _1 = int.Parse(strArray[0]);
        //    if(_1 < 0 && _1 > 255) { return false; }

        //    int _2 = int.Parse(strArray[1]);
        //    if (_2 < 0 && _2 > 255) { return false; }

        //    int _3 = int.Parse(strArray[2]);
        //    if (_3 < 0 && _3 > 255) { return false; }

        //    int _4 = int.Parse(strArray[3]);
        //    if (_4 < 0 && _4 > 255) { return false; }

        //    return true;
        //}

        //public static int CountChar(string s, char c)
        //{
        //    return s.Length - s.Replace(c.ToString(), "").Length;
        //}

        //internal static void main()
        //{
        //    int N = int.Parse(Console.ReadLine());
        //    IPAddress ipAddress;
        //    for (int i = 0; i < N; i++)
        //    {
        //        str = Console.ReadLine();
        //        bool ret = IPAddress.TryParse(str, out ipAddress);
        //        if (ret)
        //        {
        //            Console.WriteLine("True");
        //        }
        //        else
        //        {
        //            Console.WriteLine("False");
        //        }
        //    }
        //}
    }
}

//受験結果 受験言語： C# 解答時間： 8分19秒 バイト数： 535 Byte スコア： 70点
//関数の精度がよくないのか、paiza側の入力値がイレギュラーなのか..
//4
//.1.2.3.4
//192.400.1.10.1000...
//4.3.2.1
//0..33.444...
