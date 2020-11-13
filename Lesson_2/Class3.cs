using System;

double score = 0;
double input = 0;
bool flag = false;


while (true) 
{
    while (!flag)
    {
        Console.Clear();
        Console.WriteLine($"Сумма всех числе {score}"); 
        Console.Write("Повторите ввод числа: "); 

        flag = double.TryParse(Console.ReadLine(), out input); 
    }

    flag = false; 
    score = score + input; 

    if (input == 0) break; 
}

Console.Clear(); 
Console.WriteLine($"Итоговая сумма всех чисел: {score}");
Console.ReadKey();




