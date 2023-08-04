// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

int InputNum(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

void IsSquare(int firstNum, int secondNum)
{
    if (firstNum * firstNum == secondNum) Console.WriteLine("true");
    else Console.WriteLine("false");;
}


int firstNumber = InputNum("Введите первое число: ");
int secondNumber = InputNum("Введите второе число: ");

IsSquare(firstNumber,secondNumber);
