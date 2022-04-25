// using System.Collections.Generic;
using System.Linq;
using System;
//C061:繰り上がりのない足し算  
//受験結果 受験言語： C# 獲得ランク： Cランク スコア： 100点  220425
//"ones place"...一の位、”tens place"...十の位、”hundreds place"...百の位
//func string.Substring https://itsakura.com/csharp-substring

namespace paiza_C
{
    public class C061_Ano2
    {
		internal static void main()
		{
			string[] strArray = Console.ReadLine().Trim().Split(' ');
			Console.WriteLine(SumEachDigit(strArray[0], strArray[1]));
		}

		internal static string SumEachDigit(string _numA, string _numB)
		{
			int maxDigit = Math.Max(_numA.Length, _numB.Length);  //get biggest digit in two intger.
			string numA = normalizeThreeDigit(_numA);
			string numB = normalizeThreeDigit(_numB);
			string answer =
				addWithoutCarryforward(numA.Substring(0, 1), numB.Substring(0, 1))
				+ addWithoutCarryforward(numA.Substring(1, 1), numB.Substring(1, 1))
				+ addWithoutCarryforward(numA.Substring(2, 1), numB.Substring(2, 1));
			if (maxDigit == 1) answer = answer[2].ToString();
			else if (maxDigit == 2) answer = answer[1].ToString() + answer[2].ToString();
			return answer;
		}

		internal static string normalizeThreeDigit(string str)
		{
			string tmpStr = ("000" + str);
			return tmpStr.Substring(tmpStr.Length - 3);  // slice second harf string like "00056 → 056".
		}

		internal static string addWithoutCarryforward(string a, string b)
		{
			int sum = int.Parse(a) + int.Parse(b);
			if (sum >= 10) return sum.ToString().Substring(1, 1);  //if two-digit intger, slice one-digit 
			else return sum.ToString();  
		}


	}
}