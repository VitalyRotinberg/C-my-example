// В матрице чисел найти сумму элементов главной диагонали.

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

void SumDiagonal()
{
    int sum = 0;
    int count = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == count && j == count)
                sum = sum + arr[i, j];
        }
         count++;
    }
    Console.WriteLine(sum);
}

FillArray();
PrintArray();
SumDiagonal();