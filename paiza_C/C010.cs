using System;
namespace paiza_C
{
    public class C010
    {
        internal static void test()
        {
            string[] ArrayData1 = Console.ReadLine().Trim().Split(' ');  //1行目読み込み
            int a = int.Parse(ArrayData1[0]);
            int b = int.Parse(ArrayData1[1]);
            int R = int.Parse(ArrayData1[2]);
            //Console.WriteLine("工事現場のx座標" + a + ", 工事現場のy座標" + b + ", 工事現場半径" + R );
            int N = int.Parse(Console.ReadLine());  //2行目読み込み パラメータ値
            //Console.WriteLine(N);
            int x, y;  //各木陰の位置
            //(x-a)*(x-a) + (y-b)*(y-b) >= R*R  条件式

            for (int m = 0; m < N; m++)  //3行目移行を読み込み
            {
                string[] ArrayData3_ = Console.ReadLine().Trim().Split(' '); //各ユーザーの得点の配列
                x = int.Parse(ArrayData3_[0]);
                y = int.Parse(ArrayData3_[1]);
                if ((x - a) * (x - a) + (y - b) * (y - b) >= R * R)
                    Console.WriteLine("silent");
                else
                    Console.WriteLine("noisy");
                
                //if ((x - a) * (x - a) + (y - b) * (y - b) >= R * R)
                //{
                //    Console.WriteLine("silent");
                //}
                //else
                //{
                //    Console.WriteLine("noisy");
                //}


            }

        }
    }
}
