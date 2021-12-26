using System;
using System.Linq;
//C075:ポイント払い

namespace paiza_C
{
    public class C075
    {
        internal static void test()
        {
            string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
            int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
            int N = intArray[0];
            int M = intArray[1];
            int point = 0;

            for (int i = 0; i < M; i++)
            {
                int n = int.Parse(Console.ReadLine());  //運賃
                if(n > point)
                {
                    N -= n;
                    point += n/10;
                }
                else if(n <= point)
                {
                    point -= n;
                }
                Console.WriteLine(N + " "+ point);
            }
        }
    }
}
//受験結果 受験言語： C# 解答時間： 15分57秒 バイト数： 748 Byte スコア： 100点  211226

//N M
//f_1
//f_2
//...
//f_M
//・1 行目にはそれぞれ、はじめにチャージされている金額、バスの乗車回数を表す整数 N, M がこの順で半角スペース区切りで与えられます。
//・続く M 行のうちの i 行目 (1 ≦ i ≦ M) には、i 回目の降車時にかかった運賃を表す整数 f_i がこの順で半角スペース区切りで与えられます。
//・入力は合計で M + 1 行となり、入力値最終行の末尾に改行が 1 つ入ります。
