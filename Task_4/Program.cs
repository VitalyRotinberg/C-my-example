//Найти максимальное из трех чисел
int GetRandomNumber()
{
    int randomNumber = new Random().Next(1, 100);
    return randomNumber;
}

int MaxDigit(int firstDigit, int secondDigit)
{
    int max = 0;
    if (firstDigit > secondDigit)
        max = firstDigit;
    else
        max = secondDigit;
    return max;
}

int numberOne = GetRandomNumber(), numberTwo = GetRandomNumber(), numberThree = GetRandomNumber();
Console.WriteLine($"{numberOne}, {numberTwo}, {numberThree}");

int temporary = MaxDigit(numberTwo, numberThree);
int maxNumber = MaxDigit(numberOne, temporary);

Console.WriteLine($"Максимальное из трех чисел {maxNumber}");
