// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int[] array = new int[10];

int GetRandomNumber()
{
    int randomNumber = new Random().Next(100, 1000);
    return randomNumber;
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = GetRandomNumber();
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void EvenOddNumberCounter(int[] array)
{
    int even = 0;
    int odd = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0)
            even++;
        else
            odd++;
    }
    Console.WriteLine($"Количество четных чисел в массиве {even}");
    Console.WriteLine($"Количество нечетных чисел в массиве {odd}");
}

FillArray(array);
PrintArray(array);
EvenOddNumberCounter(array);