using System.Collections.Generic;
using System.Linq;
using System;
//構造体の検索
//220225 スコア100
//結局classでといた staticという概念がいまいち良くわかってない...

namespace paiza_C.Questions
{
    public class SearchForStruct
    {
		public class student
		{
			public student(string n, string o, string b, string s)  //メンバー変数のコンストラクタ
			{
				name = n;
				old = o;
				birth = b;
				state = s;
			}
			public string name { get; set; }  //static入れるとエラーになった
			public string old { get; set; }
			public string birth { get; set; }
			public string state { get; set; }
		}

		internal static void main()
		{
			int N = int.Parse(Console.ReadLine());
			List<student> stu = new List<student>();
			for (int i = 0; i < N; i++)
			{
				string[] strArray = Console.ReadLine().Trim().Split(' ');
				stu.Add(new student(strArray[0], strArray[1], strArray[2], strArray[3]));
			}
			string age = Console.ReadLine();
			string ageToName = stu.Find(x => x.old == age).name;
			//静的メンバ member にはインスタンス参照でアクセスできないので、代わりに型名で修飾する。
			Console.WriteLine(ageToName);
		}
	}
}
