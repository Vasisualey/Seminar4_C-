// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


Console.Clear();
int Insert(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine()!)!;
    return result;
}

int[] ArrayResult(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i=0; i < length; i++)
    {
        array[i] = new Random().Next(min,max+1);
    }
    return array;
}

void Print(int[] array)
{
    Console.Write("[");
    for(int i = 0; i<array.Length-1;i++)
    {
        Console.Write($"{array[i]}, ");
    }
        Console.Write($"{array[array.Length-1]}");
    Console.Write("]");
}
int length = Insert("Длина массива: ");
int min = Insert("Начальное значение диапазона чисел: ");
int max = Insert("Конечное значение диапазона чисел: ");
int [] array = ArrayResult(length, min, max);
Print(array);
