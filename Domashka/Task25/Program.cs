// SЗадача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Clear();
int Insert(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine()!)!;
    return result;
}

int Process(int Base, int Valent)
{
    int Process = 1;
    for (int i = 0; i < Valent;i++)
    {
        Process = Process*Base;
    }
    return Process;
}

bool Trueorfalse(int Valent)
{
    if (Valent < 0)
    {
        Console.WriteLine("Степень не может быть меньше нуля");
        return false;
    }
    return true;
}

int Base = Insert("Введите возводимое в степень число: ");
int Valent = Insert("Введите степень числа: ");
if(Trueorfalse(Valent))
{
    Console.WriteLine($"Число {Base} в степени {Valent} равно {Process(Base, Valent)}.");
}