// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.


int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int result = m + 1;

Console.Write($"{m} ");

for (int i = m; i < n; i++)
{
    Console.Write($"{result} ");
    result++;
}