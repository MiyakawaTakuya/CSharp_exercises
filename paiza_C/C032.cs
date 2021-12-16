using System;
//C032:お得な買い物

namespace paiza_C
{
    public class C032
    {
        internal static void test()
        {
            int N = int.Parse(Console.ReadLine());
            int food = 0;
            int book = 0;
            int cloth = 0;
            int other = 0;
            int pointSum = 0;

            for (int i = 0; i < N; i++)
            {
                string[] ArrayData = Console.ReadLine().Trim().Split(' ');
                if(ArrayData[0] =="0")
                {
                    food += int.Parse(ArrayData[1]);
                }
                else if(ArrayData[0] == "1")
                {
                    book += int.Parse(ArrayData[1]);
                }
                else if (ArrayData[0] == "2")
                {
                    cloth += int.Parse(ArrayData[1]);
                }
                else if (ArrayData[0] == "3")
                {
                    other += int.Parse(ArrayData[1]);
                } 
            }
            pointSum = 5 * (food / 100) + 3 * (book / 100) + 2 * (cloth / 100) + 1 * (other / 100);
            Console.WriteLine(pointSum);
        }
    }
}
//受験結果 受験言語： C# 解答時間： 14分43秒 バイト数： 1083 Byte スコア： 100点


//入力は以下のフォーマットで与えられます。
//N
//v_1 p_1
//v_2 p_2
//...
//v_N p_N

//・入力の 1 行目に購入した商品の総数を表す N が与えられます。
//・続く N 行目のうち i 行目 (1 ≦ i ≦ N) に商品の種類を表す整数 v_i および商品の金額を表す整数 p_i がこの順に半角スペース区切りで与えられます。
//・v_i について、0 は食料品、1 は書籍、2 は衣類、3 はその他を表します。
//・入力は合計で N + 1 行からなり、入力値最終行の末尾に改行が１つ入ります。