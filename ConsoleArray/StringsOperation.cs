using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

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
        public static string String_From_CharArray()
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
            int strlenth = str.Length;
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
        public static string Contains_StartsWith_EndsWith()
        {
            
            string str1 = "Hello";
            bool contains = str1.Contains("ell");  // Output: true
            bool startsWith = str1.StartsWith("He");  // Output: true
            bool endsWith = str1.EndsWith("lo");  // Output: true
            Console.WriteLine(contains);
            Console.WriteLine(startsWith);
            Console.WriteLine(endsWith);
            Console.ReadLine();
            return "";
        }
        public static string Substring_Operations()
        {
           
            string str1 = "Hello";
            string subStr = str1.Substring(1, 3);  // Output: "ell"
            Console.WriteLine(subStr);
            Console.ReadLine();
            return "";
        }


        public static string String_Replacement()
        {
            
            string str1 = "Hello";
            string replaced = str1.Replace("Hello", "Hi");  // Output: "Hi World"
            Console.WriteLine(replaced);
            Console.ReadLine();
            return "";
        }
        public static string Trimming()
        {
            //Trim: Removes leading and trailing whitespaces
            string trimmed = "   Hello   ".Trim();  // Output: "Hello"
            Console.WriteLine(trimmed);
            //TrimStart / TrimEnd: Removes leading or trailing whitespaces
            string trimmedStart = "   Hello".TrimStart();  // Output: "Hello"
            string trimmedEnd = "Hello   ".TrimEnd();  // Output: "Hello"

            Console.ReadLine();
            return "";
        }

        public static string Splitting_String()
        {

            string sentence = "Hello World from C#";
            string[] words = sentence.Split(' ');  // Output: ["Hello", "World", "from", "C#"]
            Console.ReadLine();
            return "";
        }
        public static string Changing_Case()
        {
            string sentence = "Hello World from C#";
            //ToUpper: Converts all characters to uppercase
            string upper = sentence.ToUpper();  // Output: "HELLO"
            Console.WriteLine(upper);

            //ToLower: Converts all characters to lowercase
            string lower = sentence.ToLower();  // Output: "hello"
            Console.WriteLine(lower);
            Console.ReadLine();
            return "";
        }
        public static string String_Padding()
        {
            //PadLeft: Adds padding to the left of the string
            string paddedLeft = "42".PadLeft(5, '0');  // Output: "00042"
            Console.WriteLine(paddedLeft);

            //PadRight: Adds padding to the right of the string
            string paddedRight = "42".PadRight(5, '0');  // Output: "42000"
            Console.WriteLine(paddedRight);

            Console.ReadLine();
            return "";
        }
        public static string String_Joining()
        {//Join: Joins an array or collection of strings with a delimiter.
            string[] words = { "Hello", "World", "from", "C#" };
            string joined = string.Join(" ", words);  // Output: "Hello World from C#"

            Console.WriteLine(joined);
            Console.ReadLine();
            return "";
        }
        public static string String_Interpolation()
        {//String Interpolation: A more readable and efficient way of constructing strings
            string name = "John";
            int age = 30;
            string message = $"Hello, my name is {name} and I am {age} years old.";

            Console.WriteLine(message);
            Console.ReadLine();
            return "";
        }
        public static string String_Formatting()
        {//Using String.Format
            string name = "John";
            int age = 30;
            string formatted = string.Format("My name is {0} and I am {1} years old", name, age);
            Console.WriteLine(formatted);

            //Using ToString with Format Specifiers:
            double pi = 3.14159;
            string piFormatted = pi.ToString("F2");  // Output: "3.14"
            Console.WriteLine(piFormatted);

            Console.ReadLine();
            return "";
        }
        public static string Escape_Sequences()
        {
            string str = "Hello\nWorld\t!";  // Output: "Hello" (new line) "World" (tab) "!"
            Console.WriteLine(str);
            Console.ReadLine();
            return "";
        }
        public static string StringBuilder_Operations()
        {
            //Using StringBuilder: For efficient string concatenation when manipulating large or numerous strings.
            StringBuilder sb = new StringBuilder("Hello");
            sb.Append(" World");
            sb.Insert(5, ",");  // Output: "Hello, World"
            sb.Remove(0, 1);     // Output: "ello, World"
            string finalString = sb.ToString();

            Console.WriteLine(finalString);
            Console.ReadLine();
            return "";
        }

        public static string Regular_Expressions()
        {
            //Regex Operations: C# provides powerful regular expression support via System.Text.RegularExpressions

            //Matching
            string input = "The quick brown fox";
            bool match = Regex.IsMatch(input, @"\bfox\b");  // Output: true
            Console.WriteLine(match);


            //Replace:
            string replaced = Regex.Replace(input, @"\bfox\b", "cat");  // Output: "The quick brown cat"
            Console.WriteLine(replaced);
            Console.ReadLine();
            return "";
        }
        public static string String_Equality_with_IgnoreCase()
        {
            //Equality with IgnoreCase
            string str1 = "hello";
            string str2 = "HELLO";
            bool areEqual = string.Equals(str1, str2, StringComparison.OrdinalIgnoreCase);  // Output: true
            Console.WriteLine(areEqual);
            Console.ReadLine();
            return "";
        }
        public static string Null_or_Empty_Check()
        {
            //Check if a String is Null or Empty:
            string str = "";
            bool isNullOrEmpty = string.IsNullOrEmpty(str);  // Output: true
            Console.WriteLine(isNullOrEmpty);

            //Check if a String is Null, Empty, or Whitespace
            bool isNullOrWhiteSpace = string.IsNullOrWhiteSpace(str);  // Output: true
            Console.WriteLine(isNullOrWhiteSpace);
            Console.ReadLine();
            return "";
        }

    }
}




//Summary
//String Manipulation: Substring(), Replace(), Trim(), Split(), etc.
//Comparisons: Equals(), Compare(), StartsWith(), EndsWith(), Contains().
//Formatting: String.Format(), ToString(), string interpolation.
//Efficiency: Use StringBuilder for high - performance concatenation and manipulation.
//Regex: Use for pattern matching, replacing substrings based on patterns.
//Null and Empty Handling: IsNullOrEmpty(), IsNullOrWhiteSpace().
//These are some of the essential string operations in C# that can be important for interviews. Understanding these operations is crucial, as string manipulation is a common task in many C# applications.