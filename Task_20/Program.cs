// Задать номер четверти, показать диапазоны для возможных координат

// Напишем метод получения цифры от 1 до 4, с проверкой на дурака.

int GetQuarterNumber()
{
    Console.WriteLine($"Введите номер четверти оси координат");
    bool checkStatus = true;
    int numberInt = 0;
    while (checkStatus)
    {
        string numberStr = Console.ReadLine();
        if (int.TryParse(numberStr, out numberInt))
        {
            if (numberInt > 0 && numberInt < 5)
            {
                checkStatus = false;
                break;
            }
            else
                Console.WriteLine("Введите число от 1 до 4");
        }
        else
            Console.WriteLine("Ввели не число");

    }
    return numberInt;
}

int quarterNumber = GetQuarterNumber();

// С помощью операторов ветвления покажем пользователю возможный диапазон координат. 

if (quarterNumber == 1)
    Console.Write("Диапазон координат для 1 четверти по оси X от 1 до + ∞, по оси Y от 1 до + ∞ ");
else if (quarterNumber == 2)
    Console.Write("Диапазон координат для 2 четверти по оси X от - 1 до - ∞, по оси Y от 1 до + ∞ ");
else if (quarterNumber == 3)
    Console.Write("Диапазон координат для 3 четверти по оси X от - 1 до - ∞, по оси Y от - 1 до - ∞ ");
else
    Console.Write("Диапазон координат для 4 четверти по оси X от 1 до + ∞, по оси Y от - 1 до - ∞ ");
