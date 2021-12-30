using System;
using System.Linq;

//C102: 行きたいライブのスケジュール
namespace paiza_C
{
    public class C102
    {
		//フィールド
		private static int[] liveA = new int[31];
        private static int[] liveB = new int[31];
        private static int check = 0;  //状態管理. 次Aいく時は0, 次Bいく時は1

        internal static void main()
		{
            input();
            scrutinize();
		}

        internal static void input()
        {
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                int a = int.Parse(Console.ReadLine());
                liveA[a - 1] = 1;  //該当する日にちのところに1を入れる.空のところは0になってる
            }
            int M = int.Parse(Console.ReadLine());
            for (int i = 0; i < M; i++)
            {
                int b = int.Parse(Console.ReadLine());
                liveB[b - 1] = 1;  //該当する日にちのところに1を入れる
            }
        }

        internal static void scrutinize()
		{
            for (int i = 0; i < 31; i++)
            {
                if(liveA[i]==0 && liveB[i] == 0) Console.WriteLine("x");
                else if (liveA[i] == 1 && liveB[i] == 0) Console.WriteLine("A");
                else if (liveA[i] == 0 && liveB[i] == 1) Console.WriteLine("B");
                else if (liveA[i] == 1 && liveB[i] == 1) booking();
            }
        }

        internal static void booking()
        {
            if (check == 0) { Console.WriteLine("A"); check = 1; }
            else if (check == 1) { Console.WriteLine("B"); check = 0; }
        }
    }
}

//受験結果 受験言語： C# 解答時間： 35分27秒 バイト数： 1466 Byte スコア： 100点

//M
//a_1
//a_2
//...
//a_M
//N
//b_1
//b_2
//...
//b_N
//・1 行目に A のライブ日数を表す整数 M が与えられます。
//・続く M 行のうちの i 行目 (1 ≦ i ≦ M) には、バンド A の i 番目のライブの日を表す整数 a_i (1 ≦ a_i ≦ 31) が与えられます。
//・続く 1 行には B のライブ日数を表す整数 N が与えられます。
//・続く N 行のうちの i 行目 (1 ≦ i ≦ N) には、バンド B の i 番目のライブの日を表す整数 b_i (1 ≦ b_i ≦ 31) が与えられます。
//・入力は合計で M + 1 + N + 1 行となり、入力値最終行の末尾に改行が 1 つ入ります。

//a_1
//a_2
//...
//a_31
//・期待する出力は 31 行からなります。
//・ 行目 (1 ≦ i ≦ 31) にはそれぞれ今月の i 日目にバンド A とバンド B のいずれのライブに行くかを表す文字列を出力してください。
//　・バンド A のライブに行く場合は、大文字アルファベットの "A" を出力してください。
//　・バンド B のライブに行く場合は、大文字アルファベットの "B" を出力してください。
//　・ライブがない場合小文字アルファベットの "x" を出力してください。