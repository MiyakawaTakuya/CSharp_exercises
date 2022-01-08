using System.Collections.Generic;
using System.Linq;
using System;
//C044:手の組み合わせ

namespace paiza_C
{
    public class C044
    {
		//フィールド
		//private static string[] janken;

		internal static void main()
		{
			int N = int.Parse(Console.ReadLine());
			string[] janken = new string[N];
			for (int i = 0; i < N; i++)
			{
				janken[i] = Console.ReadLine();
			}
			judge(janken);
			
		}

		internal static void judge(string[] jan)
		{
            if (jan.Contains("paper") && jan.Contains("rock") && jan.Contains("scissors"))
            {
				Console.WriteLine("draw");
			}
			else if (jan.Contains("paper") && jan.Contains("rock") && !jan.Contains("scissors"))
			{
				Console.WriteLine("paper");
			}
			else if (jan.Contains("paper") && !jan.Contains("rock") && jan.Contains("scissors"))
			{
				Console.WriteLine("scissors");
			}
			else if ( !jan.Contains("paper") && jan.Contains("rock") && jan.Contains("scissors"))
			{
				Console.WriteLine("rock");
			}
			else  //一種類しかなかった場合
            {
				Console.WriteLine("draw");
			}

		}
	}
}

//受験結果 受験言語： C# 解答時間： 9分32秒 バイト数： 934 Byte スコア： 80点  境界データで失点２つ
//受験結果 受験言語： C# 獲得ランク： Cランク スコア： 100点  一種類しかなかった場合をdrawにしてないぽかみす

//N
//a_1
//a_2
//...
//a_N
//・入力は合計で N + 1 行となり、入力値最終行の末尾に改行が１つ入ります。
//・1 行目には、じゃんけんへの参加者の数を表します。
//・続く N 行のうち i 行目 (1 ≦ i ≦ N) に i 番目の参加者の出した手を表す文字列 a_i が与えられます。