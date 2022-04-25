// using System.Collections.Generic;
using System.Linq;
using System;
//C061:繰り上がりのない足し算  220425 
//"ones place"...一の位、”tens place"...十の位、”hundreds place"...百の位

namespace paiza_C
{
    public class C061_Ano2
    {
		//各位の１文字を受け取って一時的に数値に置き換えて足して、一の位だけをstringで返す関数
		internal static string SumEachDigit(string numA_, string numB_)
		{
			string numA = normalizeThreeDigit(numA_);
			string numB = normalizeThreeDigit(numB_);

		}

		internal static string normalizeThreeDigit(string str)
		{
			string tmpStr = ("000" + str);
			return tmpStr.Substring(tmpStr.Length - 3);  // slice second harf string like "00056 → 056".
		}

		internal static string addWithoutCarryforward(string a, string b)
		{
			int sum = int.Parse(a) + int.Parse(b);
			if (sum >= 10)
            {
                return sum.ToString().Substring(1, 1);  
            }
            else
            {
                return sum.ToString();  //足しても一桁だったらそのまま返す
            }

		}

		internal static void main()
		{
			string[] strArray = Console.ReadLine().Trim().Split(' ');
			string answer = SumEachDigit(strArray[0], strArray[1]);

			Console.WriteLine();
		}
	}
}