//  4. Найти максимальное из трех чисел

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}    

int a1 = 79;
int b1 = 99;
int c1 = 52;
int max = Max(a1, b1, c1);
Console.WriteLine(max);