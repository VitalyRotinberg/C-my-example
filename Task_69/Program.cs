// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int result = 0;

for (int i = m; i <= n; i++)
{
    result = result + i;
}
Console.WriteLine(result);