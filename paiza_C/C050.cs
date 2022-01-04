using System.Collections.Generic;
using System.Linq;
using System;
//C050:オークションの結果

namespace paiza_C
{
    public class C050
    {
		//フィールド
		private static int S,a,b,rote;

		internal static void main()
		{
            //入力
			string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
			int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
			S = intArray[0];
			a = intArray[1];
			b = intArray[2];
            //予算の上限まで続く再帰関数
			while(!isEnd(negotiation(S))) negotiation(S);
            //出力
			if(rote ==0) { Console.WriteLine("B " + S); }
			else if (rote == 1) { Console.WriteLine("A " + S); }
		}
        //予算の上限かどうかを判断する関数
        internal static bool isEnd(int price)
		{
			if (rote == 0 && a >= S + 10)  //Aさんの交渉
			{
				return false;
			}
			else if (rote == 1 && b >= S + 1000)
			{
				return false;
			}
            else
            {
				return true;
			}
	    }

        //予算が足りなくなるまでルーチンさせる再帰関数
        internal static int negotiation(int price)
        {
            if (rote == 0)  //Aさんの交渉
            {
                price += 10;
                //a -= price;
                rote = 1;
                S = price;
                return S;
            }
            else if (rote == 1)
            {
                price += 1000;
                //b -= price;
                rote = 0;
                S = price;
                return S;
            }
                return price;
        }
    }
}

//受験結果 受験言語： C# 解答時間： 52分43秒 バイト数： 1286 Byte スコア： 60点  220104
//時間かかりすぎた.間違えて都度財布から値段を引いてしまっていた.

//商品の値段は S 円から始まります。 A さんと B さんが、この順で交互に値段を上げていきます。
//・A さんの作成した自動取引プログラムは今の商品の価格に 10 円を足した価格で交渉します。
//・B さんの作成した自動取引プログラムは今の商品の価格に 1,000 円を足した価格で交渉します。
//入力は以下のフォーマットで与えられます。
//S a b
//・商品の最初の時点での値段を表す整数 S、 A さんの予算を表す整数 a、 B さんの予算を表す整数 b がこの順に半角スペース区切りで与えられます。
//・入力は 1 行となり、末尾に改行が 1 つ入ります。
//P v
//期待する出力は 1 行からなります。
//1 行目に、オークションで商品を落札した人を表す英大文字 P、落札価格を表す整数 v をこの順で半角スペース区切りで出力してください。
//英大文字 P は、商品を落札した人物が A さんであれば "A"、商品を落札した人物が B さんであれば "B" としてください。
//1 行目の出力の最後に改行を入れ、余計な文字、空行を含んではいけません。