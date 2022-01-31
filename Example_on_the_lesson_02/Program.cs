Console.Write("Введите число 1 : ");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr); // функция для преобразования строки

Console.Write("Введите число 2 : ");
string numberStr2 = Console.ReadLine();
int number2 = int.Parse(numberStr2);

int number3 = number2 * number2;

if (number3 == number)
    Console.WriteLine ("Первое число является квадратом второго");
    else
    Console.WriteLine ("Первое число не является квадратом второго");
