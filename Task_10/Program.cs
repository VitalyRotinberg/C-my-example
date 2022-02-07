// Показать вторую цифру трёхзначного числа.
int GetRandomNumber()//получаем любое трехзначное число
{
    int randomNumber = new Random().Next(100, 1000);
    return randomNumber;
}

int number = GetRandomNumber();
Console.WriteLine($"Сгенерированное число - {number}");

int result = (number/10)%10;
Console.WriteLine($"Вторая цифра числа {number} - {result}");
