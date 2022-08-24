// Необязательная задача. Напишите программу, считывающую с пользовательского ввода целое число n (неотрицательное), 
// выводящее это число в консоль вместе с правильным образом изменённым словом "программист".

void ProgrammersGreeting(int count)
{    
    string ending;
    int lastDigit = count % 10;
    int last2Digits = count % 100;

    if (lastDigit == 1) 
    {
        if (last2Digits == 11) ending = "ов";
        else ending = "";
    }
    else if (1 < lastDigit & lastDigit < 5) 
    {
        if (11 <= last2Digits & last2Digits < 15) ending = "ов";
        else ending = "а";
    }
    else ending = "ов";

    Console.WriteLine($"{count} программист{ending}");
}

Console.Write("Введите целое неотрицательное число: ");
int num = int.Parse(Console.ReadLine());

// Для проверки вывода.
int index = 0;
while (index < num)
{
    ProgrammersGreeting(index);
    index++;
}
