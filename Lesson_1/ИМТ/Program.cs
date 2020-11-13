using System;

namespace ИМТ
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Это калькулятор массы тебя ИМТ");
            Console.WriteLine("Ваш рост");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваш вес");
            int m = Convert.ToInt32(Console.ReadLine());
            int v = m / (h * h);
            int i = v;
            Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
