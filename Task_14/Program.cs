//Найти третью цифру числа или сообщить, что её нет
int GetNumber()//получаем любое число
{
    Console.WriteLine($"Введите любое число");
    string numberStr = Console.ReadLine();
    bool checkStatus = true;
    int numberInt = 0;
    while(checkStatus)
    {
        if(int.TryParse(numberStr, out numberInt))
        {
            checkStatus = false;
            break;
        }
        else
            Console.WriteLine("Ввели не число");
        numberStr = Console.ReadLine();
    }
    return numberInt;
}
int NumberCounter(int digit)//считаем количество цифр в числе

{
    int result = digit;
    int i = 0;
    while (result != 0)
    {
        result = result / 10;
        i++;
    }
    return i;
}

int number = GetNumber();
int amountOfNumber = NumberCounter(number);
int discharge = 10;
int thirdNumber = 0;

if (amountOfNumber < 3)
    Console.WriteLine($"Третьей цифры не обнаружено");

if (amountOfNumber == 3)
    Console.WriteLine($"Третья цифра {number % discharge}");

if (amountOfNumber > 3)
{
    int result = amountOfNumber - 3;
    while (result != 0)
    {
        discharge = discharge * 10;
        result--;
    }
    thirdNumber = (number % discharge) / (discharge / 10);
    Console.WriteLine($"Третья цифра {thirdNumber}");
}
