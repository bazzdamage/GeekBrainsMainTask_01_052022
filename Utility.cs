using System.Text;

namespace GeekBrainsMainTask_01_052022
{
    internal class Utility
    {
        public static int ProcessedStringCount(string[] stringArray, int wordlength)
        {
            int stringCount = 0;
            foreach (string word in stringArray)
            {
                if (word.Length <= wordlength) stringCount++;
            }
            return stringCount;
        }
        public static string[] MakeArray(string[] stringArray, int stringCount, int wordlength)
        {
            string[] resultArray = new string[stringCount];
            int j = 0;
            foreach (string word in stringArray)
            {
                if (word.Length <= wordlength)
                {
                    resultArray[j] = word;
                    j++;
                }
            }
            return resultArray;
        }
        public static void PrintArray(string[] stringArray, int stringCount, int wordlength)
        {
            Console.WriteLine($"Total count of strings, that contains {wordlength} or less symbols are {stringCount}...\n...And here they are");
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }
        }
        public static string[] UserInputStringArray(char separator)
        {
            bool result = false;
            int count = 0;
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("Please input some symbols or entire string, then PRESS ENTER:\n or type quit to make a Array");
            while (result == false)
            {
                string s = Console.ReadLine();
                if (s.ToLower() == "quit")
                {
                    result = true;
                }
                else
                {
                    sb = sb.Append(s + separator);
                    count++;
                    Console.WriteLine($"You are inputed {count} strings already...");
                }
            }
            return MakeArrayFromString(sb.ToString(), separator);
        }
        public static string[] MakeArrayFromString(string str, char separator)
        {
            string[] result = str.Split(separator);
            return result;
        }
    }
}
