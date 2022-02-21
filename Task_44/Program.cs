// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

double GetNumber(string message)
{
    Console.WriteLine(message);
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}

// Зададим k1, b1 и k2, b2.
double k1 = GetNumber("Введите k1");
double b1 = GetNumber("Введите b1");
double k2 = GetNumber("Введите k2");
double b2 = GetNumber("Введите b2");

if (k1 == k2)
    Console.WriteLine("Прямые не пересекаются");

// Найдем X
double x = (b1 - b2) / (k2 - k1);
Console.WriteLine($"X равен {x}");

double y = (k2 * b1 - k1 * b2) / (k2 - k1);
Console.WriteLine($"Y равен {y}");