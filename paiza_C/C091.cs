using System;
using System.Collections.Generic;
using System.Linq;
//C091:みかんの仕分け

namespace paiza_C
{
    public static class C091
    {
        static int Nearest(this IEnumerable<int> self, int target)
        {
            var min = self.Min(c => Math.Abs(c - target));  //絶対値が最小値になる要素
            return self.First(c => Math.Abs(c - target) == min);
            //Enumerable.First メソッド 指定された条件を満たす、シーケンスの"最初"の要素を返します
        }

        internal static void test()
        {
            string[] ArrayData = Console.ReadLine().Trim().Split(' ');
            int N = int.Parse(ArrayData[0]);  //仕分ける重さの区切りを表す整数
            int M = int.Parse(ArrayData[1]);  //みかんの個数を表す整数

            //N の倍数で1000以下までの値の範囲で配列を生成
            int[] boxArray;
            int Nplus = N;
            var list = new List<int>();
            list.Add(Nplus); //初期値を代入
            while (Nplus <= 1000)
            {
                Nplus += N;
                list.Add(Nplus);
            }
            boxArray = list.ToArray();  //最後に配列として整える
            Array.Reverse(boxArray); //該当する箱が２つあった場合に大きい値をとりださせるようにするするため、大きい順に並べる

            //配列中から近似値をとる
            for (int i = 1; i <= M; i++)
            {
                int w_ = int.Parse(Console.ReadLine()); //各行のみかんの重さ
                Console.WriteLine(boxArray.Nearest(w_));
            }
        }
    }
}

//N M
//w_1
//w_2
//...
//w_M
//・1 行目にそれぞれ仕分ける重さの区切りを表す整数、みかんの個数を表す整数 N, M がこの順で半角スペース区切りで与えられます。
//・続く M 行のうちの i 行目 (1 ≦ i ≦ M) には、i 番目のみかんの重さを表す整数 w_i が与えられます。
//・入力は合計で M + 1 行となり、入力値最終行の末尾に改行が １ つ入ります。
//・1 ≦ N ≦ 100
//・1 ≦ M ≦ 10
//・1 ≦ w_i ≦ 1,000(1 ≦ i ≦ M)

//受験結果 受験言語： C# 解答時間： 41分34秒 バイト数： 1133 Byte スコア： 73点  211207
//正答率9割　
//近似値をとるときにNの倍数が２つ存在してしまう場合(絶対値minの値取れる値が２つ存在してしまうときに最初に来る方(小さい方)を選択してしまう)
//２つ存在する場合は大きい方の箱に渡さないといけないがその処理ができていない。

//受験結果 受験言語： C# 獲得ランク： Cランク スコア： 100点  211207
//Array.Reverse(boxArray); //該当する箱が２つあった場合に大きい値をとりださせるようにするするため、大きい順に並べる
//を一行追加してクリア