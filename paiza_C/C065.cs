using System.Collections.Generic;
using System.Linq;
using System;
//C065:【ぱいじょ！コラボ問題】数字あてゲーム

namespace paiza_C
{
    public class C065
    {
		//フィールド
		private static int x;
		private static Dictionary<string, int> unequalSign = new Dictionary<string, int>() { { "<", 101 }, { ">", 0 } };
		private static List<int> slash = new List<int>();

		internal static void main()
		{
			//入力  <>はDictionaryで管理  /はListで管理
			int N = int.Parse(Console.ReadLine());
			for (int i = 0; i < N; i++)
			{
				string[] strArray = Console.ReadLine().Trim().Split(' '); //読み取り
				store(strArray[0], int.Parse(strArray[1]));
			}

			//出力
			Console.WriteLine(selectOne(candidates()));
		}

		//条件の値を格納していく
		internal static void store(string a ,int b)
		{
			if(a == "<")  //最大
            {
				if(unequalSign[a] > b)  //より厳しい条件の値がきたら入れ替ええる
				{
					unequalSign[a] = b;
				}
            }
			else if (a == ">")  //最小
			{
				if (unequalSign[a] < b)  //より厳しい条件の値がきたら入れ替ええる
				{
					unequalSign[a] = b;
				}
			}
			else if (a == "/")  
			{
				slash.Add(b);
			}
		}

		//候補の数を書き出す
		internal static List<int> candidates()
		{
            int min = unequalSign[">"] + 1;
			int max = unequalSign["<"];
			List<int> cand = new List<int>();
			int x = min;
			while(x >= min && x < max)
            {
				cand.Add(x);
				x++;
            }
			return cand;
		}

		//割り切れる値を算出して返す
		internal static int selectOne(List<int> cans)
		{
			int listcount = slash.Count;
			List<int> onStage = new List<int>(cans);  //ダミーとしてインスタンスから生成する(代入だと参照してしまう)
			for (int k = 0; k < listcount; k++)
			{
			    foreach(int c in cans)  //ダミーを生成しないとここのインデックスの部分が動的になって不具合起きる
                {
			    	if (c % slash[k] != 0)
                    {
						onStage.Remove(c);
					}
                }
			}
			return onStage[0];
		}

	}
}

//受験結果 受験言語： C# 解答時間： 78分12秒 バイト数： 1683 Byte スコア： 0点  時間切れ 正答率は100

//問題集計
//難易度： 1938 ±7
//受験者数： 5,132人
//正解率： 49.44％
//平均解答時間： 25分58秒
//平均スコア： 47.38点
//N
//o_1 x_1
//o_2 x_2
//...
//o_N x_N
//・1 行目にはヒントの数を表す整数 N が与えられます。
//・続く N 行のうちの i 行目 (1 ≦ i ≦ N) には、i 番目のヒントの種類を表す記号 o_i と i 番目のヒントの変数を表す整数 x_i がこの順に半角スペース区切りで与えられます。
//・入力は合計で N + 1 行となり、入力値最終行の末尾に改行が １ つ入ります。
//すべてのテストケースにおいて、以下の条件をみたします。

//・1 ≦ N ≦ 10
//・各 i(1 ≦ i ≦ N) について
//　・o_i は半角記号で ">", "<", "/" のいずれか
//　・1 ≦ x_i ≦ 100
//・N 個の条件を満たす正整数は一意に定まる。