using System;
using System.Linq;
//C072:モンスターの進化

namespace paiza_C
{
    public class C072
    {
        internal static void test()
        {
            string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
            int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
            int ATK = intArray[0];
            int DEF = intArray[1];
            int AGI = intArray[2];
            int N = int.Parse(Console.ReadLine());  //進化候補の数
            int count = 0;
            for (int i = 0; i < N; i++)
            {
                string[] strArray2 = Console.ReadLine().Trim().Split(' ');  //読み取り
                int[] intArray2 = (strArray2.Where((source, index) => index != 0)).Select(int.Parse).ToArray(); //1つ目の値を除いた６つの数字を配列化
                if(intArray2[0] <= ATK && ATK <= intArray2[1] && intArray2[2] <= DEF && DEF <= intArray2[3] && intArray2[4] <= AGI && AGI <= intArray2[5])
                {
                    Console.WriteLine(strArray2[0]);  //進化先

                }
                else
                {
                    count++;  //進化できなかった場合カウント
                }
                
            }
            if (count == N)
            {
                Console.WriteLine("no evolution");
            }

        }
    }
}

//受験結果 受験言語： C# 解答時間： 25分23秒 バイト数： 1283 Byte スコア： 90点  2121224
//一問間違い. 

//ATK DEF AGI
//N
//s_1 MINATK_1 MAXATK_1 MINDEF_1 MAXDEF_1 MINAGI_1 MAXAGI_1
//s_2 MINATK_2 MAXATK_2 MINDEF_2 MAXDEF_2 MINAGI_2 MAXAGI_2
//...
//s_N MINATK_N MAXATK_N MINDEF_N MAXDEF_N MINAGI_N MAXAGI_N
//・1 行目にはそれぞれ、モンスターの現在の攻撃力、防御力、素早さを表す 3 つの整数 ATK, DEF, AGI がこの順で半角スペース区切りで与えられます。
//・2 行目には進化先のモンスター数を表す整数 N が与えられます。
//・続く N 行のうち、i 行目 (1 ≦ i ≦ N) には、i 番目の進化先のモンスターの名前を表す文字列 s_i と進化条件を表す 6 つの整数 MINATK_i, MAXATK_i, MINDEF_i, MAXDEF_i, MINAGI_i, MAXAGI_i がこの順で半角スペース区切りで与えられます。
//　・s_i はモンスターの名前を表す、小文字の英字からなる文字列です。
//　・MINATK_i, MAXATK_i は攻撃力の条件を表し、このモンスターに進化するには攻撃力が MINATK_i 以上 MAXATK_i 以下である必要があります。
//　・MINDEF_i, MAXDEF_i は防御力の条件を表し、このモンスターに進化するには防御力が MINDEF_i 以上 MAXDEF_i 以下である必要があります。
//　・MINAGI_i, MAXAGI_i は素早さの条件を表し、このモンスターに進化するには素早さが MINAGI_i 以上 MAXAGI_i 以下である必要があります。
//・入力は合計で N + 2 行からなり、末尾には改行が 1 つ入ります。
