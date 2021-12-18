using System;
//C031:時差を求めたい

namespace paiza_C
{
    public class C031
    {
        private static double baseInt;

        internal static void test()
        {
            int N = int.Parse(Console.ReadLine());
            string[,] cityTime =new string[N,2];
            for (int i = 0; i < N; i++)
            {
                string[] ArrayData = Console.ReadLine().Trim().Split(' ');
                cityTime[i, 0] = ArrayData[0];  //都市名
                cityTime[i, 1] = ArrayData[1];  //時差
            }
            string[] ArrayData2 = Console.ReadLine().Trim().Split(' ');  //基準都市と時刻
            string City = ArrayData2[0];
            string[] ArrayData2_time = ArrayData2[1].Trim().Split(':');  //[0]にh, [1]にmin
            DateTime dt = new DateTime(2021, 12, 24, int.Parse(ArrayData2_time[0]), int.Parse(ArrayData2_time[1]), 0);
            //string result = dt.ToString("hh:mm");  //12時間表記
            //string baseCityTime = dt.ToString("HH:mm");  //24時間表記

            //forで回して一致する都市名があるところでそれを基準時設定させる
            for (int i = 0; i < N; i++)
            {
                if( City == cityTime[i, 0])
                {
                    baseInt = double.Parse(cityTime[i, 1]);  
                }
            }
            //forで回して各都市の時間を足し引きして書き出す
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(dt.AddHours(double.Parse(cityTime[i, 1]) - baseInt).ToString("HH:mm"));
            }

        }
    }
}

//受験結果 受験言語： C# 解答時間： 67分10秒 バイト数： 1554 Byte スコア： 0点   211217

//N
//p_1 s_1
//p_2 s_2
//…
//p_N s_N
//q t

//・1 行目には都市の総数を表す整数 N が与えられます。
//・続く N 行のうち i 行目 (1 ≦ i ≦ N) には i 番目の都市の名前を表す文字列 p_i とその都市の現地時刻の世界標準時からの進み（単位：時）を表す整数 s_i がこの順に半角スペース区切りで与えられます。
//　　s_i が負である場合はその絶対値ぶんだけ時刻が遅れていることを表します。
//・次の行には投稿を行ったユーザの所在地の都市の名前を表す文字列 q と現地時間での投稿時刻を表す文字列 t がこの順に半角スペース区切りで与えられます。
//　　t は 0 埋め二桁の数字で時 = hh、分 = mmとし hh:mm 形式で与えられます。
//・入力は合計で N + 2 行であり、入力最終行の最後に改行が 1 つ入ります。

//d_1
//d_2
//...
//d_N
//・期待する出力は N 行からなります。
//・出力の i 行目 (1 ≦ i ≦ N) に、i 番目の都市に住むユーザが見た時の投稿時刻を表す文字列 d_i を 0 埋め二桁の数字で時 = hh、分 = mmとし hh:mm 形式で出力してください。
//・N 行目の最後に改行を 1 つ入れ、余計な文字、空行を含んではいけません。