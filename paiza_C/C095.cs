using System.Collections.Generic;
using System.Linq;
using System;
//C095:合言葉
namespace paiza_C
{
    public class C095
    {
		private static string s,t;
		private static char[] aikotoba;
		private static char[] answer;

		internal static void main()
		{
			s = Console.ReadLine();
			t = Console.ReadLine();

			if(s == t || s.Length!= t.Length)
            {
				Console.WriteLine("NO");
			}
			else
            {
				Console.WriteLine(judgeChar());
            }
			
		}

		internal static string judgeChar()
		{
			aikotoba = s.ToCharArray();
			answer = t.ToCharArray();
			List<char> charAnswer = new List<char>(answer); //リストに変換
            for (int i = 0; i < aikotoba.Length; i++)
            {
				if (charAnswer.Contains(aikotoba[i]))charAnswer.Remove(aikotoba[i]);
			}
			if(charAnswer.Count == 0)
            {
				return "YES";
            }
            else { return "NO"; }
        }
	}
}


//受験結果 受験言語： C# 解答時間： 32分24秒 バイト数： 865 Byte スコア： 100点  220103
//s
//t
//・1行目に、合言葉を表す文字列 s が与えられます。
//・2 行目に、システムに入力される文字列 t が与えられます。
//・入力は 2 行となり、2 行目の末尾に改行が 1 つ入ります。