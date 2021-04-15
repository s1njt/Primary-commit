using System;

namespace Thimbles
{
    class Thimbles
    {
        static void Main(string[] args)
        {
            string choose, userInput;
            int selectedTimble, balance, rate, difference;
            string buttonForBalance = "E";
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
                    const string resume = "W-Продолжить";
                    const string BalanceSheet = "\nE-Узнать баланс";
                    const string endOfGame = "\nF-Завершить игру";
                    string[] ConstantValues = new string[] { resume, BalanceSheet, endOfGame };
                    String i = String.Join(" ", ConstantValues);
                    Console.WriteLine(i);
                    userInput = Console.ReadLine();
                    Console.Clear();

                    if (userInput == buttonForBalance)
                    {
                        Console.WriteLine("\nВаш баланс: " + balance);
                        Console.WriteLine("\nНажмите клавиши:");
                        Console.WriteLine(i);
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
                    Console.WriteLine("\nНажмите клавиши:");
                    const string resume = "W-Продолжить";
                    const string BalanceSheet = "\nE-Узнать баланс";
                    const string endOfGame = "\nF-Завершить игру";
                    string[] ConstantValues = new string[] { resume, BalanceSheet, endOfGame };
                    String i = String.Join(" ", ConstantValues);
                    Console.WriteLine(i);
                    userInput = Console.ReadLine();
                    Console.Clear();

                    if (userInput == buttonForBalance)
                    {
                        Console.WriteLine("\nВаш баланс: " + difference);
                        Console.WriteLine("\nНажмите клавиши:");
                        Console.WriteLine(i);
                        userInput = Console.ReadLine();
                        Console.Clear();
                    }
                }
            } while (userInput.Equals(replay, StringComparison.OrdinalIgnoreCase));
        }
    }
}
