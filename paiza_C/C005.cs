using System;
using System.Net;
using System.Collections.Generic;

namespace paiza_C
{
    public class C005
    {

        //internal static void test()
        //{
        //    //記載されている複数行を一つの配列に納める
        //    //通常の配列では使用前にサイズを指定する必要がある. まずは動的に対応できるListを利用する.
        //    int i = 0;
        //    string[] array;
        //    var list = new List<string>();
        //    while (true)
        //    {
        //        string line = Console.ReadLine();
        //        if (line == null)
        //        {
        //            break;
        //        }
        //        else
        //        {
        //            list.Add(line);
        //            i++;
        //        }
        //    }
        //    array = list.ToArray();  //ここで配列にぶちこ

        //    //IPAddressクラスのTryParseメソッドを用いて、IPアドレス判定を各行行う.
        //    int M = int.Parse(array[0]);  //1行目のIPアドレスの行数Mを取得
        //    IPAddress ipaddr;
        //    for (int a = 1; a <= M; a++)
        //    {
        //        bool ret = IPAddress.TryParse(array[a], out ipaddr);
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
        //正答率８割くらい
        //条件1 ≦ N ≦ 100 と　1 ≦ M ≦ 100を満たすような条件式を書いていないからか？

    }
}
//3
//010.030.043.005
//010.030.043.005010.030.043.
//168.100.43.255
