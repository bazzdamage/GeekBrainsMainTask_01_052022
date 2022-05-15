namespace GeekBrainsMainTask_01_052022

{
    class Solution
    {
        static string[] example = { "hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan" };
        static string[] stringArray;
        static int wordlength = 3;

        public static void Main(String[] args)
        {
            if (MakeDecision()) stringArray = Utility.UserInputStringArray('/');
            else stringArray = example;
            int stringCount = Utility.ProcessedStringCount(stringArray, wordlength);
            string[] result = Utility.MakeArray(stringArray, stringCount, wordlength);
            Utility.PrintArray(result, stringCount, wordlength);
        }
        static bool MakeDecision()
        {
            Console.WriteLine("Do you want to enter the array yourself or use an example?...\n1 for manual input\n2 for use a example\n");
            string s = String.Empty;
            while (s != "1" & s != "2")
            {
                Console.WriteLine("Please enter 1 or 2 and press ENTER");
                s = Console.ReadLine();
            }
            if (s == "1") return true;
            return false;
        }
    }
}