using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArray
{
    public static class WWArray
    {

        public static void MainArray(string[] args)
        {
            Console.WriteLine("Hello World!");
            //GetArray();
            minArray();
        }

        public static void GetArray()
        {

            String str = "GeeksForGeeks";

            Console.WriteLine("String    : " + str);

            Console.WriteLine("Sub String1: " + str.Substring(0, 4));

            Console.WriteLine("Sub String2: " + str.Substring(8));
        }
        public static string minArray()
        {
            int[] Num = { 15, 12, 10, 1, 5 };
            double Average = Num.Aggregate((a, b) => a * b);

            Console.WriteLine(Average);
            Console.ReadLine();
            return "";

        }
    }
}
