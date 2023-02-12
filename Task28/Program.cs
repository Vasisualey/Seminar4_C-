// Напишите программу, которая принимает на вход число N
// и выдает произведение чисел от 1 до N.

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!)!;

Console.WriteLine($"Произведение чисел: {getMultiply(number)}");
int getMultiply(int number)
{
    int temp = 1;
    for(int count = 1; count<=number; count++)
    {
        temp = temp*count;
    }
return temp;
}

