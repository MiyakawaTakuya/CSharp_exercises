using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Net;
//B004:ログファイルの抽出

namespace paiza_C
{
    public class B004
    {
        private static int min_3, max_3, min_4, max_4;

        internal static void test()
        {
            //IPAddress ipAddr = IPAddress.Parse(Console.ReadLine());  正規表現のやつはエラーになる
            string ipAddr = Console.ReadLine();
            string[] ArrayData0 = ipAddr.Trim().Split('.');
            //int min_3, max_3, min_4, max_4;
            //ArrayData0[2]は第三オクテット、ArrayData0[3]は第４オクテット、数値じゃなく正規表現っぽい表現の場合があるので条件分岐で捌く
            //取り急ぎcontainで-と*で判断する？  それぞれ最小値最大値で値を代入していく
            //第３オクテット
            if (ArrayData0[2] == "*")
            {
                min_3 = 0;
                max_3 = 255;
            }
            else if(ArrayData0[2].Contains('-'))
            {
                string[] ArrayData0_3 = ArrayData0[2].Trim().Split('-');
                min_3 = int.Parse(ArrayData0_3[0].Replace("[", ""));
                max_3 = int.Parse(ArrayData0_3[1].Replace("]", ""));
            }
            //第４オクテット
            if (ArrayData0[3] == "*")
            {
                min_4 = 0;
                max_4 = 255;
            }
            else if (ArrayData0[3].Contains('-'))
            {
                string[] ArrayData0_4 = ArrayData0[2].Trim().Split('-');
                min_4 = int.Parse(ArrayData0_4[0].Replace("[", ""));
                max_4 = int.Parse(ArrayData0_4[1].Replace("]", ""));
            }

            //該当する各行を必要な項目だけ書き出していく
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                string[] ArrayData = Console.ReadLine().Trim().Split(' ');
                string[] ArrayData_34 = ArrayData[0].Trim().Split('.');
                int no3 = int.Parse(ArrayData_34[2]);
                int no4 = int.Parse(ArrayData_34[3]);

                if (ipAddr.Contains('-')|| ipAddr.Contains('*')) //最初の一行目に-や*が含まれている場合
                {
                    if (min_3 <= no3 && no3 <= max_3 && min_4 <= no4 && no4 <= max_4)
                    {
                        Console.WriteLine(ArrayData[0] + " " + ArrayData[3].Replace("[", "") + " " + ArrayData[6]);
                    }
                }
                else  //最初の一行目に-や*が含まれていない場合
                {
                    if (ArrayData[0] == ipAddr) //そのまま一致するかどうかを判別するだけで良いので
                    {
                        Console.WriteLine(ArrayData[0] + " " + ArrayData[3].Replace("[", "") + " " + ArrayData[6]);
                    }
                }
            }

            //var IPv4 = new Dictionary<string, int[]>();  //各オクテットに該当する数字を格納した配列を準備する
        }
    }
}

//受験結果 受験言語： C# 解答時間： 254分45秒 バイト数： 2383 Byte スコア： 0点

//Apacheのログが以下のような書式であります。ログは上から古い順に記録されているとします。
//「IPアドレス identユーザー名 認証ユーザー名 [アクセス日時] "リクエストヘッダ ファイル名 プロトコル" ステータスコード 転送されたバイト数 呼び出し元URL ブラウザ情報等」
//IPアドレス
//identユーザー名
//認証ユーザー名
//[アクセス日時]
//"リクエストヘッダ ファイル名 プロトコル"
//ステータスコード
//転送されたバイト数
//呼び出し元URL
//ブラウザ情報等
//※半角スペース区切り

//101.80.23.49 - - [08/Jul/2013:16:55:14 +0900] "GET /index.html HTTP/1.1" 200 12345 "http://google.com" "safari"
//51.185.9.25 - - [08 / Jul / 2013:17:05:10 + 0900] "GET / HTTP/1.1" 200 12345 "http://google.com" "chrome"

//入力される値
//1行目に検索条件として、IPアドレスが入力されます。範囲指定も可能で第3、第4オクテットは * (0から255全て)、[S-E] (SからEまで)で指定することが可能です。
//2行目には入力されるログの行数Nが入力されます。
//3行目以降には2行目で入力された行数分のApacheのログが入力されます。ログ１行の長さMは500文字以内とします。

//IPアドレスは「.」で区切られて左から第1.第2.第3.第4オクテットと呼ばれます。
//範囲指定ができるのは第3、第4オクテットまでとします。