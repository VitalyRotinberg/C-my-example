//Показать четные числа от 1 до N;
Console.WriteLine($"Перед выполнением задания важно отметить неверное условие задачи, число 1 не является четным");
Console.WriteLine();
Console.WriteLine($"Введите любое число");
string numberStr = Console.ReadLine();
int upToWhatNumber = int.Parse(numberStr);
Console.WriteLine($"Сейчас на экране отобразятся все четные числа до {upToWhatNumber}");

for (int i = 2; i <= upToWhatNumber; i = i + 2)
{
    Console.Write($"{i} ");
}