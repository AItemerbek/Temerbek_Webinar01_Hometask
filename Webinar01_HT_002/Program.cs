/*Задача 2:  
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */
Console.Clear();

Console.WriteLine("Приветствую, пользователь! Данная программа позволяет найти большее число из двух вводимых.");

Console.Write("Введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine()!);

if (firstNumber == secondNumber)
{
    Console.Write($"Числа {firstNumber} и {secondNumber} равны");
}
else
{
    if (firstNumber > secondNumber)
    {
        Console.Write($"Число {firstNumber} больше числа {secondNumber}");
    }
    else
    {
        Console.Write($"Число {secondNumber} больше числа {firstNumber}");
    }
}
