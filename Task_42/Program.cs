// Определить сколько чисел больше 0 введено с клавиатуры
// Чтобы закончить ввод чисел скажем пользователю отправить 0.

int[] arr = new int[10];

int GetNumber()
{
    bool checkStatus = true;
    int numberInt = 0;
    while (checkStatus)
    {
        string numberStr = Console.ReadLine();
        if (int.TryParse(numberStr, out numberInt))
        {
            checkStatus = false;
            break;
        }
        else
            Console.WriteLine("Ввели не число");

    }
    return numberInt;
}

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        arr[i] = GetNumber();
}

void CounterPositiveNumber(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            count++;
    }
    Console.WriteLine($"Было введено {count} чисел больше 0");
}

Console.WriteLine("Введите 10 чисел");
FillArray(arr);
CounterPositiveNumber(arr);

//Вопрос, как написать код, чтобы не указывать изначально размер массива, а вводить числа, к примеру пока пользователь не введет 0 или точку?