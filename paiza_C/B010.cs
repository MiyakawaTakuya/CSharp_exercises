using System.Collections.Generic;
using System.Linq;
using System;
//B010:サッカーのオフサイド判定

namespace paiza_C
{
	public class B010
	{
		//フィールド
		//private static int[] teamA = new int[11];
		//private static int[] teamB = new int[11];
		private static List<int> teamA = new List<int>();
		private static List<int> teamB = new List<int>();
		private static Dictionary<int, int> dicTeamA = new Dictionary<int, int>() { { 1, 0 }, { 2, 0 }, { 3, 0 }, { 4, 0 }, { 5, 0 }, { 6, 0 }, { 7, 0 }, { 8, 0 }, { 9, 0 }, { 10, 0 }, { 11, 0 } };
		private static Dictionary<int, int> dicTeamB = new Dictionary<int, int>() { { 1, 0 }, { 2, 0 }, { 3, 0 }, { 4, 0 }, { 5, 0 }, { 6, 0 }, { 7, 0 }, { 8, 0 }, { 9, 0 }, { 10, 0 }, { 11, 0 } };
		private static int passStart;
		private static int offSidePoint;
		private static string passTeam;
		private static List<int> offSideMem = new List<int>();

		internal static void main()
		{
			//入力
			string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
			passTeam = strArray[0];
			passStart = int.Parse(strArray[1]);

			string[] strArrayA = Console.ReadLine().Trim().Split(' ');
			teamA = strArrayA.Select(int.Parse).ToList();
			string[] strArrayB = Console.ReadLine().Trim().Split(' ');
			teamB = strArrayB.Select(int.Parse).ToList();
			for (int i = 1; i <= 11; i++)
			{
				dicTeamA[i] = teamA[i - 1];
				dicTeamB[i] = teamB[i - 1];
			}
			//対象を絞っていく
			//敵陣にいるメンバーを算出
			if (passTeam == "A")
			{
				areaB();
                if (offSideMem.Count==0)
                {
					Console.WriteLine("None");
				}
                else
                {
					for (int j = 0; j < offSideMem.Count; j++)
					{
						Console.WriteLine(dicTeamA.FirstOrDefault(x => x.Value.Equals(offSideMem[j])).Key);
					}
				}

			}
			else
			{
				areaA();
				if (offSideMem.Count == 0)
				{
					Console.WriteLine("None");
				}
				else
				{
					for (int j = 0; j < offSideMem.Count; j++)
					{
						Console.WriteLine(dicTeamB.FirstOrDefault(x => x.Value.Equals(offSideMem[j])).Key);
					}
				}
			}
		}

		internal static void areaA()
		{
			int passS = dicTeamB[passStart];
			teamA.OrderBy(a => a);  //昇順
			offSidePoint = teamA[1];
			for (int i = teamB.Count - 1; i >= 0; i--)
			{
				if (teamB[i] > 55) teamB.RemoveAt(i);
				if (teamB[i] > passS) teamB.RemoveAt(i);
			}

			for (int i = 0; i < teamB.Count; i++)
			{
				if (offSidePoint < teamB[i]) offSideMem.Add(teamB[i]);
			}
		}
		internal static void areaB()
		{
			int passS = dicTeamA[passStart];
			teamB.OrderByDescending(a => a);  //降順
			offSidePoint = teamB[1];
			for (int i = teamA.Count - 1; i >= 0; i--)
			{
				if (teamA[i] <= 55)teamA.RemoveAt(i);
				if (teamA[i] <= passS) teamA.RemoveAt(i);
			}
			for (int i = 0; i < teamA.Count; i++)
			{
				if(offSidePoint< teamA[i]) offSideMem.Add(teamA[i]);
			}
		}
	}
}
//18:52

//'''
//オフサイドになる条件
//1.味方チームの選手からのパスを受け取る。
//2.パスを受け取る選手が敵チームの陣にいる。
//今回はチームAとチームBの試合を考えます。
//チームAの陣はx座標が0以上55以下の位置で、ゴールラインはx座標が0の位置、
//チームBの陣はx座標が55以上110以下の位置で、ゴールラインはx座標が110の位置です。
//3. 「パスを出した選手」よりも、敵チームのゴールラインの近くにいる。
//　　(パスを出した選手とx座標が同じなら、オフサイドにならない)
//4. 「敵チームのゴールラインから2人目の敵チームの選手」よりも、敵チームのゴールラインの近くにいる。
//　　(2番目の選手とx座標が同じなら、オフサイドにならない)
//'''
//与えられたサッカーの試合状況に対して、次のパスを受け取るとオフサイドと判定される選手の背番号を小さいものから順に
//1行ずつ出力してください。
//オフサイドと判定される選手がいない場合には、"None"と1行で出力してください。