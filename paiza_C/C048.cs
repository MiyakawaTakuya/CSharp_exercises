using System;
using System.Linq;

//C048:タダ飲みコーヒー


namespace paiza_C
{
    public class C048
    {
        internal static void test()
        {
            string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
            int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
            int X = intArray[0];
            int P = intArray[1];
            int nowPrice = X;
            int payMoney = 0;

            while(true)
            {
                payMoney += nowPrice;
                nowPrice = nowPrice * (100 - P) / 100;
                //nowPrice = Math.Floor(nowPrice * (100 - P) / 100);

                if (nowPrice == 0)
                {
                    break;
                }
            }
            Console.WriteLine(payMoney);
        }
    }
}

//受験結果 受験言語： C# 解答時間： 21分20秒 バイト数： 653 Byte スコア： 99点  211227

//入力は以下のフォーマットで与えられます。

//X P
//・コーヒーの価格を示す整数 X と 割引き率を示す整数 P が、この順に半角スペース区切りで与えられます。
//・入力は 1 行となり、末尾に改行が 1 つ入ります。