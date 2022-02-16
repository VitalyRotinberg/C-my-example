// Подсчитать сумму цифр в числе

// Первым делом нужно научиться разделять конкретные цифры от числа. 
//Т.к. от перестановки слагаемых сумма не меняется проще всего это сделать используя деление с остатком и уменьшение числа на разряд.

//Получаем любое число.
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

//Пишем метод, который позволит откусить последнюю цифру и сложить ее с результирующей переменной
int SumNumber(int number)
{
    int result = 0;
    while (number != 0)
    {
        result = (number % 10) + result;
        number = number / 10;
    }
    return result;
}

//Получаем число и вызываем метод

int digit = GetNumber("Введите число, в котором хотите посчитать сумма цифр");

Console.WriteLine($"Сумма цифр в числе {digit} будет равняться = {SumNumber(digit)}");
