using System;

namespace Thimbles
{
    class Thimbles
    {
        static void Main(string[] args)
        {
            string choose, userInput;
            int selectedTimble, balance, rate, difference;
            string buttonForBalance = "B";
            string replay = "W";

            Console.Write("\n\t\t\t\tНАПЕРСТКИ!\n");
            Console.Write("\nВведите количество денег на балансе: ");
            string sr = Console.ReadLine();
            balance = Convert.ToInt32(sr);
            Console.Clear();

            do
            {
                Console.Write("Сделайте вашу ставку: ");
                string betPlaced = Console.ReadLine();
                rate = Convert.ToInt32(betPlaced);
                Console.Clear();

                Console.Write("Перед вами три наперстка, какой низ них хотите открыть открыть?\n");
                choose = Console.ReadLine();
                selectedTimble = Convert.ToInt32(choose);
                Random random = new Random();
                int random_number = random.Next(1, 3);
                Console.Clear();

                if (selectedTimble == random_number)
                {
                    int summ = (rate * 2);
                    int result = balance + summ;
                    balance = result;

                    Console.WriteLine("\n\t\tУгадали!\n");
                    Console.WriteLine("Вы выйграли: " + summ);
                    Console.WriteLine("\nНажмите клавиши:");
                    const string continuation = "-Продолжить";
                    const string balanceSheet = "\n-Узнать баланс";
                    const string endTheGame = "\n-Завершить игру";
                    string[] values = new string[] { continuation, balanceSheet, endTheGame };
                    String userInput = String.Join(" ", values);
                    Console.WriteLine(userInput);
                    userInput = Console.ReadLine();
                    Console.Clear();

                   if (userInput == buttonForBalance)
                    {
                        Console.WriteLine("\nВаш баланс: " + balance);
                        Console.WriteLine("\nНажмите клавиши:\n W-продолжить \n B-узнать баланс \n F-завершить игру");
                        userInput = Console.ReadLine();
                        Console.Clear();
                    }

                }
                else
                {
                    difference = balance - rate;
                    balance = difference;

                    Console.WriteLine("\n\t\tНе угадали!\n");
                    Console.WriteLine("Вы проиграли: " + rate);
                    const string P = "-Продолжить";
                    const string B = "\n-Узнать баланс";
                    const string F = "\n-Завершить игру";
                    string[] values = new string[] { P, B, F };
                    String i = String.Join(" ", values);

                    userInput = Console.ReadLine();
                    Console.Clear();

                    if (userInput == buttonForBalance)
                    {
                        Console.WriteLine("\nВаш баланс: " + difference);
                        Console.WriteLine("\nНажмите клавиши:\n W-продолжить \n B-узнать баланс \n F-завершить игру");
                        userInput = Console.ReadLine();
                        Console.Clear();
                    }
                }
            } while (.Equals(replay, StringComparison.OrdinalIgnoreCase));
        }
    }
}

