// Найти кубы чисел от 1 до N

// Получаем число, до которого нужно найти кубы всех чисел
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


// Вызываем методы

Console.WriteLine("Введите число, до которого хотите возвести все числа в куб");

int number = GetNumber();

for (int i = 1; i <= number; i++)
{
    Console.WriteLine($"Куб числа {i} = {i * i * i}");
}