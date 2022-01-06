using System.Collections.Generic;
using System.Linq;
using System;
//C076:給与の計算

namespace paiza_C
{
    public class C076
    {
		//フィールド
		private static int X,Y,Z,Sum;

		internal static void main()
		{
			//入力
			string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
			int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
			X = intArray[0];
			Y = intArray[1];
			Z = intArray[2];
			int N = int.Parse(Console.ReadLine());
			var salary = new Dictionary<int, int>()
			{ {0,Z},{1,Z},{2,Z},{3,Z},{4,Z},{5,Z},{6,Z},{7,Z},{8,Z},{9,X}, {10,X},{11,X},{12,X},{13,X},{14,X},{15,X},{16,X},{17,Y},{18,Y},{19,Y},{20,Y},{21,Y},{22,Z},{23,Z}};
			//勤務時間入力＆日毎の給与計算
			for (int i = 0; i < N; i++)
			{
				string[] strArray2 = Console.ReadLine().Trim().Split(' ');
				int[] attendanceArray = strArray2.Select(int.Parse).ToArray();
				Sum += aDaySalary(attendanceArray, salary);
			}
			//出力
			Console.WriteLine(Sum);
		}

		//その日ごとの給与を計算する関数
		internal static int aDaySalary(int[] a, Dictionary<int, int> sa)
		{
			int daySum = 0;
			for (int j = a[0]; j < a[1]; j++)
			{
				daySum += sa[j];
			}
			return daySum;
		}
	}
}

//受験結果 受験言語： C# 解答時間： 21分47秒 バイト数： 1061 Byte スコア： 100点

//・9 時から 17 時まで: 時給 X 円(通常の時給)
//・17 時から 22 時まで: 時給 Y 円(夜の時給)
//・それ以外の時間: 時給 Z 円(深夜の時給)

//X Y Z
//N
//S_1 T_1
//S_2 T_2
//...
//S_N T_N
//・1 行目には、通常の時給 X、夜の時給 Y、深夜の時給 Z がこの順に整数で半角スペース区切りで与えられます。
//・2 行目には、出勤日数 N が整数で与えられます。
//・続く N 行の i 番目 (1 ≦ i ≦ N) には、i 日目の出勤時刻 S_i と退勤時刻 T_i がこの順に整数で半角スペース区切りで与えられます。
//・入力は合計で N + 2 行となり、入力値最終行の末尾に改行が 1 つ入ります。
