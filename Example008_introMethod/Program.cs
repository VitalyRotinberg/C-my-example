int Max(int arg1, int arg2, int arg3)//возвращаемый тип аргумента int, тип самого аргумента int, имя аргумента arg1, arg2, arg3
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 15, b1 = 42, c1 = 52;
int a2 = 51, b2 = 80, c2 = 76;
int a3 = 37, b3 = 96, c3 = 17;

//int max1 = Max(a1, b1, c1);
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3, b3, c3);
//int max = Max(max1, max2, max3);

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine(max);