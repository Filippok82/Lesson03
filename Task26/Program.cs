// 26. Возведите число А в натуральную степень B используя цикл
double n;
double a;
double s;
Console.WriteLine("введите число А ");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Выберите степень ");
n = Convert.ToDouble(Console.ReadLine());

for ( int i = 1; i<=n;)
{
   s=Convert.ToDouble(Math.Pow(a, n));
   Console.WriteLine("Ответ " + s);
   break;
}
 