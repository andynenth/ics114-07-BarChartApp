using System;

namespace BarChartApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] countNumber = new int[10];
            DisplayInstructions();
            ProcessEntries(countNumber);
            DisplayResult(countNumber);
        }

        static void ProcessEntries(int[] countNumber)
        {
            int num;
            bool moreData = true;

            do
            {
                num = GetValue();
                if (num == -1)
                {
                    moreData = false;
                }
                else
                {
                    countNumber[num - 1]++;
                }
            } while (moreData);
        }

        static void DisplayResult(int[] countNumber)
        {
            Console.Clear();
            Console.WriteLine("Frequency Distribution\n");
            for (int i = 0; i < countNumber.Length; i++)
            {
                Console.Write("| {0} ", i+1);
                if (countNumber[i]!=0)
                {
                    for (int j = 0; j < countNumber[i]; j++)
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
        }

        static int GetValue()
        {
            int num;
            string inVal;
            Console.Write("Input any number between 1 and 10 (Q to stop): ");
            inVal = Console.ReadLine();

            if (inVal.ToLower()=="q")
            {
                return -1;
            }

            while (!int.TryParse(inVal, out num) || num<1 || num>10)
            {
                Console.Write("\nInvalid data - re-enter number [1 to 10] (Q to stop): ");
                inVal = Console.ReadLine();
                if (inVal.ToLower()=="q")
                {
                    return -1;
                }
            }

            return num;
        }

        static void DisplayInstructions()
        {
            Console.WriteLine("This application will allow you to enter any\n" +
                "number of entries between 1 and 10.\n\n" +
                "When you stop entering values, a frequency\n" +
                "distribution showing the number of times each\n" +
                "value was entered will be displayed.");
            Console.WriteLine("\n\tTo stop entering values type Q or q\n");
            Console.Write("\n\n\nPress any key when you are ready to begin...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
