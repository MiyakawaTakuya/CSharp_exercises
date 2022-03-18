using System.Collections.Generic;
using System.Linq;
using System;
//B020:ネットサーフィン

namespace paiza_C
{
    public class B020
    {
		private static List<string[]> sarfList = new List<string[]>();

		internal static void main()
		{
			int q = int.Parse(Console.ReadLine());
			for (int i = 0; i < q; i++)
			{
				string[] strArray = Console.ReadLine().Trim().Split(' ');
				sarfList.Add(strArray);
				Console.WriteLine(output(strArray, strArray[0] == "use"));
			}
		}

		internal static string output(string[] arr,bool isBack)
		{
            if (!isBack)
            {
				string[] skip = arr.Skip(2).ToArray();
				return String.Join(" ", skip);
			}
            else  //backだったら 
            {
				sarfList.RemoveAt(sarfList.Count()-1); //最後の要素消す
				sarfList.RemoveAt(sarfList.Count() - 1); //最後の要素消す
				return output(sarfList[sarfList.Count() - 1], false);
            }
		}
	}
}

//受験結果 受験言語： C# 解答時間： 44分6秒 バイト数： 952 Byte スコア： 98点  220319

//5
//go to blank page
//go to bja n
//go to va
//use the back button
//use the back button

//q_i(1 ≦ i ≦ n) は
//"use the back button"
//直前に開いていたページを開くクエリ
//"go to [page_name]"
//[page_name] という名前のページを開くクエリを表します。
//[page_name] は英小文字と半角スペースからなる文字列です。また、 q_1 は必ず "go to blank page" です。