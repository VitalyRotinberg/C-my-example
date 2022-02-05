//Выяснить является ли число чётным
Console.WriteLine($"Введите любое число");
string numberStr = Console.ReadLine();

int number = int.Parse(numberStr);
int result = number % 2;

if (result == 0)
    Console.WriteLine($"Число является четным");
else
    Console.WriteLine($"Число не является четным");