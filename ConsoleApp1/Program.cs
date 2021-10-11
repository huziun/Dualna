using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            Task3();

        }
        static void Task1()
        {
            int countA = 0, countO = 0, countI = 0, countE = 0;
            Console.WriteLine("Enter some text: ");
            string SomeText = Console.ReadLine();
            for (int i = 0; i < SomeText.Length; i++)
                //регулярні вираження;
            {
                if (SomeText[i] == 'a')
                {
                    countA++;
                }
                if (SomeText[i] == 'o')
                {
                    countO++;
                }
                if (SomeText[i] == 'i')
                {
                    countI++;
                }
                if (SomeText[i] == 'e')
                {
                    countE++;
                }
            }
            int countLeters = countA + countO + countI + countE;
            Console.WriteLine("Letters: {0}\nA: {1}\nO: {2}\nI: {3}\nE: {4}",countLeters,countA,countO,countI,countE);
        }
        static void Task2()
        {
            Console.WriteLine("Enter number of month: ");
            int number = Convert.ToInt32(Console.ReadLine());
            try
            {
                int daysInMonth = System.DateTime.DaysInMonth(2021, number);
                Console.WriteLine("Days in month: {0}", daysInMonth);
            }
            catch(ArgumentOutOfRangeException)
            {
                Console.WriteLine("Error month!");
            }
            Console.ReadLine();
        }
        static void Task3()
        {
            Console.WriteLine("Enter 10 integer numbers: ");
            int number, first_5 = 0, last_5 = 1;
            bool check= false;
            for (int i = 0; i < 10; i++)
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (i < 5)
                {
                    if(number < 0)
                    {
                        check = true;
                    }
                    first_5 += number;
                }
                else
                {
                    last_5 *= number;
                }
            }
            string output = (check) ? Convert.ToString(last_5) : Convert.ToString(first_5);
            Console.WriteLine("Result: {0}.", output);
        }
    }
}
