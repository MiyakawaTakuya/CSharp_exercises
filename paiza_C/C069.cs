using System;
using System.Linq;
//C069: お祭りの日付

namespace paiza_C
{
    public class C069
    {
        internal static void test()
        {
            string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
            int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
            int y = intArray[0];
            int m = intArray[1];  //現在の月
            int d = intArray[2];
            string[] strArray2 = Console.ReadLine().Trim().Split(' ');  //読み取り
            int[] intArray2 = strArray2.Select(int.Parse).ToArray();  //intへ変換
            int M = intArray2[0];  //開催する月
            int D = intArray2[1];　//開催する日付
            int daySum = 0;
            int Y = 0;

            //開催する年を算出
            for (int i = 0 ; i < 4 ; i++)
            {
                if ((i + y) % 4 == 1)
                {
                    Y = i + y;  //開催する年を取得
                    break;
                }
            }

            //引き算して日数を算出
            daySum = ((Y-1) * (15 * 6 + 13 * 7) + daysOfMonth(M) + D) - ((y-1) * (15 * 6 + 13 * 7) + daysOfMonth(m) + d);
            Console.WriteLine(daySum);
        }


        //月を計算する関数
        internal static int daysOfMonth(int a)
        {
            int monthSum = 0;
            for (int i = 1; i <= 13; i++)
            {
                if (i % 2 == 0 && i!= a)  //偶数月
                {
                    monthSum += 15;
                }
                else if (i % 2 == 1 && i != a)
                {
                    monthSum += 13;
                }
                else if (i == a)
                {
                    break;
                }
            }
            return monthSum ;
        }
    }
}

//受験結果 受験言語： C# 解答時間： 55分13秒 バイト数： 1103 Byte スコア： 6点  211228  月の計算を14に簡略化して正答率低いと自覚した上で回答...
//月の計算を行う関数を作成
//受験結果 受験言語： C# 獲得ランク： Cランク スコア： 100点 

//・1 年には 1 月から 13 月までの 13 ヶ月がある。
//・偶数月の日数は 15 日である。
//・奇数月の日数は 13 日である。

//入力は以下のフォーマットで与えられます。
//y m d  
//a b
//・1 行目には計算を始める基準日の年を表す整数 y, 月を表す整数 m, 日を表す整数 d がこの順に半角スペース区切りで与えられます。
//・2 行目には次の開催日の月を表す整数 a, 日を表す整数 b がこの順に半角スペース区切りで与えられます。
//・入力は合計で 2 行となり、入力値最終行の末尾に改行が一つ入ります。

//paiza 王国では 4 で割って余りが 1 になる年に開催されるパイーザ祭があります。
//paiza 王国では暦が独特であり、以下のような暦になっています。

//・1 年には 1 月から 13 月までの 13 ヶ月がある。
//・偶数月の日数は 15 日である。
//・奇数月の日数は 13 日である。
