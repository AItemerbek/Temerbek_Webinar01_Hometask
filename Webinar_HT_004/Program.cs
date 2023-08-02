/* Задача 4: 

Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.Clear();

Console.WriteLine("Добрый день, пользователь! Данная программа позволяет найти наибольшее число из трех вводимых.");

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);

Console.Write("Введите третье число: ");
int c = int.Parse(Console.ReadLine()!);

int maxnumber = a;

if(b > maxnumber)
{
    maxnumber = b;
}
if(c > maxnumber)
    {
        maxnumber = c;
    }

Console.Write($"Из чисел {a}, {b}, {c},  наибольшее число {maxnumber}"); 