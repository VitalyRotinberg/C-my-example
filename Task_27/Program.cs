//Определить количество цифр в числе
//123/10 = 12/10 = 1/10 = 0
//   0      1      2      3
int GetNumber()//получаем число
{
    int randomNumber = new Random().Next(100, 10000);
    return randomNumber;
}

int number = GetNumber();
Console.WriteLine(number);

int countOfDigit = 0;
while (number != 0)
{
    number = number / 10;
    countOfDigit++;
}
    
Console.WriteLine(countOfDigit);