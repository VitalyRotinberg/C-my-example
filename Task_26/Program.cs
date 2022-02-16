// Возведите число А в натуральную степень B используя цикл
// Для начала напишем метод, по которому будем получать числа от пользователей с проверкой на дурака.
int GetNumber(string message)
{
    Console.WriteLine(message);
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

//После напишем метод по возведению числа А в степень В с помощью цикла (на самом деле есть уже встроенная функция для этих целей)))
int Exponentiation(int a, int b)
{
    int result = 1;
    for (int i = 0; i < b; i++)
        result = result * a;
    return result;
}

// Считываем числа с консоли и вызываем функцию, которая возведет нам число в степень.

int number = GetNumber("Введите число, которое хотите возвести в степень");
int degree = GetNumber("Введите степень");

int res = Exponentiation(number, degree);

Console.WriteLine($"Результатом возведения числа {number} в степень {degree}, будет значение - {res}");