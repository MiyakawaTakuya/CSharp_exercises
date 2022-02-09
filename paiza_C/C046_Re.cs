using System;
using System.Collections.Generic;
using System.Linq;
//受験結果 受験言語： C# 獲得ランク： Cランク スコア： 100点  220208  20minくらい

namespace paiza_C
{
    public class C046_Re
    {
		internal static void main()
		{
            //入力
            int N = int.Parse(Console.ReadLine());
            string[] ArrayData = Console.ReadLine().Trim().Split(' ');
            var member = new Dictionary<string, int>();  //名前と金額の合計を入れる箱
            for (int i = 0; i < N; i++)
            {
                member.Add(ArrayData[i], 0);
            }
            int M = int.Parse(Console.ReadLine());
            for (int i = 0; i < M; i++)
            {
                string[] ArrayData2 = Console.ReadLine().Trim().Split(' ');
                member[ArrayData2[0]] += int.Parse(ArrayData2[1]);  //該当する名前のところに金額をたす
            }

            //一度リストに変換して並べ替え
            var memList = member.ToList();
            //memList.Sort((pair1, pair2) => pair1.Value.CompareTo(pair2.Value));  //昇順
            memList.Sort((pair1, pair2) => pair2.Value.CompareTo(pair1.Value));  //降順
            //出力
            foreach (var value in memList)
            {
                Console.WriteLine(value.Key);
            }
        }
	}
}
