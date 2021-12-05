// 68. Показать натуральные числа от M до N, N и M заданы

void Num (int a)
{
    int M =25;
    int N =52;
    if(a>=M && a<=N)
    {
        Console.Write($"{a}"+ " ");
        Num (a+1);
    }
}
Num(25);