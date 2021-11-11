// 24. Найти кубы чисел от 1 до N

double n;
double a;
Console.WriteLine("введите число N ");
n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= n; ++i)
{
    a = Math.Pow(i, 3);
    Console.WriteLine(" Куб числа  " + i + "  равен: " + a);
}
Console.WriteLine();


 