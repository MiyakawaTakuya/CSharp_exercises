using System;
using System.Linq;
//C028:単語テストの採点

namespace paiza_C
{
    public class C028
    {
		//フィールド
		private static int pointSum = 0;
		private static char[] answer; 
		private static char[] correct;
		private static int missCount = 0;

		internal static void main()
		{
			int N = int.Parse(Console.ReadLine());
			for (int i = 0; i < N; i++)
			{
				string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
				if (lenthCheck(strArray[0], strArray[1])) charCheck(strArray[0], strArray[1]);
			}
			Console.WriteLine(pointSum);
		}

		internal static bool lenthCheck(string a, string b)
		{
			if (a.Length == b.Length) return true; return false;
		}

		private static void charCheck(string a, string b)
		{
			correct = a.ToCharArray();
			answer = b.ToCharArray();
			for (int i = 0; i < a.Length; i++)
			{
				if (correct[i] != answer[i]) missCount++;
			}
			switch (missCount)  //得点入れる
			{
				case 0: pointSum += 2; break;
				case 1: pointSum += 1; break;
				default: break;
			}
		}
	}
}

//受験結果 受験言語： C# 解答時間： 43分3秒 バイト数： 986 Byte スコア： 72点

//N
//q_1 a_1
//q_2 a_2
//...
//q_N a_N

//・1 行目に問題数を表す N が与えられます。
//・続く N 行のうち i 行目 (1 ≦ i ≦ N) には各問題の正解 q_i と生徒の解答 a_i がこの順に半角スペース区切りで与えられます。
//・入力は合計で N + 1 行となり、入力値最終行の末尾に改行が１つ入ります
