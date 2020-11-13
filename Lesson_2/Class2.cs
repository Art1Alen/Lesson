using System;
using System.Diagnostics;

namespace Мое_Задание_2
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    class Class2
    {
        static void Main()
        {
         

            double score = 0;
            double input = 0;
            bool flag = false;


            while (true) 
                while (!flag)
                {
                    Console.Clear();
                    Console.WriteLine($"Сумма всех числе {score}");
                    Console.Write("Повторите ввод числа: "); 

                    flag = double.TryParse(Console.ReadLine(), out input); 
                }
            }


                    Console.WriteLine("Итоговая сумма всех чисел: {score}");// я чето тут нечего не понял :(( но походу я думаю так
          
private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }


    }
