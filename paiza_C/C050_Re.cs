// using System.Collections.Generic;
using System.Linq;
using System;
//再チャレンジ C050:オークションの結果
//22 / 02 / 23 再帰関数で再チャレンジ スコア100

namespace paiza_C
{
    public class C050_Re
    {
		private static int S, a, b;

		internal static void main()
		{
			string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
			int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
			S = intArray[0];
			a = intArray[1];
			b = intArray[2];

            if(negotiation(0)==0) Console.WriteLine("A "+ S);
            else Console.WriteLine("B " + S);
        }

        //予算が足りなくなるまでルーチンさせる再帰関数
        internal static int negotiation(int offer)
        {
            if (offer == 0 && S + 10 > a)return 1;
            else if (offer == 1 && S + 1000 > b) return 0;

            if (offer == 0)  //Aさんの交渉
            {
                S += 10;
                return negotiation(1);
            }
            else //if (offer == 1)
            {
                S += 1000;
                return negotiation(0);
            }
        }
    }
}

