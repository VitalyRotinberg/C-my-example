//Даны два числа. Показать большее и меньшее число

Random randomaizer = new Random();

int numberOne = randomaizer.Next(1, 10);
Console.WriteLine(numberOne);

int numberTwo = randomaizer.Next(1, 10);
Console.WriteLine(numberTwo);

int max = 0, min = 0;

if (numberOne > numberTwo)
{
    max = numberOne;
    min = numberTwo;
    Console.WriteLine($"Большее число {max}, меньшее {min}");
}
if (numberOne < numberTwo)
{
    max = numberTwo;
    min = numberOne;
    Console.WriteLine($"Большее число {max}, меньшее {min}");
}

if (numberOne == numberTwo)
    Console.WriteLine($"Оба числа равны");