// 67. Показать натуральные числа от N до 1, N задано
void Num(int a)
{
    int N = 16;
    if (a < N && a != 0)
    {
        Console.Write($"{a}" + " ");
        Num(a - 1);

    }

}
Num(15);