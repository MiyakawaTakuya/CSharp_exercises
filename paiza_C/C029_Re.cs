using System;
using System.Collections.Generic;
using System.Linq;
//C029:旅行の計画

namespace paiza_C
{
    public class C029_Re
    {
        internal static void test()
        {
            string[] ArrayData = Console.ReadLine().Trim().Split(' ');
            int M = int.Parse(ArrayData[0]);  //全体日数
            int N = int.Parse(ArrayData[1]);  //旅の日数
            double sum = 0;  //降水確率の合計
            double aveChance = 0;  //降水確率の平均
            double minAveChance = 100;  //降水確率の平均の最小値
            double[,] aveArray = new double[M - N + 1, 2 ];   //旅の初日と平均降水確率を入れていく配列 
            //int[,] aveArray = new int[M - N + 1, 1];

            //読み取り 連想配列で掬い取る
            var chanceOfPreci = new Dictionary<int, int>();
            for (int i = 0; i < M ; i++)
            {
                string[] strArray2 = Console.ReadLine().Trim().Split(' ');  //読み取り
                int[] intArray = strArray2.Select(int.Parse).ToArray();  //intへ変換
                chanceOfPreci.Add(intArray[0], intArray[1]);  //日付と降水確率を代入
            }

            //平均値の計算
            var pair = chanceOfPreci.FirstOrDefault();
            int firstDay = pair.Key;  //旅の初日を取得
            //for (int i = firstDay; i < firstDay + N; i++)
            for (int i = 0; i < M - N + 1; i++)
            {
                for (int p = 0; p < N; p++)
                {
                    sum += chanceOfPreci[firstDay + i + p];
                }
                aveChance = sum / N;
                aveArray[i, 0] = firstDay + i;  //旅の初日と降水確率を代入していく
                aveArray[i, 1] = aveChance;  //旅の初日と降水確率を代入していく
                if (minAveChance > aveChance)  //降水確率の最小値をとる
                {
                    minAveChance = aveChance;
                }
                sum = 0;   //最初、ここのリセット処理を忘れてた
            }

            //最小値と一致する日にちを取得して書き出してbreakしておしまい
            for (int i = 0; i < M - N + 1; i++)
            {
                if(aveArray[i, 1] == minAveChance)
                {
                    Console.WriteLine(aveArray[i, 0] + " " + (aveArray[i, 0] + N - 1) );  //旅の終わりの日の算出の仕方間違えてた。配列枠外指してた
                    break;
                }
            }

        }
    }
}

//受験結果 受験言語： C# 解答時間： 59分3秒 バイト数： 2029 Byte スコア： 0点  例題1/2正解だったのでやってみたが１問しか正解ない...  211223
//

//受験結果 受験言語： C# 獲得ランク： Cランク スコア： 100点  20分くらい修正後  なとか全問正解