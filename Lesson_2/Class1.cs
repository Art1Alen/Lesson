using System;


namespace Мое_Задание_2
{
    class Class1
    {
        static void Main()
        {
           
            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{Count(number)}");
            Console.ReadKey();
        }

        public static int Count(int a)
        {
            int countNumber = (int)Math.Log10(a) + 1;
            return countNumber;
        }
    }
}

