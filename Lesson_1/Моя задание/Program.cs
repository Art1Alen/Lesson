using System;
using System.Text.Encodings.Web;

namespace Моя_задание
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Заполняйте АНКЕТУ");
            Console.WriteLine("Как вас завут?");
            String name = Console.ReadLine();
            Console.WriteLine("Ваша Фамилия?");
            String surname = Console.ReadLine();
            Console.WriteLine("Ваш возраст?");
            String age = Console.ReadLine();
            Console.WriteLine("Ваш рост?");
            String rost = Console.ReadLine();
            Console.WriteLine("Ваш вес?");
            String ves = Console.ReadLine();
            String Text = $"Ваши данные,{name}{surname}{age}{rost}{ves}";
            Console.WriteLine(Text);
            Console.ReadKey();
        }
        
    }
}
