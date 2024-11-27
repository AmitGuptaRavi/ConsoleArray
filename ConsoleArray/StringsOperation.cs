using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArray
{
   public static class StringsOperation
    {
        public static string LiteralStrings()
        {
            string str = "Hello, World!";
            Console.WriteLine(str);
            Console.ReadLine();
            return "";
        }


        public static string EmptyStrings()
        {
            string emptyStr = string.Empty;
            Console.WriteLine(emptyStr);
            Console.ReadLine();
            return "";
        }
        public static string String_From_CharArray  ()
        {
            char[] chars = { 'H', 'e', 'l', 'l', 'o' };
            string strFromCharArray = new string(chars);

            Console.WriteLine(strFromCharArray);
            Console.ReadLine();
            return "";
        }
        public static string StringLength()
        {
            string str = "Hello, World!";
            int strlenth= str.Length;
            Console.WriteLine(strlenth);
            Console.ReadLine();
            return "";
        }
        public static string Accessing_Characters()
        {
            string str = "Hello";
            char ch = str[1];  // Output: 'e'
            Console.WriteLine(ch);
            Console.ReadLine();
            return "";
        }
        public static string String_Concatenation()
        {
            string str1 = "Hello";
            string str2 = " World";
            string result = str1 + str2;  // Output: "Hello World"


            //Using String.Concat()
            string result1 = string.Concat(str1, str2);  // Output: "Hello World"

            //Using StringBuilder for Performance (when concatenating in a loop)

            StringBuilder sb = new StringBuilder();
            sb.Append("Hello");
            sb.Append(" World");
            string result2 = sb.ToString();  // Output: "Hello World"

            Console.WriteLine(result);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.ReadLine();
            return "";
        }


        public static string String_Comparison()
        {
            //Equality Comparison
            string str1 = "Hello";
            string str2 = "Hello";
            bool isEqual = str1 == str2;  // Output: true
            Console.WriteLine(isEqual);

            //Using String.Compare() (case-sensitive, returns an integer indicating lexicographical order)
            int result = string.Compare(str1, str2);  // Output: 0 (if equal)
            Console.WriteLine(result);

            //Case-Insensitive Comparison
            bool isEqualIgnoreCase = string.Equals(str1, str2, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine(isEqualIgnoreCase);
            Console.ReadLine();
            return "";
        }
    }
}
