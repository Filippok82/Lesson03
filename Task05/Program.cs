// 5. Написать программу вычисления значения функции y=f(a)
double Function (double x)
{
    double y = Math.Sin(x);
    return y;
}
 Console.WriteLine("Введите число х ");
 double x = Convert.ToDouble(Console.ReadLine());
 Console.WriteLine($"Ответ {Function(x):F3}");