using System;
using System.Collections.Generic;
using System.Linq;

namespace paiza_C
{
    public class B043_Re
    {
        //フィールド
        private static char[,] nowMap;
        private static char nowHouse;
        public struct Pos  //なぜpublicじゃなければだめなのか？
        {
            internal int x;
            internal int y;
            internal string dire;
            internal int count;
        }
        private static Pos nowPos = new Pos();
        //入力
        internal static void input()
        {
            string[] strArray = Console.ReadLine().Trim().Split(' ');  //読み取り
            int[] intArray = strArray.Select(int.Parse).ToArray();  //intへ変換
            nowMap = new char[intArray[0], intArray[1]]; //char型の２次元配列
            //現在地と向き
            string[] strArray2 = Console.ReadLine().Trim().Split(' ');  //読み取り
            int[] intArray2 = strArray2.Select(int.Parse).ToArray();  //intへ変換
            nowPos.x = intArray2[1] - 1;  //現在地のx座標(配列表記)
            nowPos.y = intArray2[0] - 1;  //現在地のy座標(配列表記)
            nowPos.dire = "North";
            nowPos.count = 0;
            for (int i = 0; i < intArray[0]; i++)
            {
                string text = Console.ReadLine();  //文字列として読み込み
                char[] chars = text.ToCharArray();  //一文字ずつ配列に組み込む
                for (int p = 0; p < intArray[1]; p++)
                {
                    nowMap[i, p] = chars[p];  //二次元配列に入れていく
                }
            }
        }
        //街にいるかどうかの確認
        internal static bool inTown(Pos pos)
        {
            if(pos.x >= 0 && pos.x <= nowMap.GetLength(1) - 1 && pos.y >= 0 && pos.y <= nowMap.GetLength(0) - 1 && nowPos.count <= 2000)
                return true; return false;
        }
        //現在の家が何か読み込み 回転する 一マス進む 家を変換する
        internal static char[,] changHouse(Pos pos)
        {  
            nowHouse = nowMap[pos.y, pos.x];
            if (nowHouse == '*') //富豪の家
            {
                nowMap[pos.y, pos.x] = '.';  //家マップの値を変換
                switch (nowPos.dire)  //左回りして一つ進む
                {
                    case "North": nowPos.dire = "West"; nowPos.x -= 1; break;
                    case "East": nowPos.dire = "North"; nowPos.y -= 1; break;
                    case "South": nowPos.dire = "East"; nowPos.x += 1; break;
                    case "West": nowPos.dire = "South"; nowPos.y += 1; break;
                }
                nowPos.count += 1;
            }
            else if (nowHouse == '.')  //庶民の家
            {
                nowMap[pos.y, pos.x] = '*';  //家マップの値を変換
                switch (nowPos.dire)  //右回りして一つ進む
                {
                    case "North": nowPos.dire = "East"; nowPos.x += 1; break;
                    case "East": nowPos.dire = "South"; nowPos.y += 1; break;
                    case "South": nowPos.dire = "West"; nowPos.x -= 1; break;
                    case "West": nowPos.dire = "North"; nowPos.y -= 1; break;
                }
                nowPos.count += 1;
            }
            return nowMap;
        }

        //出力
        internal static void output(char[,] map)
        {
            for (int i = 0; i < nowMap.GetLength(0); i++)
            {
                for (int p = 0; p < nowMap.GetLength(1); p++)
                {
                    Console.Write(map[i, p]);
                }
                Console.WriteLine("");  //改行
            }
        }

        internal static void main()
        {
            input();
            while (inTown(nowPos)) changHouse(nowPos);
            output(nowMap);
        }        
    }
}

//受験結果 受験言語： C# 獲得ランク： Bランク スコア： 100点

//internal static void rotateR_and()   //East, West, North, South  //左上が０、下が+方向であることに注意
//{
//    if (nowOrie == "North")
//    {
//        nowOrie = "East";
//        nowPos_x += 1;
//    }
//    else if (nowOrie == "East")
//    {
//        nowOrie = "South";
//        nowPos_y += 1;
//    }
//    else if (nowOrie == "South")
//    {
//        nowOrie = "West";
//        nowPos_x -= 1;
//    }
//    else if (nowOrie == "West")
//    {
//        nowOrie = "North";
//        nowPos_y -= 1;
//    }
//}

//private static Dictionary<string, string> rotateR = new Dictionary<string, string>()
//  {{ "North","East"},{ "East","South"},{ "South","West"},{ "West","North"}};
//private static Dictionary<string, int> go_rotateR = new Dictionary<string, int>()
//  {{ "North",-1},{ "East","South"},{ "South","West"},{ "West","North"}};