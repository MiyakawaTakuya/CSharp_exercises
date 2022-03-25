using System.Collections.Generic;
using System.Linq;
using System;
//B023:マッチ棒パズル
//問題集計
//難易度： 2372 ±16
//受験者数： 3,710人
//正解率： 60.07％
//平均解答時間： 67分15秒
//平均スコア： 34.11点

//受験結果 受験言語： C# 解答時間： 228分52秒 バイト数： 4128 Byte スコア： 0点 22/03/26
//久々のタイムアウトの0点  正解率も50%しかない(例題はクリア)
//多分Aランク並みに難しいやつ.

////何に着目すべきか？
//0~9までのそれぞれの数字で切り替えができる範囲の有限性
//入れ替えパターンを算出する

///１本抜き取ったきりにしてもそのまま数字として成り立つ数字
// 6(5) 7(1) 8(0,6,9) 9(3,5)
///抜き取らずにただ１本追加すると数字として成り立つ数字
// 0(8) 1(7) 3(9) 6(8) 5(6,9) 9(8)

///中で１本を位置変えすると数字として成り立つ数字   →ここに登場しない1 4 7 8のうち１種類だけの数字で構成されているものはnoneとなる
// 0(6,9) 2(3) 3(2,5) 5(3) 6(0,9) 9(6)
///中で１本を位置変えしても数字として成り立たない数字
// 1 4 7 8 

//各数字を一つの配列で扱う？
//各桁数を分割したint配列が良さそう
//桁数が変わることはないので、桁数分の配列の大きさは固定
//最初に0が来るパターンをうまく捌けるようにする

//入れ替えた後の数字をintでまとめてListにAddしていく
//最後に重複しているものを削除し、Sortして書き出して終わり

namespace paiza_C
{
	public class B023
    {
		private static List<int> newNum = new List<int>();
		private static char StockNum;

		internal static void main()
		{
			//入力
			string Str = Console.ReadLine();
			int intS = int.Parse(Str);
			int s_len = Str.Length;
			char[] charNum = Str.ToCharArray();
			var re = charNum.Distinct();
			List<char> result0 = new List<char>(re);

            //そもそも入れ替え得ないパターンを排除
            if (result0.Count == 1)
            {
				if (result0[0] == '1' || result0[0] == '4' || result0[0] == '7' || result0[0] == '8')Console.WriteLine("none");
			}
            else
            {
				//入れ替え処理
				char[] num__ = new char[charNum.Length];
				Array.Copy(charNum, num__, s_len);
				ReplaceWithinItself(num__);
				tryDraw(charNum);

				//整頓して出力
				if (newNum.Count != 0)
				{
					newNum.RemoveAll(s => s == intS);
					IEnumerable<int> result = newNum.Distinct();
					List<int> newNum_ = new List<int>(result);
					newNum_.Sort();
					foreach (var a in newNum_)
					{
						if (a.ToString().Length != s_len)
						{
							string ap = "0" + a.ToString();
							Console.WriteLine(ap);
						}
						else Console.WriteLine(a);
					}
				}
				else Console.WriteLine("none");
			}
		}


		internal static void tryDraw(char[] num)
		{
			///１本抜き取ったきりにしてもそのまま数字として成り立つ数字
			// 6(5) 7(1) 8(0,6,9) 9(3,5)
			for (int i = 0; i < num.Length; i++)
			{
				char[] num2 = new char[num.Length];
				Array.Copy(num, num2, num.Length);
				if (num2[i]=='6')
                {
					num2[i] = '5';
					tryAdd(num2);
					num2[i] = '6';
				}
				else if (num2[i] == '7')
				{
					num2[i] = '1';
					tryAdd(num2);
					num2[i] = '7';
				}
				else if (num2[i] == '8')
				{
					num2[i] = '0';
					tryAdd(num2);
					num2[i] = '6';
					tryAdd(num2);
					num2[i] = '9';
					tryAdd(num2);
					num2[i] = '8';
				}
				else if (num2[i] == '9')
				{
					num2[i] = '3';
					tryAdd(num2);
					num2[i] = '5';
					tryAdd(num2);
					num2[i] = '9';
				}
			}
		}

		internal static void tryAdd(char[] nu)
		{

			///抜き取らずにただ１本追加すると数字として成り立つ数字
			// 0(8) 1(7) 3(9) 5(6,9) 6(8)  9(8)
			for (int j = 0; j < nu.Length; j++)
			{
				char[] num_ = new char[nu.Length];
				Array.Copy(nu, num_, nu.Length);
				if (num_[j] == '0')
				{
					num_[j] = '8';
					newNum.Add(toNum(num_));
					num_[j] = '0';
				}
				else if (num_[j] == '1')
				{
					num_[j] = '7';
					newNum.Add(toNum(num_));
					num_[j] = '1';
				}
				else if (num_[j] == '3')
				{
					num_[j] = '9';
					newNum.Add(toNum(num_));
					num_[j] = '3';
				}
				else if (num_[j] == '5')
				{
					num_[j] = '6';
					newNum.Add(toNum(num_));
					num_[j] = '9';
					newNum.Add(toNum(num_));
					num_[j] = '5';
				}
				else if (num_[j] == '6')
				{
					num_[j] = '8';
					newNum.Add(toNum(num_));
					num_[j] = '6';
				}
				else if (num_[j] == '9')
				{
					num_[j] = '8';
					newNum.Add(toNum(num_));
					num_[j] = '9';
				}
			}
		}


	    //その桁の中で入れ替えて数字を生成できる場合に生成してaddする関数
		internal static void ReplaceWithinItself(char[] nu)
		{

			///中で１本を位置変えすると数字として成り立つ数字
			// 0(6,9) 2(3) 3(2,5) 5(3) 6(0,9) 9(6)
			for (int i=0; i < nu.Length;i++ )
            {
				char[] num = new char[nu.Length];
				Array.Copy(nu, num, nu.Length);
				if (num[i] == '0')
                {
					num[i] = '6';
					newNum.Add(toNum(num));
					num[i] = '9';
					newNum.Add(toNum(num));
				}
				else if (num[i] == '2')
				{
					num[i] = '3';
					newNum.Add(toNum(num));
				}
				else if (num[i] == '3')
				{
					num[i] = '2';
					newNum.Add(toNum(num));
					num[i] = '5';
					newNum.Add(toNum(num));
				}
				else if (num[i] == '5')
				{
					num[i] = '3';
					newNum.Add(toNum(num));
				}
				else if (num[i] == '6')
				{
					num[i] = '0';
					newNum.Add(toNum(num));
					num[i] = '9';
					newNum.Add(toNum(num));
				}
				else if (num[i] == '9')
				{
					num[i] = '6';
					newNum.Add(toNum(num));
				}
			}
		}

		//int[]をintにしてnewNumに付け足す
		internal static int toNum(char[] nuM)
		{
			string a = String.Join("",nuM);
			return int.Parse(a);
		}
	}
}

//・1 ≦ (s の長さ) ≦ 10
//・s は '0', '1', ..., '9' からなる文字列