// Написать программу масштабирования фигуры
string strValue = "(0,0) (2,0) (2,2) (0,2)";
Console.WriteLine("Введите множитель: ");
int k = int.Parse(Console.ReadLine());

//Удаляем "(" и "), и ","
strValue = strValue.Replace("(", "").Replace(")", "").Replace(",", " ");

//Разбиваем строку на массив, разделить " " - пробел
string[] strArray = strValue.Split(" ");

string result = string.Empty;

foreach (var item in strArray)
{
    Console.Write($"{item} ");
}
Console.WriteLine();

for (int i = 0; i < strArray.Length - 1; i = i + 2)
{
    int x = k * int.Parse(strArray[i]);
    int y = k * int.Parse(strArray[i + 1]);

    result = result + $"({x}, {y})";
}

Console.WriteLine(result);