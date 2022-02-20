// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом.

Random randomDouble = new Random();
double[] arrDouble = new double[10];

void FillAndPrintArray(double[] arrDouble)
{
    for (int i = 0; i < arrDouble.Length; i++)
    {
        arrDouble[i] = Math.Round(randomDouble.NextDouble() * 10, 3);
        Console.Write($"{arrDouble[i]} ");
    }
    Console.WriteLine();
}

FillAndPrintArray(arrDouble);

void DifferenceMaxMin (double[] arrDouble)
{
    double max = arrDouble[0];
    double min = arrDouble[0];
    for (int i = 0; i < arrDouble.Length; i++)
    {
        if (arrDouble[i] > max)
            max = arrDouble[i];
        if (arrDouble[i] < min)
            min = arrDouble[i];
    }
    Console.WriteLine($"Max - {max}");
    Console.WriteLine($"Min - {min}");
    Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {max - min}");
}

DifferenceMaxMin(arrDouble);