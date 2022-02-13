// Найти расстояние между точками в пространстве 2D/3D

// Первымм делом необходимо определиться в каком пространстве необходимо найти расстояние между точками
int GetSpaceNumber()
{
    Console.WriteLine($"Введите 2 , если хотите измерить расстояние в 2D пространстве, или 3, для 3D");
    bool checkStatus = true;
    int numberInt = 0;
    while (checkStatus)
    {
        string numberStr = Console.ReadLine();
        if (int.TryParse(numberStr, out numberInt))
        {
            if (numberInt > 1 && numberInt < 4)
            {
                checkStatus = false;
                break;
            }
            else
                Console.WriteLine("Введите число 2 или 3");
        }
        else
            Console.WriteLine("Ввели не число");

    }
    return numberInt;
}

// Метод получения координат точки с проверкой
double GetCoordinates(string message)
{
    Console.WriteLine($"Введите координату {message}");
    double numberDouble = Convert.ToDouble(Console.ReadLine());

    return numberDouble;
}

// Напишем метод для определения расстояния в 2D
void Ditance2D()
{
    double x1 = GetCoordinates("x1"); 
    double x2 = GetCoordinates("x2");
    double y1 = GetCoordinates("y1"); 
    double y2 = GetCoordinates("y2");

    double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    Console.WriteLine ($"Расстояние между точками в плоскости 2D - {result}");
}

// Аналогичный метод для 3D
void Ditance3D()
{
    double x1 = GetCoordinates("x1"); 
    double x2 = GetCoordinates("x2");
    double y1 = GetCoordinates("y1"); 
    double y2 = GetCoordinates("y2");
    double z1 = GetCoordinates("z1"); 
    double z2 = GetCoordinates("z2");

    double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    Console.WriteLine ($"Расстояние между точками в плоскости 3D - {result}");
}

// теперь пишем основной код, с оператором ветвления
int spaceNumber = GetSpaceNumber();

if (spaceNumber == 2)
    Ditance2D();
else
    Ditance3D();