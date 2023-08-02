﻿/* Задача 8: 

Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.Clear();

Console.WriteLine("Добрый день, пользователь! Данная программа выводит в терминал все четные значения в диапазоне от 1 до N");

Console.Write("Введите число N: ");
int number = int.Parse(Console.ReadLine()!);

int count = 2; // По условию задачи мы должны выводить все четные числа в диапазоне от 1 до N, то счетчик можем начинать с 2. Т.к. 1 нечетное число и его не нужно выдводить. 

Console.Write($"Вот список всех четных чисел в диапазоне от 1 до {number}: ");

while(count <= number)
{
   Console.Write(count);
    if(count < number - 1 )
    {
        Console.Write(", ");
    }
    count = count + 2; // Увеличиваем счетчик на 2, пропуская нечетные значения. 
}
