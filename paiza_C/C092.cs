using System;
//C092:工場のベルトコンベア

namespace paiza_C
{
    public class C092
    {
        internal static void test()
        {
            string[] ArrayData = Console.ReadLine().Trim().Split(' ');
            int N = int.Parse(ArrayData[0]);
            int A = int.Parse(ArrayData[1]); 
            int B = int.Parse(ArrayData[2]);
            char[] chararrayN = Console.ReadLine().ToCharArray();  //一文字ずつの配列
            char[] chararrayA = Console.ReadLine().ToCharArray();  
            char[] chararrayB = Console.ReadLine().ToCharArray();
            int x = 0, y = 0 ;

            for (int i = 0; i < N; i++)
            {
                if (chararrayN[i] == chararrayA[x])
                {
                    A--;  //処理できたらカウント減らす
                    x++;
                }
                if (chararrayN[i] == chararrayB[y])
                {
                    B--;
                    y++;
                }
            }
            if (A < 0)
            {
                A = 0;
            }
            if (B < 0)
            {
                B = 0;
            }
            Console.WriteLine(A+ " " +B);
        }
    }
}

//受験結果 受験言語： C# 解答時間： 59分20秒 バイト数： 1068 Byte スコア： 46点  211215
//境界値データで一箇所だけランタイムエラーが出てしまった

//N A B
//s_N
//s_A
//s_B
//・1 行目に信号機のスケジュールの長さを表す整数 N、ベルトコンベア A に乗っている部品の数を表す整数 A、 ベルトコンベア B に乗っている部品の数を表す整数 B がこの順で半角スペース区切りで与えられます。
//・続く 3 行には、信号機のスケジュール、1 つめのベルトコンベアのそれぞれの部品の進む方向、2 つめのベルトコンベアのそれぞれの部品の進む方向を表す文字列 s_N, s_A, s_B が与えられます。
//・入力は合計で 4 行となり、入力値最終行の末尾に改行が 1 つ入ります。

//信号機のスケジュールが全て終了した時、 2 つのベルトコンベアに残っている部品の数を以下の形式で出力してください。

//x y
//・期待する出力は 1 行からなります。
//・それぞれベルトコンベア A に残っている部品の数、ベルトコンベア B に残っている部品の数を表す整数 x, y をこの順で半角スペース区切りで出力してください。
//・末尾に改行を入れ、余計な文字、空行を含んではいけません。
//すべてのテストケースにおいて、以下の条件をみたします。

//・1 ≦ N, A, B ≦ 100
//・(s_N の長さ) = N
//・(s_A の長さ) = A
//・(s_B の長さ) = B
//・s_N, s_A, s_B は、"F", "R", "L" からなる文字列
//・"F" は直進、"R" は右折、"L" は左折を意味する。
