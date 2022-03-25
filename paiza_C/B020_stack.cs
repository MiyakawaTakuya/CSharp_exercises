using System.Collections.Generic;
using System.Linq;
using System;
//https://atmarkit.itmedia.co.jp/ait/articles/1802/14/news014.html

namespace paiza_C
{
    public class B020_stack
	{ 
		private static Stack<string[]> sarfList = new Stack<string[]>();

		internal static void main()
		{
			int q = int.Parse(Console.ReadLine());
			for (int i = 0; i < q; i++)
			{
				string[] strArray = Console.ReadLine().Trim().Split(' ');
				if (strArray[0] != "use")
				{
					sarfList.Push(strArray);  //追加
					string[] skip = strArray.Skip(2).ToArray();
					Console.WriteLine(String.Join(" ", skip));
				}
				else
				{
					sarfList.Pop();  //取り出し
					string[] read = sarfList.Peek(); //参照
					string[] skip = read.Skip(2).ToArray();
					Console.WriteLine(String.Join(" ", skip));
				}
			}
		}
	}
}
//5
//go to blank page
//go to bja n
//go to va
//use the back button
//use the back button
