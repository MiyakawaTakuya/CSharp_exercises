// using System.Collections.Generic;
using System.Linq;
using System;
//C080:【2020年七夕問題】ボタンを押すゲーム

namespace paiza_C
{
    public class C080
    {
		//フィールド
		private static int N,Y,M,x,y,count;
		//private static int[] correctArray;

		internal static void main()
		{
			//入力
			string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
			int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
			N = intArray[0];
			Y = intArray[1];
			M = int.Parse(Console.ReadLine());
			string[] strArray2 = Console.ReadLine().Trim().Split(' ');  //読み取り
			int[] touchButArray = strArray2.Select(int.Parse).ToArray();  //intへ変換

			//正解のArrayを作成する
			int[] correctArray = new int[M];
			while(true)
            {
			    for (int i = 0; i < M; i++)
			    {
					if (count == M) break;
			    	if(i < N)
                    {
			    		correctArray[count] = i + 1;
						count++;
			    	}
			    	else if(i == N)
                    {
			    		i = -1;
                    }
			    }
				break;
			}

			//出力
			Console.WriteLine(judge(correctArray, touchButArray));
		}

		//正解のと比較して行ってxyをカウント
		internal static int judge(int[] cor, int[] tou)
		{
			for (int i = 0; i < M; i++)
			{
				if(cor[i]==tou[i])
                {
					x++;
                }
                else
                {
					y++;
                }
			}

			if(y < Y)
            {
				return x * 1000;
            }
			else
            {
				return -1;
			}
		}
	}
}

//受験結果 受験言語： C# 解答時間： 36分12秒 バイト数： 1345 Byte スコア： 80点  220109 正答率100

//N Y
//M
//a_1 a_2 ... a_M
//・1 行目にボタンの数を表す整数 N、ゲームオーバーになる誤ったボタンを押す回数を表す整数 Y がこの順に半角スペース区切りで与えられます。
//・2 行目にボタンを押した回数を表す整数 M が与えられます。
//・3 行目に i 番目 (1 ≦ i ≦ M) の操作ログを表す整数 a_i が半角スペース区切りで与えられます。
//・入力は合計で 3 行となり、入力値最終行の末尾に改行が 1 つ入ります。
//ただし、ゲームオーバーになる場合はスコアの代わりに - 1 を出力してください。