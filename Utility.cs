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
                if (word.Length >= wordlength) stringCount++;
            }
            return stringCount;
        }
        public static string[] MakeArray(string[] stringArray, int stringCount, int wordlength)
        {
            string[] resultArray = new string[stringCount];
            int j = 0;
            foreach (string word in stringArray)
            {
                if (word.Length >= wordlength)
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
    }
}
