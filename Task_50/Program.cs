// В двумерном массиве n×k заменить четные элементы на противоположные.
// Не совсем точное условие задачи. Четная позиция должна быть одновременно и по строкам и столбцам, или только по строкам? Я выполнил исходя из того, что i и j должны быть четными одновременно

int[,] arr = new int[6, 5];

Random randomNumber = new Random();

void FillArray()
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = randomNumber.Next(-100, 101);
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ChangeModul(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (i % 2 == 0 && i != 0)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (j % 2 == 0 && j != 0)
                    if (arr[i, j] > 0)
                        arr[i, j] = -arr[i, j];
                    else
                        arr[i, j] = -1 * arr[i, j];
            }
        }
    }
}

FillArray();
PrintArray();
ChangeModul(arr);
Console.WriteLine();
PrintArray();