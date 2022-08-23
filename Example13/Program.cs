//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void ThirdNumberPrint(int number)
{
    if (number < 100)
    {
        Console.WriteLine("Третьей цифры нет!");
    }
    else if (number == 100)
    {
        Console.WriteLine(0);
    }
    else
    {
        int pow = Convert.ToInt32(Math.Ceiling(Math.Log(number, 10)));
        int num3 = number / (Convert.ToInt32(Math.Pow(10, pow - 3))) % 10;
        Console.WriteLine(num3);
    }
}

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
ThirdNumberPrint(num);


