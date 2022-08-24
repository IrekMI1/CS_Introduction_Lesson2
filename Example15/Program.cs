//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void WeekendOrNotPrint(int num)
{
    if (num < 0 | num >= 8)
    {
        Console.WriteLine("Неверное число!");
    }
    else if(num < 6)
    {
        Console.WriteLine("Нет");
    } 
    else 
    {
        Console.WriteLine("Да");
    }
}

Console.Write("Введите число от 1 до 7: ");
int number = int.Parse(Console.ReadLine());

WeekendOrNotPrint(number);
