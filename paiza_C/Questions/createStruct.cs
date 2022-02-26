// using System.Collections.Generic;
 using System.Linq;
using System;
//構造体の作成
//220225 スコア100
//strcutの基本 http://dotnetcsharptips.seesaa.net/article/428850842.html

namespace paiza_C.Questions
{
    public class createStruct
    {
		private static int N;

		internal struct User
		{
			internal User(string n,string o, string b, string s)  //コンストラクタ
			{
				nickname = n;
				old = o;
				birth = b;
				state = s;
			}
			internal static string nickname { get; set; }
			internal static string old { get; set; }
			internal static string birth { get; set; }
			internal static string state { get; set; }
		}

		internal static void main()
		{
			N = int.Parse(Console.ReadLine());
			for (int i = 0; i < N; i++)
			{
				string[] strArray = Console.ReadLine().Trim().Split(' ');
				User u = new User(strArray[0], strArray[1], strArray[2], strArray[3]);
				Console.WriteLine("User{");
                Console.WriteLine("nickname : " + User.nickname);
				Console.WriteLine("old : " + User.old);
				Console.WriteLine("birth : " + User.birth);
				Console.WriteLine("state : " + User.state);
				Console.WriteLine("}");

			}
			
		}
	}
}
