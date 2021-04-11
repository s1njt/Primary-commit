using System;

namespace Thimbles
{
    class Thimbles
    {
        static void Main(string[] args)
        {
            string str, control;
            int thimble, balance, rate, compute;
            string cesh = "B";
            string replay = "W";

            Console.Write("\n\t\t\t\tНАПЕРСТКИ!\n");
            Console.Write("\nВведите количество денег на балансе:");
            string sr = Console.ReadLine();
            balance = Convert.ToInt32(sr);
            Console.Clear();

            do {
                Console.Write("Сделайте вашу ставку:");
                string st = Console.ReadLine();
                rate = Convert.ToInt32(st);
                Console.Clear();

                Console.Write("Перед вами три наперстка, какой низ них хотите открыть открыть?\n");
                str = Console.ReadLine();
                thimble = Convert.ToInt32(str);
                Random random = new Random();
                int random_number = random.Next(1, 3);
                Console.Clear();

                if (thimble == random_number) {
                    int summ = (rate * 2);
                    int rezult= balance + summ;
                    balance = rezult;

                    Console.WriteLine("\n\t\tУгадали!\n");
                    Console.WriteLine("Вы выйграли:"+summ);
                    Console.WriteLine("\nНажмите клавиши:\n W-продолжить \n B-узнать баланс \n F-завершить игру");
                    control = Console.ReadLine();
                    Console.Clear();

                    if (control == cesh) {
                        Console.WriteLine("\nВаш баланс:"+balance);
                        Console.WriteLine("\nНажмите клавиши:\n W-продолжить \n B-узнать баланс \n F-завершить игру");
                        control = Console.ReadLine();
                        Console.Clear();
                    }

                } else {
                    compute = balance - rate;
                    balance = compute;

                    Console.WriteLine("\n\t\tНе угадали!\n");
                    Console.WriteLine(("Вы проиграли:"+rate));
                    Console.WriteLine("\nНажмите клавиши:\n W-продолжить \n B-узнать баланс \n F-завершить игру");
                    control = Console.ReadLine();
                    Console.Clear();

                    if (control == cesh) {
                        Console.WriteLine("\nВаш баланс:"+compute);
                        Console.WriteLine("\nНажмите клавиши:\n W-продолжить \n B-узнать баланс \n F-завершить игру");
                        control = Console.ReadLine();
                        Console.Clear();
                    }
                }
            } while (control.Equals(replay, StringComparison.OrdinalIgnoreCase));
        }
    }
}


