using System.Collections.Generic;
using System.Linq;
using System;

namespace paiza_C.Questions
{
    public class AdjacencyMatrix
    {
		internal static void main()
		{
			int N = int.Parse(Console.ReadLine());
			int[,] matrix = new int[N, N];
			for (int i = 0; i < N-1; i++)
			{
				string[] strArray = Console.ReadLine().Trim().Split(' ');
				int[] intArray = strArray.Select(int.Parse).ToArray();
				matrix[intArray[0] - 1, intArray[1] - 1] = 1;
				matrix[intArray[1] - 1, intArray[0] - 1] = 1;
			}

			for (int i = 0; i < N; i++)
			{
				for (int p = 0; p < N; p++)
				{
					if (p != N - 1) Console.Write(matrix[i,p] + " ");
					else Console.Write(matrix[i, p]);
				}
				Console.WriteLine("");  //改行
			}
		}
	}

	public class AdjacencyList
	{
		internal static void main()
		{
			int N = int.Parse(Console.ReadLine());
			int[,] matrix = new int[N, N];
			for (int i = 0; i < N - 1; i++)
			{
				string[] strArray = Console.ReadLine().Trim().Split(' ');
				int[] intArray = strArray.Select(int.Parse).ToArray();
				matrix[intArray[0] - 1, intArray[1] - 1] = 1;
				matrix[intArray[1] - 1, intArray[0] - 1] = 1;
			}

			for (int i = 0; i < N; i++)
			{
				List<int> temp = new List<int>();
				for (int p = 0; p < N; p++)
				{
					if (matrix[i, p] != 0) temp.Add(p + 1);
				}
				Console.WriteLine(string.Join(" ",temp));  //改行
			}
		}
	}

	//ロジックはあってるはずだし、正当例とほぼ同じなのにランタイムエラー祭り....w ２割正解
	public class IsThereTheEdge
	{
		internal static void main()
		{
			string[] strArray_ = Console.ReadLine().Trim().Split(' ');
			int[] intArray_ = strArray_.Select(int.Parse).ToArray();
			int N = intArray_[0];
			int K = intArray_[1];
			int[,] matrix = new int[N, N];
			for (int i = 0; i < N - 1; i++)
			{
				string[] strArray = Console.ReadLine().Trim().Split(' ');
				int[] intArray = strArray.Select(int.Parse).ToArray();
				matrix[intArray[0] - 1, intArray[1] - 1] = 1;
				matrix[intArray[1] - 1, intArray[0] - 1] = 1;
			}

			for (int j = 0; j < N - 1; j++)
			{
				string[] strArray2 = Console.ReadLine().Trim().Split(' ');
				int[] intArray2 = strArray2.Select(int.Parse).ToArray();
				if(matrix[intArray2[0] - 1, intArray2[1] - 1] != 1) Console.WriteLine("NO");
				else Console.WriteLine("YES");
			}
		}
	}

	//葉は言い換えると、接続する辺が 1 本のみであるような頂点
	public class LeafJudgment
    {
    	internal static void main()
    	{
			int N = int.Parse(Console.ReadLine());
			int[,] matrix = new int[N, N];
			for (int i = 0; i < N - 1; i++)
			{
				string[] strArray = Console.ReadLine().Trim().Split(' ');
				int[] intArray = strArray.Select(int.Parse).ToArray();
				matrix[intArray[0] - 1, intArray[1] - 1] = 1;
				matrix[intArray[1] - 1, intArray[0] - 1] = 1;
			}

			for (int i = 0; i < N; i++)
			{
				List<int> temp = new List<int>();
				for (int p = 0; p < N; p++)
				{
					if (matrix[i, p] != 0) temp.Add(p + 1);
				}
				if(temp.Count()==1) Console.WriteLine(i+1);
			}
		}
    }

	//木の中心 (paizaランク B 相当)  →まだ未完成のコード
	//葉となっている頂点とそれに接続する辺を木から取り除く。
	//を頂点が 1 つ、または 2 つとなるまで操作を繰り返していき、残った頂点を（元の） 木の中心とする
	public class TreeCenter
	{
		static int N;
		static int[,] matrix;

