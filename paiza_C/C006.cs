using System;
//C006:ハイスコアランキング


namespace paiza_C
{
    public class C006
    {
        internal static void test()
        {
            string[] ArrayData1 = Console.ReadLine().Trim().Split(' ');  //1行目読み込み
            int N = int.Parse(ArrayData1[0]);
            int M = int.Parse(ArrayData1[1]);
            int K = int.Parse(ArrayData1[2]);
            // Console.WriteLine("パラメータ個数" + N + ", ユーザー数" + M + ", トップ数" + K );
            string[] ArrayData2 = Console.ReadLine().Trim().Split(' ');  //2行目読み込み パラメータ値
                                                                         // Console.WriteLine("{0}", string.Join(", ", ArrayData2));
            double Sum = 0;
            double[] SumArray = new double[M];

            for (int m = 0; m < M; m++)  //3行目移行を読み込み
            {
                string[] ArrayData3_ = Console.ReadLine().Trim().Split(' '); //各ユーザーの得点の配列

                for (int i = 0; i < N; i++)  //3行目移行を読み込み
                {
                    double point = double.Parse(ArrayData2[i]);  //i番目のポイント
                    int num = int.Parse(ArrayData3_[i]);  //i番目の個数
                    Sum += point * num;
                }
                SumArray[m] = Math.Round(Sum, MidpointRounding.AwayFromZero);  //小数点一位で四捨五入
                Sum = 0;  //合計値リセット
            }
            // Console.WriteLine("{0}", string.Join(", ", SumArray)); //M行分の合計値を整数の値として一つの配列にまとめられた
            Array.Sort(SumArray);  //小さいものから順に並び替える
            Array.Reverse(SumArray); //それを逆にして降順にする
            for (int n = 0; n < K; n++)  //１番からK番目までのランキング表示
            {
                Console.WriteLine(SumArray[n]);
            }
        }
    }
}

//入力値
//4 10 3
//1.5 1.2 2 0.4
//208 200 3 99988
//255 150 50 65472
//103 748 39 48571
//159 403 32 89928
//254 300 67 78492
//249 298 47 45637
//253 382 89 37282
//250 350 78 76782
//251 371 69 67821
//256 312 89 54382
