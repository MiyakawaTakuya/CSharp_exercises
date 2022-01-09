// using System.Collections.Generic;
using System.Linq;
using System;
//B006:ダーツゲーム

namespace paiza_C
{
    public class B006
    {
		//フィールド
		private static int o_y,s,θ,x,y, markSize;

		internal static void main()
		{
			//入力
			string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
			int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
			o_y = intArray[0];
			s = intArray[1];
			θ = intArray[2];
			string[] strArray2 = Console.ReadLine().Trim().Split(' ');  //読み取り
			int[] intArray2 = strArray2.Select(int.Parse).ToArray();  //intへ変換
			x = intArray2[0];  //的までの距離
			y = intArray2[1];  //的の高さ(中心位置)
			markSize = intArray2[2];

			Console.WriteLine(isHit(pos_Y()));
		}

		//距離x進んだ時の矢のy方向の大きさ(高さ)を算出する関数
		internal static double pos_Y()
		{
			double tanθ = Math.Tan(θ * (Math.PI / 180));
			double cosθ = Math.Cos(θ * (Math.PI / 180));
			//double a = (9.8 * x * x) / (2 * s * s * cosθ * cosθ);
 			double Y = o_y + x * tanθ -(9.8 * x * x)/(2* s * s * cosθ * cosθ);
			return Y;
		}

		//的に当たっているか判定して出力する関数
		internal static string isHit(double _Y)
		{
			double okUpY = y + markSize / 2;
			double okUnderY = y - markSize / 2;
			double a = Math.Abs(y - _Y);
			double kyori = Math.Round(a, 1, MidpointRounding.AwayFromZero); //小数第二位で四捨五入
			if (_Y >= okUnderY && _Y <= okUpY)
			{
				return "Hit" + " " + kyori;
			}
			else
            {
				return "Miss";
			}
			
		}
	}
}

//問題集計
//難易度： 1881 ±6
//受験者数： 6,394人
//正解率： 42.39％
//平均解答時間： 38分20秒
//平均スコア： 62.18点
//当たった場合、的の中心からの距離を小数点第2位で四捨五入 した小数点第1位までの数値を出力してください。
//1行目には初期値点の高さo_y,矢の初速s,角度θがスペース区切りの数値で入力されます。
//2行目には的までの距離xと高さyと的の大きさがスペース区切りの数値で入力されます。
//また、浮動小数の誤差が起こることを考慮しテストケースの矢の軌道は的の端0.05の範囲は通らないものとして入力されます。

//var sin = Math.Sin(angle * (Math.PI / 180));
//var cos = Math.Cos(angle * (Math.PI / 180));
//var tan = Math.Tan(angle * (Math.PI / 180));
//a=12.262
// 小数第二位で四捨五入
//Console.WriteLine(Math.Round(a, 1, MidpointRounding.AwayFromZero)); //12.3