		internal static void main()
		{
			N = int.Parse(Console.ReadLine());
			matrix = new int[N, N];
			for (int i = 0; i < N - 1; i++)
			{
				string[] strArray = Console.ReadLine().Trim().Split(' ');
				int[] intArray = strArray.Select(int.Parse).ToArray();
				matrix[intArray[0] - 1, intArray[1] - 1] = 1;
				matrix[intArray[1] - 1, intArray[0] - 1] = 1;
			}
            CutToTreeCenter();
		}
		//手順
		//①葉を取り除く
		//②取り除かれた後の要素数をカウントする
		//③2以下でなかったら①から繰り返す
		//④出力

		internal static void CutToTreeCenter()
        {
			//葉を削る
			List<int[]> cutList = new List<int[]>();
            for (int i = 0; i < N; i++)
			{
				
				int count_ = 0;
				int tempIndex = 0;
				for (int p = 0; p < N; p++)
				{
					if (matrix[i, p] != 0)
					{
						count_++;
						tempIndex = p;
					}
				}
				if (count_ == 1)
				{
					cutList.Add(new int[] {i, tempIndex});
					cutList.Add(new int[] {tempIndex,i});
				}
			}
			foreach (int[] ab in cutList)
			{
				matrix[ab[0], ab[1]] = 0;
				matrix[ab[1], ab[0]] = 0;
			}


            List<int> edgeNum = new List<int>();
			int count = 0;
            for (int i = 0; i < N; i++)
            {
				for (int j = 0; j < N; j++)
				{
                    if (matrix[i, j] != 0)
                    {
						count++;
                    }
                }
				edgeNum.Add(count);
			}
			if (count <= 2)
			{
				for (int i = 0; i < N; i++)
				{
					if (edgeNum[i] > 0) Console.WriteLine(i + 1);
				}
			}
			else CutToTreeCenter();
		}
	}
	//	葉となっている頂点を探し、その頂点とそれに接続する辺を削除する操作を、頂点数が 2 以下になるまで続けましょう。
	//辺の削除は、木の情報を持つ隣接リストから削除された辺で隣接していた頂点を削除したり、
	//隣接行列の辺で隣接していた頂点の値を 1 → 0 に修正することで行うことができます。
	//頂点の削除は、木から取り除かれた（次数が 0 になった）頂点番号を記憶しておくことで行うことができます。
	//C++の回答例
	//隣接リストを用いて実装しています。
	//配列 exist で頂点が木に属するかどうかを管理しています。 頂点番号 i が木に属するとき exist[i - 1] が 1 に、
    //属さないとき 0 になるようにしています。

//#include <algorithm>
//#include <iostream>
//#include <vector>

//using namespace std;

//int main()
//	{
//		int N, num_of_vertex;
//		cin >> N;
//		num_of_vertex = N;

//		vector<int> exist(N, 1);
//		vector<vector<int>> g(N);

//		for (int i = 0; i < N - 1; i++)
//		{
//			int a, b;
//			cin >> a >> b;
//			a--;
//			b--;
//			g[a].push_back(b);
//			g[b].push_back(a);
//		}

//		while (2 < num_of_vertex)
//		{
//			for (int i = 0; i < N; i++)
//			{
//				if (g[i].size() == 1)
//				{
//					num_of_vertex--;
//					exist[i] = 0;
//					g[i].clear();
//				}
//			}

//			for (int i = 0; i < N; i++)
//			{
//				for (int j = 0; j < g[i].size(); j++)
//				{
//					if (exist[g[i][j]] == 0)
//					{
//						g[i].erase(g[i].begin() + j);
//						j--;
//					}
//				}
//			}
//		}

//		for (int i = 0; i < N; i++)
//		{
//			if (exist[i] == 1)
//			{
//				cout << i + 1 << endl;
//			}
//		}
//	}



}

//グラフ理論における木とは、n 個の頂点と、それら全てを連結する n-1 個の辺からなるグラフのことです。
//プログラミングで木を扱う際には、辺の情報を利用しやすい形で保持することが好まれるので、隣接行列や隣接リストと呼ばれる形式で辺の情報を管理します。
//グラフ(頂点数 N) の隣接行列とは、 N × N の行列 g であって i 行 j 列目の要素が
//・ i 番目の頂点と j 番目の頂点が辺で結ばれているとき 1
//・ 結ばれていないとき 0
//であるようなもののことをいいます。

//N*Nの２次元配列を用意する
//ヒットしたところに1を代入していく