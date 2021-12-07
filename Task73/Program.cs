//73. Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
//Первые два элемента последовательности задаются пользователем

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int N = 5;
void SumNext(int a, int b, int N)

{
    int c;

    if (N > 0)
    {
        c = a + b;
        a = b;
        b = c;
        Console.WriteLine(c);
        N = N - 1;
        SumNext(a, b, N);
    }
}
SumNext(a, b, N);





