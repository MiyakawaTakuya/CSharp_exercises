using System;
using System.Collections.Generic;
//C049:【ぱいじょ！コラボ問題】エレベーター

namespace paiza_C
{
    public class C049
    {
        internal static void test()
        {
            int N = int.Parse(Console.ReadLine());
            var array = new List<int>();
            int[] movedArray = new int[N];

            //まずは階数の配列を生成
            for (int i = 0; i < N; i++)
            {
                int floor = int.Parse(Console.ReadLine());
                array.Add(floor);
            }
            movedArray = array.ToArray();
            //階数の配列を用いて、移動距離(差)の合計値を出す
            int sum = Math.Abs(movedArray[0] - 1);  //最初の移動だけこちらで処理、他はfor文内で
            for (int i = 0; i < N - 1; i++)  //最初の１つ分だけ処理済みなのでN - 1
            {
                sum += Math.Abs(movedArray[i + 1] - movedArray[i]);
            }
            Console.WriteLine(sum);
        }
    }
}

//入力は以下のフォーマットで与えられます。

//N
//f_1
//...
//f_N
//・1 行目にログの行数を示す整数 N が入力が与えられます。
//・続く N 行にエレベーターが止まった階 f_i (1 ≦ i ≦ N) が整数で順に入力されます。
//・入力は合計で N+1 行であり、最終行の末尾に改行が 1 つ入ります。

//受験結果 受験言語： C# 解答時間： 17分8秒 バイト数： 781 Byte スコア： 100点  211209