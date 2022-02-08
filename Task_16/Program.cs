//Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine($"Введите число обозначающее день недели");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);

while (number < 0 ^ number > 8 ^ number == 0)
{
    Console.WriteLine($"Введите число от 1 до 7");
    numberStr = Console.ReadLine();
    number = int.Parse(numberStr);
}
if (number == 6 ^ number == 7)
    Console.WriteLine($"Этот день недели является выходным");

if (number > 0 & number < 6)
    Console.WriteLine($"Этот день недели не является выходным");