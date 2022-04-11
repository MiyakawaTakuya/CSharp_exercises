using System.Collections.Generic;
using System.Linq;
using System;
using System.IO;

namespace paiza_C.Questions
{
    public class PxDT_BMIDisplayDietApp
    {
        static public void main()
        {
            string[] strArray = Console.ReadLine().Trim().Split(' ');
            int[] intArray = strArray.Select(int.Parse).ToArray();
            int w = intArray[0];
            int h = intArray[1];
            int b = intArray[2];
            double BMI = 10000 * w / h / (double)h;
            //Console.WriteLine(BMI);
            if (b > BMI) Console.WriteLine(0);
            else
            {
                double howReduce = (double)w - b * h * (double)h/10000;
                Console.WriteLine((int)Math.Ceiling(howReduce));
            }
        }
    }
}
