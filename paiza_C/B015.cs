 using System.Collections.Generic;
 using System.Linq;
using System;
//B015: 7セグメントディスプレイ
//受験結果 受験言語： C# 解答時間： 61分55秒 バイト数： 1643 Byte スコア： 78点  220219
//ケース 1（条件内の特殊なデータ）の出力結果一つが違った。

namespace paiza_C
{
    public class B015
    {
		private static string[] NUMBERS = new string[10] {"1111110","0110000", "1101101", "1111001", "0110011", "1011011", "1011111", "1110010", "1111111", "1111011" };

		private class Symmetry
		{
			internal string[] sym = new string[7];
			internal Symmetry(string[] _)  //コンストラクタ
			{
				sym[0] = _[0];
				sym[1] = _[5];
				sym[2] = _[4];
				sym[3] = _[3];
				sym[4] = _[2];
				sym[5] = _[1];
				sym[6] = _[6];
			}
			//internal string[] sym { get; set; }
		}

		private class Rotation
		{
			internal string[] rot = new string[7];
			internal Rotation(string[] _)  //コンストラクタ
			{
				rot[0] = _[3];
				rot[1] = _[4];
				rot[2] = _[5];
				rot[3] = _[0];
				rot[4] = _[1];
				rot[5] = _[2];
				rot[6] = _[6];
			}
		}

		internal static void main()
		{
			//入力
			string[] a_segment = Console.ReadLine().Trim().Split(' ');
			string[] b_segment = Console.ReadLine().Trim().Split(' ');
			Console.WriteLine(isMatch(a_segment, b_segment));

			Symmetry a = new Symmetry(a_segment);
			Symmetry b = new Symmetry(b_segment);
			Console.WriteLine(isMatch(a.sym, b.sym));

			Rotation a_ = new Rotation(a_segment);
			Rotation b_ = new Rotation(b_segment);
			Console.WriteLine(isMatch(a_.rot, b_.rot));
		}

		internal static string isMatch(string[] a, string[] b)
		{
			string A = String.Join("", a);
			string B = String.Join("", b);
			int count = 0;
			foreach(string i in NUMBERS)
			{
				if (i == A)
				{
					count++;
				}
				else if (i == B)
				{
					count++;
				}
			}
			if(count == 2)
            {
				return "Yes";
			}
            else
            {
				return "No";
			}
		}


	}
}


//入力される値
//入力は以下のフォーマットで与えられます。
//a_1 a_2 a_3 a_4 a_5 a_6 a_7
//b_1 b_2 b_3 b_4 b_5 b_6 b_7
//1行目に1つ目の7セグメントディスプレイの状態、2行目に2つ目の7セグメントディスプレイの状態が与えられます。

//期待する出力
//以下の3つの条件についてそれぞれ順番に条件を満たすなら "Yes" 、満たさないならば "No" を出力し、改行区切りで出力してください。
//装置が正しく2桁の数字を表すか
//装置を対称移動すると正しく2桁の数字を表すか
//装置を回転移動すると正しく2桁の数字を表すか

////ロジック
//数字は文字列で判定していくのが処理量少なくて済みそう
//関数を３つ用意する

//読み取った値a1~a7とb1〜b7の値の配列を文字列化する。
//それぞれが0〜9のどれかに該当するかを判定する。
//一つでも数字として判定されなかったら"No"を返す、２つとも無事に満たしたら"Yes"を返す

//読み取った値の配列を対称移動して文字列化する。
//それぞれが0〜9のどれかに該当するかを判定する。
//一つでも数字として判定されなかったら"No"を返す、２つとも無事に満たしたら"Yes"を返す

//読み取った値の配列を回転移動して文字列化する。
//それぞれが0〜9のどれかに該当するかを判定する。
//一つでも数字として判定されなかったら"No"を返す、２つとも無事に満たしたら"Yes"を返す