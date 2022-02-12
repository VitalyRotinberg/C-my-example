// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

// ¬ Логическое отрицание. Если Значение было false, то после логического отрицания оно становится true, и наоборот. Условный оператор выглядит так: (!*переменна*)

// Для начала напишем метод, который рандомно будет инициализировать в переменные true или false.
bool GetRandomBool()
{
    int randomNumber = new Random().Next(0, 2);
    if (randomNumber == 1)
        return true;
    else
        return false;
}

// Создаем две переменные Х и Y, они будут равны результату выполненной функции.

bool x = GetRandomBool();
Console.WriteLine($"X имеет значение {x}");

bool y = GetRandomBool();
Console.WriteLine($"Y имеет значение {y}");

// Проверяем истинность утверждения.

bool result = !(x || y) == ((!x) && (!y));
if (result)
    Console.WriteLine("Утверждение истинно");
else
    Console.WriteLine("Утверждение ложное");