//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int SecondNumber(int number)
{
    int num2 = (number / 10) % 10;
    return num2;
}

Console.Write("Введите трехзначное число: ");
int x = int.Parse(Console.ReadLine());

Console.WriteLine(SecondNumber(x));