// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Clear();
int Insert(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine()!)!;
    return result;
}

int Sum(int number)
{
    int result =0;
    while (number > 0)
    {
        result = result + number%10;
        number = number/10;
    }
    return result;
}

int number = Insert("Введите число: ");
Console.WriteLine($"Сумма цифр в числе {number} равна {Sum(number)}.");


