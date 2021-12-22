using System;
using System.Collections.Generic;
using System.Linq;
//C088:RPGでお買い物

namespace paiza_C
{
    public class C088
    {
        internal static void test()
        {
            int N = int.Parse(Console.ReadLine());  //道具の個数
            string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
            int[] intArray = strArray.Select(int.Parse).ToArray();
            //ハッシュテーブル（連想配列）を使う（Dictionaryクラス編）
            var tools = new Dictionary<int, int>();
            for (int i = 1 ; i <= N; i++)
            {
                tools.Add(i, intArray[i-1]);
            }
            string[] strArray_3 = Console.ReadLine().Trim().Split(' ');  //読み取り
            int T = int.Parse(strArray_3[0]);  //最初の所持金を表す整数 
            int Q = int.Parse(strArray_3[1]);  //注文回数を表す整数
            int buy = 0;
            for (int i = 0; i < Q; i++)
            {
                string[] strArray_4 = Console.ReadLine().Trim().Split(' ');  //読み取り
                int[] intArray_4 = strArray_4.Select(int.Parse).ToArray();
                buy = tools[intArray_4[0]] * intArray_4[1]; //金額*個数
                if(T - buy < 0)
                {
                    //何もしない
                }
                else if(T - buy >= 0)
                {
                    T -= buy;
                }
            }
            Console.WriteLine(T);

        }
    }
}
//受験結果 受験言語： C# 解答時間： 25分24秒 バイト数： 1295 Byte スコア： 100点  211222

//N
//a_1 ... a_N
//T Q
//x_1 k_1
//...
//x_Q k_Q
//・1 行目には、道具の個数を表す整数 N が与えられます。
//・2 行目には、 N 個の各道具の単価が半角スペース区切りで与えられます。
//　・ここで、 a_i (1 ≦ i ≦ N) は i 番目の道具の単価を表します。
//　・3 行目には、最初の所持金を表す整数 T と注文回数を表す整数 Q が与えられます。
//・3 + j 行目 (1 ≦ j ≦ Q) には、 j 回目の注文の情報が以下の形式で与えられます。
//　・購入したい道具の番号を表す整数 x_j とその個数 k_j が半角スペース区切りで与えられます。
//・入力は合計で Q + 3 行となり、入力値最終行の末尾に改行が 1 つ入ります。
//・1 ≦ N ≦ 100
//・1 ≦ a_i ≦ 999,999(1 ≦ i ≦ N)
//・0 ≦ T ≦ 999,999
//・1 ≦ Q ≦ 100
//・1 ≦ x_j ≦ N(1 ≦ j ≦ Q)
//・1 ≦ k_j ≦ 99(1 ≦ j ≦ Q)