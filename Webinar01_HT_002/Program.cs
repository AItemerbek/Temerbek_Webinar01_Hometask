/*Задача 2:  
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */
Console.Clear();

Console.WriteLine("Добрый день, пользователь! Данная программа позволяет найти большее число из двух вводимых.");

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);

if(a == b)
{
    Console.Write($"Числа {a} и {b} равны");
}
else
{
    if(a > b) 
    {
        Console.Write($"Число {a} больше числа {b}"); 
    }
    else
    {
        Console.Write($"Число {b} больше числа {a}"); 
    }
}
