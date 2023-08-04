/* Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
7 и 23.

14 -> нет 
46 -> нет 
161 -> да */

int InputNum(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

bool Test(int num)
{
    return (num % 7 == 0) && (num % 23 == 0);

}

int num = InputNum("Введите число: ");
bool check = Test(num);
Console.WriteLine(check);
