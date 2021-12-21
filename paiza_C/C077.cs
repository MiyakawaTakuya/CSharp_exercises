using System;
using System.Linq;
//C077:【30万人記念問題】レポートの評価

namespace paiza_C
{
    public class C077
    {
        internal static void test()
        {
            string[] strArray = Console.ReadLine().Trim().Split(' ');
            int k = int.Parse(strArray[0]);
            int n = int.Parse(strArray[1]);  //問題数
            int onePoint = 100 / n;
            double sumPoint = 0;

            for (int i = 0; i < k; i++)
            {
                string[] strArray2 = Console.ReadLine().Trim().Split(' ');  //読み取り
                int[] intArray = strArray2.Select(int.Parse).ToArray();  //intへ変換

                //日数判定から
                if (intArray[0] >= 10)
                {
                    Console.WriteLine("D");
                }
                else if(intArray[0] > 0 && intArray[0] <= 9)
                {
                    sumPoint = intArray[1] * onePoint * 0.8;
                    ABCD(sumPoint);
                }
                else if (intArray[0] <= 0)
                {
                    sumPoint = intArray[1] * onePoint;
                    ABCD(sumPoint);
                }
            }
        }

        internal static void ABCD(double sumPoint)
        {
            if(sumPoint < 60)
            {
                Console.WriteLine("D");
            }
            else if(sumPoint >= 60 && sumPoint < 70)
            {
                Console.WriteLine("C");
            }
            else if (sumPoint >= 70 && sumPoint < 80)
            {
                Console.WriteLine("B");
            }
            else if (sumPoint >= 80)
            {
                Console.WriteLine("A");
            }
        }

        //分岐点数付近の小数点絡みの点数を判定できてなかった  59.8点とか
        //internal static void ABCD(double sumPoint)
        //{
        //    if (sumPoint <= 59)
        //    {
        //        Console.WriteLine("D");
        //    }
        //    else if (sumPoint >= 60 && sumPoint <= 69)
        //    {
        //        Console.WriteLine("C");
        //    }
        //    else if (sumPoint >= 70 && sumPoint <= 79)
        //    {
        //        Console.WriteLine("B");
        //    }
        //    else if (sumPoint >= 80)
        //    {
        //        Console.WriteLine("A");
        //    }
        //}
    }
}

//受験結果 受験言語： C# 解答時間： 32分23秒 バイト数： 1588 Byte スコア： 87点  211221
//一文間違えてる.

//条件分岐を変更した
//受験結果 受験言語： C# 獲得ランク： Cランク スコア： 100点

//入力は以下のフォーマットで与えられます。
//k n
//d_1 a_1
//d_2 a_2
//...
//d_k a_k
//・1 行目に学生の人数を表す整数 k、レポートの問題数を表す整数 n がこの順に半角スペース区切りで与えられます。
//・続く k 行のうちの i 行目 (1 ≦ i ≦ k) には、i 番目の学生のレポートを提出した日を表す整数 d_i、i 番目の学生が正解した問題数を表す整数 a_i がこの順に半角スペース区切りで与えられます。
//・入力は合計で k + 1 行となり、入力値最終行の末尾に改行が 1 つ入ります。
//・1 ≦ k ≦ 100
//・n は 100 の約数
//・-14 ≦ d_i ≦ 14 (1 ≦ i ≦ k)
//・0 ≦ a_i ≦ n(1 ≦ i ≦ k)