using System.Collections.Generic;
using System.Linq;
using System;
//C082:【推しプロコラボ問題】テストの赤点

namespace paiza_C
{
    public class C082
    {
		//フィールド
		private static int X,Y;
		private static int[,] results;
		//点数をそのまま格納する用
		private static List<int> Eng = new List<int>();
		private static List<int> Jap = new List<int>();
		private static List<int> Mat = new List<int>();
		//赤点リスト
		private static List<int> red_Eng = new List<int>();
		private static List<int> red_Jap = new List<int>();
		private static List<int> red_Mat = new List<int>();


		internal static void main()
		{
			//入力
			string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
			int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
			X = intArray[0];
			Y = intArray[1];  //下からY位までが赤点
			results = new int[X, 5];  //[eng,jap,mat,red,No] 二次元配列で一回チャレンジ
			for (int i = 0; i < X; i++)
			{
				string[] strArray2 = Console.ReadLine().Trim().Split(' ');
				int[] intArray2 = strArray2.Select(int.Parse).ToArray();
				results[i, 0] = intArray2[0];
				results[i, 1] = intArray2[1];
				results[i, 2] = intArray2[2];
				results[i, 3] = 0;
				results[i, 4] = i+1;
			}

			//各科目ごとに昇順の配列を算出する
			toList(Eng, 0);
			toList(Jap, 1);
			toList(Mat, 2);

			//重複しているものを省いた配列
			int[] rank_Eng = Eng.Distinct().ToArray();
			int[] rank_Jap = Jap.Distinct().ToArray();
			int[] rank_Mat = Mat.Distinct().ToArray();

			//赤点リスト →各生徒の科目ごとに見ていって、赤点が該当していたらポイントを追加していく
			addRedPoint(toRedList(red_Eng,rank_Eng, Eng), 0);
			addRedPoint(toRedList(red_Jap,rank_Jap, Jap), 1);
			addRedPoint(toRedList(red_Mat,rank_Mat, Mat), 2);

			//出力
			for (int k = 0; k < X; k++)
			{
				Console.WriteLine(results[k, 3]);
			}
				
		}

		//各科目のListを作成する
		internal static void toList(List<int> subject,int whitch)
		{
			for (int i = 0; i < X; i++)
			{
				subject.Add(results[i,whitch]);
			}
			subject.Sort();
		}
		//赤点の点数を格納した配列を作成  //TODO 格納する前にその赤点に該当する点をとっている人が何人いるか把握して、Yの値を超えないようにする
		internal static List<int> toRedList(List<int> red, int[] rank, List<int> input)
		{
			int redCount = 0;
			for (int i = 0; i < Y; i++)
			{
				redCount += input.Count(n => n == rank[i]);  //赤点に該当している総数
				red.Add(rank[i]);   //下からY位までの値を格納
				if (redCount >= Y) break;
			}
			return red;
		}
		//赤点の点数を追加していく関数
		internal static void addRedPoint(List<int> red,int witch)
		{
			for (int j = 0; j < X; j++)
			{
                if (red.Contains(results[j,witch]))
                {
					results[j, 3] += 1;
				}
			}
		}

		//プロパティ
		//private class Results
		//{
		//	public int No_ { get; set; }
		//	public int Eng { get; set; }
		//	public int Jap { get; set; }
		//	public int Mat { get; set; }
		//	public int Red { get; set; }
		//}

		//internal static void main()
		//{
		//	//入力
		//	string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
		//	int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
		//	X = intArray[0];
		//	Y = intArray[1];  //下からY位までが赤点
		//	Results[] results = new Results[X];
		//	for (int i = 0; i < X; i++)
		//	{
		//		string[] strArray2 = Console.ReadLine().Trim().Split(' '); 
		//		int[] intArray2 = strArray2.Select(int.Parse).ToArray();
		//		results[i].No_ = i + 1 ;
		//		results[i].Eng = intArray2[0];
		//		results[i].Jap = intArray2[1];
		//		results[i].Mat = intArray2[2];
		//		results[i].Red =0;
		//	}

		//	//各科目で点数を昇順で算出する
		//	//英語
		//	IOrderedEnumerable<Results> orderedEng = results.OrderBy(value => value.Eng);
		//	Results[] resultArray = orderedEng.Distinct().ToArray();

		//	//赤点の分だけその人ごとにポイントを示す

		//	//出力
		//	Console.WriteLine();
		//}


	}
}

//受験結果 受験言語： C# 解答時間： 1077分0秒 バイト数： 2448 Byte スコア： 0点  220110
//激ムズ　もっとやりやすい関数とかあるはず　力技でなんとか　一晩寝かせてしまった

//X Y
//E_1 J_1 M_1
//E_2 J_2 M_2
//...
//E_X J_X M_X
//・1 行目にはテストを受けた生徒の人数を表す整数 X と赤点となってしまう下からの順位を表す整数 Y がこの順で半角スペース区切りで与えられます。
//・続く X 行のうち、i 行目(1 ≦ i ≦ X)には i 番目の生徒の英語、国語、数学の点数を表す整数 E_i, J_i, M_i がこの順で半角スペース区切りで与えられます。
//・入力は合計で X + 1 行となり、末尾に改行が 1 つ入ります。