using System;
namespace paiza_C
{
    public class C013_2
    {
        internal static void test()
        {
            string n = Console.ReadLine(); //嫌いな数字
            int m = int.Parse(Console.ReadLine()); //病室の数
            string r_i; //病室の番号 あえてstring
            int count = 0; //部屋に嫌いな数字だったときのカウンター

            for (int i = 0; i < m; i++)
            {
                r_i = Console.ReadLine();
                if (r_i.Contains(n))
                {
                    count += 1;
                }
                else
                {
                    Console.WriteLine(r_i);
                }
            }
            if(count == m)
            {
                Console.WriteLine("none");
            }
        }
    }
}
