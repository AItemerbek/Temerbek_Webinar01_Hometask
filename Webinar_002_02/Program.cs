/*Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98
*/

int DelSecondDigit(int number)
{
    int result = number / 100 * 10 + number % 10;
    return result;
}

int newNumber = new Random().Next(100, 1000);
int newdigit = DelSecondDigit(newNumber);

Console.WriteLine($"Из числа {newNumber} получили число {newdigit}");