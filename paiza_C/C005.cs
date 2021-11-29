using System;

using System.Collections.Generic;

namespace paiza_C
{
    public class C005
    {
        internal static void test()
        {
            int i = 0;
            string[] array;
            var list = new List<string>();
            while (true)
            {
                string line = System.Console.ReadLine();
                if (line == null)
                {
                    break;
                }
                else
                {
                    list.Add(line);
                    i++;
                }
            }
            array = list.ToArray();
            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);
            Console.WriteLine(array[3]);
            Console.WriteLine(array[4]);
        }

    }
}
