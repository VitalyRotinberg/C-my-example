// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты.

int[,] arr = new int[6, 6];

Random randomNumber = new Random();

void FillArray()
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = randomNumber.Next(1, 101);
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
                    arr[i, j] = arr[i, j] * arr[i, j];
            }
        }
    }
}

FillArray();
PrintArray();
ChangeModul(arr);
Console.WriteLine();
PrintArray();