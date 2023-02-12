// Напишите программу, которая принимает на вход число
// и выдает количество цифр в числе.

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!)!;

Console.WriteLine($"Количество цифр: {getCount(number)}");
int getCount(int number)
{
    int count = 1;
    while(number >10)
    {
        number = number /10;
        count = count +1;
    }
    return count;
}