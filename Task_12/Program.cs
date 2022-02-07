// Удалить вторую цифру трёхзначного числа
int GetRandomNumber()//получаем любое трехзначное число
{
    int randomNumber = new Random().Next(100, 1000);
    return randomNumber;
}
int Exception(int digit)//исключаем вторую цифра из трехзначного числа
{
    int temp = digit % 10;
    int result = (digit / 100) * 10 + temp;
    return result;
}

int number = GetRandomNumber();
Console.WriteLine($"Сгенерированное число - {number}");

Console.WriteLine($"Число после исключения второй цифры {Exception(number)}");

