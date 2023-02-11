// Напишите программу, которая принимает на вход число А и 
//выдает сумму чисел от 1 до А.

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!)!;
Console.WriteLine($"Сумма цифр = {GetSumNums(num)}");

int GetSumNums(int number)
{
    int sum =0;
    while(number>0)
    {
        sum+=number;
        Console.Write(sum+ " ");
        number--; 
    }
    return sum;
}