using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Net;
//B004:ログファイルの抽出

namespace paiza_C
{
    public class B004
    {
        internal static void test()
        {
            //IPAddress ipAddr = IPAddress.Parse(Console.ReadLine());  正規表現のやつはエラーになる
            string ipAddr = Console.ReadLine();
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                string[] ArrayData = Console.ReadLine().Trim().Split(' ');
                //ArrayData[0],ArrayData[3],ArrayData[6]
                bool result = Regex.IsMatch(ArrayData[0], ipAddr);
                if (result)
                {
                    Console.WriteLine(ArrayData[0] + " " + ArrayData[3] + " " + ArrayData[6]);

                }
            }
        }
    }
}

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