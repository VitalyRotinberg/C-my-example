// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран.

// Первым делом напишу метод, который будет генерить либо 0, либо 1
int GetRandomNumber()
{
    int randomNumber = new Random().Next(0, 2);
    return randomNumber;
}

// Далее пишем метод, который будет заполнять массив.
void FillArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = GetRandomNumber();
    }
}

// Последним этапом выводим на экран заполненный массив.
void PrintArray (int [] array)
{
     for (int i = 0; i < array.Length; i++)
     {
        Console.Write($"{array[i]} ");
     }
}

int[] arr = new int[8];
FillArray(arr);
PrintArray(arr);