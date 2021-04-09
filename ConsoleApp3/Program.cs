using System;
namespace Еhimble
{
   class Thimbles
   {
     static void Main(string[] args)
     { 
        string str, bal;
        int a, b, s, y;
        string cesh = "B";
        string replay = "W";

        Console.Write("\n\t\t\t\tНАПЕРСТКИ!\n");
        Console.Write("\nВведите количество денег на балансе:\t");
        string sr = Console.ReadLine();
        b = Convert.ToInt32(sr);
        Console.Clear();
        
       do {  
        Console.Write("Сделайте вашу ставку:\t");
        string st = Console.ReadLine();
        s = Convert.ToInt32(st);
        Console.Clear();

        Console.Write("Перед вами три наперстка, какой низ них хотите открыть открыть?\n");
        str = Console.ReadLine();
        a = Convert.ToInt32(str);
        Console.Clear();

        Random random= new Random();
        int r = random.Next(1, 3);

        if (a == r) {
         int summ = (s * 2);
         int rezult = b + summ;
         b = rezult;

         Console.WriteLine("\tУгадали!\n");
         Console.WriteLine("Вы выйграли:" + summ);
         Console.WriteLine("\nНажмите клавиши:\n W-продолжить \n B-узнать баланс \n F-завершить игру");
         bal = Console.ReadLine();
         Console.Clear();

           if (bal == cesh) {
             Console.WriteLine("\nВаш баланс:" + b);
             Console.WriteLine("\nНажмите клавиши:\n W-продолжить \n B-узнать баланс \n F-завершить игру");
             bal = Console.ReadLine();
             Console.Clear();
           }
        }else { 
         y = b - s;
         b = y;

         Console.WriteLine("\tНе угадали!\n");
         Console.WriteLine(("Вы проиграли:" + s));
         Console.WriteLine("\n\tНажмите клавиши:\n W-продолжить \n B-узнать баланс \n F-завершить игру");
         bal = Console.ReadLine();
         Console.Clear();

            if (bal == cesh) {     
                Console.WriteLine("\nВаш баланс:" + y);
                Console.WriteLine("\n\tНажмите клавиши:\n W-продолжить \n B-узнать баланс \n F-завершить игру");
                bal = Console.ReadLine();
                Console.Clear();
            }
        }
       } while (bal.Equals(replay, StringComparison.OrdinalIgnoreCase));
     }
   }
}


