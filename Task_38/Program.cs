// Найти сумму чисел одномерного массива стоящих на нечетной позиции

int[] arr = new int[20];

int GetRandomNumber()
{
    int randomNumber = new Random().Next(1, 1000);
    return randomNumber;
}

// Надоело два метода вызывать, все в одном пусть будет)
void FillAndPrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = GetRandomNumber();
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

void SumOddPositionArray(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
            result = result + arr[i];
    }
    Console.WriteLine($"Сумма элементов массива на нечетной позиции = {result}");
}

FillAndPrintArray(arr);
SumOddPositionArray(arr);