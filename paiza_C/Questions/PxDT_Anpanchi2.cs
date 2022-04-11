using System.Collections.Generic;
using System.Linq;
using System;
using System.IO;
//ランタイムエラーが出てしまっている回答 20/28

namespace paiza_C.Questions
{
    public class PxDT_Anpanchi
    {
        private static List<StringAnalysis> strList =new List<StringAnalysis>();

        private class StringAnalysis
        {
            internal StringAnalysis(string str)
            {
                Name = str;
                Head =str.Substring(0,2);
                Bottom = str.Substring(str.Length - 2);
            }
            internal string Name { get; set; }
            internal string Head { get; set; }
            internal string Bottom { get; set; }
        }

        static public void main()
        {
            //入力と文字列解析クラスStringAnalysisのインスタンスを生成しList化
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();
                if (str.Length >= 2)
                {
                    strList.Add(new StringAnalysis(str));
                }
            }

            //接尾を起点に見ていって一致する接頭があるかチェックする
            //総当たりN*N → 当然ランタイムエラーでアウト 20/28正解が限界
            int maxLength = 0;
            for (int i = 0; i < strList.Count(); i++)
            {
                for(int j = 0;j < strList.Count();j++)
                {
                    if(i!=j && strList[i].Bottom == strList[j].Head && (strList[i].Name.Length + strList[j].Name.Length-2) > maxLength)
                    {
                        maxLength= strList[i].Name.Length + strList[j].Name.Length - 2;
                    }
                }
            }
            //出力
            if(maxLength==0) Console.WriteLine(-1);
            else Console.WriteLine(maxLength);
        }
    }
}
