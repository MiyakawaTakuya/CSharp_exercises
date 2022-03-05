using System.Linq;
using System;
//B017:手役の強さ
//受験結果 受験言語： C# 解答時間： 45分5秒 バイト数： 1512 Byte スコア： 68点  3/20間違い...  220305
//受験結果 受験言語： C# 獲得ランク： Bランク スコア： 100点 コメントアウトのところ少し修正で通った

namespace paiza_C
{
    public class B017
    {
        internal static void main()
		{
			char[] chararray = Console.ReadLine().ToCharArray();
			Array.Sort(chararray);  //*DZZ

			Console.WriteLine(yakuAll_ck(chararray));
		}

		internal static string yakuAll_ck(char[] cha)
		{
            if (four_ck(cha)) return "FourCard";
			else if (three_ck(cha)) return "ThreeCard";
			else if (two_ck(cha)) return "TwoPair";
			else if (one_ck(cha)) return "OnePair";
			else  return "NoPair";
		}

		internal static bool four_ck(char[] cha)
		{
			var chaDis = cha.Distinct();
			if (chaDis.Count() == 1)
            {
				return true;
            }else if(chaDis.Contains('*') && chaDis.Count() == 2)
            {
				return true;
            }
			return false;
		}

		internal static bool three_ck(char[] cha)
		{
			if ((cha[0]== cha[1] && cha[1] == cha[2]) || (cha[1] == cha[2] && cha[2] == cha[3]))
			{
				return true;
			}
			var chaDis = cha.Distinct();
			if (chaDis.Contains('*') && chaDis.Count() == 3)
			{
				return true;
			}
			return false;
		}

		internal static bool two_ck(char[] cha)
		{
			var chaDis = cha.Distinct();
            if (chaDis.Contains('*'))
			{
				return false;
			}
            else if(chaDis.Count() == 2)
			{
				return true;
			}
			return false;
		}
		internal static bool one_ck(char[] cha)
		{
			var chaDis = cha.Distinct();
			//if (chaDis.Contains('*'))
			//{
			//	return false;
			//}
			if (chaDis.Contains('*')&& chaDis.Count() == 4)
			{
				return true;
			}
			else if (!chaDis.Contains('*') && chaDis.Count() == 3)
			{
				return true;
			}
			return false;
		}


	}
}
