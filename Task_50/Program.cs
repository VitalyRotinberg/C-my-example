// В двумерном массиве n×k заменить четные элементы на противоположные.

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
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (j % 2 == 0 && j != 0)
                    if (arr[i, j] > 0)
                        arr[i, j] = -arr[i, j];
                    else
                        arr[i, j] = -1 * arr[i, j];
            }
}

FillArray();
PrintArray();
ChangeModul(arr);
Console.WriteLine();
PrintArray();