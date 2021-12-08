using System;
using System.Collections.Generic;
//B095:カラオケ大会

namespace paiza_C
{
    public class B095
    {
        internal static void test()
        {
            string[] ArrayData = Console.ReadLine().Trim().Split(' ');
            int N = int.Parse(ArrayData[0]);
            int M = int.Parse(ArrayData[1]);
            int point;
            var musicArray = new List<int>();
            int[] correctArray = new int[M];
            int sumPoint = 100; //持ち点
            int max = 0; //最高点を入れる
            int musicalInterval;

            //まずは正解配列を生成
            for (int i = 0; i < M; i++)
            {
                point = int.Parse(Console.ReadLine());
                musicArray.Add(point);
            }
            correctArray = musicArray.ToArray();

            for (int i = 1; i <= N; i++)
            {
                for (int m = 0; m < M; m++)   //かくプレイヤーの点数判定していく
                {
                    musicalInterval = int.Parse(Console.ReadLine());  //このプレイヤーの音程を取得
                    int d = Math.Abs(correctArray[m] - musicalInterval);  //正しい音階との差の絶対値
                    if (d <= 5)
                    {
                        //減点しない
                    }
                    else if(d <= 10 && d > 5)
                    {
                        sumPoint = sumPoint - 1;
                    }
                    else if (d <= 20 && d> 10)
                    {
                        sumPoint = sumPoint - 2;
                    }
                    else if (d <= 30 && d > 20)
                    {
                        sumPoint = sumPoint - 3;
                    }
                    else if (d > 30)
                    { 
                        sumPoint = sumPoint - 5;
                    }
                }
                //ここで最大値を検証する
                if (max < sumPoint)
                {
                    max = sumPoint;
                }
                sumPoint = 100; //持ち点のリセット
            }

            Console.WriteLine(max);
        }

    }
}

//あなたの会社でカラオケ大会をすることになりました。
//課題曲を決め、カラオケの得点を出し N 人で競います。
//社長にどうしてもと頼まれて、カラオケの得点計算プログラムをあなたが書くことになりました。

//音楽に疎いあなたは少し勉強して、音程が Hz (ヘルツ)で表現されることを知りました。そこで、それを基準に得点を計算することにしました。
//採点は 100 点からの減点方式で 0 点を下回ることはありません。以下を参考にして、課題曲の誤差があるたびにに点数を引いていきます。
//ただし、誤差とは、ただしい音程と自分が歌った音程の差の絶対値とします。

//・誤差 5 Hz 以内なら減点しない
//・上記に当てはまらず、誤差 10 Hz 以内なら 1 点減点
//・上記に当てはまらず、誤差 20 Hz 以内なら 2 点減点
//・上記に当てはまらず、誤差 30 Hz 以内なら 3 点減点
//・上記に当てはまらない場合、5 点減点

//課題曲の正しい音程と、N 人の歌った音程が入力されるので、N 人のうちの最高得点を出力してください。

//入力値
//N M  
//a_1   正しい音程
//...
//a_M
//h_{1,1}  一人目の音程
//...
//h_
//{ M,1}
//h_
//{ 1,2}  二人目の音程
//...
//h_
//{ M,2}
//...
//...
//...
//h_
//{ 1,N}   N人目の音程
//...
//h_
//{ M,N}
//・1 行目に歌う人数を表す整数 N と課題曲の長さを表す整数 M が与えられます。
//・続く M 行のうち i 行目には課題曲の i 番目の小節の正しい音程を表す整数 a_i (1 ≦ i ≦ M) が与えられます。
//・続く M 行ごとに、j 番目の i 行目には j 番目の人が歌った課題曲の i 番目の小節の音程を表す整数 h_{i, j} (1 ≦ i ≦ M, 1 ≦ j ≦ N) が与えられます。
//・入力は合計で 1 + M + MN 行となり、入力値最終行の末尾に改行が 1 つ入ります。

//入力例1
//2 3
//400
//410
//420
//400
//400
//400
//300
//300
//300
//出力例1
//97

//受験結果 受験言語： C# 解答時間： 47分2秒 バイト数： 2196 Byte スコア： 32点  211209
//例題1,2,3はクリアしたのにめちゃ点数低いのはなぜ..？
//→sumPoint = 100; //持ち点のリセット が抜けてしまっていた為だった.

//受験結果 受験言語： C# 獲得ランク： Bランク スコア： 100点  211209