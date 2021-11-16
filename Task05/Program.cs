// 5. Написать программу вычисления значения функции y=f(a)
double Function (double x)
{
    double y = Math.Sin(x)+10;
    return y;
}
 Console.WriteLine("Введите число х ");
 double a = Convert.ToDouble(Console.ReadLine());
 Console.WriteLine($"Ответ {Function(a):F3}");