// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

/*var arr = new int[10, 10];

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

void StreamlineArray()
{
    int temp = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1) - 1 - j; k++)
            {
                if (arr[i, j] < arr[i, j + 1])
                {
                    temp = arr[i, j];
                    arr[i, j] = arr[i, j + 1];
                    arr[i, j + 1] = temp;
                }
            }
        }
    }
}

FillArray();
PrintArray();
StreamlineArray();
Console.WriteLine();
PrintArray();*/

void PrintArray()
{
    int[,] arr = new int[4, 4] { { 16, 24, 11, 18 }, { 47, 24, 26, 78 }, { 25, 74, 37, 20 }, { 39, 27, 98, 12 } };

    for (int i = 0; i < arr.GetLength(0); i++)
        SortRow(arr, i);

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write(arr[i, j] + " ");
        Console.WriteLine();
    }
    Console.ReadLine();
}
void SortRow(int[,] massiv, int r)
{
    for (int i = 0; i < massiv.GetLength(1); i++)
        for (int j = i + 1; j < massiv.GetLength(1); j++)
        {
            if (massiv[r, i] < massiv[r, j])
            {
                int tmp = massiv[r, i];
                massiv[r, i] = massiv[r, j];
                massiv[r, j] = tmp;
            }
        Console.WriteLine();
        }
        
}
PrintArray();