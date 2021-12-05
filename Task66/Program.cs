// 66. Показать натуральные числа от 1 до N, N задано
void Num(int n)
{
    int N = 20;
   
    {
        Console.Write($"{n}" + " ");
        if (n < N) Num(n + 1);
    }
}
Num(1);