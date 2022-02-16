//Показать кубы чисел, заканчивающихся на четную цифру
// Вообще сначала нужно определить, каких числе нам нужно показать кубы, из условия не понятно, кубы всех чисел мира проверять, или до числа N.
// Сойдемся на мнении, что кубы чисел будем определять до числа N.

// Получаем то самое число N.
int GetNumber(string message)
{
    Console.WriteLine(message);
    bool checkStatus = true;
    int numberInt = 0;
    while (checkStatus)
    {
        string numberStr = Console.ReadLine();
        if (int.TryParse(numberStr, out numberInt))
        {
            checkStatus = false;
            break;
        }
        else
            Console.WriteLine("Ввели не число");

    }
    return numberInt;
}

// Узнаем кубы чисел, до числа N, если заканчивается на четную цифру - выводим на консоль. Проверять четное ли число буду с помощью деления с остатком на 2.
void PrintEvenCube(int number)
{
    int cubeNumber = 0;
    for (int i = 1; i <= number; i++)
    {
        cubeNumber = i * i * i;
        if (cubeNumber % 2 == 0)
        {
            Console.WriteLine($"Куб числа {i} является четным. Куб числа {i} = {cubeNumber}");
        }
    }
}

// Получаем число, и печатаем четные кубы чисел.

int number = GetNumber("Введите число, до которого нужно определить кубы всех чисел");
PrintEvenCube(number);