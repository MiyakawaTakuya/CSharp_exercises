using System.Collections.Generic;
 using System.Linq;
using System;
//B028:チャット記録  220424
//受験結果 受験言語： C# 解答時間： 55分3秒 バイト数： 2142 Byte スコア： 91点 正答率100%

namespace paiza_C
{
    public class B028
    {
		private static  List<Employee> empList = new List<Employee>();
		private static List<Group> groList = new List<Group>();

		private class Employee
		{
			internal Employee()
			{
				messages=new List<string>();
			}
			internal List<string> messages { get; set; }
		}

		private class Group
		{
			internal Group(List<int> a)
			{
				members = new List<int>(a);
			}
			internal List<int> members { get; set; }
		}

		internal static void main()
		{
			string[] strArray = Console.ReadLine().Trim().Split(' ');
			int[] intArray = strArray.Select(int.Parse).ToArray();
			int n = intArray[0];
			int g = intArray[1];
			int m = intArray[2];
			//社員 インスタンス生成 (配列の番号で管理するので注意)
			for (int i = 0; i < n; i++) empList.Add(new Employee());
			//グループの読み込み インスタンス生成 (配列の番号で管理するので注意)
			if (g != 0)
			{
				for (int i = 0; i < g; i++)
				{
					string[] strArray_g = Console.ReadLine().Trim().Split(' ');
					int[] intArray_g = strArray_g.Select(int.Parse).ToArray();
					int memNum = intArray_g[0];
					List<int> tmp_members = new List<int>();
					for (int j = 1; j <= memNum; j++)
					{
						tmp_members.Add(intArray_g[j]);
					}
					groList.Add(new Group(tmp_members));
				}
			}
			//メッセージを読み込みそれぞれの社員に保有させる
			for (int i = 1; i <= m; i++)
			{
				string[] strArray_m = Console.ReadLine().Trim().Split(' ');
				saveMessage(int.Parse(strArray_m[0]), int.Parse(strArray_m[1]), int.Parse(strArray_m[2]), strArray_m[3]);
			}
			//出力
			int count = 0;
			foreach(var mem in empList)
            {
				foreach (var mess in mem.messages) Console.WriteLine(mess);
				count++;
				if(count != empList.Count()) Console.WriteLine("--");
			}
		}

		internal static void saveMessage(int from,int toGroup,int to,string mess)
		{
            if (toGroup != 1)
            {
				empList[from - 1].messages.Add(mess);
				empList[to - 1].messages.Add(mess);
			}
            else
            {
				for (int j = 0; j < groList[to - 1].members.Count(); j++)
				{
					empList[groList[to - 1].members[j]-1].messages.Add(mess);
				}
			}
		}
	}
}

//入力例
//4 1 4
//2 3 2
//1 0 2 from1to2
//3 1 1 from3togroup1
//3 0 2 from3to2
//4 0 1 from4to1
