using System;
using System.Linq;
//B043:ねずみ小僧

namespace paiza_C
{
    public class B043
    {

        private static string nowOrie = "North";  //East, West, North, South
        private static int nowPos_x = 0;
        private static int nowPos_y = 0;
        private static char nowHouse ;
        private static int moveCount = 0;

        internal static void test()
        {
            //座標の大きさ
            string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
            int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
            int H = intArray[0];
            int W = intArray[1];
            //家マップの作成
            char[,] nowMap = new char[H, W]; //char型の２次元配列
            //現在地と向き
            string[] strArray2 = Console.ReadLine().Trim().Split(' ');  //読み取り
            int[] intArray2 = strArray2.Select(int.Parse).ToArray();  //intへ変換
            nowPos_x = intArray2[0] - 1;  //現在地のx座標(配列表記)
            nowPos_y = intArray2[1] - 1;  //現在地のx座標(配列表記)

            for (int i = 0; i < H; i++)
            {
                string text = Console.ReadLine();  //文字列として読み込み
                char[] chars = text.ToCharArray();  //一文字ずつ配列に組み込む
                for (int p = 0; p < W; p++)
                {
                    nowMap[i, p] = chars[p];  //二次元配列に入れていく
                }
            }
            //nowHouse = nowMap[nowPos_y, nowPos_x];

            //ここから移動の基本プログラム
            //範囲外に行こうとしたら終了するプログラム(x.yが範囲外の値だったら弾く)
            while (nowPos_x >= 0 && nowPos_x <= W - 1 && nowPos_y >=0 && nowPos_y <=  H - 1 && moveCount <= 2000)
            {
                nowHouse = nowMap[nowPos_y, nowPos_x];
                //現在の家が何か読み込み 回転する 一マス進む 家を変換する
                if (nowHouse == '*') //富豪の家
                {
                    changeHouse(nowHouse);
                    nowMap[nowPos_y, nowPos_x] = nowHouse;  //家マップの値を変回
                    rotateL_and();
                    moveCount += 1;
                }
                else if (nowHouse == '.')  //庶民の家
                {
                    changeHouse(nowHouse);
                    nowMap[nowPos_y, nowPos_x] = nowHouse;  //家マップの値を変回
                    rotateR_and();
                    moveCount += 1;
                }
            }

            //最後に家マップを書き出す
            for (int i = 0; i < H; i++)
            {
                for (int p = 0; p < W; p++)
                {
                    Console.Write(nowMap[i, p]);
                }
                Console.WriteLine("");  //改行
            }

        }

        internal static void rotateR_and()   //East, West, North, South  //左上が０、下が+方向であることに注意
        {
            if (nowOrie == "North")
            {
                nowOrie = "East";
                nowPos_x += 1;
            }
            else if (nowOrie == "East")
            {
                nowOrie = "South";
                nowPos_y += 1;
            }
            else if (nowOrie == "South")
            {
                nowOrie = "West";
                nowPos_x -= 1;
            }
            else if (nowOrie == "West")
            {
                nowOrie = "North";
                nowPos_y -= 1;
            }
        }

        internal static void rotateL_and()   //East, West, North, South
        {
            if (nowOrie == "North")
            {
                nowOrie = "West";
                nowPos_x -= 1;

            }
            else if (nowOrie == "East")
            {
                nowOrie = "North";
                nowPos_y -= 1;
            }
            else if (nowOrie == "South")
            {
                nowOrie = "East";
                nowPos_x += 1;
            }
            else if (nowOrie == "West")
            {
                nowOrie = "South";
                nowPos_y += 1;
            }
        }

        internal static void changeHouse(char c)   
        {
            if (c =='*')
            {
                nowHouse = '.';
            }
            else if (c == '.')
            {
                nowHouse = '*';
            }
        }
    }
}

//受験結果 受験言語： C# 解答時間： 118分39秒 バイト数： 3967 Byte スコア： 21点  2h以内に一旦回答  211227

//・今いる家が庶民の家であれば、その家を富豪の家にする。その後、90 度(自分から見て) 右に回転して正面に 1 マス分進む。
//・今いる家が富豪の家であれば、その家を庶民の家にする。その後、90 度(自分から見て) 左に回転して正面に 1 マス分進む。

//H W
//h0 w0
//s_1
//...
//s_H
//・1 行目には町の大きさを表す 2 つの整数 H, W がこの順で半角スペース区切りで与えられます。これは町が縦 H マス、横 W マスのグリッドで表されることを意味しています。
//・2 行目にはねずみ小僧の初期位置を表す 2 つの整数 h0, w0 がこの順で半角スペース区切りで与えられます。これは、ねずみ小僧が座標 (h0, w0) にある家から出発することを表しています。
//・続く H 行には町にあるそれぞれの家が庶民の家か富豪の家かを表す文字列 s_i が与えられます。s_i は "." と "*" のみからなる長さ W の文字列で、
//　・s_i の j 文字目が "." であるとき、座標 (i, j) にある家が庶民の家であることを、
//　・s_i の j 文字目が "*" であるとき、座標 (i, j) にある家が富豪の家であることを
//・入力は合計で H + 2 行となり、入力値最終行の末尾に改行が１つ入ります。