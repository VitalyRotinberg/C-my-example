//Написать программу замену элементов массива на противоположные

// Объявляю глобальный массив
int[] array = new int[10];

int GetRandomNumber()
{
    int randomNumber = new Random().Next(-100, 101);
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

void ChangeModul(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            array[i] = -array[i];
        else
            array[i] = -1 * array[i];
    }
}

FillArray(array);
PrintArray(array);

ChangeModul(array);
PrintArray(array);
