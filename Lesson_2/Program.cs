using System;

namespace Мое_Задание_2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите первое число: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.Write("Введите третье число: ");
            int thirdNumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"Минимальное число: { MinimalScore(firstNumber, secondNumber, thirdNumber)}");
            Console.ReadKey();
            Console.Clear();
        }

        
        public static int MinimalScore(int a, int b, int c)
        {
            int score;
            if (a < b && a < c)
            {
                score = a;

            }
            else if (b < a && b < c)
            {
                score = b;
            }
            else
            {
                score = c;
            }
            return score;
        }
    }
}
        
    

