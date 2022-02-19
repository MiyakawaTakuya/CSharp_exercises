using System.Collections.Generic;
using System.Linq;
using System;
//A057: 最長スワイプ
//受験結果 受験言語： C# 解答時間： 171分23秒 バイト数： 6743 Byte スコア： 90点  全問正解
//でも評価はEの見習いコーダーだった....
//受験者数： 1,155人 正解率： 75.55％ 平均解答時間： 79分13秒 平均スコア： 71.95点

namespace paiza_C
{
    public class A057
    {
		//フィールド
		private static int N,delta, LongestSwipe, ahead, now,len, count_p, count_m;
		private static int[,] table;

		internal static void main()
		{
			//入力
			N = int.Parse(Console.ReadLine());
			table = new int[N,N];
			for (int i = 0; i < N; i++)
			{
				string str = Console.ReadLine();
				for (int j = 0; j < N; j++)
				{
					table[i,j] = int.Parse(str[j].ToString());
				}
			}
            //スワイプ
			swipeLine();
            swipeColumn();
            swipeDiagonally();
            //出力
            Console.WriteLine(LongestSwipe+1);
		}

		internal static void swipeLine()
		{
			//上の行から順に読み込んでいく
			for (int i = 0; i < N; i++)
			{
				count_p = 0;
				count_m = 0;
				ahead = table[i, 0];
                for (int j = 1; j < N; j++)
                {
                    now = table[i, j];
                    LongestSwipe_check(ahead, now);
                    ahead = now;
				}
            }
		}

        internal static void swipeColumn()
        {
            //一番左の列から順に読み込んでいく
            for (int i = 0; i < N; i++)
            {
                count_p = 0;
                count_m = 0;
                ahead = table[0, i];
                for (int j = 1; j < N; j++)
                {
                    now = table[j, i];
                    LongestSwipe_check(ahead, now);
                    ahead = now;
                }
            }
        }

        internal static void swipeDiagonally()
        {
            ///左上から右下にかけて斜め方向を順に読み込んでいく
            //左上から真ん中の最長部分までのスワイプについて
            for (int i = 1; i < N; i++)
            {
                count_p = 0;
                count_m = 0;
                len = i - 0 + 1;
                ahead = table[0, i];
                for (int j = 1; j < len; j++)
                {
                    now = table[j, i-1 - j + 1];  //要検証
                    LongestSwipe_check(ahead, now);
                    ahead = now;
                }
            }
            //最長部の次から右下部分までのスワイプ
            for (int k = 1; k <= N-2; k++)
            {
                count_p = 0;
                count_m = 0;
                len = (N-1)-k+1;
                ahead = table[k, N - 1];
                for (int l = 1; l < len; l++)
                {
                    now = table[k+l, N-1-l];
                    LongestSwipe_check(ahead, now);
                    ahead = now;
                }
            }

            ///右上から左下にかけて斜め方向を順に読み込んでいく
            //右上から真ん中の最長部分までのスワイプについて
            for (int i = N-2; i >= 0; i--)
            {
                count_p = 0;
                count_m = 0;
                len = N - i ;
                ahead = table[0, i];
                for (int j = 1; j < len; j++)  //
                {
                    now = table[j, i + 1 +j - 1];   //要検証→多分大丈夫
                    LongestSwipe_check(ahead, now);
                    ahead = now;
                }
            }
            //最長部の次から左下部分までのスワイプ
            for (int k = 1; k <= N-2; k++)
            {
                count_p = 0;
                count_m = 0;
                len = N - k;
                ahead = table[k, 0];
                for (int l = 1; l < len; l++)  //
                {
                    now = table[k + l, l];
                    LongestSwipe_check(ahead,now);
                    ahead = now;
                }
            }
        }

        internal static void LongestSwipe_check(int ahe,int no)
        {
            delta = no - ahe;
            if (delta == 1)
            {
                count_p++;
                count_m = 0;
            }
            else if (delta == -1)
            {
                count_m++;
                count_p = 0;
            }
            else
            {
                count_p = 0;
                count_m = 0;
            }
            int[] _ = { LongestSwipe, count_p, count_m };
            LongestSwipe = _.Max();
        }

    }
}

//入力は次のフォーマットで与えられます。
//N
//s_1
//s_2
//...
//s_N
//・1 行目には縦横に並ぶ数字の数を表す整数 N が与えられます。
//・続く N 行のうちの i 行目 (1 ≦ i ≦ N) には、半角数字からなる長さ N の文字列 s_i が与えられます。s_i の j 番目 (1 ≦ j ≦ N) の文字はゲーム上の i 行 j 列の数字を表します。
//・入力は合計で N + 1 行となり、入力値最終行の末尾に改行が 1 つ入ります。

//入力例2
//6
//390154
//523713
//611375
//652114
//219785
//745000

//出力例2
//3

/////ロジック組み立て
//縦・横・斜めをそれぞれ別々に読み込んでいく関数を用意する

//横
//各行ごとに1ずつ変化する回数が何回あるのかをカウントしていく。(１ずつor-1ずつの両方で検証していく)
//都度LongestSwipeを更新していく