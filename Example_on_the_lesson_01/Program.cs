Console.Write("Введите число : ");

string numberStr = Console.ReadLine();

int number = int.Parse(numberStr); // функция для преобразования строки в число

Console.WriteLine($"Квадрат числа = {number * number}");