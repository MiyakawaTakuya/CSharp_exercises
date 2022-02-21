// using System.Collections.Generic;
// using System.Linq;
using System;
namespace paiza_C.Questions
{
    public class OnePercentGrowthDaily
    {
        internal static void main()
        {
            int HowManydays;
            HowManydays = 365*3;
            double afterGrowth = Math.Pow(1.01, HowManydays);
            afterGrowth = Math.Round(afterGrowth, 1, MidpointRounding.AwayFromZero);
            Console.WriteLine("1%の成長を"+ HowManydays + "日間継続すると、"+afterGrowth +"倍成長できる。");
        }
    }
}
